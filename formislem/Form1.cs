using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void kodolustur()
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(100,1000);
            textBox5.Text = sayi.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kodolustur();
            timer1.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text == "admin" && textBox2.Text =="1234" && textBox3.Text == textBox5.Text ) 
            {
                Form2 frm = new Form2();
                frm.kullanici = textBox1.Text;
                frm.Show();
                this.Hide(); 
            }
            else 
            {
                MessageBox.Show("Hatalı bilgi girişi var,Lütfen kontrol ediniz","Hata",MessageBoxButtons.OK,MessageBoxIcon.Stop);

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            
        }

        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac %2 == 0) 
            {
                label3.BackColor = Color.YellowGreen;
            }
            else { label3.BackColor = Color.Gray;}
            if(sayac == 10)
            {
                sayac = 0;
            }
        }
    }
}
