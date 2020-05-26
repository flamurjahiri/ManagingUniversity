using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOrari.Model;

namespace ProjektiOrari.Controller
{
    public class OrariMapper
    {
        public List<string> merrOrarin(User u, int selected)
        {
            List<string> vargu = new List<string>();

            if (u.Statusi == 1) {
                using (DBEntities db = new DBEntities())
                {


                    var query = (from lz in db.LendetEZgjedhuras
                                 from us in db.Users
                                 from l in db.Ligjeruesits
                                 from le in db.Lendas
                                 from o in db.Oraris
                                 where lz.idLigjeruesi == l.IDLigjeruesi && le.IDLenda == l.IDLenda
                                 && o.IDLigjeruesi == l.IDLigjeruesi && us.IDuseri == l.IDProfesori
                                 && selected == lz.Semestri && u.IDuseri == lz.Studenti
                                 select new
                                 {
                                     le.Emri_i_lendes,
                                     le.Lloji,
                                     o.Dita,
                                     o.OraFillimit,
                                     o.OraMbarimit,
                                     o.Emri_Numri_i_salles,
                                     us.Emri
                                 }).ToList();

                    foreach (var record in query)
                    {
                        vargu.Add(record.Emri_i_lendes + ";" + record.Emri + ";" + record.Dita + ";" + record.OraFillimit + " - " + record.OraMbarimit + ";" + record.Emri_Numri_i_salles + ";" + record.Lloji);
                    }
                }
            }
            else if (u.Statusi == 2 || u.Statusi == 3)
            {
                using (DBEntities db = new DBEntities())
                {


                    var query = (
                                 from l in db.Ligjeruesits
                                 from le in db.Lendas
                                 from o in db.Oraris
                                 where le.IDLenda == l.IDLenda
                                 && o.IDLigjeruesi == l.IDLigjeruesi && u.IDuseri == l.IDProfesori
                                 && selected == o.Semestri && u.IDuseri == l.IDProfesori
                                 select new
                                 {
                                     le.Emri_i_lendes,
                                     le.Lloji,
                                     o.Dita,
                                     o.OraFillimit,
                                     o.OraMbarimit,
                                     o.Emri_Numri_i_salles,
                                     u.Emri
                                 }).ToList();

                    foreach (var record in query)
                    {
                        vargu.Add(record.Emri_i_lendes + ";" + record.Emri + ";" + record.Dita + ";" + record.OraFillimit + " - " + record.OraMbarimit + ";" + record.Emri_Numri_i_salles + ";" + record.Lloji);
                    }
                }

            }
            else
            {
                using (DBEntities db = new DBEntities())
                {


                    var query = (
                                 from l in db.Ligjeruesits
                                 from le in db.Lendas
                                 from o in db.Oraris
                                 from us in db.Users
                                 where le.IDLenda == l.IDLenda
                                 && o.IDLigjeruesi == l.IDLigjeruesi
                                 && selected == o.Semestri && us.IDuseri == l.IDProfesori
                                 select new
                                 {
                                     le.Emri_i_lendes,
                                     le.Lloji,
                                     o.Dita,
                                     o.OraFillimit,
                                     o.OraMbarimit,
                                     o.Emri_Numri_i_salles,
                                     us.Emri
                                 }).ToList();

                    foreach (var record in query)
                    {
                        vargu.Add(record.Emri_i_lendes + ";" + record.Emri + ";" + record.Dita + ";" + record.OraFillimit + " - " + record.OraMbarimit + ";" + record.Emri_Numri_i_salles + ";" + record.Lloji);
                    }
                }

            }
                

                

            return vargu;

        }

        public List<string> shikoFeedback()
        {
            List<string> rez = new List<string>();
            using (DBEntities db = new DBEntities())
            {
                var query = (from f in db.feedbacks
                             from u in db.Users
                             from l in db.Lendas
                             from lz in db.LendetEZgjedhuras
                             from u2 in db.Users
                             from li in db.Ligjeruesits
                             where u2.IDuseri == li.IDProfesori && li.IDLenda == l.IDLenda
                             && f.Lenda == lz.idLendaZgjedhur && u.IDuseri == f.Studenti &&
                             li.IDLigjeruesi == lz.idLigjeruesi
                                         select new
                                         {
                                             id = f.idFeedback,
                                             emri = u.Emri,
                                             mbiemri =u.Mbiemri,
                                             lenda = l.Emri_i_lendes,
                                             emriP = u2.Emri,
                                             mbiemriP = u2.Mbiemri,
                                             mesazhi = f.Mesazhi,
                                             date = f.Data_e_feedback

                                         }).OrderByDescending(c=>c.id).ToList();

                foreach (var record in query)
                {
                    rez.Add(record.emri + " " + record.mbiemri + ";" + record.lenda + ";" + record.emriP +  ";" + record.mesazhi + ";" + record.date);
                }
            }
            return rez;
        }

