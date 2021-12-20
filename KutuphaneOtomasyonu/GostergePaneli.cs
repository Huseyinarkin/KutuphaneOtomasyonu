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

namespace KutuphaneOtomasyonu
{
    public partial class GostergePaneli : Form
    {
        public GostergePaneli()
        {
            InitializeComponent();
        }

        private void GostergePaneli_Load(object sender, EventArgs e)
        {
            int totalKitap =  KitapIadeBL.grafikHepsi();
            int totalOgr = OgrenciBL.totalOgr();
            lblTKitap.Text = totalKitap.ToString();
            lblTOgr.Text = totalOgr.ToString();
        }      
    }
}
