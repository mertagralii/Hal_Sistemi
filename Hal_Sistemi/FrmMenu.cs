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
        void listeleme()
        {
            // Listeleme Metodu (innerjoinli)
            string innerjoin = "SELECT TBLCariHareket.ID AS 'Hareket Numarası',TBLUrun.ID AS 'Ürün Numarası',TBLMusteri.ID AS 'Müşteri Numarası',TBLMusteri.Tckn AS 'TCKN',TBLMusteri.Vkn AS 'Vergi Kimlik Numarası',TBLMusteri.EFatura AS 'E-Fatura' ,TBLMusteri.Unvan AS 'Ünvan' ,TBLMusteri.VergiDairesi,TBLMusteri.Adres,TBLMusteri.Telefon,TBLMusteri.Eposta AS'E-Posta',TBLUrun.UrunAd AS 'Ürün Adı',TBLUrun.Birim,TBLUrun.Cinsi,TBLUrun.Mensei,TBLUrun.BirimAdet,TBLUrun.BirimFiyat,TBLUrun.KDV,CAST(((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) + ((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) * (TBLUrun.KDV / 100.0))) AS DECIMAL(18, 2)) AS 'Toplam Fiyat' FROM TBLCariHareket INNER JOIN TBLMusteri ON TBLMusteri.ID = TBLCariHareket.MusteriID INNER JOIN TBLUrun ON TBLUrun.ID = TBLCariHareket.UrunID ORDER BY TBLMusteri.ID ASC";
            SqlDataAdapter da = new SqlDataAdapter( innerjoin,baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Hareket Numarası"].DisplayIndex = 0;
            dataGridView1.Columns["Müşteri Numarası"].DisplayIndex = 1;
            dataGridView1.Columns["Ürün Numarası"].DisplayIndex = 2;
            dataGridView1.Columns["TCKN"].DisplayIndex = 3;
            dataGridView1.Columns["Vergi Kimlik Numarası"].DisplayIndex = 4;
            dataGridView1.Columns["Ünvan"].DisplayIndex = 5;
            dataGridView1.Columns["E-Fatura"].DisplayIndex = 6;
            dataGridView1.Columns["VergiDairesi"].DisplayIndex = 7;
            dataGridView1.Columns["Adres"].DisplayIndex = 8;
            dataGridView1.Columns["Telefon"].DisplayIndex = 9;
            dataGridView1.Columns["Ürün Adı"].DisplayIndex = 10;
            dataGridView1.Columns["Cinsi"].DisplayIndex = 11;
            dataGridView1.Columns["Mensei"].DisplayIndex = 12;
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
            // Listeleme
            listeleme();
        }

        private void BtnAramaYap_Click(object sender, EventArgs e)
        {
            // Arama İşlemi
            string arama = "SELECT TBLCariHareket.ID AS 'Hareket Numarası',TBLUrun.ID AS 'Ürün Numarası',TBLMusteri.ID AS 'Müşteri Numarası',TBLMusteri.Tckn AS 'TCKN',TBLMusteri.Vkn AS 'Vergi Kimlik Numarası',TBLMusteri.EFatura AS 'E-Fatura' ,TBLMusteri.Unvan AS 'Ünvan' ,TBLMusteri.VergiDairesi,TBLMusteri.Adres,TBLMusteri.Telefon,TBLMusteri.Eposta AS'E-Posta',TBLUrun.UrunAd AS 'Ürün Adı',TBLUrun.Birim,TBLUrun.Cinsi,TBLUrun.Mensei,TBLUrun.BirimAdet,TBLUrun.BirimFiyat,TBLUrun.KDV,CAST(((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) + ((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) * (TBLUrun.KDV / 100.0))) AS DECIMAL(18, 2)) AS 'Toplam Fiyat' FROM TBLCariHareket INNER JOIN TBLMusteri ON TBLMusteri.ID = TBLCariHareket.MusteriID INNER JOIN TBLUrun ON TBLUrun.ID = TBLCariHareket.UrunID WHERE Unvan LIKE @P1 ORDER BY TBLMusteri.ID ASC";
            SqlCommand search = new SqlCommand(arama, baglanti);
            search.Parameters.AddWithValue("@P1", "%" + TxtAramaYap.Text + "%");
            baglanti.Open();
            SqlDataReader reader = search.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            MessageBox.Show("Arama İşlemi Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            // Listeleme
            listeleme();
        }
    }
}
