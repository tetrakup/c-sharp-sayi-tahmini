using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminiOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] kullaniciSayi = new int[6]; //kullanicinin girdiği  sayilar dizisi
            kullaniciSayi[0] = Convert.ToInt32(textBox1.Text);
            kullaniciSayi[1] = Convert.ToInt32(textBox2.Text);
            kullaniciSayi[2] = Convert.ToInt32(textBox3.Text);
            kullaniciSayi[3] = Convert.ToInt32(textBox4.Text);
            kullaniciSayi[4] = Convert.ToInt32(textBox5.Text);
            kullaniciSayi[5] = Convert.ToInt32(textBox6.Text);

            Random rnd = new Random();
            int[] rastgeleSayi = new int[6]; //rastegle üretilen sayiler dizisi
            for (int i = 0; i < 6; i++)
            {
            dongu:
                int rastSayi = rnd.Next(1, 50);
                if (rastgeleSayi.Contains(rastSayi) == false) //çakışmayı kontrol edip rastgeleSayi dizisinde rastSayi yoksa diziye ekler
                    rastgeleSayi[i] = rastSayi; // 1-50 arasında,50 dahil değil
                else
                    goto dongu;
            }

            /*
            int[] rastgeleSayi = new int[6];//Bu satır, 6 elemanlı bir tam sayı dizisi oluşturur. Bu dizi, rastgele sayılar için kullanılacak.
            Random rnd = new Random();//Bu satır, rastgele sayılar üretmek için Random sınıfından bir nesne oluşturur.

             for(int i = 0; i <6;)
             {
                 int rastSayi = rnd.Next(1,50);// Bu satır, 1 ile 50 arasında rastgele bir sayı üretir ve bu sayıyı rastSayi değişkenine atar.

                 if(!rastgeleSayi.Contains(rastSayi))//eğer rastSayi, rastgeleSayi dizisinde yoksa içeriye girer.
                 {
                     rastgeleSayi[i] = rastSayi; //eğer çatışma yoksa rastSayi değerini rstgeleSayi dizisinin i indisine ekler.
                     i++;
                 }
             }*/

            //rastgele sayilari labell'lara yazdirir.
            label1.Text = rastgeleSayi[0].ToString();
            label2.Text = rastgeleSayi[1].ToString();
            label3.Text = rastgeleSayi[2].ToString();
            label4.Text = rastgeleSayi[3].ToString();
            label5.Text = rastgeleSayi[4].ToString();
            label6.Text = rastgeleSayi[5].ToString();

            int toplam = 0;
            for(int i=0 ; i<6 ; i++)
            {
                if (rastgeleSayi.Contains(kullaniciSayi[i]) == true)
                    toplam++;
            }
            label7.Text = toplam.ToString();
        }
    }
}
