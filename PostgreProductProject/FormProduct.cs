using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace PostgreProductProject
{
    public partial class FormProduct : Form
    {

        DataSet ds = new DataSet();
        public FormProduct()
        {
            InitializeComponent();
        }

        NpgsqlConnection conect = new NpgsqlConnection("server=localhost;port=5432;Database=projectDb;user Id=postgres;password=4462252");
      

        private void FormProduct_Load(object sender, EventArgs e)
        {
          
            conect.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from categories", conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "categoryName";
            comboBox1.ValueMember = "categoryId";
            comboBox1.DataSource = dt;

            string query = "select * from products";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(query, conect);
           
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            conect.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // added kısmı TAMAM;
            conect.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("insert into products (productid,productname,reserve,buyingprice,saleprice,category) values (@p1,@p2,@p3,@p4,@p5,@p6)", conect);
            cmd.Parameters.AddWithValue("@p1", int.Parse(textproductID.Text));
            cmd.Parameters.AddWithValue("@p2", textproductName.Text);
            cmd.Parameters.AddWithValue("@p3", int.Parse(numericUpDown2.Text));
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(textbuyingPrice.Text));
            cmd.Parameters.AddWithValue("@p5", decimal.Parse(textsellingPrice.Text));

            cmd.Parameters.AddWithValue("@p6", int.Parse(comboBox1.SelectedValue.ToString()));
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("added");  //ii

            string query = "select * from products";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conect.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //update kısmı TAMAM;
            conect.Open();
            NpgsqlCommand cmd3 = new NpgsqlCommand("update products set productname=@p1,reserve=@p2,buyingprice=@p3,saleprice=@p5 where productid=@p4", conect);


            cmd3.Parameters.AddWithValue("@p1", textproductName.Text);
            cmd3.Parameters.AddWithValue("@p2", int.Parse(numericUpDown2.Value.ToString()));
            cmd3.Parameters.AddWithValue("@p3", decimal.Parse(textbuyingPrice.Text));
            cmd3.Parameters.AddWithValue("@p4", int.Parse(textproductID.Text));
            cmd3.Parameters.AddWithValue("@p5", decimal.Parse(textsellingPrice.Text));


            cmd3.ExecuteNonQuery();

            MessageBox.Show("updated");
           

            string query = "select * from products";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conect.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete kısmı TAMAM;
            conect.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("Delete From products where productId=@p1", conect);
            cmd2.Parameters.AddWithValue("@p1", int.Parse(textproductID.Text));
            cmd2.ExecuteNonQuery();
            conect.Close();
            MessageBox.Show("deleted"); //ii

            string query = "select * from products";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          textproductID.Text =  dataGridView1.SelectedCells[0].Value.ToString();
          textproductName.Text =  dataGridView1.SelectedCells[1].Value.ToString();
          numericUpDown2.Value =  Convert.ToInt32(dataGridView1.SelectedCells[2].Value);
          textbuyingPrice.Text =  dataGridView1.SelectedCells[3].Value.ToString();
          textsellingPrice.Text =  dataGridView1.SelectedCells[4].Value.ToString();
         
        }

       
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //aramaa TAMAM

            string query = "select * from products";
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conect.Close();

            DataView dv = ds.Tables[0].DefaultView;
            dv.RowFilter = "productname Like '" + textBox1.Text + "%'";
            //dv.RowFilter = string.Format("Ad LIKE '{0}%'", textBox5.Text);
            dataGridView1.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri mtr = new musteri();
            mtr.Show();
            this.Hide();
        }
    }
}
