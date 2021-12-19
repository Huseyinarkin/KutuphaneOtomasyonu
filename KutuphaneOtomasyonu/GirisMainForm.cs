using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class GirisMainForm : Form
    {
        public GirisMainForm()
        {
            InitializeComponent();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Gorevli girisi ve Öğrenci girişi butonlarına basıldığında renklerini değiştirerek hangi butonun basılı olduğunu gösteriyoruz.
            (sender as Button).BackColor = Color.White;
            (sender as Button).ForeColor = Color.Black;
            button1.BackColor= Color.Black;
            button1.ForeColor = Color.White;

            //butona tikladığımızda panel2 ye göstermek istediğimiz form penceresini getiriyoruz.
            panel2.Controls.Clear();
            GorevliGiris c1 = new GorevliGiris(this);
            c1.Dock = DockStyle.Fill;
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(c1);
            c1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gorevli girisi ve Öğrenci girişi butonlarına basıldığında renklerini değiştirerek hangi butonun basılı olduğunu gösteriyoruz.
            (sender as Button).BackColor = Color.White;
            (sender as Button).ForeColor = Color.Black;
            button2.BackColor = Color.Black;
            button2.ForeColor = Color.White;

            //butona tikladığımızda panel2 ye göstermek istediğimiz form penceresini getiriyoruz.
            panel2.Controls.Clear();
            OgrGiris c1 = new OgrGiris(this);
            c1.Dock = DockStyle.Fill;
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(c1);
            c1.Show();
        }

        private void GirisMainForm_Load(object sender, EventArgs e)
        {
            //Form yuklendiginde panel2 Gorevli giris ekranını getiriyorum
            panel2.Controls.Clear();
            GorevliGiris c1 = new GorevliGiris(this);
            c1.Dock = DockStyle.Fill;
            c1.TopLevel = false;
            c1.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(c1);
            c1.Show();
        }
    }
}
