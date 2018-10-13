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
	public partial class view_books : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
		public view_books()
		{
			InitializeComponent();
		}

		private void view_books_Load(object sender, EventArgs e)
		{
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
			disp_books();


		}

		private void button1_Click(object sender, EventArgs e)
		{
			int i = 0;
			try
			{
				
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from books_info where book_name like('%"+textBox1.Text+"%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				i = Convert.ToInt32(dt.Rows.Count.ToString());
				dataGridView1.DataSource = dt;
				
				if(i == 0)
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
			//int i = 0;
			try
			{
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from books_info where book_name like('%" + textBox1.Text + "%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				//i = Convert.ToInt32(dt.Rows.Count.ToString());
				dataGridView1.DataSource = dt;
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			int i = 0;
			try
			{
				
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from books_info where book_author_name like('%" + textBox2.Text + "%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				i = Convert.ToInt32(dt.Rows.Count.ToString());
				dataGridView1.DataSource = dt;
			
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

		private void textBox2_KeyUp(object sender, KeyEventArgs e)
		{
			//int i = 0;
			try
			{
				
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from books_info where book_author_name like('%" + textBox2.Text + "%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				//i = Convert.ToInt32(dt.Rows.Count.ToString());
				dataGridView1.DataSource = dt;
				
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			panel3.Visible = true;
			int i = 0;
			i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
			//MessageBox.Show(i.ToString());
			try
			{
				
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from books_info where id="+i+"";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				foreach(DataRow dr in dt.Rows)
				{
					bookname.Text = dr["book_name"].ToString();
					authorname.Text = dr["book_author_name"].ToString();
					publicationname.Text = dr["book_publication_name"].ToString();
					purchasedate.Value = Convert.ToDateTime(dr["book_purchase_date"].ToString());
					bookprice.Text = dr["book_price"].ToString();
					bookquantity.Text = dr["book_quantity"].ToString();
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int i;
			i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
			//try
			//{
				
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				MessageBox.Show(purchasedate.Value.ToString());
				cmd.CommandText = "update books_info set book_name = '"+bookname.Text + "', book_author_name = '"+authorname.Text +"', book_publication_name='"+publicationname.Text +"', book_purchase_date='"+purchasedate.Value.ToString() +"', book_price='"+bookprice.Text +"', book_quantity='"+bookquantity.Text +"' where id='"+i +"'";
				cmd.ExecuteNonQuery();
				
				disp_books();
				MessageBox.Show("Book Details Updated Successfully!");
				panel3.Visible = false;
			//}
			//catch(Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}
		}
		public void disp_books()
		{
			try
			{
			
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from books_info";
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
	}
}
