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
using Car;

namespace Car_Rent
{
    public partial class Mobil : Form
    {
        public Mobil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\Showroom.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select * from Car";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (regno.Text == "" || brand.Text == "" || model.Text == "" || price.Text == "")
            {
                MessageBox.Show("Informasi tidak ada");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Car values('" + regno.Text + "','" + brand.Text + "', '" + model.Text + "','" + Status.SelectedItem.ToString() + "' ,'" + price.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobil berhasil ditambahkan");
                    con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void Mobil_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (regno.Text == "" || brand.Text == "" || model.Text == "" || price.Text == "")
            {
                MessageBox.Show("Informasi tidak ada");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Car set Brand ='" +brand.Text + "',Model ='" + model.Text + "', Status = '" + Status.SelectedItem.ToString() +"',Harga = "+ price.Text +" where RegNo = '" + regno.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Mobil berhasil di update");
                    con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (regno.Text == "")
            {
                MessageBox.Show("Informasi tidak ditemukan");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Car where RegNo ='" + regno.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus mobil berhasil");
                    con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void CarDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            regno.Text = CarDGV.SelectedRows[0].Cells[0].Value.ToString();
            brand.Text = CarDGV.SelectedRows[0].Cells[1].Value.ToString();
            model.Text = CarDGV.SelectedRows[0].Cells[2].Value.ToString();
            Status.SelectedItem = CarDGV.SelectedRows[0].Cells[3].Value.ToString();
            price.Text = CarDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
