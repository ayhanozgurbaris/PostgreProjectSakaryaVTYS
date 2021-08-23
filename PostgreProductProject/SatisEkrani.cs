using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PostgreProductProject
{
    public partial class SatisEkrani : Form
    {

        DataSet ds = new DataSet();

        public SatisEkrani()
        {
            InitializeComponent();
        }

        NpgsqlConnection conect = new NpgsqlConnection("server=localhost;port=5432;Database=projectDb;user Id=postgres;password=4462252");

        private void SatisEkrani_Load(object sender, EventArgs e)
        {
            conect.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from customer", conect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMusteri.DisplayMember = "name";
            cmbMusteri.ValueMember = "id";
            cmbMusteri.DataSource = dt;

            conect.Close();

            conect.Open();
            NpgsqlDataAdapter daz = new NpgsqlDataAdapter("select * from products", conect);
            DataTable dtz = new DataTable();
            daz.Fill(dtz);
            cmbUrun.DisplayMember = "productname";
            cmbUrun.ValueMember = "productid";
            cmbUrun.DataSource = dtz;

            conect.Close();

        }

        private void bttnGoProducts_Click(object sender, EventArgs e)
        {
            // todo;
            // getProduct ıd
            // getCustomerId


            // insert into sale
        }

        private void dgwMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUrunl_Click(object sender, EventArgs e)
        {

            FormProduct fdct = new FormProduct();
            fdct.Show();
            this.Hide();
        }
    }
}
