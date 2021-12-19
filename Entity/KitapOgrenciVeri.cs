using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kitap ve ogrenci için kullanılan ortak verilerini diğer katmanlarda kullanabilmek için get set işlemi yapıldı
    public class KitapOgrenciVeri
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }        
        public DateTime KitapAlinma { get; set; }
        public string KitapTeslim { get; set; }
        public bool KitapKontrol { get; set; }

    }
}
