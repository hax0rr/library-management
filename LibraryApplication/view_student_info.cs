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
using System.IO;

namespace LibraryApplication
{

	public partial class view_student_info : Form
	{
		string wanted_path, pwd;
		DialogResult result;
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
		public view_student_info()
		{
			InitializeComponent();
		}

		private void view_student_info_Load(object sender, EventArgs e)
		{
			
			if(conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();

			fill_grid();

		}

		public void fill_grid()
		{
			dataGridView1.Columns.Clear();
			dataGridView1.Refresh();
			int i = 0;
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from student_info";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			dataGridView1.DataSource = dt;

			Bitmap img;
			DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

			imgCol.HeaderText = "Student Picture";
			imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
			imgCol.Width = 100;
			dataGridView1.Columns.Add(imgCol);

			foreach (DataRow dr in dt.Rows)
			{
				img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
				dataGridView1.Rows[i].Cells[8].Value = img;
				dataGridView1.Rows[i].Height = 100;
				i = i + 1;
			}
		}


		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				int i = 0;
				dataGridView1.Columns.Clear();
				dataGridView1.Refresh();
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "select * from student_info where student_name like('%"+textBox1.Text +"%')";
				cmd.ExecuteNonQuery();
				DataTable dt = new DataTable();
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;

				Bitmap img;
				DataGridViewImageColumn imgCol = new DataGridViewImageColumn();

				imgCol.HeaderText = "Student Picture";
				imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
				imgCol.Width = 100;
				dataGridView1.Columns.Add(imgCol);

				foreach (DataRow dr in dt.Rows)
				{
					img = new Bitmap(@"..\..\" + dr["student_image"].ToString());
					dataGridView1.Rows[i].Cells[8].Value = img;
					dataGridView1.Rows[i].Height = 100;
					i = i + 1;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i;
			i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "select * from student_info where id="+i+"";
			cmd.ExecuteNonQuery();
			DataTable dt = new DataTable();
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			da.Fill(dt);
			foreach (DataRow dr in dt.Rows)
			{
				student_name.Text = dr["student_name"].ToString();
				student_enrollment_no.Text = dr["student_enrollment_no"].ToString();
				student_dept.Text= dr["student_department"].ToString();
				student_sem.Text = dr["student_sem"].ToString();
				student_contact.Text = dr["student_contact"].ToString();
				student_email.Text = dr["student_email"].ToString();
			}
			conn.Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (result == DialogResult.OK)
			{
				int i;
				i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
				String img_path;
				File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");
				img_path = "student_images\\" + pwd + ".jpg";

				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "update student_info set student_name='"+student_name.Text +"', student_image='" +img_path.ToString() + "', student_enrollment_no='" + student_enrollment_no.Text + "',student_department='" + student_dept.Text + "',student_sem='" + student_sem.Text + "',student_contact='" + student_contact.Text + "',student_email='" + student_email.Text + "' where id='"+i +"'";
				cmd.ExecuteNonQuery();
				fill_grid();
				MessageBox.Show("Record Updated Successfully!");
			}
			else if(result == DialogResult.Cancel)
			{

				int i;
				i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = "update student_info set student_name='" + student_name.Text + "', student_enrollment_no='" + student_enrollment_no.Text + "',student_department='" + student_dept.Text + "',student_sem='" + student_sem.Text + "',student_contact='" + student_contact.Text + "',student_email='" + student_email.Text + "' where id='" + i + "'";
				cmd.ExecuteNonQuery();
				fill_grid();
				MessageBox.Show("Record Updated Successfully!");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pwd = Class1.GetRandomPassword(20);
			wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
			result = openFileDialog1.ShowDialog();
			openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg| GIF Files (*.gif)|*.gif";
			
		}
	}
}
