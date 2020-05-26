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
using System.Windows.Forms.VisualStyles;

namespace ProjektiOrari.Views
{
    public partial class CnfNO : Form
    {
        private List<int> idO = new List<int>();
        private List<int> idK = new List<int>();
        private User u;
        public CnfNO(User u)
        {
            InitializeComponent();
            this.u = u;
            mbushOrarit();
        }


        public void mbushOrarit()
        {
            OrariMapper om = new OrariMapper();
            bunifuDataGridView1.Rows.Clear();
            
            List<string> a = om.kerkesatPerNderrim(u);
            
            foreach (var i in a) {
                string[] v = i.Split(';');
                string[] rez = new string[v.Length-2];
                for (int j = 0; j<rez.Length; j++)
                {
                    rez[j] = v[j];
                }
                idO.Add(int.Parse(v[v.Length - 2]));
                idK.Add(int.Parse(v[v.Length - 1]));
                bunifuDataGridView1.Rows.Add(rez);
            }
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            OrariMapper um = new OrariMapper();
            for (int i = 0; i < bunifuDataGridView1.Rows.Count; i++)
            {
                Boolean test = false;
                if (bunifuDataGridView1.Rows[i].Cells[5].Value != null)
                {
                    test = (bool)bunifuDataGridView1.Rows[i].Cells[5].Value;
                }
                if (test)
                {
                    Orari o = um.ktheOrarin(idO.ElementAt(i));
                    KerkesaPerNderrim k = um.ktheKerkesen(idK.ElementAt(i));
                    o.OraFillimit = k.OraFillimit;
                    o.OraMbarimit = k.OraMbarimit;
                    o.Dita = k.Dita;
                    
                    if (um.updateOrari(o))
                    {
                        um.updateApprove(k);
                        idO = new List<int>();
                        idK = new List<int>();
                        mbushOrarit();
                    }

                }
            }

            bunifuDataGridView1.Rows.Clear();
            mbushOrarit();
            
        }
    }
}
