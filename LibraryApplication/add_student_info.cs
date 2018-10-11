using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace LibraryApplication
{
	public partial class add_student_info : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
		string pwd;
		string wanted_path;
		public add_student_info()
		{
			InitializeComponent();
		}

		private void add_student_info_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			pwd = Class1.GetRandomPassword(20);
			wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
			DialogResult result = openFileDialog1.ShowDialog();
			openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg| GIF Files (*.gif)|*.gif";
			if(result == DialogResult.OK)
			{
				pictureBox1.ImageLocation = openFileDialog1.FileName;
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				String img_path;
				File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" +pwd + ".jpg");
				img_path = "student_images\\" + pwd + ".jpg";
				conn.Open();
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandType = CommandType.Text; 
				cmd.CommandText = "insert into student_info values('" +textBox1.Text + "','" +img_path.ToString() + "','" +textBox3.Text + "','" +textBox4.Text + "','" +textBox5.Text + "','" +textBox6.Text + "','" +textBox7.Text + "')";
				cmd.ExecuteNonQuery();
				conn.Close();
				//textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox5.Text = ""; textBox6.Text = "";

				MessageBox.Show("Student Record Added!!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
