using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kİtap iade işlemleri için verilerini diğer katmanlarda kullanabilmek amacı ile get set işlemi yapıldı
    public class KitapIadeVeri
    {
        public int KitapKayitId { get; set; }
        public int KitapId { get; set; }
        public int OgrenciId { get; set; }
        public DateTime KitapAlinma { get; set; }
        public DateTime KitapTeslim { get; set; }
        public bool KitapKontrol { get; set; }
        public float OgrenciCeza { get; set; }
    }
}
