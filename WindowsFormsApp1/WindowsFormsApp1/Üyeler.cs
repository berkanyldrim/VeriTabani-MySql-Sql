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
    public partial class Üyeler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Üyeler()
        {
            InitializeComponent();
        }

        private void Üyeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev3DataSet12.Üyeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.üyelerTableAdapter.Fill(this.odev3DataSet12.Üyeler);
            listeleme();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO Üyeler(TCNO,Ad,Soyad,TelNO,EPosta)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
                cmd.CommandText = "select *from Üyeler";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Üyeler");
                dataGridView1.DataSource = ds.Tables["Üyeler"];
                baglanti.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SİLMEK İSTEDİĞİNE EMİNMİSİNİZ ?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = "delete from Üyeler where TCNO=@numara";
                    cmd.Parameters.AddWithValue("@numara", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ.");
                    listeleme();



                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "update Üyeler set TCNO='" + textBox1.Text + "', Ad='" + textBox2.Text + "', Soyad='" + textBox3.Text + "',TelNO='" + textBox4.Text + ",EPosta='" + textBox5.Text + "'where TCNO=@numara";
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
            string TCNO = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string Ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string Soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string TelNO = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            string EPosta = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox1.Text = TCNO;
            textBox2.Text = Ad;
            textBox3.Text = Soyad;
            textBox4.Text = TelNO;
            textBox5.Text = EPosta;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select *from Üyeler where TCNO like '%" + textBox6.Text + "%'", baglanti);
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
