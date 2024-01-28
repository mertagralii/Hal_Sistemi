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
            SqlCommand cari = new SqlCommand("Select ID,Unvan from TBLMusteri Where SilindiMi = 0", baglanti);
            cari.CommandType = CommandType.Text;
            SqlDataReader dr = cari.ExecuteReader();
            while (dr.Read())
            {

                CmbMusteri.Items.Add(dr["Unvan"]);

            }
            baglanti.Close();
        }
        // Ürün Getir
        void ürüngetir()
        {
            baglanti.Open();
            SqlCommand urun = new SqlCommand("Select ID,UrunAd from TBLUrun Where SilindiMi=0", baglanti);
            urun.CommandType = CommandType.Text;
            SqlDataReader dr = urun.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["UrunAd"]);
            }
            baglanti.Close();
        }
        void listeleme()
        {
            // Listeleme Metodu
            SqlDataAdapter da = new SqlDataAdapter("SELECT TBLUrun.ID AS 'Ürün Numarası',TBLMusteri.ID AS 'Müşteri Numarası',Tckn AS 'TCKN',Vkn AS 'Vergi Kimlik Numarası',EFatura AS 'E-Fatura' ,Unvan AS 'Ünvan' ,VergiDairesi,Adres,Telefon,UrunAd AS 'Ürün Adı',Birim,Cinsi,Mensei,BirimFiyat,KDV FROM TBLUrun INNER JOIN TBLMusteri\r\nON TBLUrun.ID = TBLMusteri.ID\r\n", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Vergi Kimlik Numarası"].DisplayIndex = 3;
            dataGridView1.Columns["Ünvan"].DisplayIndex = 4;
            dataGridView1.Columns["E-Fatura"].DisplayIndex = 5;
            dataGridView1.Columns["VergiDairesi"].DisplayIndex = 6;
            dataGridView1.Columns["Adres"].DisplayIndex = 7;
            dataGridView1.Columns["Telefon"].DisplayIndex = 8;
            dataGridView1.Columns["Ürün Adı"].DisplayIndex = 9;
            dataGridView1.Columns["Cinsi"].DisplayIndex = 10;
            dataGridView1.Columns["Mensei"].DisplayIndex = 11;


        }

        // CariHareket Tablosunu getirme

        void carihareket()
        {
            SqlCommand komut = new SqlCommand("Select * From TBLCariHareket Where MusteriID=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", CmbMusteri.Text);
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
            ürüngetir();
            listeleme();

        }
    }
}
