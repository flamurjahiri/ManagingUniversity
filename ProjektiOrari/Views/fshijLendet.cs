using ProjektiOrari.Controller;
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
    public partial class fshijLendet : Form
    {
        public fshijLendet()
        {
            InitializeComponent();
            mbushLendet();
        }

        public void mbushLendet()
        {
            UserMapper um = new UserMapper();
            List<string> lendet = um.merrLendetELira();
            foreach (var i in lendet)
            {
                bunifuDropdown1.Items.Add(i);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UserMapper um = new UserMapper();

            MessageBox.Show(um.fshijLendet(bunifuDropdown1.Text));
            bunifuDropdown1.Items.Clear();
            mbushLendet();
        }
    }
}
