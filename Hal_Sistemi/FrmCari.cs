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
    public partial class FrmCari : Form
    {
        public FrmCari()
        {
            InitializeComponent();
        }
        // SQL BAĞLANTISI
        SqlConnection baglanti = new SqlConnection(@"Data Source=Mert;Initial Catalog=DbHalSistem;Integrated Security=True");

        void listeleme()
        {
            // Listeleme Metodu
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,tcknvkn as 'TCKN/VKN',efatura AS 'E-Fatura',unvanad as 'Ünvan/Ad',VergiDairesi,Adres,Telefon,eposta as 'E-Posta' FROM TBLMusteri", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizleme()
        {
            //TextBox Temizleme
            TxtTCKNVKN.Text = " ";
            TxtEFatura.Text = " ";
            TxtUnvanAd.Text = " ";
            TxtVergiDairesi.Text = " ";
            TxtAdres.Text = " ";
            MskTelefon.Text = " ";
            TxtEposta.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form açıldığında datagrid'e tabloları çekme kısmı
            listeleme();

           
        }

        private void BtnSistemKaydet_Click(object sender, EventArgs e)
        {
            // Cari(Müşteri) Sisteme Ekleme Kısmı
            baglanti.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO TBLMusteri (tcknvkn,efatura,unvanad,VergiDairesi,Adres,Telefon,eposta) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)", baglanti);
            if ("@P1".Length == 10)
            {
                TxtUnvanAd.Text = "Tüzel";
                insert.Parameters.AddWithValue("@P3", TxtUnvanAd.Text);
            }
            else
            {
                TxtUnvanAd.Text = "Şahıs";
                insert.Parameters.AddWithValue("@P3",TxtUnvanAd.Text);
            }
            insert.Parameters.AddWithValue("@P1", TxtTCKNVKN.Text);
            insert.Parameters.AddWithValue("@P2", TxtEFatura.Text);
            insert.Parameters.AddWithValue("@P4", TxtVergiDairesi.Text);
            insert.Parameters.AddWithValue("@P5", TxtAdres.Text);
            insert.Parameters.AddWithValue("@P6", MskTelefon.Text);
            insert.Parameters.AddWithValue("@P7", TxtEposta.Text);
            insert.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Cari(Müşteri) Sisteme Kaydedildi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleme();
            temizleme();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Datagrid'de secilen satırları texboxlara çekme
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtTCKNVKN.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtEFatura.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtUnvanAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtVergiDairesi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtEposta.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme İşlemi
            baglanti.Open();
            SqlCommand update = new SqlCommand("Update TBLMusteri set tcknvkn =@P1,efatura =@P2,unvanad =@P3,VergiDairesi=@P4,Adres=@P5,Telefon=@P6,eposta=@P7 Where ID=@P8 ", baglanti);
            update.Parameters.AddWithValue("@P1", TxtTCKNVKN.Text);
            update.Parameters.AddWithValue("@P2", TxtEFatura.Text);
            update.Parameters.AddWithValue("@P3", TxtUnvanAd.Text);
            update.Parameters.AddWithValue("@P4", TxtVergiDairesi.Text);
            update.Parameters.AddWithValue("@P5", TxtAdres.Text);
            update.Parameters.AddWithValue("@P6", MskTelefon.Text);
            update.Parameters.AddWithValue("@P7", TxtEposta.Text);
            update.Parameters.AddWithValue("@P8", Txtid.Text);
            update.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Cari(Müşteri) Sistemde Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listeleme();
            temizleme();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            // Silme İşlemi
            baglanti.Open();
            SqlCommand delete = new SqlCommand("Delete from TBLMusteri Where ID =@P1", baglanti);
            delete.Parameters.AddWithValue("@P1", Txtid.Text);
            delete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Cari(Müşteri) Sistemden Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listeleme();
            temizleme();

        }
    }
}
