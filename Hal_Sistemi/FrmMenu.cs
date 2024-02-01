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
using System.Xml.Linq;


namespace Hal_Sistemi
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        // GLOBAL ALAN KISMI 


        // SQL Bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=Mert;Initial Catalog=DbHalSistem;Integrated Security=True");

        int deger = 0;

        void listeleme()
        {
            // Listeleme Metodu (innerjoinli)
            string innerjoin = "SELECT TBLCariHareket.ID AS 'Hareket Numarası',TBLUrun.ID AS 'Ürün Numarası',TBLMusteri.ID AS 'Müşteri Numarası',TBLMusteri.Tckn AS 'TCKN',TBLMusteri.Vkn AS 'Vergi Kimlik Numarası',TBLMusteri.EFatura AS 'E-Fatura' ,TBLMusteri.Unvan AS 'Ünvan' ,TBLMusteri.VergiDairesi,TBLMusteri.Adres,TBLMusteri.Telefon,TBLMusteri.Eposta AS'E-Posta',TBLUrun.UrunAd AS 'Ürün Adı',TBLUrun.Birim,TBLUrun.Cinsi,TBLUrun.Mensei,TBLUrun.BirimAdet,TBLUrun.BirimFiyat,TBLUrun.KDV,CAST(((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) + ((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) * (TBLUrun.KDV / 100.0))) AS DECIMAL(18, 2)) AS 'Toplam Fiyat' FROM TBLCariHareket INNER JOIN TBLMusteri ON TBLMusteri.ID = TBLCariHareket.MusteriID INNER JOIN TBLUrun ON TBLUrun.ID = TBLCariHareket.UrunID Where TBLMusteri.SilindiMi=0 AND TBLUrun.SilindiMi=0 ORDER BY TBLMusteri.ID ASC";
            SqlDataAdapter da = new SqlDataAdapter(innerjoin, baglanti);
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
            dataGridView1.Columns["E-Posta"].DisplayIndex = 10;
            dataGridView1.Columns["Ürün Adı"].DisplayIndex = 11;
            dataGridView1.Columns["Cinsi"].DisplayIndex = 12;
            dataGridView1.Columns["Mensei"].DisplayIndex = 13;
        }
        //Tüm tabloları temizleme metodu
        void temizleme()
        {
            TxtCariID.Text = " ";
            TxtMüsteriID.Text = " ";
            TxtUrunID.Text = " ";
            MskTcknVkn.Text = " ";
            TxtUnvan.Text = " ";
            TxtVergiDairesi.Text = " ";
            TxtAdres.Text = " ";
            MskTelefon.Text = " ";
            TxtEposta.Text = " ";
            TxtUrunAd.Text = " ";
            TxtCinsi.Text = " ";
            TxtMensei.Text = " ";
            TxtBirimAdet.Text = " ";
            TxtBirimFiyat.Text = " ";
            CmbBirim.Text = " ";
            TxtKDV.Text = " ";
            LBTutar.Text = "0" + "" + "TL";
            RBEvet.Checked = false;
            RBHayir.Checked = false;
            TxtAramaYap.Text = " ";
        }
        // Müşteri Temizleme Metodu
        void musteritemizleme()
        {
            MskTcknVkn.Text = " ";
            TxtUnvan.Text = " ";
            RBEvet.Checked = false;
            RBHayir.Checked = false;
            TxtVergiDairesi.Text = " ";
            TxtAdres.Text = " ";
            MskTelefon.Text = " ";
            TxtEposta.Text = " ";
        }
        //Ürün Temizleme Metodu
        void uruntemizleme()
        {
            TxtUrunAd.Text = " ";
            TxtCinsi.Text = " ";
            TxtMensei.Text = " ";
            CmbBirim.Text = " ";
            TxtBirimAdet.Text = " ";
            TxtBirimFiyat.Text = " ";
            TxtKDV.Text = " ";
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
            string arama = "SELECT TBLCariHareket.ID AS 'Hareket Numarası',TBLUrun.ID AS 'Ürün Numarası',TBLMusteri.ID AS 'Müşteri Numarası',TBLMusteri.Tckn AS 'TCKN',TBLMusteri.Vkn AS 'Vergi Kimlik Numarası',TBLMusteri.EFatura AS 'E-Fatura' ,TBLMusteri.Unvan AS 'Ünvan' ,TBLMusteri.VergiDairesi,TBLMusteri.Adres,TBLMusteri.Telefon,TBLMusteri.Eposta AS'E-Posta',TBLUrun.UrunAd AS 'Ürün Adı',TBLUrun.Birim,TBLUrun.Cinsi,TBLUrun.Mensei,TBLUrun.BirimAdet,TBLUrun.BirimFiyat,TBLUrun.KDV,CAST(((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) + ((TBLUrun.BirimAdet * TBLUrun.BirimFiyat) * (TBLUrun.KDV / 100.0))) AS DECIMAL(18, 2)) AS 'Toplam Fiyat' FROM TBLCariHareket INNER JOIN TBLMusteri ON TBLMusteri.ID = TBLCariHareket.MusteriID INNER JOIN TBLUrun ON TBLUrun.ID = TBLCariHareket.UrunID WHERE Unvan  LIKE @P1 AND TBLUrun.SilindiMi=0 ORDER BY TBLMusteri.ID ASC";
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
            temizleme();
            MessageBox.Show("Cari Hareket Tablosu Listelendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            // Ekleme İşlemi
            try
            {
                baglanti.Open();
                SqlCommand cariHareketİnsert = new SqlCommand("INSERT INTO TBLCariHareket (MusteriID,UrunID) VALUES (@P1,@P2)", baglanti);
                cariHareketİnsert.Parameters.AddWithValue("@P1", TxtMüsteriID.Text);
                cariHareketİnsert.Parameters.AddWithValue("@P2", TxtUrunID.Text);
                cariHareketİnsert.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listeleme();
                temizleme();
            }
            catch
            {
                MessageBox.Show("Müşteri Numarası ve Ürün Numarası Girilmedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme İşlemi

            baglanti.Open();
            SqlCommand cariHareketUpdate = new SqlCommand("UPDATE TBLCariHareket SET MusteriID=@P1,UrunID=@P2 Where ID=@P3", baglanti);
            cariHareketUpdate.Parameters.AddWithValue("@P1", TxtMüsteriID.Text);
            cariHareketUpdate.Parameters.AddWithValue("@P2", TxtUrunID.Text);
            cariHareketUpdate.Parameters.AddWithValue("@P3", TxtCariID.Text);
            cariHareketUpdate.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleme();
            temizleme();
        }

        private void CmbBirim_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Klavye Girişini Engelle
            e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagrid'den gelen verileri kutulara yerleştirme

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtCariID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtMüsteriID.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[3].Value.ToString() == "")
            {
                MskTcknVkn.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            }
            else
            {
                MskTcknVkn.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            }

            TxtUnvan.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                deger = 1;
                RBEvet.Checked = true;

            }
            else
            {
                deger = 0;
                RBHayir.Checked = true;
            }
            TxtVergiDairesi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            TxtEposta.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            CmbBirim.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            TxtCinsi.Text = dataGridView1.Rows[secilen].Cells[13].Value.ToString();
            TxtMensei.Text = dataGridView1.Rows[secilen].Cells[14].Value.ToString();
            TxtBirimAdet.Text = dataGridView1.Rows[secilen].Cells[15].Value.ToString();
            TxtBirimFiyat.Text = dataGridView1.Rows[secilen].Cells[16].Value.ToString();
            TxtKDV.Text = dataGridView1.Rows[secilen].Cells[17].Value.ToString();
            LBTutar.Text = dataGridView1.Rows[secilen].Cells[18].Value.ToString() + " " + " TL"; 
        }
        private void TxtMüsteriID_TextChanged(object sender, EventArgs e)
        {
            //Texbox'ın içine bir değer yazıldığında gelen değerleri diğer tablolara doldur.


            // Eğer müşteri numarası boşsa diğer alanları da temizle
            string customerID = TxtMüsteriID.Text.Trim();
            if (string.IsNullOrEmpty(customerID))
            {
                musteritemizleme();
                return;
            }
            SqlCommand Musterigetir = new SqlCommand("Select Tckn,EFatura,Unvan,VergiDairesi,Adres,Telefon,Eposta,Vkn From TBLMusteri Where ID=@ID AND SilindiMİ=0", baglanti);
            Musterigetir.Parameters.AddWithValue("@ID", TxtMüsteriID.Text);
            baglanti.Open();
            SqlDataReader dr = Musterigetir.ExecuteReader();
            if (dr.Read())
            {
                if (dr["Vkn"].ToString().Length <= 10)
                {
                    MskTcknVkn.Text = dr["Vkn"].ToString();
                }

                if (dr["Tckn"].ToString().Length == 11)
                {
                    MskTcknVkn.Text = dr["Tckn"].ToString();
                }
                TxtUnvan.Text = dr["Unvan"].ToString();
                if (dr["EFatura"].ToString() == "True")
                {
                    RBEvet.Checked = true;
                }
                else
                {
                    RBHayir.Checked = true;
                }
                TxtVergiDairesi.Text = dr["VergiDairesi"].ToString();
                TxtAdres.Text = dr["Adres"].ToString();
                MskTelefon.Text = dr["Telefon"].ToString();
                TxtEposta.Text = dr["Eposta"].ToString();
            }
            baglanti.Close();
            dr.Close();
            return;
        }

        private void TxtUrunID_TextChanged(object sender, EventArgs e)
        {
            //Texbox'ın içine bir değer yazıldığında gelen değerleri diğer tablolara doldur.
            // Eğer Ürün numarası boşsa diğer alanları da temizle
            string customerID = TxtUrunID.Text.Trim();
            if (string.IsNullOrEmpty(customerID))
            {
                uruntemizleme();
                return;
            }
            SqlCommand urungetir = new SqlCommand("Select UrunAd,Birim,Cinsi,Mensei,BirimAdet,BirimFiyat,KDV From TBLUrun Where ID =@ID AND SilindiMi=0", baglanti);
            urungetir.Parameters.AddWithValue("@ID", TxtUrunID.Text);
            baglanti.Open();
            SqlDataReader dr = urungetir.ExecuteReader();
            if (dr.Read())
            {
                TxtUrunAd.Text = dr["UrunAd"].ToString();
                TxtCinsi.Text = dr["Cinsi"].ToString();
                TxtMensei.Text = dr["Mensei"].ToString();
                CmbBirim.Text = dr["Birim"].ToString();
                TxtBirimAdet.Text = dr["BirimAdet"].ToString();
                TxtBirimFiyat.Text = dr["BirimFiyat"].ToString();
                TxtKDV.Text = dr["KDV"].ToString();
            }
            baglanti.Close();
            dr.Close() ;

        }

        private void MskTcknVkn_TextChanged(object sender, EventArgs e)
        {
            if (MskTcknVkn.Text.Length <= 10)
            {
                TxtVergiDairesi.Visible = true;
                RBEvet.Visible = true;
                RBHayir.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }
            else
            {
                label7.Visible = false;
                label8.Visible = false;
                TxtVergiDairesi.Visible = false;
                RBEvet.Visible = false;
                RBHayir.Visible = false;
            }
        }
    }
}
