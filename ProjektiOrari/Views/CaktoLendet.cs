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
    public partial class CaktoLendet : Form
    {
        public List<int> idja = new List<int>();
        public List<int> idL = new List<int>();
        private int zgjedh = -1;
        public int c = -1;
        public CaktoLendet()
        {
            InitializeComponent();
            panel2.Hide();
            
        }
        public void mbushDropdown()
        {
            bunifuDropdown1.Items.Clear();
            bunifuDropdown2.Items.Clear();
            bunifuDropdown3.Items.Clear();
            idja = new List<int>();
            idL = new List<int>();
            UserMapper um = new UserMapper();

            List<string> lendet = um.merrLendet();

          
            foreach (var i in lendet)
            {
                String[] s = i.Split(';');
                idL.Add(int.Parse(s.ElementAt(1)));
                bunifuDropdown1.Items.Add(s.ElementAt(0));
            }

            List<string> emrat = um.merrEmrat(2);
            foreach (var i in emrat)
            {
                String[] s = i.Split(';');
                idja.Add(int.Parse(s.ElementAt(0)));
                bunifuDropdown2.Items.Add(s.ElementAt(1));
            }

            bunifuDropdown3.Items.Add("Ligjerata");
            bunifuDropdown3.Items.Add("Ushtrime");

        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (zgjedh == -1)
            {
                label4.ForeColor = System.Drawing.Color.Red;
                label4.Text = "Nuk keni zgjedhur profesor ose student";
            }
            else
            {
                if (zgjedh == 1)
                {
                    OrariMapper om = new OrariMapper();
                    UserMapper um = new UserMapper();
                    Ligjeruesit l = new Ligjeruesit();
                    l.IDProfesori = idja.ElementAt(bunifuDropdown2.SelectedIndex);
                    /*Console.WriteLine(l.IDProfesori);*/
                    /* l.Lenda = um.ktheLendenMeId(idL.ElementAt(bunifuDropdown1.SelectedIndex));*/
                    l.IDLenda = idL.ElementAt(bunifuDropdown1.SelectedIndex);
                    //kur po e thirr qitu Lenda duhet IDLenda me thirr jo lenda edhe ktu pe krijon 1 lend te re qata
                    /*Console.WriteLine(l.Lenda.IDLenda);*/
                    l.Lloji = bunifuDropdown3.Text[0] + "";
                    if (om.caktoLenden(l))
                    {
                        MessageBox.Show("Keni caktuar lenden me sukses");
                    }
                    else
                    {
                        label4.ForeColor = System.Drawing.Color.Red;
                        label4.Text = "Nuk mund te shtohet";
                    }
                }
                else
                {
                    UserMapper um = new UserMapper();
                    LendetEZgjedhura lz = new LendetEZgjedhura();
                    lz.Semestri = int.Parse(bunifuDropdown5.Text);
                    lz.idLigjeruesi = c;
                    lz.Studenti = idja.ElementAt(bunifuDropdown2.SelectedIndex);
                    if (um.insertLendetZgjedhuraStudent(lz))
                    {
                        MessageBox.Show("Keni shtuar me sukses lenden");
                    }
                    else
                    {
                        label4.ForeColor = System.Drawing.Color.Red;
                        label4.Text = "Nuk mund te shtohet";
                    }
                }
            

            }
        

        }

        public void mbushiDropDown2()
        {
            bunifuDropdown1.Items.Clear();
            bunifuDropdown2.Items.Clear();
            bunifuDropdown3.Items.Clear();

            idL = new List<int>();
            idja = new List<int>();
            UserMapper um = new UserMapper();

            List<string> lendet = um.merrLendet();


            foreach (var i in lendet)
            {
                String[] s = i.Split(';');
                idL.Add(int.Parse(s.ElementAt(1)));
                bunifuDropdown1.Items.Add(s.ElementAt(0));
            }

            List<string> emrat = um.merrEmrat(1);
            foreach (var i in emrat)
            {
                String[] s = i.Split(';');
                idja.Add(int.Parse(s.ElementAt(0)));
                bunifuDropdown2.Items.Add(s.ElementAt(1));
            }
        }

        private void bunifuDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(bunifuDropdown4.SelectedIndex == 1)
            {
                label1.Text = "Stafi";
                label3.Text = "L/U";
                panel2.Hide();
                mbushDropdown();
                zgjedh = 1;
            }
            else if (bunifuDropdown4.SelectedIndex == 0)
            {
                label1.Text = "Studenti";
                label3.Text = "Profesori";
                panel2.Show();
                mbushiDropDown2();
                zgjedh = 0;
            }
        }

        private void CaktoLendet_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserMapper um = new UserMapper();
            if (zgjedh == 0)
            {
                bunifuDropdown3.Items.Clear();
                List<string> profa = um.profesoriLendeve(bunifuDropdown1.Text);
               // Console.WriteLine(bunifuDropdown1.SelectedIndex);
                foreach (var i in profa)
                {
                    string[] s = i.Split(';');
                    bunifuDropdown3.Items.Add(s.ElementAt(1));
                    c = int.Parse(s.ElementAt(0));
                }
            }
        }
    }
}
