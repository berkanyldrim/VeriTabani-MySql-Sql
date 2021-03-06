﻿using System;
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
    public partial class Eğitmen : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A7TKHK6;Initial Catalog=odev3;Integrated Security=True");
        public Eğitmen()
        {
            InitializeComponent();
        }

        private void Eğitmen_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev3DataSet7.Eğitmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eğitmenTableAdapter.Fill(this.odev3DataSet7.Eğitmen);
            listeleme();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "INSERT INTO Eğitmen(id,yönetir,uzmandır)VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"')";
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
                cmd.CommandText = "select *from Eğitmen";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Eğitmen");
                dataGridView1.DataSource = ds.Tables["Eğitmen"];
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
                    cmd.CommandText = "delete from Eğitmen where id=@numara";
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
                cmd.CommandText = "update Eğitmen set id='" + textBox1.Text + "', yönetir='" + textBox2.Text + "', uzmandır='" + textBox3.Text +"'where id=@numara";
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
            string id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string yönetir = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string uzmandır= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox1.Text = id;
            textBox2.Text = yönetir;
            textBox3.Text = uzmandır;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("Select *from Eğitmen where id like '%" + textBox4.Text + "%'", baglanti);
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
