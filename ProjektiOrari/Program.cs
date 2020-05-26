using ProjektiOrari.Controller;
using ProjektiOrari.Model;
using ProjektiOrari.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektiOrari
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());



            /*UserGroup ug = new UserGroup();
            ug.Emri = "Flamur";
            ug.Prioriteti = 5;
            using (DBEntities db = new DBEntities())
            {
                db.UserGroups.Add(ug);
                db.SaveChanges();
            }
            MessageBox.Show("Test12");
        }*/
        }
    }
}
