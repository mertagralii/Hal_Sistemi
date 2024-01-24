using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hal_Sistemi
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        // SQL Bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=Mert;Initial Catalog=DbHalSistem;Integrated Security=True");

        private void BtnCari_Click(object sender, EventArgs e)
        {
            FrmCari cari = new FrmCari();
            cari.Show();
        }

        private void BtnUrunler_Click(object sender, EventArgs e)
        {
            FrmUrun urun = new FrmUrun();   
            urun.Show();
        }
    }
}
