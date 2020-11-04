namespace Uzduotis
{
	partial class RegistrationForm
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
			this.txtWarning = new System.Windows.Forms.TextBox();
			this.dateTimeBirthday = new System.Windows.Forms.DateTimePicker();
			this.panel8 = new System.Windows.Forms.Panel();
			this.labelRegistrationBirthday = new System.Windows.Forms.Label();
			this.labelLogin = new System.Windows.Forms.Label();
			this.buttonRegister = new System.Windows.Forms.Button();
			this.labelRegistrationPassword = new System.Windows.Forms.Label();
			this.txtRegistrationPassword = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labelRegistrationUsername = new System.Windows.Forms.Label();
			this.txtRegistrationUsername = new System.Windows.Forms.TextBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.labelRegistrationSurname = new System.Windows.Forms.Label();
			this.txtRegistrationSurname = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.labelRegistrationName = new System.Windows.Forms.Label();
			this.txtRegistrationName = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// txtWarning
			// 
			this.txtWarning.BackColor = System.Drawing.Color.White;
			this.txtWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtWarning.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWarning.ForeColor = System.Drawing.Color.Red;
			this.txtWarning.Location = new System.Drawing.Point(29, 10);
			this.txtWarning.Margin = new System.Windows.Forms.Padding(4);
			this.txtWarning.Name = "txtWarning";
			this.txtWarning.ReadOnly = true;
			this.txtWarning.Size = new System.Drawing.Size(310, 16);
			this.txtWarning.TabIndex = 45;
			this.txtWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtWarning.Visible = false;
			// 
			// dateTimeBirthday
			// 
			this.dateTimeBirthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeBirthday.Location = new System.Drawing.Point(35, 130);
			this.dateTimeBirthday.Name = "dateTimeBirthday";
			this.dateTimeBirthday.Size = new System.Drawing.Size(286, 23);
			this.dateTimeBirthday.TabIndex = 44;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel8.Location = new System.Drawing.Point(35, 153);
			this.panel8.Margin = new System.Windows.Forms.Padding(4);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(286, 1);
			this.panel8.TabIndex = 40;
			// 
			// labelRegistrationBirthday
			// 
			this.labelRegistrationBirthday.AutoSize = true;
			this.labelRegistrationBirthday.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegistrationBirthday.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelRegistrationBirthday.Location = new System.Drawing.Point(32, 113);
			this.labelRegistrationBirthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegistrationBirthday.Name = "labelRegistrationBirthday";
			this.labelRegistrationBirthday.Size = new System.Drawing.Size(54, 15);
			this.labelRegistrationBirthday.TabIndex = 43;
			this.labelRegistrationBirthday.Text = "Birthday";
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelLogin.Location = new System.Drawing.Point(159, 376);
			this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(41, 18);
			this.labelLogin.TabIndex = 29;
			this.labelLogin.Text = "Login";
			this.labelLogin.Click += new System.EventHandler(this.LabelLogin_Click);
			// 
			// buttonRegister
			// 
			this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonRegister.FlatAppearance.BorderSize = 0;
			this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRegister.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonRegister.Location = new System.Drawing.Point(34, 317);
			this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
			this.buttonRegister.Name = "buttonRegister";
			this.buttonRegister.Size = new System.Drawing.Size(287, 42);
			this.buttonRegister.TabIndex = 30;
			this.buttonRegister.Text = "Register";
			this.buttonRegister.UseVisualStyleBackColor = false;
			this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
			// 
			// labelRegistrationPassword
			// 
			this.labelRegistrationPassword.AutoSize = true;
			this.labelRegistrationPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegistrationPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelRegistrationPassword.Location = new System.Drawing.Point(34, 247);
			this.labelRegistrationPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegistrationPassword.Name = "labelRegistrationPassword";
			this.labelRegistrationPassword.Size = new System.Drawing.Size(61, 15);
			this.labelRegistrationPassword.TabIndex = 42;
			this.labelRegistrationPassword.Text = "Password";
			// 
			// txtRegistrationPassword
			// 
			this.txtRegistrationPassword.BackColor = System.Drawing.Color.White;
			this.txtRegistrationPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRegistrationPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRegistrationPassword.ForeColor = System.Drawing.Color.Black;
			this.txtRegistrationPassword.Location = new System.Drawing.Point(37, 265);
			this.txtRegistrationPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtRegistrationPassword.Name = "txtRegistrationPassword";
			this.txtRegistrationPassword.PasswordChar = '*';
			this.txtRegistrationPassword.Size = new System.Drawing.Size(286, 16);
			this.txtRegistrationPassword.TabIndex = 41;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel7.Location = new System.Drawing.Point(37, 288);
			this.panel7.Margin = new System.Windows.Forms.Padding(4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(286, 1);
			this.panel7.TabIndex = 39;
			// 
			// labelRegistrationUsername
			// 
			this.labelRegistrationUsername.AutoSize = true;
			this.labelRegistrationUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegistrationUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelRegistrationUsername.Location = new System.Drawing.Point(33, 173);
			this.labelRegistrationUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegistrationUsername.Name = "labelRegistrationUsername";
			this.labelRegistrationUsername.Size = new System.Drawing.Size(62, 15);
			this.labelRegistrationUsername.TabIndex = 38;
			this.labelRegistrationUsername.Text = "Username";
			// 
			// txtRegistrationUsername
			// 
			this.txtRegistrationUsername.BackColor = System.Drawing.Color.White;
			this.txtRegistrationUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRegistrationUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRegistrationUsername.ForeColor = System.Drawing.Color.Black;
			this.txtRegistrationUsername.Location = new System.Drawing.Point(36, 192);
			this.txtRegistrationUsername.Margin = new System.Windows.Forms.Padding(4);
			this.txtRegistrationUsername.Name = "txtRegistrationUsername";
			this.txtRegistrationUsername.Size = new System.Drawing.Size(287, 16);
			this.txtRegistrationUsername.TabIndex = 37;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel6.Location = new System.Drawing.Point(36, 215);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(287, 1);
			this.panel6.TabIndex = 36;
			// 
			// labelRegistrationSurname
			// 
			this.labelRegistrationSurname.AutoSize = true;
			this.labelRegistrationSurname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegistrationSurname.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelRegistrationSurname.Location = new System.Drawing.Point(194, 55);
			this.labelRegistrationSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegistrationSurname.Name = "labelRegistrationSurname";
			this.labelRegistrationSurname.Size = new System.Drawing.Size(55, 15);
			this.labelRegistrationSurname.TabIndex = 35;
			this.labelRegistrationSurname.Text = "Surname";
			// 
			// txtRegistrationSurname
			// 
			this.txtRegistrationSurname.BackColor = System.Drawing.Color.White;
			this.txtRegistrationSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRegistrationSurname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRegistrationSurname.ForeColor = System.Drawing.Color.Black;
			this.txtRegistrationSurname.Location = new System.Drawing.Point(197, 74);
			this.txtRegistrationSurname.Margin = new System.Windows.Forms.Padding(4);
			this.txtRegistrationSurname.Name = "txtRegistrationSurname";
			this.txtRegistrationSurname.Size = new System.Drawing.Size(124, 16);
			this.txtRegistrationSurname.TabIndex = 34;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel5.Location = new System.Drawing.Point(197, 97);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(124, 1);
			this.panel5.TabIndex = 33;
			// 
			// labelRegistrationName
			// 
			this.labelRegistrationName.AutoSize = true;
			this.labelRegistrationName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegistrationName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelRegistrationName.Location = new System.Drawing.Point(31, 55);
			this.labelRegistrationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegistrationName.Name = "labelRegistrationName";
			this.labelRegistrationName.Size = new System.Drawing.Size(38, 15);
			this.labelRegistrationName.TabIndex = 32;
			this.labelRegistrationName.Text = "Name";
			// 
			// txtRegistrationName
			// 
			this.txtRegistrationName.BackColor = System.Drawing.Color.White;
			this.txtRegistrationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRegistrationName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRegistrationName.ForeColor = System.Drawing.Color.Black;
			this.txtRegistrationName.Location = new System.Drawing.Point(36, 74);
			this.txtRegistrationName.Margin = new System.Windows.Forms.Padding(4);
			this.txtRegistrationName.Name = "txtRegistrationName";
			this.txtRegistrationName.Size = new System.Drawing.Size(126, 16);
			this.txtRegistrationName.TabIndex = 31;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel4.Location = new System.Drawing.Point(36, 97);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(126, 1);
			this.panel4.TabIndex = 28;
			// 
			// RegistrationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(378, 419);
			this.Controls.Add(this.txtWarning);
			this.Controls.Add(this.dateTimeBirthday);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.labelRegistrationBirthday);
			this.Controls.Add(this.labelLogin);
			this.Controls.Add(this.buttonRegister);
			this.Controls.Add(this.labelRegistrationPassword);
			this.Controls.Add(this.txtRegistrationPassword);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.labelRegistrationUsername);
			this.Controls.Add(this.txtRegistrationUsername);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.labelRegistrationSurname);
			this.Controls.Add(this.txtRegistrationSurname);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.labelRegistrationName);
			this.Controls.Add(this.txtRegistrationName);
			this.Controls.Add(this.panel4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RegistrationForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtWarning;
		private System.Windows.Forms.DateTimePicker dateTimeBirthday;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label labelRegistrationBirthday;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Button buttonRegister;
		private System.Windows.Forms.Label labelRegistrationPassword;
		private System.Windows.Forms.TextBox txtRegistrationPassword;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label labelRegistrationUsername;
		private System.Windows.Forms.TextBox txtRegistrationUsername;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label labelRegistrationSurname;
		private System.Windows.Forms.TextBox txtRegistrationSurname;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label labelRegistrationName;
		private System.Windows.Forms.TextBox txtRegistrationName;
		private System.Windows.Forms.Panel panel4;
	}
}