using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;        // BL katmanını kullanacağımız için ekledik.
using Entity;   // Entity katmanını kullanacağımız için ekledik.

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapVeri kitap = new KitapVeri()  //Kitap veriden nesne oluşturuldu
            {
                KitapId = int.Parse(textBox1.Text)  // Id aktarıldı
            };
            kitap = KitapBL.kitapIdBilgi(kitap);
            label1.Text = kitap.KitapAd;

        }
    }
}
