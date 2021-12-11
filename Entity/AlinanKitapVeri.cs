using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Aldığımız kitapların verilerini diğer katmanlarda kullanabilmek için get set işlemi yapıldı
    public class AlinanKitapVeri
    {
        public int OgrenciId { get; set; }
        public string KitapAd { get; set; }
        public DateTime KitapAlinma { get; set; }
        public string KitapTeslim { get; set; }
        public bool KitapKontrol { get; set; }

    }
}
