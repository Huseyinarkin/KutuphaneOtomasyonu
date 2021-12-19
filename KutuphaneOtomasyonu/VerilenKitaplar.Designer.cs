
namespace KutuphaneOtomasyonu
{
    partial class VerilenKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerilenKitaplar));
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kitapListe = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitapListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(175, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 25);
            this.label16.TabIndex = 39;
            this.label16.Text = "Verilen Kitap Liste";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.kitapListe);
            this.panel4.Location = new System.Drawing.Point(175, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(585, 390);
            this.panel4.TabIndex = 38;
            // 
            // kitapListe
            // 
            this.kitapListe.AllowUserToAddRows = false;
            this.kitapListe.AllowUserToDeleteRows = false;
            this.kitapListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitapListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kitapListe.BackgroundColor = System.Drawing.Color.White;
            this.kitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapListe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kitapListe.Location = new System.Drawing.Point(8, 11);
            this.kitapListe.Margin = new System.Windows.Forms.Padding(2);
            this.kitapListe.Name = "kitapListe";
            this.kitapListe.ReadOnly = true;
            this.kitapListe.RowHeadersWidth = 51;
            this.kitapListe.RowTemplate.Height = 24;
            this.kitapListe.Size = new System.Drawing.Size(568, 372);
            this.kitapListe.TabIndex = 3;
            // 
            // VerilenKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerilenKitaplar";
            this.Text = "VerilenKitaplar";
            this.Load += new System.EventHandler(this.VerilenKitaplar_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitapListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView kitapListe;
    }
}