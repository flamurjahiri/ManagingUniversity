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
using System.Web.Mvc;
using System.Windows.Forms;

namespace ProjektiOrari.Views
{
    public partial class ShtimiLendeve : Form
    {
        public ShtimiLendeve()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            
            Lenda l = new Lenda();
            l.Emri_i_lendes = lendaBox.Text;
            l.Orë = textBox1.Text;
            l.Lloji = bunifuDropdown1.Text[0] + "";

            AllChanges ac = new AllChanges();
            if (ac.shtoLendet(l))
            {
                MessageBox.Show("Keni shtuar me sukses");
                lendaBox.Text = "";
                textBox1.Text = "";
                bunifuDropdown1.ResetText();            }
            else
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "Shkruaj te dhenat sakte";
            }
        }
    }
}
