﻿namespace Hal_Sistemi
{
    partial class FrmUrun
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
            this.TxtBirimAdet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtUrunid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbBirim = new System.Windows.Forms.ComboBox();
            this.TxtKDVOran = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtMensei = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSilme = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnListele = new System.Windows.Forms.Button();
            this.TxtAramaYap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAramaYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBirimAdet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtUrunid);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CmbBirim);
            this.groupBox1.Controls.Add(this.TxtKDVOran);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtBirimFiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtMensei);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtCins);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtUrunAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // TxtBirimAdet
            // 
            this.TxtBirimAdet.Location = new System.Drawing.Point(147, 270);
            this.TxtBirimAdet.Name = "TxtBirimAdet";
            this.TxtBirimAdet.Size = new System.Drawing.Size(290, 32);
            this.TxtBirimAdet.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Birim Adet:";
            // 
            // TxtUrunid
            // 
            this.TxtUrunid.Location = new System.Drawing.Point(147, 25);
            this.TxtUrunid.Name = "TxtUrunid";
            this.TxtUrunid.ReadOnly = true;
            this.TxtUrunid.Size = new System.Drawing.Size(98, 32);
            this.TxtUrunid.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ürün İD:";
            // 
            // CmbBirim
            // 
            this.CmbBirim.FormattingEnabled = true;
            this.CmbBirim.Items.AddRange(new object[] {
            "KG",
            "ADET",
            "ÇUVAL",
            "KASA"});
            this.CmbBirim.Location = new System.Drawing.Point(147, 120);
            this.CmbBirim.Name = "CmbBirim";
            this.CmbBirim.Size = new System.Drawing.Size(290, 32);
            this.CmbBirim.TabIndex = 2;
            this.CmbBirim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbBirim_KeyPress);
            // 
            // TxtKDVOran
            // 
            this.TxtKDVOran.Location = new System.Drawing.Point(147, 372);
            this.TxtKDVOran.Name = "TxtKDVOran";
            this.TxtKDVOran.Size = new System.Drawing.Size(290, 32);
            this.TxtKDVOran.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "KDV Oranı:";
            // 
            // TxtBirimFiyat
            // 
            this.TxtBirimFiyat.Location = new System.Drawing.Point(147, 315);
            this.TxtBirimFiyat.Name = "TxtBirimFiyat";
            this.TxtBirimFiyat.Size = new System.Drawing.Size(290, 32);
            this.TxtBirimFiyat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birim Fiyatı:";
            // 
            // TxtMensei
            // 
            this.TxtMensei.Location = new System.Drawing.Point(147, 222);
            this.TxtMensei.Name = "TxtMensei";
            this.TxtMensei.Size = new System.Drawing.Size(290, 32);
            this.TxtMensei.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Menşei:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cins:";
            // 
            // TxtCins
            // 
            this.TxtCins.Location = new System.Drawing.Point(147, 171);
            this.TxtCins.Name = "TxtCins";
            this.TxtCins.Size = new System.Drawing.Size(290, 32);
            this.TxtCins.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Birim:";
            // 
            // TxtUrunAd
            // 
            this.TxtUrunAd.Location = new System.Drawing.Point(147, 72);
            this.TxtUrunAd.Name = "TxtUrunAd";
            this.TxtUrunAd.Size = new System.Drawing.Size(290, 32);
            this.TxtUrunAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAramaYap);
            this.groupBox2.Controls.Add(this.TxtAramaYap);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BtnListele);
            this.groupBox2.Controls.Add(this.BtnSilme);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.BtnEkle);
            this.groupBox2.Location = new System.Drawing.Point(616, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 419);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // BtnSilme
            // 
            this.BtnSilme.Location = new System.Drawing.Point(93, 179);
            this.BtnSilme.Name = "BtnSilme";
            this.BtnSilme.Size = new System.Drawing.Size(255, 43);
            this.BtnSilme.TabIndex = 10;
            this.BtnSilme.Text = "Silme";
            this.BtnSilme.UseVisualStyleBackColor = true;
            this.BtnSilme.Click += new System.EventHandler(this.BtnSilme_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(93, 109);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(255, 43);
            this.BtnGuncelle.TabIndex = 9;
            this.BtnGuncelle.Text = "Güncelleme";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(93, 37);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(255, 43);
            this.BtnEkle.TabIndex = 8;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1039, 214);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Listesi";
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
            this.dataGridView1.Size = new System.Drawing.Size(1033, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(93, 259);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(255, 43);
            this.BtnListele.TabIndex = 11;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // TxtAramaYap
            // 
            this.TxtAramaYap.Location = new System.Drawing.Point(107, 364);
            this.TxtAramaYap.Name = "TxtAramaYap";
            this.TxtAramaYap.Size = new System.Drawing.Size(171, 32);
            this.TxtAramaYap.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Arama:";
            // 
            // BtnAramaYap
            // 
            this.BtnAramaYap.Location = new System.Drawing.Point(294, 362);
            this.BtnAramaYap.Name = "BtnAramaYap";
            this.BtnAramaYap.Size = new System.Drawing.Size(122, 34);
            this.BtnAramaYap.TabIndex = 19;
            this.BtnAramaYap.Text = "Ara";
            this.BtnAramaYap.UseVisualStyleBackColor = true;
            this.BtnAramaYap.Click += new System.EventHandler(this.BtnAramaYap_Click);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUrun";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urun_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtKDVOran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBirimFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtMensei;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbBirim;
        private System.Windows.Forms.Button BtnSilme;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtUrunid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBirimAdet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAramaYap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Button BtnAramaYap;
    }
}