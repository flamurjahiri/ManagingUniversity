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
    public partial class NderrimiOrarit : Form
    {
        private User u;
        public NderrimiOrarit(User u)
        {
            InitializeComponent();
            this.u = u;
            UserMapper um = new UserMapper();

            List<string> lendet = um.ktheEmrin(u);

            int c = 0;
            foreach (var i in lendet)
            {
                bunifuDropdown1.Items.Add(i);
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == -1 || bunifuDropdown2.SelectedIndex == -1)
            {
                label5.ForeColor = System.Drawing.Color.Red;
                label5.Text = "Nuk keni zgjedhur lende ose Dite";
            }
            else
            {
                
                KerkesaPerNderrim k = new KerkesaPerNderrim();
                UserMapper um = new UserMapper();
                List<int> a = um.ktheID(u);
                k.Lenda = a.ElementAt(bunifuDropdown1.SelectedIndex);
                string[] d = { "H", "M", "Me", "E", "P" };
                k.Dita = d.ElementAt(bunifuDropdown2.SelectedIndex);
                TimeSpan ts = TimeSpan.Parse(orafillimit.Text);
                TimeSpan ts2 = TimeSpan.Parse(orambairmit.Text);
                k.OraFillimit = ts;
                k.OraMbarimit = ts2;
                new OrariMapper().dergoKerkesen(k);

            }




        }
    }
}
