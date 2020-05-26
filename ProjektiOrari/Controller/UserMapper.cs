using ProjektiOrari.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjektiOrari.Model;
using System.Web.Mvc;
using System.Data.Entity.Validation;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace ProjektiOrari.Controller
{
    public class UserMapper
    {
        public  string EncodePasswordToBase64(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        } //this function Convert to Decord your Password
        //qito 2 funksione encode edhe decode spo bajn mir aha pe di
        public string DecodeFrom64(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        public Boolean checkPassowrd(string pass)
        {
            if (pass.Length < 6 || pass.Length > 12)
                return false;


            /*//At least 1 upper case letter
            if (!pass.Any(char.IsUpper))
                return false;*/

            //At least 1 lower case letter
            if (!pass.Any(char.IsLower))
                return false;

            /*//No two similar chars consecutively
            for (int i = 0; i < pass.Length - 1; i++)
            {
                if (pass[i] == pass[i + 1])
                    return false;
            }
*/
            //At least 1 special char
            /*string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (pass.Contains(c))
                    return true;
            }
            return false;*/
            return true;

        }

        public List<string> ktheUsers(int roli)
        {
            List<string> vargu = new List<string>();

            using (DBEntities db = new DBEntities())
            {

                var query = (from u in db.Users
                             where u.Statusi == roli
                             select new
                             {
                                 u.Emri,
                                 u.Mbiemri,
                                 u.Username,
                                 u.E_Mail
                             }).ToList();

                foreach (var record in query)
                {
                    vargu.Add(record.Emri + ";" + record.Mbiemri + ";" + record.Username + ";" + record.E_Mail);
                }

            }
            return vargu;

        }

        public List<string>  emriLendeve(User u)
        {
            List<string> vargu = new List<string>();
            
            using (DBEntities db = new DBEntities())
            {
                

                var query = (from lz in db.LendetEZgjedhuras
                             from us in db.Users
                             from l in db.Ligjeruesits
                             from le in db.Lendas
                             from u2 in db.Users
                             from ug in db.UserGroups
                             where lz.Studenti == us.IDuseri && lz.idLigjeruesi == l.IDLigjeruesi
                             && le.IDLenda == l.IDLenda && u2.IDuseri == l.IDProfesori && u2.Statusi == ug.Prioriteti
                             && u.IDuseri == us.IDuseri
                             select new
                             {
                                 l.IDLenda,
                                 le.Emri_i_lendes,
                                 ug.Emri
                             }).ToList() ;
                
                foreach (var record in query)
                {
                    vargu.Add(record.IDLenda + " - " +record.Emri_i_lendes + " - " + record.Emri);
                    /*vargu[1].Add(record.Emri);*/

                    
                }


            }
            return vargu;

        }

        public void shtoStudent(User u)
        {
            using(DBEntities db = new DBEntities())
            {
                db.Users.Add(u);
                db.SaveChanges();
                MessageBox.Show("Keni shtuar me sukses");
            }
        }

        public List<string> ktheEmrin(User u)
        {
            List<string> a = emriLendeve(u);
            List<string> rez = new List<string>();
            foreach (var i in a)
            {
                string[] s = i.Split('-');
                rez.Add(s[1] + "-" + s[2]);
            }
            return rez;
        }

        public List<int> ktheID(User u)
        {
            List<string> a = emriLendeve(u);
            List<int> rez = new List<int>();
            foreach (var i in a)
            {
                string[] s = i.Split('-');
                int asd = int.Parse(s[0]);
                rez.Add(asd);
            }
            return rez;
        }


        public Boolean addFeedback(feedback f)
        {
            using (DBEntities db = new DBEntities())
            {
                    db.feedbacks.Add(f);
                    db.SaveChanges();
                return true;
                
            }
            return false;
        }


        public void fshijUsers(string l)
        {
            string s = "Nuk keni fshire me sukses";

            using (DBEntities db = new DBEntities())
            {
                s = "Keni fshire me sukses";
                
                    var query = db.Users.Where(c => (c.Username == l)).Select(c => c);
                if (query.SingleOrDefault() != null)
                {
                    var useri = query.SingleOrDefault();
                    db.Users.Remove(useri);
                    db.SaveChanges();
                }
            }
            MessageBox.Show(s);


        }

        public List<string> merrLendet()
        {
            List<string> rez = new List<string>();

            using (DBEntities db = new DBEntities())
            {
                var query = db.Lendas.Select(c => c.Emri_i_lendes + ";" + c.IDLenda).ToList();

                rez = query;
            }
            return rez;
        }

        public Lenda ktheLendenMeId(int id)
        {
            
            using(DBEntities db = new DBEntities())
            {
                /*Lenda l = new Lenda();*/
                var query = db.Lendas.Where(c => c.IDLenda == id).Select(c => c);


                return query.SingleOrDefault();
            }
            return null;
        }


        public List<string> merrEmrat(int st)
        {
            List<string> rez = new List<string>();
            if (st == 2 || st == 3)
            {
                using (DBEntities db = new DBEntities())
                {

                    var query = (from u in db.Users
                                 where u.Statusi == 2 || u.Statusi == 3
                                 select new
                                 {
                                     u.IDuseri,
                                     u.Emri,
                                     u.Mbiemri,

                                 }).ToList();


                    foreach (var record in query)
                    {
                        rez.Add(record.IDuseri + ";" + record.Emri + " " + record.Mbiemri);
                    }
                }
            }
            else
            {
                using (DBEntities db = new DBEntities())
                {

                    var query = (from u in db.Users
                                 where u.Statusi == 1
                                 select new
                                 {
                                     u.IDuseri,
                                     u.Emri,
                                     u.Mbiemri,

                                 }).ToList();


                    foreach (var record in query)
                    {
                        rez.Add(record.IDuseri + ";" + record.Emri + " " + record.Mbiemri);
                    }
                }
            }
            return rez;
        }

        public List<string> profesoriLendeve(string profesori)
        {
            List<string> rez = new List<string>();
            using (DBEntities db = new DBEntities())
            {

                var query = (from u in db.Users
                             from l in db.Lendas
                             from li in db.Ligjeruesits
                             where u.IDuseri == li.IDProfesori && li.IDLenda == l.IDLenda &&
                             l.Emri_i_lendes == profesori
                             select new
                             {
                                 li.IDLigjeruesi,
                                 u.Emri,
                                 u.Mbiemri

                             }).ToList();

                foreach (var record in query)
                {
                    Console.WriteLine(record.IDLigjeruesi);
                    rez.Add(record.IDLigjeruesi + ";" + record.Emri + " " + record.Mbiemri);
                }
            }
            return rez;
        }


        public Boolean insertLendetZgjedhuraStudent(LendetEZgjedhura lz)
        {
            using (DBEntities db = new DBEntities())
            {
                db.LendetEZgjedhuras.Add(lz);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public List<string> mbushLendet()
        {
            List<string> rez = new List<string>();
            using (DBEntities db = new DBEntities())
            {
                var query = db.Lendas.Select(c => c.Emri_i_lendes);
                foreach (var record in query)
                {
                    rez.Add(record);
                }
            }
            return rez;
        }


        public string fshijLendet(string l)
        {
            string s = "Nuk keni fshire me sukses";

            using (DBEntities db = new DBEntities())
            {
                s = "Keni fshire me sukses";

                var query = db.Lendas.Where(c => (c.Emri_i_lendes == l)).Select(c => c);
                if (query.SingleOrDefault() != null)
                {
                    var Lenda = query.SingleOrDefault();
                    db.Lendas.Remove(Lenda);
                    db.SaveChanges();
                }
            }
            return s;
        }


        public List<string> merrLendetELira()
        {
            List<string> rez = new List<string>();
            using (DBEntities db = new DBEntities())
            {
                /* Select l.[Emri i lendes]
         From Lenda l
         where l.[Emri i lendes] not in (
                                     select distinct l.[Emri i lendes]
                             from Ligjeruesit li inner join LendetEZgjedhura lz on 
                             lz.idLigjeruesi = li.IDLigjeruesi inner join Lenda l on l.IDLenda = li.IDLenda)*/

                var query = (from li in db.Ligjeruesits
                             from l in db.Lendas
                             where li.IDLenda == l.IDLenda
                             select l.Emri_i_lendes).Distinct().ToList();
                var query2 = (from l in db.Lendas
                              select l.Emri_i_lendes).ToList();

                    foreach (var i in query2)
                {
                    Boolean asd = false;
                    foreach (var j in query)
                    {
                        if (i.Equals(j))
                        {
                            asd = true;
                        }
                    }
                    if (!asd)
                    {
                        rez.Add(i);
                    }
                    
                }
                    
            }
            return rez;
        }

    }
}
