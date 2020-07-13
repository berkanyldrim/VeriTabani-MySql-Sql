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
    public partial class Çalışanlar : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Çalışanlar()
        {
            InitializeComponent();
        }

        private void Çalışanlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev3DataSet4.Çalışanlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.çalışanlarTableAdapter.Fill(this.odev3DataSet4.Çalışanlar);
            listeleme();
        }

        private void button1_Click(object sender, EventArgs e)//ekle butonu
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO Çalışanlar(id,Ad,Soyad,TelNO,EPosta,Maaş)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +textBox4.Text + "','" + textBox5.Text + "','" + int.Parse(textBox6.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("KAYIT İŞLEMİ TAMAMLANMIŞTIR.");


            }
        }
        void listeleme()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select *from Çalışanlar";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Çalışanlar");
                dataGridView2.DataSource = ds.Tables["Çalışanlar"];
                baglanti.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)//silme butonu
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNE EMİNMİSİNİZ ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from Çalışanlar where id=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ.");
                    listeleme();



                }
            }
        }

        private void button3_Click(object sender, EventArgs e)//güncelleme butonu
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update Çalışanlar set id='" + textBox1.Text + "', Ad='" + textBox2.Text + "', Soyad='" +textBox3.Text+ "',TelNO='" + textBox4.Text + "',EPosta='" + textBox5.Text + "', Maaş='" + int.Parse(textBox6.Text) + "'where id=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("GÜNCELLEME İŞLEMİ TAMAMLANMIŞTIR.");
                listeleme();



            }
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            string id = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            string Ad = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            string Soyad = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            string TelNO = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            string EPosta = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            string Maaş = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            textBox1.Text = id;
            textBox2.Text = Ad;
            textBox3.Text = Soyad;
            textBox4.Text = TelNO;
            textBox5.Text = EPosta;
            textBox6.Text = Maaş;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select *from Çalışanlar where id like '%" + textBox7.Text + "%'", baglanti);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("ARAMA  İŞLEMİ TAMAMLANMIŞTIR.");




            }
        }
    }
}
