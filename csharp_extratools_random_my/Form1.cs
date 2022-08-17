using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_extratools_random_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox'lara girdiğimiz değerlerle labellara kodlar aracılığı ile rastgele atadığımız değerlerin eşleşmesi durumunda textbox'ları yeşile,
            //eşleşmemeleri durumunda da kırmızıya boyayan uygulama yaptık
            Random rnd = new Random();

            int sayi1, sayi2, sayi3, sayi4;

            sayi1 = rnd.Next(1, 30);
            sayi2 = rnd.Next(1, 30);
            sayi3 = rnd.Next(1, 30);
            sayi4 = rnd.Next(1, 30);

            label1.Text=sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();

            //sayı1
            if(textBox1.Text==label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            //sayı2
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            //sayı3
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            //sayı4
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }



            //CAPTCHA Uygulaması

            //Uygulamayı yapmak için farklı değerler içeren diziler oluşturup,
            //rastgele belirlenen sayının ilgili dizideki index'e ait elemanı ekrana getireceğiz.

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h", "i" };
            string[] sembol2 = { "+", "-", "*", "/", "#", "@", "%", "&" };
            string[] sembol3 = { "TA", "VD", "FD", "D1", "C8", "4A", "O2", "KA", "5+", "Y7D", "6A+" };

            Random r1 = new Random();
            int s1, s2, s3,s4,s5,s6,s7;
            s1 = r1.Next(0, sembol1.Length);
            s2 = r1.Next(0, sembol2.Length);
            s3 = r1.Next(0, sembol3.Length);
            s4 = r1.Next(0, sembol1.Length);
            s5 = r1.Next(0, sembol2.Length);
            s6 = r1.Next(0, sembol3.Length);
            s7 = r1.Next(0, sembol1.Length);


            label5.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + sembol1[s4].ToString() + sembol2[s5].ToString() + sembol3[s6].ToString() + sembol1[s7].ToString();

        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == label5.Text)
            {
                textBox5.BackColor = Color.Green;
                MessageBox.Show("Doğrulama Başarılı!");
            }
            else
            {
                textBox5.BackColor = Color.Red;
                MessageBox.Show("Doğrulama Başarısız!");

            }
        }
    }
}
