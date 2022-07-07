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
namespace Car
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive\Documents\Showroom.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            con.Open();
            string query = "select * from Admin";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0]; 
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Id.Text == "" || username.Text == "" || pass.Text == "" )
            {
                MessageBox.Show("Informasi tidak ada");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Admin values(" + Id.Text + ",'" + username.Text + "', '" + pass.Text +"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin berhasil ditambahkan");
                    con.Close();
                    populate();

                }catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Id.Text=="")
            {
                MessageBox.Show("Informasi tidak ditemukan");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from Admin where Id=" + Id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus admin berhasil");
                    con.Close();
                    populate();
                }catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            username.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            pass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Id.Text == "" || username.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Informasi tidak ada");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update Admin set username ='" + username.Text + "',pass ='" + pass.Text + "'where Id=" + Id.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin berhasil di update");
                    con.Close();
                    populate();

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
