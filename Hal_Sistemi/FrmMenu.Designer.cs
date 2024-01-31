namespace Hal_Sistemi
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSat = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnUrunler = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnListele = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAramaYap = new System.Windows.Forms.TextBox();
            this.BtnAramaYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAramaYap);
            this.groupBox2.Controls.Add(this.TxtAramaYap);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Controls.Add(this.BtnSat);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnEkle);
            this.groupBox2.Location = new System.Drawing.Point(901, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnSat
            // 
            this.BtnSat.Location = new System.Drawing.Point(83, 162);
            this.BtnSat.Name = "BtnSat";
            this.BtnSat.Size = new System.Drawing.Size(176, 51);
            this.BtnSat.TabIndex = 4;
            this.BtnSat.Text = "Sat";
            this.BtnSat.UseVisualStyleBackColor = true;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(83, 90);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(176, 51);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(83, 18);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(176, 51);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnUrunler);
            this.groupBox3.Controls.Add(this.BtnCari);
            this.groupBox3.Location = new System.Drawing.Point(1260, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 384);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteriler ve Ürünler";
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Location = new System.Drawing.Point(14, 249);
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.Size = new System.Drawing.Size(214, 53);
            this.BtnUrunler.TabIndex = 1;
            this.BtnUrunler.Text = "Ürünler";
            this.BtnUrunler.UseVisualStyleBackColor = true;
            this.BtnUrunler.Click += new System.EventHandler(this.BtnUrunler_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(14, 79);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(214, 53);
            this.BtnCari.TabIndex = 0;
            this.BtnCari.Text = "Müşteri(Cari)";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1482, 290);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cari Hareket Tablosu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1476, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari ID :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(135, 32);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 32);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Numarası :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(181, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 32);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri Numarası:";
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(83, 239);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(176, 51);
            this.BtnListele.TabIndex = 5;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Arama:";
            // 
            // TxtAramaYap
            // 
            this.TxtAramaYap.Location = new System.Drawing.Point(89, 321);
            this.TxtAramaYap.Name = "TxtAramaYap";
            this.TxtAramaYap.Size = new System.Drawing.Size(157, 32);
            this.TxtAramaYap.TabIndex = 7;
            // 
            // BtnAramaYap
            // 
            this.BtnAramaYap.Location = new System.Drawing.Point(252, 318);
            this.BtnAramaYap.Name = "BtnAramaYap";
            this.BtnAramaYap.Size = new System.Drawing.Size(95, 36);
            this.BtnAramaYap.TabIndex = 8;
            this.BtnAramaYap.Text = "Ara";
            this.BtnAramaYap.UseVisualStyleBackColor = true;
            this.BtnAramaYap.Click += new System.EventHandler(this.BtnAramaYap_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1517, 718);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.Button BtnUrunler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnAramaYap;
        private System.Windows.Forms.TextBox TxtAramaYap;
        private System.Windows.Forms.Label label4;
    }
}