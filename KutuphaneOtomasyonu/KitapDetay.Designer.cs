
namespace KutuphaneOtomasyonu
{
    partial class KitapDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDetay));
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.kitapId = new System.Windows.Forms.TextBox();
            this.idKitapListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.kitapYazar = new System.Windows.Forms.Label();
            this.kitapSayfa = new System.Windows.Forms.Label();
            this.kitapTuru = new System.Windows.Forms.Label();
            this.kitapAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kitapAlimTeslimListe = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idKitapListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 25);
            this.label16.TabIndex = 47;
            this.label16.Text = "ID Listesi";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnGetir);
            this.panel4.Controls.Add(this.kitapId);
            this.panel4.Controls.Add(this.idKitapListe);
            this.panel4.Location = new System.Drawing.Point(12, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 501);
            this.panel4.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Kitap ID:";
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.OldLace;
            this.btnGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGetir.Location = new System.Drawing.Point(177, 34);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(60, 30);
            this.btnGetir.TabIndex = 50;
            this.btnGetir.Text = "Göster";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // kitapId
            // 
            this.kitapId.Location = new System.Drawing.Point(97, 40);
            this.kitapId.Margin = new System.Windows.Forms.Padding(2);
            this.kitapId.Name = "kitapId";
            this.kitapId.Size = new System.Drawing.Size(76, 20);
            this.kitapId.TabIndex = 49;
            this.kitapId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kitapId_KeyPress);
            // 
            // idKitapListe
            // 
            this.idKitapListe.AllowUserToAddRows = false;
            this.idKitapListe.AllowUserToDeleteRows = false;
            this.idKitapListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.idKitapListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.idKitapListe.BackgroundColor = System.Drawing.Color.White;
            this.idKitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.idKitapListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idKitapListe.Location = new System.Drawing.Point(12, 100);
            this.idKitapListe.Margin = new System.Windows.Forms.Padding(2);
            this.idKitapListe.Name = "idKitapListe";
            this.idKitapListe.ReadOnly = true;
            this.idKitapListe.RowHeadersWidth = 51;
            this.idKitapListe.RowTemplate.Height = 24;
            this.idKitapListe.Size = new System.Drawing.Size(234, 380);
            this.idKitapListe.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Kitap Detay Bilgi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblSifre);
            this.panel1.Controls.Add(this.lblNo);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Controls.Add(this.kitapYazar);
            this.panel1.Controls.Add(this.kitapSayfa);
            this.panel1.Controls.Add(this.kitapTuru);
            this.panel1.Controls.Add(this.kitapAd);
            this.panel1.Location = new System.Drawing.Point(291, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 124);
            this.panel1.TabIndex = 48;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BackColor = System.Drawing.Color.Transparent;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.Yellow;
            this.lblSifre.Location = new System.Drawing.Point(301, 73);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(65, 17);
            this.lblSifre.TabIndex = 64;
            this.lblSifre.Text = "Yazar : ";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblNo.Location = new System.Drawing.Point(42, 73);
            this.lblNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(112, 17);
            this.lblNo.TabIndex = 63;
            this.lblNo.Text = "Sayfa Sayısı : ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.Yellow;
            this.lblSoyad.Location = new System.Drawing.Point(308, 27);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(57, 17);
            this.lblSoyad.TabIndex = 62;
            this.lblSoyad.Text = "Türü : ";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.BackColor = System.Drawing.Color.Transparent;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.Yellow;
            this.lblAd.Location = new System.Drawing.Point(62, 27);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(88, 17);
            this.lblAd.TabIndex = 61;
            this.lblAd.Text = "Kİtap Adı : ";
            // 
            // kitapYazar
            // 
            this.kitapYazar.AutoSize = true;
            this.kitapYazar.BackColor = System.Drawing.Color.Transparent;
            this.kitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapYazar.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapYazar.Location = new System.Drawing.Point(364, 73);
            this.kitapYazar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapYazar.Name = "kitapYazar";
            this.kitapYazar.Size = new System.Drawing.Size(44, 17);
            this.kitapYazar.TabIndex = 60;
            this.kitapYazar.Text = "------";
            // 
            // kitapSayfa
            // 
            this.kitapSayfa.AutoSize = true;
            this.kitapSayfa.BackColor = System.Drawing.Color.Transparent;
            this.kitapSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapSayfa.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapSayfa.Location = new System.Drawing.Point(151, 73);
            this.kitapSayfa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapSayfa.Name = "kitapSayfa";
            this.kitapSayfa.Size = new System.Drawing.Size(44, 17);
            this.kitapSayfa.TabIndex = 59;
            this.kitapSayfa.Text = "------";
            // 
            // kitapTuru
            // 
            this.kitapTuru.AutoSize = true;
            this.kitapTuru.BackColor = System.Drawing.Color.Transparent;
            this.kitapTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapTuru.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapTuru.Location = new System.Drawing.Point(364, 27);
            this.kitapTuru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapTuru.Name = "kitapTuru";
            this.kitapTuru.Size = new System.Drawing.Size(44, 17);
            this.kitapTuru.TabIndex = 58;
            this.kitapTuru.Text = "------";
            // 
            // kitapAd
            // 
            this.kitapAd.AutoSize = true;
            this.kitapAd.BackColor = System.Drawing.Color.Transparent;
            this.kitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapAd.ForeColor = System.Drawing.Color.FloralWhite;
            this.kitapAd.Location = new System.Drawing.Point(151, 27);
            this.kitapAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kitapAd.Name = "kitapAd";
            this.kitapAd.Size = new System.Drawing.Size(44, 17);
            this.kitapAd.TabIndex = 57;
            this.kitapAd.Text = "------";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Kitapları Alanların Listesi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.kitapAlimTeslimListe);
            this.panel2.Location = new System.Drawing.Point(294, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 329);
            this.panel2.TabIndex = 50;
            // 
            // kitapAlimTeslimListe
            // 
            this.kitapAlimTeslimListe.AllowUserToAddRows = false;
            this.kitapAlimTeslimListe.AllowUserToDeleteRows = false;
            this.kitapAlimTeslimListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapAlimTeslimListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kitapAlimTeslimListe.BackgroundColor = System.Drawing.Color.White;
            this.kitapAlimTeslimListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapAlimTeslimListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapAlimTeslimListe.Location = new System.Drawing.Point(12, 21);
            this.kitapAlimTeslimListe.Margin = new System.Windows.Forms.Padding(2);
            this.kitapAlimTeslimListe.Name = "kitapAlimTeslimListe";
            this.kitapAlimTeslimListe.ReadOnly = true;
            this.kitapAlimTeslimListe.RowHeadersWidth = 51;
            this.kitapAlimTeslimListe.RowTemplate.Height = 24;
            this.kitapAlimTeslimListe.Size = new System.Drawing.Size(544, 287);
            this.kitapAlimTeslimListe.TabIndex = 59;
            // 
            // KitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapDetay";
            this.Text = "KitapDetay";
            this.Load += new System.EventHandler(this.KitapDetay_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idKitapListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView idKitapListe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox kitapId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label kitapYazar;
        private System.Windows.Forms.Label kitapSayfa;
        private System.Windows.Forms.Label kitapTuru;
        private System.Windows.Forms.Label kitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView kitapAlimTeslimListe;
    }
}