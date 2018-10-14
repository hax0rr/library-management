namespace LibraryApplication
{
	partial class mdi_user
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_user));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.returnBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.bookStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
			this.menuStrip.Size = new System.Drawing.Size(1053, 25);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// booksToolStripMenuItem
			// 
			this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBooksToolStripMenuItem,
            this.viewBooksToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnBooksToolStripMenuItem,
            this.bookStockToolStripMenuItem});
			this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
			this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
			this.booksToolStripMenuItem.Text = "Books";
			// 
			// addNewBooksToolStripMenuItem
			// 
			this.addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
			this.addNewBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addNewBooksToolStripMenuItem.Text = "Add New Books";
			this.addNewBooksToolStripMenuItem.Click += new System.EventHandler(this.addNewBooksToolStripMenuItem_Click);
			// 
			// viewBooksToolStripMenuItem
			// 
			this.viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
			this.viewBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.viewBooksToolStripMenuItem.Text = "View Books";
			this.viewBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBooksToolStripMenuItem_Click);
			// 
			// issueBooksToolStripMenuItem
			// 
			this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
			this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.issueBooksToolStripMenuItem.Text = "Issue Books";
			this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
			// 
			// returnBooksToolStripMenuItem
			// 
			this.returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
			this.returnBooksToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.returnBooksToolStripMenuItem.Text = "Return Books";
			this.returnBooksToolStripMenuItem.Click += new System.EventHandler(this.returnBooksToolStripMenuItem_Click);
			// 
			// studentToolStripMenuItem
			// 
			this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentInfoToolStripMenuItem});
			this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
			this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
			this.studentToolStripMenuItem.Text = "Student";
			// 
			// addStudentToolStripMenuItem
			// 
			this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
			this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.addStudentToolStripMenuItem.Text = "Add Student";
			this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
			// 
			// viewStudentInfoToolStripMenuItem
			// 
			this.viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
			this.viewStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.viewStudentInfoToolStripMenuItem.Text = "View Student Info";
			this.viewStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInfoToolStripMenuItem_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 675);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
			this.statusStrip.Size = new System.Drawing.Size(1053, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Status";
			// 
			// bookStockToolStripMenuItem
			// 
			this.bookStockToolStripMenuItem.Name = "bookStockToolStripMenuItem";
			this.bookStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.bookStockToolStripMenuItem.Text = "Book Stock";
			this.bookStockToolStripMenuItem.Click += new System.EventHandler(this.bookStockToolStripMenuItem_Click);
			// 
			// mdi_user
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1053, 697);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "mdi_user";
			this.Text = "Library Management System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.mdi_user_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem returnBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookStockToolStripMenuItem;
	}
}



