namespace LibraryApplication
{
	partial class return_books
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label_bname = new System.Windows.Forms.Label();
			this.label_idate = new System.Windows.Forms.Label();
			this.label_return_date = new System.Windows.Forms.Label();
			this.return_date = new System.Windows.Forms.DateTimePicker();
			this.button2 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label_book_name = new System.Windows.Forms.Label();
			this.label_issue_date = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 175);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Enrollment No.";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(34, 110);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 31);
			this.button1.TabIndex = 1;
			this.button1.Text = "Search Books";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(34, 69);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(156, 23);
			this.textBox1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label_issue_date);
			this.panel2.Controls.Add(this.label_book_name);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.return_date);
			this.panel2.Controls.Add(this.label_return_date);
			this.panel2.Controls.Add(this.label_idate);
			this.panel2.Controls.Add(this.label_bname);
			this.panel2.Location = new System.Drawing.Point(26, 270);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(872, 168);
			this.panel2.TabIndex = 4;
			this.panel2.Visible = false;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label_bname
			// 
			this.label_bname.AutoSize = true;
			this.label_bname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_bname.Location = new System.Drawing.Point(53, 29);
			this.label_bname.Name = "label_bname";
			this.label_bname.Size = new System.Drawing.Size(90, 17);
			this.label_bname.TabIndex = 0;
			this.label_bname.Text = "Book Name";
			this.label_bname.Click += new System.EventHandler(this.label2_Click);
			// 
			// label_idate
			// 
			this.label_idate.AutoSize = true;
			this.label_idate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_idate.Location = new System.Drawing.Point(294, 29);
			this.label_idate.Name = "label_idate";
			this.label_idate.Size = new System.Drawing.Size(85, 17);
			this.label_idate.TabIndex = 1;
			this.label_idate.Text = "Issue Date";
			// 
			// label_return_date
			// 
			this.label_return_date.AutoSize = true;
			this.label_return_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_return_date.Location = new System.Drawing.Point(53, 69);
			this.label_return_date.Name = "label_return_date";
			this.label_return_date.Size = new System.Drawing.Size(96, 17);
			this.label_return_date.TabIndex = 4;
			this.label_return_date.Text = "Return Date";
			this.label_return_date.Click += new System.EventHandler(this.label6_Click);
			// 
			// return_date
			// 
			this.return_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.return_date.Location = new System.Drawing.Point(196, 69);
			this.return_date.Name = "return_date";
			this.return_date.Size = new System.Drawing.Size(183, 23);
			this.return_date.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(137, 115);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 28);
			this.button2.TabIndex = 6;
			this.button2.Text = "Return Book";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(251, 12);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(647, 239);
			this.panel3.TabIndex = 7;
			this.panel3.Visible = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 15);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(620, 208);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);			// 
			// label_book_name
			// 
			this.label_book_name.AutoSize = true;
			this.label_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_book_name.Location = new System.Drawing.Point(155, 29);
			this.label_book_name.Name = "label_book_name";
			this.label_book_name.Size = new System.Drawing.Size(0, 17);
			this.label_book_name.TabIndex = 7;
			// 
			// label_issue_date
			// 
			this.label_issue_date.AutoSize = true;
			this.label_issue_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_issue_date.Location = new System.Drawing.Point(385, 29);
			this.label_issue_date.Name = "label_issue_date";
			this.label_issue_date.Size = new System.Drawing.Size(0, 17);
			this.label_issue_date.TabIndex = 8;
			// 
			// return_books
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(910, 450);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "return_books";
			this.Text = "return_books";
			this.Load += new System.EventHandler(this.return_books_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DateTimePicker return_date;
		private System.Windows.Forms.Label label_return_date;
		private System.Windows.Forms.Label label_idate;
		private System.Windows.Forms.Label label_bname;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label_issue_date;
		private System.Windows.Forms.Label label_book_name;
	}
}