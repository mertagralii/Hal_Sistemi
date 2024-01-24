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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        // SQL Bağlantisi
        SqlConnection baglanti = new SqlConnection(@"Data Source=Mert;Initial Catalog=DbHalSistem;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            // Giris Kısmı
            baglanti.Open();
            SqlCommand login = new SqlCommand("Select HalNo,HalSifre From TBLHalGiris Where HalNo=@P1 and HalSifre=@P2",baglanti);
            login.Parameters.AddWithValue("@P1", TxtHalNumarasi.Text);
            login.Parameters.AddWithValue("@P2", TxtHalSifre.Text);
            SqlDataReader dr = login.ExecuteReader();
            if (dr.Read())
            {
                FrmMenu frm = new FrmMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HalNumarası yada Şifre Yanlış", "Başarısız Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }
    }
}
