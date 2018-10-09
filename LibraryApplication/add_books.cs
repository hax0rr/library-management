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
	public partial class add_books : Form
	{
		SqlConnection conn = new SqlConnection(@"Data Source=HAX0RR\SQLEXPRESS;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
		public add_books()
		{
			InitializeComponent();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			conn.Open();
			SqlCommand cmd = conn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "insert into books_info values('"+textBox1.Text +"','"+ textBox2.Text + "','"+ textBox3.Text  + "','"+ dateTimePicker1.Text + "',"+ textBox5.Text  + ","+ textBox6.Text  + ")";
			cmd.ExecuteNonQuery();
			conn.Close();
			textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox5.Text = ""; textBox6.Text = "";

			MessageBox.Show("Books Added!!");
		}
	}
}
