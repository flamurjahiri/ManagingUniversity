using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjektiOrari.Controller;
using ProjektiOrari.Model;

namespace ProjektiOrari.Views
{
    public partial class Login : Form
    {
        public int countGabim = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;
        }


        private void buttonMax_Click_1(object sender, EventArgs e)
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

        public void buttonMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void butoniX_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginMapper lm = new LoginMapper();
            string username = usernameBox.Text.Trim().ToString();
            string password = passwordBox.Text.Trim().ToString();
            /*Console.WriteLine(username + " " + password);*/
            User u = lm.checkExist(username, password);
            
            if (u != null)
            {
                LoginPanel.Controls.Clear();
                countGabim = 0;
                if (u.Statusi == 2 || u.Statusi == 3)
                {
                    ProfPanel f2 = new ProfPanel(u);
                    

                    f2.TopLevel = false;
                    LoginPanel.Controls.Add(f2);
                    f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }

                else if (u.Statusi == 4)
                {
                    RektorPanel f2 = new RektorPanel(u);
                    f2.TopLevel = false;
                    LoginPanel.Controls.Add(f2);
                    f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }
                else
                {
                    StudentPanel f2 = new StudentPanel(u);
                    f2.TopLevel = false;
                    LoginPanel.Controls.Add(f2);
                    f2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    f2.Dock = DockStyle.Fill;
                    f2.Show();
                }
            }
            else
            {
                label3.ForeColor = System.Drawing.Color.Red;
                label3.Text = "Keni shenuar te dhenat gabim";

                passwordBox.Clear();
                countGabim++;
            }

            if (countGabim == 3)
            {
                MessageBox.Show("Keni shenuar 3-here te dhenat gabim");
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
