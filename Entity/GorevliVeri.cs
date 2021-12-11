using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    //Görevliye ait verilerin diğer katmanlarda kullanabilmek için get set işlemi yapıldı
    public class GorevliVeri
    {
        public int gorevId { get; set; }
        public string gorevAd { get; set; }
        public string gorevSoyad { get; set; }
        public string gorevTc { get; set; }
        public string gorevSifre { get; set; }
    }
}
