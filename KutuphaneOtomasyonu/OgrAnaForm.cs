﻿using System;
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
    public partial class OgrAnaForm : Form
    {
        public OgrAnaForm(int oid)
        {
            //Giris Yapan Ogrencinin id sini aliyoruz.
            InitializeComponent();            
            OgrID = oid;
        }
        //Ogrenci ID yi kullanmak için global olarak tanımladım.
        int OgrID;
        //Form ekranını Tutup Sürkleyip Monitörün istediğimiz bir bölgesine koymamızı sağlayan kod blokları
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //panel1 yani form1 deki üst taraftaki paneli mouseDown eventi ile sürükleyip mönitörümüzün istediğimiz kısmına getire biliriz.
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();  // Buton' a tıklanınca uyguylamayı kapattık
        }

        private void OgrAnaForm_Load(object sender, EventArgs e)
        {
            //butona tikladığımızda panel2 ye göstermek istediğimiz form penceresini getiriyoruz.
            panel4.Controls.Clear();
            OgrBilgileri c1 = new OgrBilgileri(OgrID);
            c1.Dock = DockStyle.Fill;
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Add(c1);
            c1.Show();


            OgrenciVeri ogrenci = new OgrenciVeri()  // Ogrenci veriden nesne oluşturuldu
            {
                OgrenciId = OgrID //Id ogrenci ıd ' ye aktarıldı
            };

            //Ogrenci bilgileri labellara aktarıldı
            ogrenci = OgrenciBL.ogrenciIdBilgi(ogrenci);
            //Ogrencinin Adini ve Soy adinin lbl a yazdırdım.
            lblUserName.Text = ogrenci.OgrenciAd + " " + ogrenci.OgrenciSoyad;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GirisMainForm gorevliGiris = new GirisMainForm(); //Nesne oluşturuldu
            this.Hide();                                     //aktif form kapatıldı
            gorevliGiris.Show();                            // oluşturulan nesneden yeni form açıldı
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ekranGetir fonksiyonu ile panel4 un icerisine istediğim formu getiriyorum.
            ekranGetir(new OgrKitapIslemleri(OgrID), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ekranGetir fonksiyonu ile panel4 un icerisine istediğim formu getiriyorum.
            ekranGetir(new OgrBilgileri(OgrID), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ekranGetir fonksiyonu ile panel4 un icerisine istediğim formu getiriyorum.
            ekranGetir(new BorcOde(OgrID), sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //ekranGetir fonksiyonu ile panel4 un icerisine istediğim formu getiriyorum.
            ekranGetir(new OgrGrafik(OgrID), sender);
        }
        private void ekranGetir(Form c1,object sender)
        {
            //butona tikladığımızda panel2 ye göstermek istediğimiz form penceresini getiriyoruz.
            panel4.Controls.Clear();            
            c1.Dock = DockStyle.Fill;
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None;
            panel4.Controls.Add(c1);
            c1.Show();

            //Hangi butona basılı olduğunu belirlemek için panel5 in Lokasyonunu butonun sağ kenarına ayarlıyorum.
            panel5.Location = new Point((sender as Button).Location.X + 180, (sender as Button).Location.Y);
        }


    }
}
