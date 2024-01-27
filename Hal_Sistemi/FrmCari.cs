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
        bool CariTip = false;
        int deger = 0;

        void listeleme()
        {
            // Listeleme Metodu
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID,Tckn as 'TCKN',EFatura AS 'E-Fatura',Unvan as 'Ünvan',VergiDairesi,Adres,Telefon,EPosta as 'E-Posta', Vkn as 'VKN' FROM TBLMusteri Where SilindiMi=0", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizleme()
        {
            //TextBox Temizleme
            MskTCKNVKN.Text = " ";
            RBEvet.Checked = false;
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
            
            string query = "";
            if (CariTip)
            {
                // query = vkn li insert sorgusu
                query = "INSERT INTO TBLMusteri (Vkn,EFatura,Unvan,VergiDairesi,Adres,Telefon,EPosta) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)";
            }
            else
            {
                // query = tckn li sorgu
                query = "INSERT INTO TBLMusteri (Tckn,EFatura,Unvan,VergiDairesi,Adres,Telefon,EPosta) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7)";
            }
            SqlCommand insert = new SqlCommand(query, baglanti);
            insert.Parameters.AddWithValue("@P1", MskTCKNVKN.Text);
            if (RBEvet.Checked == true)
            {
                deger = 1;
                insert.Parameters.AddWithValue("@P2", deger);
            }
            else
            {
                deger = 0;
                insert.Parameters.AddWithValue("@P2",deger);
            }

            insert.Parameters.AddWithValue("@P3", TxtUnvanAd.Text);
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
            MskTCKNVKN.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[2].Value.ToString() =="True")
            {
                deger = 1;
                RBEvet.Checked = true;

            }
            else
            {
                deger = 0;
                RBHayir.Checked = true;
            }
            TxtUnvanAd.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtVergiDairesi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskTelefon.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtEposta.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[8].Value.ToString() == "")
            {
                MskTCKNVKN.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            }
            else
            {
                MskTCKNVKN.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            }

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            // Güncelleme İşlemi
            baglanti.Open();
            string updatequary = "";
            if (CariTip)
            {
                updatequary = "Update TBLMusteri set Vkn =@P1,EFatura =@P2,Unvan =@P3,VergiDairesi=@P4,Adres=@P5,Telefon=@P6,EPosta=@P7 Where ID=@P8 ";
            }
            else
            {
                updatequary = "Update TBLMusteri set Tckn =@P1,EFatura =@P2,Unvan =@P3,VergiDairesi=@P4,Adres=@P5,Telefon=@P6,EPosta=@P7 Where ID=@P8 ";
            }
            SqlCommand update = new SqlCommand(updatequary, baglanti);
            update.Parameters.AddWithValue("@P1", MskTCKNVKN.Text);
            if (RBEvet.Checked == true)
            {
                deger = 1;
                update.Parameters.AddWithValue("@P2", deger);
            }
            else
            {
                deger = 0;
                update.Parameters.AddWithValue("@P2",deger);
            }

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
            SqlCommand delete = new SqlCommand("Update TBLMusteri set SilindiMi=@P2 Where ID =@P1", baglanti);
            delete.Parameters.AddWithValue("@P1", Txtid.Text);
            delete.Parameters.AddWithValue("@P2",1);
            delete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Cari(Müşteri) Sistemden Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listeleme();
            temizleme();

        }

        private void MskTCKNVKN_TextChanged(object sender, EventArgs e)
        {
            if (MskTCKNVKN.Text.Length <= 10)
            {

                CariTip = true;
                TxtVergiDairesi.Visible = true;
                RBEvet.Visible = true;
                RBHayir.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
            }
            else
            {
                label2.Visible = false;
                label4.Visible = false;
                CariTip = false;
                TxtVergiDairesi.Visible = false;
                RBEvet.Visible = false;
                RBHayir.Visible = false;
            }
        }
    }
}
