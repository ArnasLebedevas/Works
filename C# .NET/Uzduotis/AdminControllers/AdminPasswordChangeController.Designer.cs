namespace Uzduotis.AdminControllers
{
	partial class AdminPasswordChangeController
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
			this.labelOldPassword = new System.Windows.Forms.Label();
			this.textBoxPasswordMatch = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonChangePassword = new System.Windows.Forms.Button();
			this.labelNewPassword = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.textBoxNewPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelOldPassword
			// 
			this.labelOldPassword.AutoSize = true;
			this.labelOldPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelOldPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelOldPassword.Location = new System.Drawing.Point(159, 83);
			this.labelOldPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelOldPassword.Name = "labelOldPassword";
			this.labelOldPassword.Size = new System.Drawing.Size(84, 15);
			this.labelOldPassword.TabIndex = 48;
			this.labelOldPassword.Text = "Old password";
			// 
			// textBoxPasswordMatch
			// 
			this.textBoxPasswordMatch.BackColor = System.Drawing.Color.White;
			this.textBoxPasswordMatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPasswordMatch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPasswordMatch.ForeColor = System.Drawing.Color.Black;
			this.textBoxPasswordMatch.Location = new System.Drawing.Point(163, 113);
			this.textBoxPasswordMatch.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxPasswordMatch.Name = "textBoxPasswordMatch";
			this.textBoxPasswordMatch.Size = new System.Drawing.Size(287, 19);
			this.textBoxPasswordMatch.TabIndex = 47;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel2.Location = new System.Drawing.Point(163, 136);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(287, 1);
			this.panel2.TabIndex = 46;
			// 
			// buttonChangePassword
			// 
			this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonChangePassword.FlatAppearance.BorderSize = 0;
			this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonChangePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonChangePassword.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonChangePassword.Location = new System.Drawing.Point(193, 226);
			this.buttonChangePassword.Margin = new System.Windows.Forms.Padding(4);
			this.buttonChangePassword.Name = "buttonChangePassword";
			this.buttonChangePassword.Size = new System.Drawing.Size(218, 31);
			this.buttonChangePassword.TabIndex = 60;
			this.buttonChangePassword.Text = "Change password";
			this.buttonChangePassword.UseVisualStyleBackColor = false;
			this.buttonChangePassword.Click += new System.EventHandler(this.ButtonChangePassword_Click_1);
			// 
			// labelNewPassword
			// 
			this.labelNewPassword.AutoSize = true;
			this.labelNewPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNewPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelNewPassword.Location = new System.Drawing.Point(159, 147);
			this.labelNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelNewPassword.Name = "labelNewPassword";
			this.labelNewPassword.Size = new System.Drawing.Size(87, 15);
			this.labelNewPassword.TabIndex = 59;
			this.labelNewPassword.Text = "New password";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel4.Location = new System.Drawing.Point(163, 200);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(287, 1);
			this.panel4.TabIndex = 57;
			// 
			// textBoxNewPassword
			// 
			this.textBoxNewPassword.BackColor = System.Drawing.Color.White;
			this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNewPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNewPassword.ForeColor = System.Drawing.Color.Black;
			this.textBoxNewPassword.Location = new System.Drawing.Point(163, 177);
			this.textBoxNewPassword.Margin = new System.Windows.Forms.Padding(4);
			this.textBoxNewPassword.Name = "textBoxNewPassword";
			this.textBoxNewPassword.Size = new System.Drawing.Size(287, 19);
			this.textBoxNewPassword.TabIndex = 58;
			// 
			// AdminPasswordChangeController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonChangePassword);
			this.Controls.Add(this.labelNewPassword);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.textBoxNewPassword);
			this.Controls.Add(this.labelOldPassword);
			this.Controls.Add(this.textBoxPasswordMatch);
			this.Controls.Add(this.panel2);
			this.Name = "AdminPasswordChangeController";
			this.Size = new System.Drawing.Size(472, 272);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelOldPassword;
		public System.Windows.Forms.TextBox textBoxPasswordMatch;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button buttonChangePassword;
		private System.Windows.Forms.Label labelNewPassword;
		private System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.TextBox textBoxNewPassword;
	}
}
