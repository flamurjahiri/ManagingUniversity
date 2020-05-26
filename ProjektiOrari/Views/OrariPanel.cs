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
    public partial class OrariPanel : Form
    {
        private User u;
        public OrariPanel(User u )
        {
            InitializeComponent();
            this.u = u;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OrariMapper om = new OrariMapper();
            tabelaOrar.Rows.Clear();
            List<string> a = om.merrOrarin(u, bunifuDropdown1.SelectedIndex+1 );

            foreach (var i in a)
            {
                string[] v = i.Split(';');
                tabelaOrar.Rows.Add(v);
            }
        }

        private void tabelaOrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
