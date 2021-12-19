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
    public partial class KtpIslem : Form
    {
        public KtpIslem()
        {
            InitializeComponent();
        }

        int id;  //Global Id tanımlandı
        private void KtpIslem_Load(object sender, EventArgs e)
        {
            kitapListe.DataSource = KitapBL.kitapListe(); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık            
            // Form açıldığında guncelleme kısmındaki textboxların ve gunceleme için gerekli id nin boş kalmasını  sağladık.
            txt_gAd.Text = "";
            comboBox_gTur.Text = null;
            txt_gSayfa.Text = "";
            txt_gYazar.Text = "";
            id = 0;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            //Ekleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txtAd.Text != "" && comboBoxTur.Text != "" && txtSayfa.Text != "" && txtYazar.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                KitapVeri kitap = new KitapVeri()
                {
                    KitapAd = txtAd.Text,
                    KitapTuru = comboBoxTur.Text,
                    KitapSayfa = txtSayfa.Text,
                    KitapYazar = txtYazar.Text
                };

                KitapBL.kitapEkle(kitap);  //business katmanındaki kitapEkle fonksiyonuna verileri gönderdik
                MessageBox.Show("Eklendi");
                kitapListe.DataSource = KitapBL.kitapListe();// Ekleme işleminden sonra listenin güncel halini ekrana yansıttık


                //Ekleme işlemi bitince textboxları temizledik

                txtAd.Text = "";
                comboBoxTur.Text = null;
                txtSayfa.Text = "";
                txtYazar.Text = "";

            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {            
            //Güncelleme işlemi için textboxların dolu olup olmadığını kontrol ettik
            if (txt_gAd.Text != "" && comboBox_gTur.Text != "" && txt_gSayfa.Text != "" && txt_gYazar.Text != "")
            {
                //Entity katmanındaki değişkenlere textboxtaki verileri aktardık
                KitapVeri kitap = new KitapVeri()
                {
                    KitapAd = txt_gAd.Text,
                    KitapTuru = comboBox_gTur.Text,
                    KitapSayfa = txt_gSayfa.Text,
                    KitapYazar = txt_gYazar.Text,
                    KitapId = id
                };

                // Girilen id ye ait kitap kontrol edildi
                if (KitapBL.kitapSorgu_BL(kitap) == true)
                {
                    KitapBL.kitapGuncelle(kitap);// Business katmanındaki kitapGuncelle Fonksiyonuna guncelleme işlemi için verileri gönderdik
                    MessageBox.Show("Guncellendi");
                    kitapListe.DataSource = KitapBL.kitapListe();// Lİstenin güncel halini datagrid e yansıttık                   
                }
                else
                    MessageBox.Show("Lütfen listeden seçim yaptıktan sonra değerleri doldurunuz !");
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
            }
        }

        private void kitapListe_SelectionChanged(object sender, EventArgs e)
        {
            //Tablo üzerinde tıklanan satırın verilerini guncelleme alanındaki textboxlara yazdırdık
            id = int.Parse(kitapListe.CurrentRow.Cells[0].Value.ToString());
            txt_gAd.Text = kitapListe.CurrentRow.Cells[1].Value.ToString();
            comboBox_gTur.Text = kitapListe.CurrentRow.Cells[2].Value.ToString();
            txt_gSayfa.Text = kitapListe.CurrentRow.Cells[3].Value.ToString();
            txt_gYazar.Text = kitapListe.CurrentRow.Cells[4].Value.ToString();            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Id nin girilmesini kontrol ettik
            if (txt_IdSil.Text != "")
            {
                //Entity katmanındaki KitapId değişkenine textboxtaki veriyi aktardık
                KitapVeri kitap = new KitapVeri()
                {
                    KitapId = int.Parse(txt_IdSil.Text)
                };

                //Girilen id ye ait kitap kontrol edildi
                if (KitapBL.kitapSorgu_BL(kitap) == true)
                {
                    KitapBL.kitapSil(kitap); // Business katmanındaki kitapSİL Fonksiyonuna silme işlemi için verileri gönderdik
                    MessageBox.Show("Silindi");
                    kitapListe.DataSource = KitapBL.kitapListe(); // Lİstenin güncel halini datagrid e yansıttık
                    txt_IdSil.Text = ""; // Silme işleminden sonra textbox ı temizledik
                }

                else
                    MessageBox.Show("Geçersiz Id !");

            }
            else
                MessageBox.Show("Gerekli alanları doldurunuz!");
        }

        private void textInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox'a harf girisini engelliyorum
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
