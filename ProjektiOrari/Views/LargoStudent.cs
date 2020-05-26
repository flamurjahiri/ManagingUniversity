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
    public partial class LargoStudent : Form
    {
        public int sel = -1;
        public LargoStudent()
        {
            InitializeComponent();
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            UserMapper om = new UserMapper();
            bunifuDataGridView1.Rows.Clear();
            sel = bunifuDropdown1.SelectedIndex + 1;
            List<string> a = om.ktheUsers(sel);

            foreach (var i in a)
            {
                string[] v = i.Split(';');
                bunifuDataGridView1.Rows.Add(v);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UserMapper um = new UserMapper();
            for (int i = 0; i <bunifuDataGridView1.Rows.Count; i++)
            {
                Boolean test = false;
                if(bunifuDataGridView1.Rows[i].Cells[4].Value != null)
                {
                    test = (bool)bunifuDataGridView1.Rows[i].Cells[4].Value;
                }
                if (test)
                {
                    string asd = bunifuDataGridView1.Rows[i].Cells[2].Value + "";
                    asd.Trim();
                    Console.WriteLine(asd);
                    um.fshijUsers(asd);
                }   
            }

            bunifuDataGridView1.Rows.Clear();
            List<string> a = um.ktheUsers(sel);

            foreach (var i in a)
            {
                string[] v = i.Split(';');
                bunifuDataGridView1.Rows.Add(v);
            }

        }
    }
}
