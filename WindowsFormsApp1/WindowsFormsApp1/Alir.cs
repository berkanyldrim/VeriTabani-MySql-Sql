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
    public partial class Alir : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Alir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//EKLEME BUTONU
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO Alir(m_id,p_id,alinan_Program,indirim)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + int.Parse(textBox3.Text) + "','" + float.Parse(textBox4.Text) + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                listeleme();
                MessageBox.Show("KAYIT İŞLEMİ TAMAMLANMIŞTIR.");


            }
        }
        void listeleme() //GrandView de Tabloları göstermek için fonksiyon
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "select *from Alir";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Alir");
                dataGridView1.DataSource = ds.Tables["Alir"];
                baglanti.Close();

            }
        }

        private void Alir_Load(object sender, EventArgs e)//Program çalıştığında listeleme fonksiyonu çalışmasını sağlayan kod
        {
            listeleme();
        }

        private void button2_Click(object sender, EventArgs e)//SİLME BUTONU
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNE EMİNMİSİNİZ ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from Alir where m_id=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
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
                cmd.CommandText = "update Alir set m_id='" + textBox1.Text + "', p_id='" + textBox2.Text + "', alinan_Program='" + int.Parse(textBox3.Text) + "',indirim='" + float.Parse(textBox4.Text) + "'where m_id=@numara";
                cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("GÜNCELLEME İŞLEMİ TAMAMLANMIŞTIR.");
                listeleme();
                


            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string m_id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string p_id = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string alinan_Program = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string indirim = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox1.Text = m_id;
            textBox2.Text = p_id;
            textBox3.Text = alinan_Program;
            textBox4.Text = indirim;
        }

        private void button4_Click(object sender, EventArgs e)//arama butonu
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select *from Alir where m_id like '%"+textBox5.Text+"%'",baglanti);
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBox.Show("ARAMA  İŞLEMİ TAMAMLANMIŞTIR.");




            }
        }
    }
}
