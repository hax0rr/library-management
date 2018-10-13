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
		public bool isNumber(String s) {
			for (int i = 0; i < s.Length; i++)
				if (char.IsDigit(s[i]) == false)
					return false;

			return true;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			try {
				if (textBox1.Text !="" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "") {
					if(!isNumber(textBox5.Text)) {
						MessageBox.Show("Invalid Price");
					}
					else if (!isNumber(textBox6.Text))
					{
						MessageBox.Show("Invalid Quantity");
					}
					else {
						SqlCommand cmd = conn.CreateCommand();
						cmd.CommandType = CommandType.Text;
						cmd.CommandText = "insert into books_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value.ToString() + "'," + textBox5.Text + "," + textBox6.Text + "," + textBox6.Text + ")";
						cmd.ExecuteNonQuery();

						textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox5.Text = ""; textBox6.Text = "";

						MessageBox.Show("Books Added!!");
						this.Close();
					}
					
				}
				else
				{
					MessageBox.Show("Fill all the details!");
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			
		}

		private void add_books_Load(object sender, EventArgs e)
		{
			if (conn.State == ConnectionState.Open)
			{
				conn.Close();
			}
			conn.Open();
		}
	}
}
