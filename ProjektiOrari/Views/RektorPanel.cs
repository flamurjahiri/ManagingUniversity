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
    public partial class RektorPanel : Form
    {
        private User u;
        public RektorPanel(User u)
        {
            InitializeComponent();
            this.u = u;
            userInfo.Text = u.Emri + " " + u.Mbiemri;
        }

        private void RektorPanel_Load(object sender, EventArgs e)
        {

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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShtoStudent f2 = new ShtoStudent("rektor");
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            OrariPanel or = new OrariPanel(u);
            or.TopLevel = false;
            panel1.Controls.Add(or);
            or.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            or.Dock = DockStyle.Fill;
            or.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            LargoStudent f2 = new LargoStudent();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShtimiLendeve f2 = new ShtimiLendeve();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CaktoLendet f2 = new CaktoLendet();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ShikoFeedBack f2 = new ShikoFeedBack();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void fshijLendet_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            fshijLendet f2 = new fshijLendet();
            f2.TopLevel = false;
            panel1.Controls.Add(f2);
            //veq pe provojm qysh pe qet
            f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            f2.Dock = DockStyle.Fill;
            f2.Show();
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
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
