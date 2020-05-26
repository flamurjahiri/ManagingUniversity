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
    public partial class ShikoNderrimet : Form
    {
        public ShikoNderrimet(User u)
        {
            InitializeComponent();
            OrariMapper om = new OrariMapper();
            tabela.Rows.Clear();
            List<string> a = om.merrOrarin(u, 2);

            foreach (var i in a)
            {
                string[] v = i.Split(';');
                tabela.Rows.Add(v);
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {

        }
    }
}
