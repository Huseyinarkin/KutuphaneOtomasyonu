using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;  // BL katmanını kullandık
using Entity; // Entity katmanını kullandık

namespace KutuphaneOtomasyonu
{
    public partial class OgrBilgileri : Form
    {
        public OgrBilgileri(int oid)
        {
            InitializeComponent();
            OgrID = oid;
        }
        //Ogrenci ID yi kullanmak için global olarak tanımladım.
        int OgrID;
        public void OgrBilgiListesi()  //Ogrencinin bilgilerinin tutulduğu fonksiyon
        {
            OgrenciVeri ogrenci = new OgrenciVeri()  // Ogrenci veriden nesne oluşturuldu
            {
                OgrenciId = OgrID //Id ogrenci ıd ' ye aktarıldı
            };

            //Ogrenci bilgileri labellara aktarıldı
            ogrenci = OgrenciBL.ogrenciIdBilgi(ogrenci);
            //lblOgrenci.Text = "Hoşgeldin  " + ogrenci.OgrenciAd;
            lblAd.Text = ogrenci.OgrenciAd;
            lblSoyad.Text = ogrenci.OgrenciSoyad;
            lblNo.Text = ogrenci.OgrenciNo;
            lblSifre.Text = ogrenci.OgrenciSifre;
            lblCinsiyet.Text = ogrenci.OgrenciCinsiyet;
            lblCeza.Text = ogrenci.OgrenciCeza.ToString();
        }

        private void OgrBilgileri_Load(object sender, EventArgs e)
        {
            OgrBilgiListesi();
        }
    }
}
