using System;
using System.Windows.Forms;

namespace Gazi.KazanMyoWinformApp
{
    public partial class Form1 : Form
    {
        static int toplam = 0;        
        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            btnSayi1.Text = rnd.Next(100).ToString();
            btnSayi2.Text = rnd.Next(100).ToString();
            btnSayi3.Text = rnd.Next(100).ToString();
            btnSayi2.Click += NumberClick;
            btnSayi3.Click += NumberClick;
            //Construcktorlar değer atama işlemleri için daha uygundur.
        }

        void NumberClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visible = false;
            toplam += int.Parse(btn.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sayıların Toplamı: {toplam}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load eventinde iş mantığınızı kurgulayabilirsiniz. Form açıldığında yapılacak olan işler.
            tmrButton.Start();

        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
