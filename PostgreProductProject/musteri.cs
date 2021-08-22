using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreProductProject
{
    public partial class musteri : Form
    {
        NpgsqlConnection conect = new NpgsqlConnection("server=localhost;port=5432;Database=projectDb;user Id=postgres;password=4462252");
        DataSet ds = new DataSet();


        public musteri()
        {
            InitializeComponent();

            string query = "select * from musteri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwMusteri.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgwMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textproductID.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //textproductName.Text = dataGridView1.SelectedCells[1].Value.ToString();
            //numericUpDown2.Value = Convert.ToInt32(dataGridView1.SelectedCells[2].Value);
            //textbuyingPrice.Text = dataGridView1.SelectedCells[3].Value.ToString();
            //textsellingPrice.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }

        private void bttnAddMusteri_Click(object sender, EventArgs e)
        {
            conect.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("insert into musteri (id,ad,soyad,sehir,productname) values (@p1,@p2,@p3,@p4,@p5)", conect);
            cmd2.Parameters.AddWithValue("@p1", int.Parse(txtBmusteriNo.Text));
            cmd2.Parameters.AddWithValue("@p2", txtBmusteriAd.Text);
            cmd2.Parameters.AddWithValue("@p3", txtBmusteriSoyad.Text);
            cmd2.Parameters.AddWithValue("@p4", txtBmusteriSehir.Text);
            // cmd2.Parameters.AddWithValue("@p5", ProductName);
            

            cmd2.ExecuteNonQuery();
            conect.Close();
            MessageBox.Show("musteri added succesfully");

            string query = "select * from musteri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwMusteri.DataSource = ds.Tables[0];

        }

        private void bttnGoProducts_Click(object sender, EventArgs e)
        {
            FormProduct fdct = new FormProduct();
            fdct.Show();
            this.Hide();
        }
    }
}
