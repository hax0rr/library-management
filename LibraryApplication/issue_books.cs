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
	public partial class issue_books : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");

		public issue_books()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{	
			try {
				if (label_student_name.Text == "")
				{
					MessageBox.Show("Enter correct student enrollment number!");
				}
				else {
					int book_qty = 0;
					SqlCommand cmd2 = conn.CreateCommand();
					cmd2.CommandType = CommandType.Text;
					cmd2.CommandText = "select * from books_info where book_name='" + txt_book_name.Text + "'";
					cmd2.ExecuteNonQuery();
					DataTable dt2 = new DataTable();
					SqlDataAdapter sda = new SqlDataAdapter(cmd2);
					sda.Fill(dt2);
					foreach (DataRow dr in dt2.Rows)
					{
						book_qty = Convert.ToInt32(dr["available_qty"].ToString());

					}
					if (book_qty > 0)
					{
						SqlCommand cmd = conn.CreateCommand();
						cmd.CommandType = CommandType.Text;
						cmd.CommandText = "insert into issue_books values('" + txt_enrollment.Text + "','" + label_student_name.Text + "','" + label_student_dept.Text + "','" + label_student_sem.Text + "','" + label_student_contact.Text + "','" + label_student_email.Text + "','" + txt_book_name.Text + "','" + issue_date.Value.ToString() + "','')";
						cmd.ExecuteNonQuery();

						SqlCommand cmd1 = conn.CreateCommand();
						cmd1.CommandType = CommandType.Text;
						cmd1.CommandText = "update books_info set available_qty = available_qty - 1 where book_name = '" + txt_book_name.Text + "'";
						cmd1.ExecuteNonQuery();

						MessageBox.Show("Books issued successfully!");
						this.Close();
					}
					else
					{
						MessageBox.Show("Book not available!");
					}

				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
			
		}

		private void issue_books_Load(object sender, EventArgs e)
		{
			if(conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
		}

		private void txt_book_name_KeyUp(object sender, KeyEventArgs e)
		{
			try {
				int count = 0;
				if (e.KeyCode != Keys.Enter)
				{
					listBox1.Items.Clear();
					SqlCommand cmd = conn.CreateCommand();
					cmd.CommandType = CommandType.Text;
					cmd.CommandText = "select * from books_info where book_name like('%" + txt_book_name.Text + "%')";
					cmd.ExecuteNonQuery();
					DataTable dt = new DataTable();
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(dt);
					count = Convert.ToInt32(dt.Rows.Count.ToString());

					if (count > 0)
					{
						listBox1.Visible = true;
						foreach (DataRow dr in dt.Rows)
						{
							listBox1.Items.Add(dr["book_name"]).ToString();
						}
					}

				}
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void txt_book_name_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Down)
			{
				listBox1.Focus();
				listBox1.SelectedIndex = 0;
			}
		}

		private void listBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				txt_book_name.Text = listBox1.SelectedItem.ToString();
				listBox1.Visible = false;
			}
		}

		private void listBox1_MouseClick(object sender, MouseEventArgs e)
		{
			txt_book_name.Text = listBox1.SelectedItem.ToString();
			listBox1.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try {
				student_photo.Image = null;

				label_student_name.Text = "";
				label_student_dept.Text = "";
				label_student_sem.Text = "";
				label_student_contact.Text = "";
				label_student_email.Text = "";


				int i = 0;
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from student_info where student_enrollment_no='" + txt_enrollment.Text + "'";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				i = Convert.ToInt32(dt.Rows.Count.ToString());

				if (i == 0)
				{
					MessageBox.Show("This Enrollment number not found!");
				}
				else
				{
					Bitmap img;
					foreach (DataRow dr in dt.Rows)
					{
						if(dr["student_image"].ToString() !="") {
							img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
							student_photo.Image = img;
							student_photo.SizeMode = PictureBoxSizeMode.StretchImage;
						}
						else
						{
							//MessageBox.Show("No Image!");
						}
						
						label_student_name.Text = dr["student_name"].ToString();
						label_student_dept.Text = dr["student_department"].ToString();
						label_student_sem.Text = dr["student_sem"].ToString();
						label_student_contact.Text = dr["student_contact"].ToString();
						label_student_email.Text = dr["student_email"].ToString();

					}
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
