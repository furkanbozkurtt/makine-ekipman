using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makine_ekipman
{
    public partial class ilaclama : Form
    {
        public static string ilaclamatip;
        public static string ilaclamaguc;
        public static string ilaclamaguc1;
        public static string ilaclamakapasite;
        public static string ilaclamakapasite1;
        public static string ilaclamadebi;
        public static string ilaclamaek;
        public static string ilaclamabirim;
        public static string ilaclamamiktar;

        public ilaclama()
        {
            InitializeComponent();
        }

        private void ilaclama_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ilaclamabirim = txtIbirim.Text;
            ilaclamamiktar = txtIMiktar.Text;
            ilaclamatip = txtITip.Text;
            ilaclamaguc = txtIGuc.Text;
            ilaclamaguc1 = txtIGuc1.Text;
            ilaclamakapasite = txtIKapasite.Text;
            ilaclamakapasite1 = txtIKapasite1.Text;
            ilaclamadebi = txtIDebi.Text;
            ilaclamaek = txtIEk.Text;
            this.Close();
        }
    }
}
