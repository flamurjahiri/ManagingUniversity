using ProjektiOrari.Controller;
using ProjektiOrari.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebPages;
using System.Windows.Forms;

namespace ProjektiOrari.Views
{
    public partial class ShtoStudent : Form
    {
        private string roli;
        public ShtoStudent(string roli)
        {
            InitializeComponent();
            this.roli = roli;
            if (roli.Equals("prof")){
                panel3.Hide(); 
            }

        }

        private void ok_Click(object sender, EventArgs e)
        {
            UserMapper um = new UserMapper();
            
            if (emriBox.Text.Trim() == ""|| mbiemriBox.Text.Trim() == "" 
                || shtetiBox.Text.Trim() == "" ||  qytetiBox.Text.Trim() == ""
                || usernameBox.Text.Trim() == "" ||  emailBox.Text.Trim() == ""
                || bunifuDropdown1.Text.Trim() == "" || !um.checkPassowrd(pwBox.Text) || !pwBox.Text.Equals(cpwBox.Text))
            {

                label7.ForeColor = System.Drawing.Color.Red;
                label7.Text = "Te dhenat nuk jane mire";

            }
            else
            {
                User u = new User();
                u.Emri = emriBox.Text;
                u.Mbiemri = mbiemriBox.Text;
                u.Gjinia = bunifuDropdown1.Text[0] + "";
                u.Shteti = shtetiBox.Text;
                u.Qyteti = qytetiBox.Text;
                u.Username = usernameBox.Text;
                u.Password = um.EncodePasswordToBase64(pwBox.Text);
                u.E_Mail = emailBox.Text;
                DateTime date = DateTime.Parse(datePick.Text);
                u.Data_e_lindjes = date;
                if (roli.Equals("prof"))
                {
                    u.Statusi = 1;
                }
                else
                {
                    u.Statusi = bunifuDropdown2.SelectedIndex + 1;
                }
                um.shtoStudent(u);

            }

        }
    }
}
