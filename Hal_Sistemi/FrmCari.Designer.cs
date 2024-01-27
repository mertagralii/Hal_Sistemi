namespace Hal_Sistemi
{
    partial class FrmCari
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
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtEposta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtUnvanAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSistemKaydet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGüncelle = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MskTCKNVKN = new System.Windows.Forms.MaskedTextBox();
            this.RBEvet = new System.Windows.Forms.RadioButton();
            this.RBHayir = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBHayir);
            this.groupBox1.Controls.Add(this.RBEvet);
            this.groupBox1.Controls.Add(this.MskTCKNVKN);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MskTelefon);
            this.groupBox1.Controls.Add(this.TxtEposta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtAdres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtVergiDairesi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtUnvanAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(531, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari(Müşteri) Kısmı";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(172, 33);
            this.Txtid.Margin = new System.Windows.Forms.Padding(4);
            this.Txtid.Name = "Txtid";
            this.Txtid.ReadOnly = true;
            this.Txtid.Size = new System.Drawing.Size(221, 32);
            this.Txtid.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "İD:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(172, 247);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(221, 32);
            this.MskTelefon.TabIndex = 6;
            // 
            // TxtEposta
            // 
            this.TxtEposta.Location = new System.Drawing.Point(172, 113);
            this.TxtEposta.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEposta.Name = "TxtEposta";
            this.TxtEposta.Size = new System.Drawing.Size(221, 32);
            this.TxtEposta.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-Posta :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon:";
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(172, 193);
            this.TxtAdres.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(221, 32);
            this.TxtAdres.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres:";
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(172, 351);
            this.TxtVergiDairesi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(221, 32);
            this.TxtVergiDairesi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vergi Dairesi :";
            // 
            // TxtUnvanAd
            // 
            this.TxtUnvanAd.Location = new System.Drawing.Point(172, 153);
            this.TxtUnvanAd.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUnvanAd.Name = "TxtUnvanAd";
            this.TxtUnvanAd.Size = new System.Drawing.Size(221, 32);
            this.TxtUnvanAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ünvan/Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Fatura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = " TCKN/VKN :";
            // 
            // BtnSistemKaydet
            // 
            this.BtnSistemKaydet.Location = new System.Drawing.Point(105, 41);
            this.BtnSistemKaydet.Name = "BtnSistemKaydet";
            this.BtnSistemKaydet.Size = new System.Drawing.Size(221, 46);
            this.BtnSistemKaydet.TabIndex = 8;
            this.BtnSistemKaydet.Text = "Kaydet";
            this.BtnSistemKaydet.UseVisualStyleBackColor = true;
            this.BtnSistemKaydet.Click += new System.EventHandler(this.BtnSistemKaydet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSil);
            this.groupBox2.Controls.Add(this.BtnSistemKaydet);
            this.groupBox2.Controls.Add(this.BtnGüncelle);
            this.groupBox2.Location = new System.Drawing.Point(612, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(436, 410);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(105, 284);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(221, 46);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGüncelle
            // 
            this.BtnGüncelle.Location = new System.Drawing.Point(105, 161);
            this.BtnGüncelle.Name = "BtnGüncelle";
            this.BtnGüncelle.Size = new System.Drawing.Size(221, 46);
            this.BtnGüncelle.TabIndex = 9;
            this.BtnGüncelle.Text = "Güncelle";
            this.BtnGüncelle.UseVisualStyleBackColor = true;
            this.BtnGüncelle.Click += new System.EventHandler(this.BtnGüncelle_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(13, 448);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1039, 214);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cari Tablosu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MskTCKNVKN
            // 
            this.MskTCKNVKN.Location = new System.Drawing.Point(172, 78);
            this.MskTCKNVKN.Mask = "00000000000";
            this.MskTCKNVKN.Name = "MskTCKNVKN";
            this.MskTCKNVKN.Size = new System.Drawing.Size(221, 32);
            this.MskTCKNVKN.TabIndex = 17;
            this.MskTCKNVKN.TextChanged += new System.EventHandler(this.MskTCKNVKN_TextChanged);
            // 
            // RBEvet
            // 
            this.RBEvet.AutoSize = true;
            this.RBEvet.Location = new System.Drawing.Point(172, 309);
            this.RBEvet.Name = "RBEvet";
            this.RBEvet.Size = new System.Drawing.Size(70, 28);
            this.RBEvet.TabIndex = 18;
            this.RBEvet.TabStop = true;
            this.RBEvet.Text = "Evet";
            this.RBEvet.UseVisualStyleBackColor = true;
            // 
            // RBHayir
            // 
            this.RBHayir.AutoSize = true;
            this.RBHayir.Location = new System.Drawing.Point(266, 309);
            this.RBHayir.Name = "RBHayir";
            this.RBHayir.Size = new System.Drawing.Size(77, 28);
            this.RBHayir.TabIndex = 19;
            this.RBHayir.TabStop = true;
            this.RBHayir.Text = "Hayır";
            this.RBHayir.UseVisualStyleBackColor = true;
            // 
            // FrmCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCari";
            this.Text = "Cari (Müşteri) Modülü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtVergiDairesi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtUnvanAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSistemKaydet;
        private System.Windows.Forms.TextBox TxtEposta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGüncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MskTCKNVKN;
        private System.Windows.Forms.RadioButton RBEvet;
        private System.Windows.Forms.RadioButton RBHayir;
    }
}

