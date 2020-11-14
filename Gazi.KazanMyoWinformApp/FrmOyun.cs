using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gazi.KazanMyoWinformApp
{    
    public partial class FrmOyun : Form
    {
        static int toplam = 0;
        static int sure = 3;
        Random rnd = new Random();
        public FrmOyun()
        {
            InitializeComponent();
            
            
        }

        private void tmrButton_Tick(object sender, EventArgs e)
        {
            
            Button btn = new Button();
            btn.Size = new Size(50, 50);
            btn.Location = new Point(rnd.Next(this.ClientSize.Width-pnlGosterge.Width-btn.Width), rnd.Next(this.ClientSize.Height-btn.Height));
            btn.Text = rnd.Next(100).ToString();
            btn.Click += Btn_Click;
            this.Controls.Add(btn);            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            toplam += int.Parse(btn.Text);            
            lblSkor.Text = $"Skor:{toplam}";
            btn.Dispose();
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            tmrButton.Start();
            tmrSure.Start();
            
        }

        

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                tmrButton.Stop();
                tmrSure.Stop();
                MessageBox.Show("Oyun Bitti");
                DialogResult dResault = MessageBox.Show("Tekrar Oynamak İster Misiniz ?", $"Skor: {toplam}", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dResault == DialogResult.No)
                {

                    FileStream fStream = new FileStream("D:\\Oyun.txt", FileMode.Append, FileAccess.Write, FileShare.None);
                    //Append=Dosya açılır yazma işlemi yapılır yoksa oluşturulur //Write= Dosyaya sadece yazma erişim yetkisi verilir //None= Başka streamlerin erişimini kapatır
                    using (StreamWriter sWriter = new StreamWriter(fStream))
                    {
                        sWriter.WriteLine($"{DateTime.Now} Tarihli Skorunuz: {toplam}");
                        sWriter.Close();
                    }
                    this.Close();
                }

                else
                {                    
                    tmrButton.Start();                    
                    tmrSure.Start();
                    toplam = 0;
                    sure = 3;                    
                    lblSkor.Text = "Skor";
                    lblSure.Text = "Süre";
                }
            }

        }

        
    }
}
