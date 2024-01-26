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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        // SQL Bağlantısı
        SqlConnection baglanti = new SqlConnection(@"Data Source=Mert;Initial Catalog=DbHalSistem;Integrated Security=True");
        void listeleme()
        {
            // Listeleme Metodu
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLUrun", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        void temizleme()
        {
            // Temizleme Metodu
            TxtUrunid.Text = " ";
            TxtUrunAd.Text = " ";
            TxtCins.Text = " ";
            CmbBirim.Text = " ";
            TxtMensei.Text = " ";
            TxtBirimFiyat.Text = " ";
            TxtKDVOran.Text = " ";
        }
        void musterigetir()
        {
            baglanti.Open();
            SqlCommand cari = new SqlCommand("Select ID from TBLMusteri", baglanti);
            cari.CommandType = CommandType.Text;
            SqlDataReader dr = cari.ExecuteReader();
            while (dr.Read())
            {
                CmbMusteri.Items.Add(dr["ID"]);
            }
            baglanti.Close();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            musterigetir();

            listeleme();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            // Ekleme İşlemi
            baglanti.Open();
            SqlCommand inter = new SqlCommand("insert into TBLUrun (MusteriID,Urunad,Birim,Cinsi,Mensei,BirimFiyat,KDV) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", baglanti);
            inter.Parameters.AddWithValue("@P1",CmbMusteri.Text);
            inter.Parameters.AddWithValue("@P2", TxtUrunAd.Text);
            inter.Parameters.AddWithValue("@P3", CmbBirim.Text);
            inter.Parameters.AddWithValue("@P4", TxtCins.Text);
            inter.Parameters.AddWithValue("@P5", TxtMensei.Text);
            inter.Parameters.AddWithValue("@P6", TxtBirimFiyat.Text);
            inter.Parameters.AddWithValue("@P7", TxtKDVOran.Text);
            inter.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleme();
            temizleme();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagrid'den seçilen satırın texboxlara getirilmesi
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            CmbMusteri.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBirim.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtCins.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMensei.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtBirimFiyat.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtKDVOran.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme İşlemi
            baglanti.Open();
            SqlCommand update = new SqlCommand("Update TBLUrun set MusteriID=@P1, UrunAd=@P2,Birim=@P3,Cinsi=@P4,Mensei=@P5,BirimFiyat=@P6,KDV=@P7 Where ID=@P8", baglanti);
            update.Parameters.AddWithValue("@P1",CmbMusteri.Text);
            update.Parameters.AddWithValue("@P2", TxtUrunAd.Text);
            update.Parameters.AddWithValue("@P3", CmbBirim.Text);
            update.Parameters.AddWithValue("@P4", TxtCins.Text);
            update.Parameters.AddWithValue("@P5", TxtMensei.Text);
            update.Parameters.AddWithValue("@P6", TxtBirimFiyat.Text);
            update.Parameters.AddWithValue("@P7", TxtKDVOran.Text);
            update.Parameters.AddWithValue("@P8",TxtUrunid.Text);
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleme();
            temizleme();

        }

        private void BtnSilme_Click(object sender, EventArgs e)
        {
            // Silme İşlemi
            baglanti.Open();
            SqlCommand delete = new SqlCommand("Delete From TBLUrun Where ID =@P1", baglanti);
            delete.Parameters.AddWithValue("@P1", TxtUrunid.Text);
            delete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Gerçekleştirildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listeleme();
            temizleme();

        }
    }
}
