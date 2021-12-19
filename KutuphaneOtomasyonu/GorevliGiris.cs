using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;   // Entity katmanını kullanacağımız için ekledik.
using BL;      // BL katmanını kullanacağımız için ekledik.

namespace KutuphaneOtomasyonu
{
    public partial class GorevliGiris : Form
    {
        public GorevliGiris(GirisMainForm a)
        {
            //GirisMainFormu bu form üzerinden kapatmak icin bir değişkene atıyoruz.
            InitializeComponent();
            formHid=a;
        }
        //GirisMainFormu na her yerden erisebilmek icin global tanımlıyoruz.
        GirisMainForm formHid;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) //CheckBox seçili ise parolayı goster text e gizle yaz
            {
                txtGorevliSifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked) //CheckBox seçili değil ise parolayı gizle ve text e göster yaz
            {
                txtGorevliSifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }

        private void btnGorevliGiris_Click(object sender, EventArgs e)
        {
            if (txtGorevliTc.Text != "" && txtGorevliSifre.Text != "") // Textler boş olup olmadığı kontrol edildi
            {
                GorevliVeri gorevli = new GorevliVeri()  // Girilen veriler entity katmanındaki değişkenlere atandı
                {
                    gorevTc = txtGorevliTc.Text,
                    gorevSifre = txtGorevliSifre.Text
                };

                if (GorevliBL.gorevliKontrol_BL(gorevli) == true) //Girilen değerler veri tabanındaki tabloda mevcut ise işlem gerçekleşti
                {
                    MessageBox.Show("Giriş başarılı");
                    AnaForm gorevliGecis = new AnaForm(); // Gorevli geçiş formundan nesne üretildi
                    formHid.Hide();                     // Bulunduğumuz fonksiyon kapatıldı
                    gorevliGecis.Show();               // Oluşturulan nesnenin formu açıldı
                }

                else
                {
                    MessageBox.Show("Hatalı giriş");
                }

            }
            else
            {
                MessageBox.Show("Gerekli alanları doldurunuz !");
            }
        }
    }
}
