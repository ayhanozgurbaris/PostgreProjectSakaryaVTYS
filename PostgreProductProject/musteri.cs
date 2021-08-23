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
    public partial class customer : Form
    {
        NpgsqlConnection conect = new NpgsqlConnection("server=localhost;port=5432;Database=projectDb;user Id=postgres;password=4462252");
        DataSet ds = new DataSet();


        public customer()
        {
            InitializeComponent();

            string query = "select * from customer";
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


        }

        private void bttnAddMusteri_Click(object sender, EventArgs e)
        {
            //MUSTERİ EKLE TAMAM

            conect.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("insert into customer (id,name,surname,city_id) values (@p1,@p2,@p3,@p4)", conect);
            cmd2.Parameters.AddWithValue("@p1", int.Parse(txtBmusteriNo.Text));
            cmd2.Parameters.AddWithValue("@p2", txtBmusteriAd.Text);
            cmd2.Parameters.AddWithValue("@p3", txtBmusteriSoyad.Text);
            cmd2.Parameters.AddWithValue("@p4", int.Parse(txtBmusteriSehir.Text));
    

            cmd2.ExecuteNonQuery();
            conect.Close();
            MessageBox.Show("customer added succesfully");

            string query = "select * from customer";
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

        private void bttnDeleteMusteri_Click(object sender, EventArgs e)
        {
            
            //DELETE KISMI TAMAM 

            conect.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("delete from customer where id=@p1", conect);
            cmd2.Parameters.AddWithValue("@p1", int.Parse(txtBmusteriNo.Text));

            cmd2.ExecuteNonQuery();
            conect.Close();
            MessageBox.Show("customer deleted succesfully");


            string query = "select * from customer";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwMusteri.DataSource = ds.Tables[0];


        }

        private void bttnUpdateMusteri_Click(object sender, EventArgs e)
        {
            //MUSTERİ GUNCELLE TAMAM

            conect.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand("update customer set name = @p2, city_id = @p3, surname = @p4  where id = @p1", conect);

            cmd2.Parameters.AddWithValue("@p1", int.Parse(txtBmusteriNo.Text));
            cmd2.Parameters.AddWithValue("@p2", txtBmusteriAd.Text);
            cmd2.Parameters.AddWithValue("@p4", txtBmusteriSoyad.Text);
            cmd2.Parameters.AddWithValue("@p3", int.Parse(txtBmusteriSehir.Text));

            cmd2.ExecuteNonQuery();

            MessageBox.Show("updated");
            string query = "select * from customer";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwMusteri.DataSource = ds.Tables[0];
            conect.Close();
        }
    }
}
