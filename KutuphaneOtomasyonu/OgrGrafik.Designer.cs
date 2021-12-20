
namespace KutuphaneOtomasyonu
{
    partial class OgrGrafik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrGrafik));
            this.grafikKitap = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // grafikKitap
            // 
            this.grafikKitap.BackColor = System.Drawing.Color.Transparent;
            this.grafikKitap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grafikKitap.Location = new System.Drawing.Point(52, 148);
            this.grafikKitap.Name = "grafikKitap";
            this.grafikKitap.ScrollGrace = 0D;
            this.grafikKitap.ScrollMaxX = 0D;
            this.grafikKitap.ScrollMaxY = 0D;
            this.grafikKitap.ScrollMaxY2 = 0D;
            this.grafikKitap.ScrollMinX = 0D;
            this.grafikKitap.ScrollMinY = 0D;
            this.grafikKitap.ScrollMinY2 = 0D;
            this.grafikKitap.Size = new System.Drawing.Size(760, 358);
            this.grafikKitap.TabIndex = 49;
            this.grafikKitap.UseExtendedPrintDialog = true;
            // 
            // OgrGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.grafikKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgrGrafik";
            this.Text = "OgrGrafik";
            this.Load += new System.EventHandler(this.OgrGrafik_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl grafikKitap;
    }
}