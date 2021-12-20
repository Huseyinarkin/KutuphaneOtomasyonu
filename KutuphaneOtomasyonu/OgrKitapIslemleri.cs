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
    public partial class OgrKitapIslemleri : Form
    {
        public OgrKitapIslemleri(int oid)
        {
            //Giris Yapan Ogrencinin id sini aliyoruz.
            InitializeComponent();
            OgrID = oid;
        }
        //Ogrenci ID yi kullanmak için global olarak tanımladım.
        int OgrID;
        public void listeRenklendirme() //Tabloda teslim sürelerinin gecikme veya teslim edilme durumlarına göre renklendirme yapıldı
        {
            for (int i = 0; i < kitapAlimTeslimListe.Rows.Count; i++) // Tablo satırı kadar döndürüldü
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle(); //Nesne oluşturuldu

                if (Convert.ToBoolean(kitapAlimTeslimListe.Rows[i].Cells[4].Value) == true) // testlim edilme durumu kontrol edildi
                {
                    //Satır renklendirildi
                    renk.BackColor = Color.Green;
                    renk.ForeColor = Color.White;
                }
                else
                {
                    //Teslim edilmeyen kitapların teslim tarihine ne kadar kaldığı öğrenildi
                    TimeSpan sonuc = DateTime.Now - Convert.ToDateTime(kitapAlimTeslimListe.Rows[i].Cells[2].Value);

                    // 15 gün ve üzeri ise satır kırmızı renk yapıldı
                    if (sonuc.TotalDays > 15)
                    {
                        renk.BackColor = Color.Red;
                    }

                    // teslim süresine 2 gün kalmış ise satır sarı yapıldı
                    if (sonuc.TotalDays >= 13 && sonuc.TotalDays <= 15)
                    {
                        renk.BackColor = Color.Yellow;
                    }
                }
                kitapAlimTeslimListe.Rows[i].DefaultCellStyle = renk; // Satırlara renklendirme işlemi gerçekleştirildi

            }
        }
        private void btnAl_Click(object sender, EventArgs e)
        {

            if (comboBoxAlinan.Text != "") //Text in doluluğu kontrol edildi
            {
                TimeSpan gecenSure = DateTime.Now - dateTimePickerAlim.Value.Date; //zaman farkı alındı
                if (gecenSure.TotalDays >= 0)  // Şuanki günden ileri olup olmadığı kontrol edildi
                {

                    KitapOgrenciVeri kitapId = new KitapOgrenciVeri() //nesne oluşturuldu
                    {
                        KitapAd = comboBoxAlinan.Text //Kitap adı aktarıldı
                    };


                    KitapIadeVeri kitap = new KitapIadeVeri() // nesne oluşturuldu
                    {
                        KitapId = KitapIadeBL.kitapId(kitapId), // kitap id aktarıldı
                        OgrenciId = OgrID,  // ogrenci id aktarıldı
                        KitapAlinma = dateTimePickerAlim.Value.Date  // alinma tarihi aktarıldı
                    };

                    KitapIadeBL.kitapAlimIslemi(kitap); // Veri tabanında alma işlemi gerçekleştirildi


                    //Güncel liste oluştruuldu
                    AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()
                    {
                        OgrenciId = OgrID
                    };
                    kitapAlimTeslimListe.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri);
                    listeRenklendirme();

                    //güncel kitaplar oluşturuldu
                    KitapIadeVeri iade = new KitapIadeVeri()
                    {
                        OgrenciId = OgrID
                    };
                    comboBoxAlinan.DataSource = KitapIadeBL.kitapAlinanLİste(iade);
                    comboBoxTeslim.DataSource = KitapIadeBL.kitapTeslimLİste(iade);

                    MessageBox.Show("Kitap alındı.");
                }
                else
                {
                    MessageBox.Show("Alım tarihi bugünden ileri bir tarih olamaz !");
                }
            }
            else
            {
                MessageBox.Show("Alınabilir kitap mevcut değil.");
            }
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (comboBoxTeslim.Text != "")  // text doluluğu kontrol edildi
            {

                KitapOgrenciVeri kitapId = new KitapOgrenciVeri() // nesne oluşturuldu
                {
                    KitapAd = comboBoxTeslim.Text //kitap adı aktarıldı
                };


                KitapIadeVeri kitap = new KitapIadeVeri() // nesne oluşturuldu ve bilgiler aktarıldı
                {
                    KitapId = KitapIadeBL.kitapId(kitapId),
                    OgrenciId = OgrID,
                    KitapTeslim = dateTimePickerTeslim.Value.Date,
                    KitapKontrol = true
                };
                KitapIadeBL.kitapTarih(kitap); //alinma tarihi çekildi
                TimeSpan sonuc = kitap.KitapTeslim - kitap.KitapAlinma; // zaman farkı alındı
                if (sonuc.TotalDays >= 0) //zaman farkını eksi olamaması kontrol edildi
                {
                    KitapIadeBL.kitapTeslimIslemi(kitap); //teslim işlemi gerçekleştirildi

                    //Güncel liste
                    AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()
                    {
                        OgrenciId = OgrID
                    };
                    kitapAlimTeslimListe.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri);
                    listeRenklendirme();  // tablo satırları renklendirildi

                    //Güncel  Kitap
                    KitapIadeVeri iade = new KitapIadeVeri()
                    {
                        OgrenciId = OgrID
                    };
                    comboBoxAlinan.DataSource = KitapIadeBL.kitapAlinanLİste(iade);
                    comboBoxTeslim.DataSource = KitapIadeBL.kitapTeslimLİste(iade);

                    if (sonuc.TotalDays > 15)  // teslim süresi 15 günü geçmiş ise ceza işlemi uygulandı
                    {
                        float ceza = float.Parse(sonuc.TotalDays.ToString()) - 15;  //15 gün teslim süresini aşanlara hergün için 1 tl kesildi
                        KitapIadeBL.ogrenciCeza(iade); //Ceza bilgisi çekildi
                        iade.OgrenciCeza += ceza; //üzerine ekleme yapıldı
                        KitapIadeBL.ogrenciCezaIslemi(iade); // Veri tabanında ceza işlemi gerçekleşti
                        //OgrBilgiListesi(); // Güncel liste 
                    }

                    MessageBox.Show("Teslim edildi");

                }

                else
                {
                    MessageBox.Show("Teslim tarihi alım tarihinden önce olamaz!");
                }

            }

            else
            {
                MessageBox.Show("Teslim edilecek kitabın yok !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlinanKitapVeri alinanKitapVeri = new AlinanKitapVeri()  // nesne oluşturuldu
            {
                OgrenciId = OgrID  //id ataması yapıldı
            };
            kitapAlimTeslimListe.DataSource = KitapIadeBL.ogrenciIdListe(alinanKitapVeri); // Form açıldığında datagrid üzerine veritabanındaki listeyi aktardık
            
            listeRenklendirme();  // Tablodaki satırları renklendirme fonksiyounu çağrıldı
        }

        private void OgrKitapIslemleri_Load(object sender, EventArgs e)
        {
            KitapIadeVeri iade = new KitapIadeVeri()  // nesne oluşturuldu
            {
                OgrenciId = OgrID  // id ataması yapıldı
            };
            comboBoxAlinan.DataSource = KitapIadeBL.kitapAlinanLİste(iade); //Combobox a alinabilicek kitaplar aktarıldı
            comboBoxTeslim.DataSource = KitapIadeBL.kitapTeslimLİste(iade); // Combobox ateslim edilecek kitaplar aktarıldı
        }
    }
}
