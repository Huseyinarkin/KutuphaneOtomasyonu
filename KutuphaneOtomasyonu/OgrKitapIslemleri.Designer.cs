
namespace KutuphaneOtomasyonu
{
    partial class OgrKitapIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrKitapIslemleri));
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.kitapAlimTeslimListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerAlim = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAlinan = new System.Windows.Forms.ComboBox();
            this.btnAl = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerTeslim = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTeslim = new System.Windows.Forms.ComboBox();
            this.btnTeslim = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(147, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 25);
            this.label16.TabIndex = 45;
            this.label16.Text = "Aldığı Kitap Listesi";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.kitapAlimTeslimListe);
            this.panel4.Location = new System.Drawing.Point(147, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(627, 303);
            this.panel4.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(19, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.kitapAlimTeslimListe.Location = new System.Drawing.Point(19, 20);
            this.kitapAlimTeslimListe.Margin = new System.Windows.Forms.Padding(2);
            this.kitapAlimTeslimListe.Name = "kitapAlimTeslimListe";
            this.kitapAlimTeslimListe.ReadOnly = true;
            this.kitapAlimTeslimListe.RowHeadersWidth = 51;
            this.kitapAlimTeslimListe.RowTemplate.Height = 24;
            this.kitapAlimTeslimListe.Size = new System.Drawing.Size(588, 235);
            this.kitapAlimTeslimListe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Kitap Alma İşlemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerAlim);
            this.panel1.Controls.Add(this.comboBoxAlinan);
            this.panel1.Controls.Add(this.btnAl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(144, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 139);
            this.panel1.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alım Tarihi :";
            // 
            // dateTimePickerAlim
            // 
            this.dateTimePickerAlim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAlim.Location = new System.Drawing.Point(150, 60);
            this.dateTimePickerAlim.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAlim.Name = "dateTimePickerAlim";
            this.dateTimePickerAlim.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerAlim.TabIndex = 18;
            // 
            // comboBoxAlinan
            // 
            this.comboBoxAlinan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlinan.FormattingEnabled = true;
            this.comboBoxAlinan.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxAlinan.Location = new System.Drawing.Point(148, 23);
            this.comboBoxAlinan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxAlinan.Name = "comboBoxAlinan";
            this.comboBoxAlinan.Size = new System.Drawing.Size(99, 21);
            this.comboBoxAlinan.TabIndex = 17;
            // 
            // btnAl
            // 
            this.btnAl.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAl.Location = new System.Drawing.Point(171, 92);
            this.btnAl.Margin = new System.Windows.Forms.Padding(2);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(76, 28);
            this.btnAl.TabIndex = 16;
            this.btnAl.Text = "Al";
            this.btnAl.UseVisualStyleBackColor = false;
            this.btnAl.Click += new System.EventHandler(this.btnAl_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Alınabilir Kitap :";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(467, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kitap Teslim İşlemi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePickerTeslim);
            this.panel2.Controls.Add(this.comboBoxTeslim);
            this.panel2.Controls.Add(this.btnTeslim);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(467, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 139);
            this.panel2.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Teslim Tarihi :";
            // 
            // dateTimePickerTeslim
            // 
            this.dateTimePickerTeslim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTeslim.Location = new System.Drawing.Point(147, 60);
            this.dateTimePickerTeslim.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTeslim.Name = "dateTimePickerTeslim";
            this.dateTimePickerTeslim.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerTeslim.TabIndex = 18;
            // 
            // comboBoxTeslim
            // 
            this.comboBoxTeslim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeslim.FormattingEnabled = true;
            this.comboBoxTeslim.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBoxTeslim.Location = new System.Drawing.Point(147, 23);
            this.comboBoxTeslim.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTeslim.Name = "comboBoxTeslim";
            this.comboBoxTeslim.Size = new System.Drawing.Size(99, 21);
            this.comboBoxTeslim.TabIndex = 17;
            // 
            // btnTeslim
            // 
            this.btnTeslim.BackColor = System.Drawing.Color.FloralWhite;
            this.btnTeslim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeslim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeslim.Location = new System.Drawing.Point(159, 91);
            this.btnTeslim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTeslim.Name = "btnTeslim";
            this.btnTeslim.Size = new System.Drawing.Size(87, 29);
            this.btnTeslim.TabIndex = 16;
            this.btnTeslim.Text = "Teslim Et";
            this.btnTeslim.UseVisualStyleBackColor = false;
            this.btnTeslim.Click += new System.EventHandler(this.btnTeslim_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Teslim Edilecek :";
            // 
            // OgrKitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrKitapIslemleri";
            this.Text = "OgrKitapIslemleri";
            this.Load += new System.EventHandler(this.OgrKitapIslemleri_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitapAlimTeslimListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView kitapAlimTeslimListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlim;
        private System.Windows.Forms.ComboBox comboBoxAlinan;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerTeslim;
        private System.Windows.Forms.ComboBox comboBoxTeslim;
        private System.Windows.Forms.Button btnTeslim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}