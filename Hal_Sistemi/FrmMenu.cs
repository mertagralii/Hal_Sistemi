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

        // Musteri IDlerini getirme
        void musterigetir()
        {
            baglanti.Open();
            SqlCommand cari = new SqlCommand("Select ID,Unvan from TBLMusteri", baglanti);
            cari.CommandType = CommandType.Text;
            SqlDataReader dr = cari.ExecuteReader();
            while (dr.Read())
            {

                //comboBox1.Items.Add(new ComboBoxItem((int)dr["ID"], dr["Unvan"].ToString()));
                comboBox1.Items.Add(dr["ID"]);
            }
            baglanti.Close();
        }
        // CariHareket Tablosunu getirme

        void carihareket()
        {
            SqlCommand komut = new SqlCommand("Select * From TBLCariHareket Where MusteriID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void BtnCari_Click(object sender, EventArgs e)
        {
            // Cari(Müşteri) Kısmını açma
            FrmCari cari = new FrmCari();
            cari.Show();
        }

        private void BtnUrunler_Click(object sender, EventArgs e)
        {
            // Urunler kısmını açma
            FrmUrun urun = new FrmUrun();
            urun.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            musterigetir();
            carihareket();

        }
    }
}
