using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;

namespace LibraryApplication
{
	public partial class books_record : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");

		public books_record()
		{
			InitializeComponent();
		}

		private void books_record_Load(object sender, EventArgs e)
		{
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
		}
		public void fill_book_info()
		{
			
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select book_name, book_author_name, book_quantity, available_qty from books_info";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView2.DataSource = dt;
		}

		private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try {
				string i;
				i = dataGridView2.SelectedCells[0].Value.ToString();
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from issue_books where  book_name='" + i.ToString() + "' and book_return_date=''";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			


		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 0;
			try
			{

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select book_name, book_author_name, book_quantity,available_qty from books_info where book_name like('%" + textBox1.Text + "%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				i = Convert.ToInt32(dt.Rows.Count.ToString());
				dataGridView2.DataSource = dt;

				if (i == 0)
				{
					MessageBox.Show("No Books Found!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			int i = 0;
			try
			{

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select book_name, book_author_name, book_quantity,available_qty from books_info where book_name like('%" + textBox1.Text + "%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				i = Convert.ToInt32(dt.Rows.Count.ToString());
				dataGridView2.DataSource = dt;

				if (i == 0)
				{
					MessageBox.Show("No Books Found!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//panel2.Visible = true;
			string i;
			i = dataGridView1.SelectedCells[6].Value.ToString();
			//MessageBox.Show(i.ToString());
			label_email.Text = i.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
				smtp.EnableSsl = true;
				smtp.UseDefaultCredentials = true;
				smtp.Credentials = new NetworkCredential("xxxx@gmail.com", "xxxxxxxx");

				MailMessage mail = new MailMessage("xxxx@gmail.com", label_email.Text, "Gentle reminder from library for returning book.", textBox3.Text);
				mail.Priority = MailPriority.High;
				smtp.Send(mail);
				MessageBox.Show("Mail has been sent to your Email-id");
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}
	}
}
