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

namespace ProjektiOrari.Views
{
    public partial class NdryshoTeDhenat : Form
    {
        private User u;
        public NdryshoTeDhenat(User u)
        {
            this.u = u;
            InitializeComponent();
            emriBox.Text = u.Emri;
            mbiemriBox.Text = u.Mbiemri;
            usernameBox.Text = u.Username;
            emailBox.Text = u.E_Mail;
        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NdryshoTeDhenat_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if(passwordBox.Text != password2Box.Text)
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "Passwordet nuk jane te njejta";
            }
            else
            {
                AllChanges ac = new AllChanges();
                UserMapper um = new UserMapper();
                u.Emri = emriBox.Text;
                 u.Mbiemri = mbiemriBox.Text;
                 u.Username = usernameBox.Text;
                u.E_Mail = emailBox.Text;
                u.Password = um.EncodePasswordToBase64(passwordBox.Text);
                ac.ndryshoTeDhenat(u);
            }
        }
    }
}
