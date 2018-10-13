namespace LibraryApplication
{
	partial class issue_books
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
			this.txt_enrollment = new System.Windows.Forms.TextBox();
			this.txt_book_name = new System.Windows.Forms.TextBox();
			this.issue_date = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.student_photo = new System.Windows.Forms.PictureBox();
			this.label_student_name = new System.Windows.Forms.Label();
			this.label_student_dept = new System.Windows.Forms.Label();
			this.label_student_sem = new System.Windows.Forms.Label();
			this.label_student_contact = new System.Windows.Forms.Label();
			this.label_student_email = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.student_photo)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label_student_email);
			this.panel1.Controls.Add(this.label_student_contact);
			this.panel1.Controls.Add(this.label_student_sem);
			this.panel1.Controls.Add(this.label_student_dept);
			this.panel1.Controls.Add(this.label_student_name);
			this.panel1.Controls.Add(this.student_photo);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.issue_date);
			this.panel1.Controls.Add(this.txt_book_name);
			this.panel1.Controls.Add(this.txt_enrollment);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(859, 460);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// txt_enrollment
			// 
			this.txt_enrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_enrollment.Location = new System.Drawing.Point(41, 74);
			this.txt_enrollment.Name = "txt_enrollment";
			this.txt_enrollment.Size = new System.Drawing.Size(164, 23);
			this.txt_enrollment.TabIndex = 0;
			// 
			// txt_book_name
			// 
			this.txt_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_book_name.Location = new System.Drawing.Point(542, 325);
			this.txt_book_name.Name = "txt_book_name";
			this.txt_book_name.Size = new System.Drawing.Size(200, 23);
			this.txt_book_name.TabIndex = 5;
			this.txt_book_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_book_name_KeyDown);
			this.txt_book_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_book_name_KeyUp);
			// 
			// issue_date
			// 
			this.issue_date.Location = new System.Drawing.Point(542, 285);
			this.issue_date.Name = "issue_date";
			this.issue_date.Size = new System.Drawing.Size(200, 20);
			this.issue_date.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Enter Enrollment Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(431, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Student Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(431, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Student Dept";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(431, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Student Sem";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(430, 194);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Student Contact";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(431, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "Student Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(431, 285);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 17);
			this.label7.TabIndex = 13;
			this.label7.Text = "Issue Date";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(431, 327);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(88, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Books Name";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(41, 116);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(164, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "Search Student";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(217, 381);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 31);
			this.button2.TabIndex = 16;
			this.button2.Text = "Issue Book";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(542, 348);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(200, 56);
			this.listBox1.TabIndex = 17;
			this.listBox1.Visible = false;
			this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
			this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
			// 
			// student_photo
			// 
			this.student_photo.Location = new System.Drawing.Point(41, 182);
			this.student_photo.Name = "student_photo";
			this.student_photo.Size = new System.Drawing.Size(164, 145);
			this.student_photo.TabIndex = 18;
			this.student_photo.TabStop = false;
			// 
			// label_student_name
			// 
			this.label_student_name.AutoSize = true;
			this.label_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_student_name.Location = new System.Drawing.Point(539, 63);
			this.label_student_name.Name = "label_student_name";
			this.label_student_name.Size = new System.Drawing.Size(0, 17);
			this.label_student_name.TabIndex = 19;
			// 
			// label_student_dept
			// 
			this.label_student_dept.AutoSize = true;
			this.label_student_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_student_dept.Location = new System.Drawing.Point(539, 107);
			this.label_student_dept.Name = "label_student_dept";
			this.label_student_dept.Size = new System.Drawing.Size(0, 17);
			this.label_student_dept.TabIndex = 20;
			// 
			// label_student_sem
			// 
			this.label_student_sem.AutoSize = true;
			this.label_student_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_student_sem.Location = new System.Drawing.Point(539, 150);
			this.label_student_sem.Name = "label_student_sem";
			this.label_student_sem.Size = new System.Drawing.Size(0, 17);
			this.label_student_sem.TabIndex = 21;
			// 
			// label_student_contact
			// 
			this.label_student_contact.AutoSize = true;
			this.label_student_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_student_contact.Location = new System.Drawing.Point(539, 194);
			this.label_student_contact.Name = "label_student_contact";
			this.label_student_contact.Size = new System.Drawing.Size(0, 17);
			this.label_student_contact.TabIndex = 22;
			// 
			// label_student_email
			// 
			this.label_student_email.AutoSize = true;
			this.label_student_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_student_email.Location = new System.Drawing.Point(539, 242);
			this.label_student_email.Name = "label_student_email";
			this.label_student_email.Size = new System.Drawing.Size(0, 17);
			this.label_student_email.TabIndex = 23;
			// 
			// issue_books
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1048, 485);
			this.Controls.Add(this.panel1);
			this.Name = "issue_books";
			this.Text = "issue_books";
			this.Load += new System.EventHandler(this.issue_books_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.student_photo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker issue_date;
		private System.Windows.Forms.TextBox txt_book_name;
		private System.Windows.Forms.TextBox txt_enrollment;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox student_photo;
		private System.Windows.Forms.Label label_student_email;
		private System.Windows.Forms.Label label_student_contact;
		private System.Windows.Forms.Label label_student_sem;
		private System.Windows.Forms.Label label_student_dept;
		private System.Windows.Forms.Label label_student_name;
	}
}