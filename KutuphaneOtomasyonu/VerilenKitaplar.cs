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
    public partial class VerilenKitaplar : Form
    {
        public VerilenKitaplar()
        {
            InitializeComponent();
        }

        private void VerilenKitaplar_Load(object sender, EventArgs e)
        {           
            KitapOgrenciVeri kitap = new KitapOgrenciVeri()
            {
                KitapKontrol = false
            };            
            kitapListe.DataSource = KitapIadeBL.KayitKitapOgrenciListe(kitap);



            KitapIadeVeri iade = new KitapIadeVeri()  // nesne oluşturuldu
            {
                OgrenciId = 1  // id ataması yapıldı
            };
            comboBoxTeslim.DataSource = KitapIadeBL.kitapTeslimLİste(iade);
        }
    }
}
