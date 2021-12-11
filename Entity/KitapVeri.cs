using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kitap verilerini diğer katmanlarda kullanabilmek için get set işlemi yapıldı
    public class KitapVeri
    {
        public int KitapId { get; set; }
        public string KitapAd { get; set; }
        public string KitapTuru { get; set; }
        public string KitapSayfa { get; set; }
        public string KitapYazar { get; set; }
    }
}
