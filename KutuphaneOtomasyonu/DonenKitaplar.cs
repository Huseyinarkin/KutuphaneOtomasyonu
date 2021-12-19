using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;       //   BL katmanına erişim sağlandı
using Entity;  //   Entity katmanına erişim sağlandı

namespace KutuphaneOtomasyonu
{
    public partial class DonenKitaplar : Form
    {
        public DonenKitaplar()
        {
            InitializeComponent();
        }

        private void DonenKitaplar_Load(object sender, EventArgs e)
        {
            KitapOgrenciVeri kitap = new KitapOgrenciVeri()
            {
                KitapKontrol = true
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
