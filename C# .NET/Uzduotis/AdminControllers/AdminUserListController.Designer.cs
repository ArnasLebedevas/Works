namespace Uzduotis
{
	partial class AdminUserListController
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ch_birthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.buttonDeleteUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_surname,
            this.ch_username,
            this.ch_password,
            this.ch_birthdate});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(56, 15);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(473, 293);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
			// 
			// ch_name
			// 
			this.ch_name.Text = "Name";
			this.ch_name.Width = 111;
			// 
			// ch_surname
			// 
			this.ch_surname.Text = "Surname";
			this.ch_surname.Width = 101;
			// 
			// ch_username
			// 
			this.ch_username.Text = "Username";
			this.ch_username.Width = 77;
			// 
			// ch_password
			// 
			this.ch_password.Text = "Password";
			this.ch_password.Width = 92;
			// 
			// ch_birthdate
			// 
			this.ch_birthdate.Text = "Birthdate";
			this.ch_birthdate.Width = 88;
			// 
			// buttonDeleteUser
			// 
			this.buttonDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonDeleteUser.Enabled = false;
			this.buttonDeleteUser.FlatAppearance.BorderSize = 0;
			this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDeleteUser.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonDeleteUser.Location = new System.Drawing.Point(142, 315);
			this.buttonDeleteUser.Margin = new System.Windows.Forms.Padding(4);
			this.buttonDeleteUser.Name = "buttonDeleteUser";
			this.buttonDeleteUser.Size = new System.Drawing.Size(287, 42);
			this.buttonDeleteUser.TabIndex = 8;
			this.buttonDeleteUser.Text = "Delete";
			this.buttonDeleteUser.UseVisualStyleBackColor = false;
			this.buttonDeleteUser.Click += new System.EventHandler(this.ButtonDeleteUser_Click);
			// 
			// AdminUserListController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonDeleteUser);
			this.Controls.Add(this.listView1);
			this.Name = "AdminUserListController";
			this.Size = new System.Drawing.Size(576, 365);
			this.Load += new System.EventHandler(this.AdminUserListController_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button buttonDeleteUser;
		private System.Windows.Forms.ColumnHeader ch_name;
		private System.Windows.Forms.ColumnHeader ch_surname;
		private System.Windows.Forms.ColumnHeader ch_username;
		private System.Windows.Forms.ColumnHeader ch_password;
		private System.Windows.Forms.ColumnHeader ch_birthdate;
	}
}
