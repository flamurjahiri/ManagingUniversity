using ProjektiOrari.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiOrari.Controller
{
    public class AllChanges
    {
        public void ndryshoTeDhenat(User u)
        {

            using (DBEntities db = new DBEntities())
            {


                var result = db.Users.SingleOrDefault(b => b.IDuseri == u.IDuseri);
                if (result != null)
                {
                    result.Emri = u.Emri;
                    result.Mbiemri = u.Mbiemri;
                    result.E_Mail = u.E_Mail;
                    result.Password = u.Password;
                    result.Username = u.Username;
                    db.SaveChanges();
                    MessageBox.Show("Ju keni ndryshuar te dhenat me sukses");
                }
            }
        }

        public void updatePasswordat()
        {
            UserMapper um = new UserMapper();
            using (DBEntities db = new DBEntities())
            {


                var result = db.Users.SingleOrDefault(b => b.IDuseri == 9);
                if (result != null)
                {
                    var b = result.Password;
                    result.Password = um.EncodePasswordToBase64(b);
                    db.SaveChanges();
                    MessageBox.Show("Ju keni ndryshuar te dhenat me sukses");
                }
            }
        }

        public Boolean shtoLendet(Lenda l)
        {
            using (DBEntities db = new DBEntities())
            {
                db.Lendas.Add(l);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
