using Npgsql;
using System;
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
    public partial class Form1 : Form
    {
        NpgsqlConnection conect = new NpgsqlConnection("server=localhost;port=5432;Database=projectDb;user Id=postgres;password=00000");


        public Form1()
        {
            InitializeComponent();

            string query = "select * from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conect.Open();
            NpgsqlCommand cmd1 = new NpgsqlCommand("insert into categories (categoryId,categoryName) values (@p1,@p2)", conect);
            cmd1.Parameters.AddWithValue("@p1", int.Parse(textCategory.Text));
            cmd1.Parameters.AddWithValue("@p2", textCatName.Text);
            cmd1.ExecuteNonQuery(); 
            conect.Close();
            MessageBox.Show("category added succesfully");

            string query = "select * from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        public object Product { get; private set; }


        private void button2_Click(object sender, EventArgs e)
        {
   
            FormProduct fdct = new FormProduct();
            fdct.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //DELETE KISMI TAMAM

            conect.Open();
            NpgsqlCommand cmd4 = new NpgsqlCommand("delete from categories where categoryid=@p1", conect);
            cmd4.Parameters.AddWithValue("@p1", int.Parse(textCategory.Text));
            cmd4.ExecuteNonQuery();
            conect.Close();
            MessageBox.Show("deleted");

            string query = "select * from categories";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {


            conect.Open();
            NpgsqlCommand cmd1 = new NpgsqlCommand("update categories set categoryname = @p2 where categoryid = @p1", conect);
         
            cmd1.Parameters.AddWithValue("@p1", int.Parse(textCategory.Text));
            cmd1.Parameters.AddWithValue("@p2", textCatName.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("updated");
            string query = "select * from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conect.Close();

        }
    }
}
