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
    public partial class Şirket : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Şirket()
        {
            InitializeComponent();
        }

        private void Şirket_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev3DataSet11.Sirket' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sirketTableAdapter.Fill(this.odev3DataSet11.Sirket);
            listeleme();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO Sirket(sirket_ismi,calisir)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
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
                cmd.CommandText = "select *from Sirket";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Sirket");
                dataGridView1.DataSource = ds.Tables["Sirket"];
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
                    cmd.CommandText = "delete from Sirket where sirket_ismi=@numara";
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
                cmd.CommandText = "update Sirket set sirket_ismi='" + textBox1.Text + "', calisir='" + textBox2.Text + " 'where sirket_ismi=@numara";
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
            string sirket_ismi = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string calisir = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox1.Text = sirket_ismi;
            textBox2.Text = calisir;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select *from Sirket where sirket_ismi like '%" + textBox3.Text + "%'", baglanti);
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
