using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjektiOrari.Model;
using ProjektiOrari.Views;

namespace ProjektiOrari.Controller
{
    public class LoginMapper
    { 
     
        public User checkExist(string username, string password2)
        {
            UserMapper um = new UserMapper();
            string password = um.EncodePasswordToBase64(password2);
            using (DBEntities db = new DBEntities()) {
                /*var query = from u in db.Users
                            where u.Username == username && u.Password == password
                            select u;*/
                var query = db.Users.Where(c => (c.Username==username && c.Password==password)).Select(c => c);
                if (query.SingleOrDefault() !=null )

                {
                    User us = new User();
                    var useri = query.SingleOrDefault();
                    us.IDuseri = useri.IDuseri;
                    us.Emri = useri.Emri;
                    us.Mbiemri = useri.Mbiemri;
                    us.Gjinia = useri.Gjinia;
                    us.Shteti = useri.Shteti;
                    us.Qyteti = useri.Qyteti;
                    us.Username = useri.Username;
                    us.Password = useri.Password;
                    us.Data_e_lindjes = useri.Data_e_lindjes;
                    us.Mosha = useri.Mosha;
                    us.Statusi = useri.Statusi;
                    us.E_Mail = useri.E_Mail;
            
                    return  us;
                }
           }
            return null;
        }


    }
}