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
    public partial class Egitim_Paketi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Egitim_Paketi()
        {
            InitializeComponent();
        }

        private void Egitim_Paketi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev3DataSet6.Egitim_Paketi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.egitim_PaketiTableAdapter.Fill(this.odev3DataSet6.Egitim_Paketi);
            listeleme();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO Egitim_Paketi(Paket_id,icerir)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
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
                cmd.CommandText = "select *from Egitim_Paketi";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Egitim_Paketi");
                dataGridView1.DataSource = ds.Tables["Egitim_Paketi"];
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
                    cmd.CommandText = "delete from Egitim_Paketi where Paket_id=@numara";
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
                cmd.CommandText = "update Egitim_Paketi set Paket_id='" + textBox1.Text + "', icerir='" + textBox2.Text + "'where Paket_id=@numara";
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
            string Paket_id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string icerir = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox1.Text = Paket_id;
            textBox2.Text = icerir;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select *from Egitim_Paketi where Paket_id like '%" + textBox3.Text + "%'", baglanti);
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
