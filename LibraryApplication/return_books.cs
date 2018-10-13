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
	public partial class return_books : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");

		public return_books()
		{
			InitializeComponent();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int i;
			i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
			//MessageBox.Show(i.ToString());
			SqlCommand cmd1 = conn.CreateCommand();
			cmd1.CommandType = CommandType.Text;
			cmd1.CommandText = "update issue_books set book_return_date='"+return_date.Value.ToString() +"' where id='"+i.ToString() +"'";
			cmd1.ExecuteNonQuery();

			SqlCommand cmd2 = conn.CreateCommand();
			cmd2.CommandType = CommandType.Text;
			cmd2.CommandText = "update books_info set available_qty=available_qty+1 where book_name='"+label_book_name.Text +"'";
			cmd2.ExecuteNonQuery();

			MessageBox.Show("Books return successfully!");
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			panel3.Visible = true;
			fill_grid(textBox1.Text);
		}

		private void return_books_Load(object sender, EventArgs e)
		{
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
		}
		public void fill_grid(string enroll_no)
		{
			int i=0;
			SqlCommand cmd1= conn.CreateCommand();
			cmd1.CommandType = CommandType.Text;
			cmd1.CommandText = "select * from student_info where student_enrollment_no = '"+enroll_no.ToString() +"'";
			cmd1.ExecuteNonQuery();
			DataTable dt1 = new DataTable();
			SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
			da1.Fill(dt1);
			i = Convert.ToInt32(dt1.Rows.Count.ToString());
			if (i == 0)
			{
				MessageBox.Show("No student exists with this Enrollment No!");
			}
			else {
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from issue_books where student_enrollment='" + enroll_no.ToString() + "' AND book_return_date=''";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
			}




		}

		

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			panel2.Visible = true;
			int i;
			i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from issue_books where id='" + i + "'";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				label_book_name.Text = dr["book_name"].ToString();
				label_issue_date.Text = dr["book_issue_date"].ToString();
			}
		}
	}
}
