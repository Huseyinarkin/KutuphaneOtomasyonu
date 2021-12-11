using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Kitap verilerini diğer katmanlarda kullanabilmek için get set işlemi yapıldı
    public class OgrenciVeri
    {
        public int OgrenciId { get; set; }
        public string OgrenciAd { get; set; }
        public string OgrenciSoyad { get; set; }
        public string OgrenciNo { get; set; }
        public string OgrenciSifre { get; set; }
        public string OgrenciCinsiyet { get; set; }
        public float OgrenciCeza { get; set; }
    }
}
