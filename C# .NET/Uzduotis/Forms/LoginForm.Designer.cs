namespace Uzduotis
{
	partial class LoginForm
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtUsernameLogin = new System.Windows.Forms.TextBox();
			this.txtPasswordLogin = new System.Windows.Forms.TextBox();
			this.labelUsernameLogin = new System.Windows.Forms.Label();
			this.labelPasswordLogin = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.labelRegister = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel1.Location = new System.Drawing.Point(50, 187);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(287, 1);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel2.Location = new System.Drawing.Point(50, 242);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(287, 1);
			this.panel2.TabIndex = 1;
			// 
			// txtUsernameLogin
			// 
			this.txtUsernameLogin.BackColor = System.Drawing.Color.White;
			this.txtUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsernameLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsernameLogin.ForeColor = System.Drawing.Color.Black;
			this.txtUsernameLogin.Location = new System.Drawing.Point(50, 164);
			this.txtUsernameLogin.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsernameLogin.Name = "txtUsernameLogin";
			this.txtUsernameLogin.Size = new System.Drawing.Size(287, 19);
			this.txtUsernameLogin.TabIndex = 3;
			// 
			// txtPasswordLogin
			// 
			this.txtPasswordLogin.BackColor = System.Drawing.Color.White;
			this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPasswordLogin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPasswordLogin.ForeColor = System.Drawing.Color.Black;
			this.txtPasswordLogin.Location = new System.Drawing.Point(50, 220);
			this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
			this.txtPasswordLogin.Name = "txtPasswordLogin";
			this.txtPasswordLogin.PasswordChar = '*';
			this.txtPasswordLogin.Size = new System.Drawing.Size(287, 19);
			this.txtPasswordLogin.TabIndex = 4;
			// 
			// labelUsernameLogin
			// 
			this.labelUsernameLogin.AutoSize = true;
			this.labelUsernameLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsernameLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelUsernameLogin.Location = new System.Drawing.Point(46, 134);
			this.labelUsernameLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelUsernameLogin.Name = "labelUsernameLogin";
			this.labelUsernameLogin.Size = new System.Drawing.Size(62, 15);
			this.labelUsernameLogin.TabIndex = 5;
			this.labelUsernameLogin.Text = "Username";
			// 
			// labelPasswordLogin
			// 
			this.labelPasswordLogin.AutoSize = true;
			this.labelPasswordLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPasswordLogin.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelPasswordLogin.Location = new System.Drawing.Point(46, 201);
			this.labelPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelPasswordLogin.Name = "labelPasswordLogin";
			this.labelPasswordLogin.Size = new System.Drawing.Size(61, 15);
			this.labelPasswordLogin.TabIndex = 6;
			this.labelPasswordLogin.Text = "Password";
			// 
			// buttonLogin
			// 
			this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonLogin.FlatAppearance.BorderSize = 0;
			this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonLogin.Location = new System.Drawing.Point(50, 270);
			this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(287, 42);
			this.buttonLogin.TabIndex = 7;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = false;
			this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
			// 
			// labelRegister
			// 
			this.labelRegister.AutoSize = true;
			this.labelRegister.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRegister.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelRegister.Location = new System.Drawing.Point(165, 329);
			this.labelRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelRegister.Name = "labelRegister";
			this.labelRegister.Size = new System.Drawing.Size(59, 18);
			this.labelRegister.TabIndex = 8;
			this.labelRegister.Text = "Register";
			this.labelRegister.Click += new System.EventHandler(this.LabelRegister_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(394, 458);
			this.Controls.Add(this.labelRegister);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.labelPasswordLogin);
			this.Controls.Add(this.labelUsernameLogin);
			this.Controls.Add(this.txtPasswordLogin);
			this.Controls.Add(this.txtUsernameLogin);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtPasswordLogin;
		private System.Windows.Forms.Label labelUsernameLogin;
		private System.Windows.Forms.Label labelPasswordLogin;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Label labelRegister;
		public System.Windows.Forms.TextBox txtUsernameLogin;
	}
}