        public void dergoKerkesen(KerkesaPerNderrim k)
        {
            using (DBEntities db = new DBEntities())
            {
                db.KerkesaPerNderrims.Add(k);
                db.SaveChanges();
                MessageBox.Show("Keni derguar me sukses kerkesen");
            }
        }

        public List<string> kerkesatPerNderrim(User u)
        {
            List<string> rez = new List<string>();
            if(u.Statusi == 4) {
                using (DBEntities db = new DBEntities())
                {
                    var query = (from f in db.KerkesaPerNderrims
                                 from lz in db.LendetEZgjedhuras
                                 from l in db.Lendas
                                 from li in db.Ligjeruesits
                                 from o in db.Oraris
                                 where f.Lenda == lz.idLendaZgjedhur &&
                                 li.IDLigjeruesi == lz.idLigjeruesi && li.IDLenda == l.IDLenda
                                 && o.IDLigjeruesi == li.IDLigjeruesi && f.approved == null

                                 select new
                                 {
                                     idO = o.IDOrari,
                                     idK = f.idKerkesa,
                                     lenda = l.Emri_i_lendes,
                                     ofv = o.OraFillimit,
                                     omv = o.OraMbarimit,
                                     dv = o.Dita,
                                     ofr = f.OraFillimit,
                                     omr = f.OraMbarimit,
                                     dr = f.Dita


                                 }).ToList();

                    foreach (var record in query)
                    {
                        rez.Add(record.lenda + ";" + record.dv + ";" + record.dr + ";"
                            + record.ofv + "-" + record.omv + ";" + record.ofr + "-" + record.omr + ";" + record.idO + ";" + record.idK);

                    }
                }
                }
                else
                {
                using (DBEntities db = new DBEntities())
                {
                    var query = (from f in db.KerkesaPerNderrims
                                 from lz in db.LendetEZgjedhuras
                                 from l in db.Lendas
                                 from li in db.Ligjeruesits
                                 from o in db.Oraris
                                 where f.Lenda == lz.idLendaZgjedhur &&
                                 li.IDLigjeruesi == lz.idLigjeruesi && li.IDLenda == l.IDLenda
                                 && o.IDLigjeruesi == li.IDLigjeruesi && f.approved == null
                                 && u.IDuseri == li.IDProfesori

                                 select new
                                 {
                                     idO = o.IDOrari,
                                     idK = f.idKerkesa,
                                     lenda = l.Emri_i_lendes,
                                     ofv = o.OraFillimit,
                                     omv = o.OraMbarimit,
                                     dv = o.Dita,
                                     ofr = f.OraFillimit,
                                     omr = f.OraMbarimit,
                                     dr = f.Dita


                                 }).ToList();

                    foreach (var record in query)
                    {
                        rez.Add(record.lenda + ";" + record.dv + ";" + record.dr + ";"
                            + record.ofv + "-" + record.omv + ";" + record.ofr + "-" + record.omr + ";" + record.idO + ";" + record.idK);

                    }
                }
            }
            return rez;
        }


        public Orari ktheOrarin(int idOrari)
        {
            using (DBEntities db = new DBEntities())
            {
                var query = db.Oraris.Where(c => (c.IDOrari == idOrari)).Select(c => c);
                return query.SingleOrDefault();

            }
            return null;
        }

        public KerkesaPerNderrim ktheKerkesen(int idOrari)
        {
            using (DBEntities db = new DBEntities())
            {
                var query = db.KerkesaPerNderrims.Where(c => (c.idKerkesa == idOrari)).Select(c => c);
                return query.SingleOrDefault();

            }
            return null;
        }

        public Boolean updateOrari(Orari o)
        {
            using(DBEntities db = new DBEntities())
            {
                var result = db.Oraris.SingleOrDefault(b => b.IDOrari == o.IDOrari);
                if (result != null)
                {
                    result.Dita = o.Dita;
                    result.OraFillimit = o.OraFillimit;
                    result.OraMbarimit = o.OraMbarimit;
                    db.SaveChanges();
                    return true;
                    MessageBox.Show("Ju keni ndryshuar te dhenat me sukses");
                }
            }
            return false;
        }

        public void updateApprove(KerkesaPerNderrim k)
        {
            using (DBEntities db = new DBEntities())
            {
                var result = db.KerkesaPerNderrims.SingleOrDefault(b => b.idKerkesa == k.idKerkesa);
                if (result != null)
                {
                    result.approved = true;
                    db.SaveChanges();
                }
            }
        }
        

        public Boolean caktoLenden(Ligjeruesit l)
        {
            using (DBEntities db = new DBEntities())
            {
                db.Ligjeruesits.Add(l);
               /* db.Lendas.Remove(l.Lenda);*/
                db.SaveChanges();
                return true;
            }
            return false;
            
        }

        
    }


}
