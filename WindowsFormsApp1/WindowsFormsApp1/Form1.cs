using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alir göster = new Alir();
            göster.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Çalışanlar göster = new Çalışanlar();
            göster.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Danışman göster = new Danışman();
            göster.Show();
       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Egitim_Paketi göster = new Egitim_Paketi();
            göster.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Eğitmen göster = new Eğitmen();
            göster.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Müşteri göster = new Müşteri();
            göster.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Programs göster = new Programs();
            göster.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Diller göster = new Diller();
            göster.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Şirket göster = new Şirket();
            göster.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Üyeler göster = new Üyeler();
            göster.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Yönetici göster = new Yönetici();
            göster.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Takvim göster = new Takvim();
            göster.Show();

        }
    }
    
}
