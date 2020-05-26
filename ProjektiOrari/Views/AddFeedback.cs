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
using System.Windows.Forms;
using ProjektiOrari.Controller;
namespace ProjektiOrari.Views
{
    public partial class AddFeedback : Form
    {
        User u;
        public AddFeedback(User u)
        {
            InitializeComponent();
            this.u = u;
            UserMapper um = new UserMapper();
            
            List<string> lendet = um.ktheEmrin(u);
            
            int c = 0;
            foreach (var i in lendet) { 
                bunifuDropdown2.Items.Add(i);
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            UserMapper um = new UserMapper();
            feedback f = new feedback();
            List<int> a = um.ktheID(u);
            f.Lenda = a.ElementAt(bunifuDropdown2.SelectedIndex);
            f.Mesazhi = usernameBox.Text;
            string[] s =  bunifuDropdown2.Text.Split('-');
            char[] pr = s[1].Trim().ToCharArray() ;
            f.MesazhiRreth = "P";
            f.Studenti = u.IDuseri;
            if (um.addFeedback(f))
            {
                MessageBox.Show("Ju keni shtuar feedback me sukses");
                usernameBox.Clear();
            }
            else
            {
                MessageBox.Show("Error ne shtimin e nje feedback-u");
            }
            
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
