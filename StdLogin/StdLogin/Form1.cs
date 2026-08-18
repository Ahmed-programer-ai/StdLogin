using System;
using System.Data; 
using System.Data.SqlClient;
namespace StdLogin
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Courses\C#\StdLogin\StdLogin\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from StdLogin", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into StdLogin values(" + txtId.Text + ",'" + txtName.Text + "','" + txtDegree.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("update StdLogin set Name = '" + txtUName.Text + "',Degree = '" + txtUDegree.Text + "' where Id = " + txtUId.Text + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from StdLogin where Id = "+txtDID.Text+"", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}