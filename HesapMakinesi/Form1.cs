using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap
{
    public partial class Form1 : Form
    {
        private bool islemDugmesineBasildiMi = false;
        private int oncekiSayi;
        private string islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            ekranLabel.Text = "0";
        }

        private void sayi2Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "2";
        }

        private void sayi3Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "3";
        }

        private void sayi4Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "4";
        }

        private void sayi5Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "5";
        }

        private void sayi6Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "6";
        }

        private void sayi7Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "7";
        }

        private void sayi8Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "8";
        }

        private void sayi9Button_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (islemDugmesineBasildiMi)
            {
                oncekiSayi = Convert.ToInt32(ekranLabel.Text);
                ekranLabel.Text = "";
                islemDugmesineBasildiMi = false;
            }

            if (ekranLabel.Text == "0") ekranLabel.Text = "";
            ekranLabel.Text += "0";
        }

        private void artiButton_Click(object sender, EventArgs e)
        {
            islemDugmesineBasildiMi = true;
            islem = "+";
        }

        private void eksiButton_Click(object sender, EventArgs e)
        {
            islemDugmesineBasildiMi = true;
            islem = "-";
        }

        private void carpiButton_Click(object sender, EventArgs e)
        {
            islemDugmesineBasildiMi = true;
            islem = "*";
        }

        private void boluButton_Click(object sender, EventArgs e)
        {
            islemDugmesineBasildiMi = true;
            islem = "/";
        }

        private void esittirButton_Click(object sender, EventArgs e)
        {
            var ikinciSayi = Convert.ToInt32(ekranLabel.Text);

            int sonuc;

            switch (islem)
            {
                case "+":
                    sonuc = oncekiSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = oncekiSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = oncekiSayi * ikinciSayi;
                    break;
                case "/":
                    sonuc = oncekiSayi / ikinciSayi;
                    break;
                default:
                    MessageBox.Show("Geçersiz işlem");
                    sonuc = 0;
                    break;
            }

            ekranLabel.Text = sonuc.ToString();
        }
    }
}
