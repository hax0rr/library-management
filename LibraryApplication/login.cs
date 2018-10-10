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
namespace LibraryApplication
{
    public partial class login : Form
    {
		int count = 0;
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        public login()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			try {
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from librarian where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				count = Convert.ToInt32(dt.Rows.Count.ToString());
				if (count == 0)
				{
					MessageBox.Show("Username and password does not match!!");
				}
				else
				{
					this.Hide();
					mdi_user mu = new mdi_user();
					mu.Show();
				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void login_Load(object sender, EventArgs e)
		{
			if(conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
		}
	}
}
