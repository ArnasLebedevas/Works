namespace Uzduotis.Forms
{
	partial class UserForm
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
			this.buttonProfile = new System.Windows.Forms.Button();
			this.buttonSignOut = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonChangeOldPassword = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelLogedInAs = new System.Windows.Forms.Label();
			this.labelHeaderNames = new System.Windows.Forms.Label();
			this.userPanel = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonProfile
			// 
			this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.buttonProfile.FlatAppearance.BorderSize = 0;
			this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonProfile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonProfile.ForeColor = System.Drawing.Color.Silver;
			this.buttonProfile.Location = new System.Drawing.Point(0, 77);
			this.buttonProfile.Margin = new System.Windows.Forms.Padding(4);
			this.buttonProfile.Name = "buttonProfile";
			this.buttonProfile.Size = new System.Drawing.Size(225, 72);
			this.buttonProfile.TabIndex = 9;
			this.buttonProfile.Text = "Profile picture";
			this.buttonProfile.UseVisualStyleBackColor = false;
			this.buttonProfile.Click += new System.EventHandler(this.ButtonProfile_Click_1);
			// 
			// buttonSignOut
			// 
			this.buttonSignOut.FlatAppearance.BorderSize = 0;
			this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSignOut.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSignOut.ForeColor = System.Drawing.Color.Silver;
			this.buttonSignOut.Location = new System.Drawing.Point(-1, 378);
			this.buttonSignOut.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSignOut.Name = "buttonSignOut";
			this.buttonSignOut.Size = new System.Drawing.Size(225, 72);
			this.buttonSignOut.TabIndex = 11;
			this.buttonSignOut.Text = "Log out";
			this.buttonSignOut.UseVisualStyleBackColor = false;
			this.buttonSignOut.Click += new System.EventHandler(this.ButtonSignOut_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.panel1.Controls.Add(this.buttonChangeOldPassword);
			this.panel1.Controls.Add(this.buttonSignOut);
			this.panel1.Controls.Add(this.buttonProfile);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(225, 450);
			this.panel1.TabIndex = 27;
			// 
			// buttonChangeOldPassword
			// 
			this.buttonChangeOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.buttonChangeOldPassword.FlatAppearance.BorderSize = 0;
			this.buttonChangeOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonChangeOldPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonChangeOldPassword.ForeColor = System.Drawing.Color.Silver;
			this.buttonChangeOldPassword.Location = new System.Drawing.Point(0, 157);
			this.buttonChangeOldPassword.Margin = new System.Windows.Forms.Padding(4);
			this.buttonChangeOldPassword.Name = "buttonChangeOldPassword";
			this.buttonChangeOldPassword.Size = new System.Drawing.Size(225, 72);
			this.buttonChangeOldPassword.TabIndex = 10;
			this.buttonChangeOldPassword.Text = "Change password";
			this.buttonChangeOldPassword.UseVisualStyleBackColor = false;
			this.buttonChangeOldPassword.Click += new System.EventHandler(this.ButtonChangeOldPassword_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.labelLogedInAs);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(225, 74);
			this.panel3.TabIndex = 0;
			// 
			// labelLogedInAs
			// 
			this.labelLogedInAs.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelLogedInAs.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelLogedInAs.ForeColor = System.Drawing.Color.White;
			this.labelLogedInAs.Location = new System.Drawing.Point(0, 0);
			this.labelLogedInAs.Name = "labelLogedInAs";
			this.labelLogedInAs.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelLogedInAs.Size = new System.Drawing.Size(225, 74);
			this.labelLogedInAs.TabIndex = 10;
			this.labelLogedInAs.Text = "User";
			this.labelLogedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLogedInAs.UseCompatibleTextRendering = true;
			// 
			// labelHeaderNames
			// 
			this.labelHeaderNames.BackColor = System.Drawing.Color.White;
			this.labelHeaderNames.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelHeaderNames.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelHeaderNames.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelHeaderNames.Location = new System.Drawing.Point(225, 0);
			this.labelHeaderNames.Name = "labelHeaderNames";
			this.labelHeaderNames.Size = new System.Drawing.Size(575, 74);
			this.labelHeaderNames.TabIndex = 28;
			this.labelHeaderNames.Text = "Main page";
			this.labelHeaderNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// userPanel
			// 
			this.userPanel.BackColor = System.Drawing.Color.White;
			this.userPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.userPanel.Location = new System.Drawing.Point(225, 77);
			this.userPanel.Name = "userPanel";
			this.userPanel.Size = new System.Drawing.Size(575, 373);
			this.userPanel.TabIndex = 29;
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.userPanel);
			this.Controls.Add(this.labelHeaderNames);
			this.Controls.Add(this.panel1);
			this.Name = "UserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttonProfile;
		private System.Windows.Forms.Button buttonSignOut;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonChangeOldPassword;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Label labelLogedInAs;
		private System.Windows.Forms.Label labelHeaderNames;
		private System.Windows.Forms.Panel userPanel;
	}
}