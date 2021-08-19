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


        public Form1()
        {
            InitializeComponent();
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

        }
        NpgsqlConnection conect = new NpgsqlConnection("server=localhost;port=5432;Database=projectDb;user Id=postgres;password=4462252");

        public object Product { get; private set; }

        private void buttonList_Click(object sender, EventArgs e)
        {
            string query = "select * from categories";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Form1 frm = new Form1();
            // frm.Show();
            FormProduct fdct = new FormProduct();
            fdct.Show();
            this.Hide();
        }
    }
}
