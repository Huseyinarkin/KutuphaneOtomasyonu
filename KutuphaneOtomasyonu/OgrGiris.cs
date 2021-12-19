using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;  // Entity katmanını kullanacağımız için ekledik.
using BL;     // BL katmanını kullanacağımız için ekledik.

namespace KutuphaneOtomasyonu
{
    public partial class OgrGiris : Form
    {
        public OgrGiris(GirisMainForm a)
        {
            //GirisMainFormu bu form üzerinden kapatmak icin bir değişkene atıyoruz.
            InitializeComponent();
            formHid = a;
        }
        //GirisMainFormu na her yerden erisebilmek icin global tanımlıyoruz.
        GirisMainForm formHid;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) // CheckBox seçili ise parolayı goster text e gizle yaz
            {
                txtOgrSifre.UseSystemPasswordChar = false;  // Parolayı göster 
                checkBox1.Text = "Gizle";                 // CheckBox textini gizle olarak değiştir
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) // ChecBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                txtOgrSifre.UseSystemPasswordChar = true;  // Parolayı gizle
                checkBox1.Text = "Göster";                 // CheckBox textini goster olarak değiştir
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtOgrNo.Text != "" && txtOgrSifre.Text != "") //Textlerin boş bırakılmaması kontrol edildi
            {
                OgrenciVeri ogrenci = new OgrenciVeri()       //Entity katmanındaki verilere girilen değerler aktarıldı
                {
                    OgrenciNo = txtOgrNo.Text,
                    OgrenciSifre = txtOgrSifre.Text

                };

                if (OgrenciBL.ogrenciKontrol_BL(ogrenci) == true) // Veritabanındaki tabloda girilen değerlere ait öğrenci var mı kontrol edildi
                {
                    int ogrid = OgrenciBL.ogrenciIdSorgu(ogrenci); //id ataması yapıldı
                    MessageBox.Show("Giriş Başarlı");
                    OgrAnaForm ogr = new OgrAnaForm(ogrid);
                    formHid.Hide();              // Bulunduğumuz fonksiyon kapatıldı                      
                    ogr.Show();                 // Oluşturulan nesne ile geçiş yapılacak form ekranı açıldı


                }
                else
                    MessageBox.Show("Hatalı giriş !");

            }

            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz!");
            }



        }

    }
}
