using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butonlar
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int sayi1, sayi2, sayi3, sonuc;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgeleSayi = new Random();
             sayi1 = rastgeleSayi.Next(0, 100);
             sayi2 = rastgeleSayi.Next(0, 100);
            sayi3= rastgeleSayi.Next(0, 100);
            button1.Text = sayi1.ToString();
            button2.Text = sayi2.ToString();
             button4.Text = sayi3.ToString();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text ="";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sonuc = sayi1 + sayi2 + sayi3;
            MessageBox.Show("Toplam:" + sonuc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "";
        }
    }
}
