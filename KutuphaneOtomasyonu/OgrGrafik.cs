using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;           //Referans aldığımız BL katmanını kullandık
using Entity;       // Referans aldığımız Entity katmanını kullandık
using ZedGraph;     //ZedGraph özelliklerini kullanabilmek için kütüphanesini ekledik

namespace KutuphaneOtomasyonu
{
    public partial class OgrGrafik : Form
    {
        public OgrGrafik(int oid)
        {
            InitializeComponent();
            OgrID = oid;
        }
        //Ogrenci ID yi kullanmak için global olarak tanımladım.
        int OgrID;
        private void OgrGrafik_Load(object sender, EventArgs e)
        {
            Grafik();                    //Grafik fonksiyonunu çağırdık
        }

        private void Grafik()  // Grafik fonksiyon oluşturuldu
        {
            KitapIadeVeri kitap = new KitapIadeVeri()  //  KitapIadeVeri Entity katmanındaki Ogrenci ıd ye değer ataması yapıldı
            {
                OgrenciId = OgrID
            };

            GraphPane myPane = grafikKitap.GraphPane;       // GraphPane nesne oluşturuldu
            myPane.Title.Text = "Öğrenci Kitap Grafiği";   // Grafik Başlığı yazıldı
            myPane.YAxis.Title.Text = "Kitap Sayısı";     // Y ekseninin ne olduğu yazıldı
            myPane.XAxis.Title.Text = "";
            double[] y1 = { KitapIadeBL.grafikAlinabilir(kitap) };  // y1 sütununa alınabilecek kitap sayısı aktarıldı
            double[] y2 = { KitapIadeBL.grafikVerilmis(kitap) };   // y2 sütununa alınabilecek kitap sayısı aktarıldı
            double[] y3 = { KitapIadeBL.grafikHepsi() };          // y3 sütununa alınabilecek kitap sayısı aktarıldı

            BarItem myBar = myPane.AddBar("Alınabilir Kitap Sayısı", null, y1, Color.Green); // y1 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Green, Color.White, Color.Green);

            myBar = myPane.AddBar("İade Edilmemiş Kitap Sayısı", null, y2, Color.Red);            // y2 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Red, Color.White, Color.Red);

            myBar = myPane.AddBar("Tüm Kitap Sayısı", null, y3, Color.Orange);              // y3 sütununun adı ve renk ataması yapıldı
            myBar.Bar.Fill = new Fill(Color.Orange, Color.White, Color.Orange);

            myPane.XAxis.MajorTic.IsBetweenLabels = true;
            myPane.XAxis.Type = AxisType.Text;
            myPane.Chart.Fill = new Fill(Color.White,
                  Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));
            grafikKitap.AxisChange();

        }
    }
}
