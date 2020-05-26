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
    public partial class ProfPanel : Form
    {
        private User u;
        public ProfPanel(User u)
        {
            InitializeComponent();
            this.u = u;
            userInfo.Text = u.Emri + " " + u.Mbiemri; 
        }

        private void butoniX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            /*new Login().buttonMin_Click(sender, e);*/
            this.WindowState = FormWindowState.Minimized;

        }

        

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                /*foreach (Control item in this.Controls)
                {
                    item.Anchor = (AnchorStyles.Right | AnchorStyles.Left);
                }*/

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OrariPanel or = new OrariPanel(u);
            or.TopLevel = false;
            panel1.Controls.Add(or);
            or.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            or.Dock = DockStyle.Fill;
            or.Show();
            /*um.updatePasswordat();*/
        }

        private void ProfPanel_Load(object sender, EventArgs e)
        {

        }

        private void userInfo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bunifuDropdown1.SelectedIndex == 0)
            {
                panel1.Controls.Clear();
                NdryshoTeDhenat f2 = new NdryshoTeDhenat(u);
                f2.TopLevel = false;
                panel1.Controls.Add(f2);
                //veq pe provojm qysh pe qet
                f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                f2.Dock = DockStyle.Fill;
                f2.Show();
            }
            if (bunifuDropdown1.SelectedIndex == 1)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShtoStudent f2 = new ShtoStudent("prof");
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
           /* AllChanges ac = new AllChanges();
            ac.updatePasswordat();*/
        }

        private void userInfo_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CnfNO f2 = new CnfNO(u);
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }
    }
}
