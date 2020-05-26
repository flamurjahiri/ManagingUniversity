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
    public partial class ShikoFeedBack : Form
    {
        public ShikoFeedBack()
        {
            InitializeComponent();
            shtoFeedBack();
        }

        public void shtoFeedBack()
        {
            OrariMapper om = new OrariMapper();
            tabelaOrar.Rows.Clear();
            List<string> a = om.shikoFeedback();

            foreach (var i in a)
            {
                string[] v = i.Split(';');
                tabelaOrar.Rows.Add(v);
            }
        }
    }
}
