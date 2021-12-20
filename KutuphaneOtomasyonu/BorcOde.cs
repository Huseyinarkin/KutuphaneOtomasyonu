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
    public partial class BorcOde : Form
    {
        public BorcOde(int oid)
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
            lblCeza.Text = ogrenci.OgrenciCeza.ToString();            
        }
        private void BorcOde_Load(object sender, EventArgs e)
        {
            OgrBilgiListesi();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (txtOdeme.Text != "")  // text doluluğu kontrol edildi
            {
                KitapIadeVeri ogrenciId = new KitapIadeVeri()  // nesne oluşturuldu
                {
                    OgrenciId = OgrID //id ataması yapıldı
                };
                KitapIadeBL.ogrenciCeza(ogrenciId); // Ceza bilgisi çekildi
                if (ogrenciId.OgrenciCeza != 0)  // ceza durumu 0 değil ise...
                {
                    float ceza = ogrenciId.OgrenciCeza - float.Parse(txtOdeme.Text); //ceza farkı atandı
                    if (ceza >= 0)  // cezanın eksi olmaması kontrol edildi
                    {
                        ogrenciId.OgrenciCeza = ceza; // Ogrenci cezasına aktarıldı
                        KitapIadeBL.ogrenciCezaIslemi(ogrenciId); //veri tabanı ile işlem gerçekleşti
                        OgrBilgiListesi(); //Güncel liste çağrıldı
                        MessageBox.Show(txtOdeme.Text + " Tl ödendi.");
                        txtOdeme.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Ödenecek tutar cezadan büyük olamaz!");
                    }
                }

                else
                {
                    MessageBox.Show("Borcunuz Bulunmamaktadır.");
                    txtOdeme.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödenecek tutarı giriniz!");
            }
        }
    }
}
