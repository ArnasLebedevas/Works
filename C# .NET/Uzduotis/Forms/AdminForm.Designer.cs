namespace Uzduotis
{
	partial class AdminForm
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
			this.panelAdminMenu = new System.Windows.Forms.Panel();
			this.buttonUserList = new System.Windows.Forms.Button();
			this.buttonAdminChangeOldPassword = new System.Windows.Forms.Button();
			this.buttonSignOut = new System.Windows.Forms.Button();
			this.buttonAdminProfile = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.labelAdminLogedInAs = new System.Windows.Forms.Label();
			this.adminPanel = new System.Windows.Forms.Panel();
			this.labelAdminHeaderNames = new System.Windows.Forms.Label();
			this.panelAdminMenu.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelAdminMenu
			// 
			this.panelAdminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.panelAdminMenu.Controls.Add(this.buttonUserList);
			this.panelAdminMenu.Controls.Add(this.buttonAdminChangeOldPassword);
			this.panelAdminMenu.Controls.Add(this.buttonSignOut);
			this.panelAdminMenu.Controls.Add(this.buttonAdminProfile);
			this.panelAdminMenu.Controls.Add(this.panel3);
			this.panelAdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelAdminMenu.Location = new System.Drawing.Point(0, 0);
			this.panelAdminMenu.Name = "panelAdminMenu";
			this.panelAdminMenu.Size = new System.Drawing.Size(225, 450);
			this.panelAdminMenu.TabIndex = 28;
			// 
			// buttonUserList
			// 
			this.buttonUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.buttonUserList.FlatAppearance.BorderSize = 0;
			this.buttonUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUserList.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUserList.ForeColor = System.Drawing.Color.Silver;
			this.buttonUserList.Location = new System.Drawing.Point(4, 237);
			this.buttonUserList.Margin = new System.Windows.Forms.Padding(4);
			this.buttonUserList.Name = "buttonUserList";
			this.buttonUserList.Size = new System.Drawing.Size(221, 72);
			this.buttonUserList.TabIndex = 12;
			this.buttonUserList.Text = "User list";
			this.buttonUserList.UseVisualStyleBackColor = false;
			this.buttonUserList.Click += new System.EventHandler(this.ButtonUserList_Click);
			// 
			// buttonAdminChangeOldPassword
			// 
			this.buttonAdminChangeOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.buttonAdminChangeOldPassword.FlatAppearance.BorderSize = 0;
			this.buttonAdminChangeOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdminChangeOldPassword.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdminChangeOldPassword.ForeColor = System.Drawing.Color.Silver;
			this.buttonAdminChangeOldPassword.Location = new System.Drawing.Point(4, 157);
			this.buttonAdminChangeOldPassword.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAdminChangeOldPassword.Name = "buttonAdminChangeOldPassword";
			this.buttonAdminChangeOldPassword.Size = new System.Drawing.Size(221, 72);
			this.buttonAdminChangeOldPassword.TabIndex = 10;
			this.buttonAdminChangeOldPassword.Text = "Change password";
			this.buttonAdminChangeOldPassword.UseVisualStyleBackColor = false;
			this.buttonAdminChangeOldPassword.Click += new System.EventHandler(this.ButtonAdminChangeOldPassword_Click);
			// 
			// buttonSignOut
			// 
			this.buttonSignOut.FlatAppearance.BorderSize = 0;
			this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSignOut.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSignOut.ForeColor = System.Drawing.Color.Silver;
			this.buttonSignOut.Location = new System.Drawing.Point(0, 378);
			this.buttonSignOut.Margin = new System.Windows.Forms.Padding(4);
			this.buttonSignOut.Name = "buttonSignOut";
			this.buttonSignOut.Size = new System.Drawing.Size(225, 72);
			this.buttonSignOut.TabIndex = 11;
			this.buttonSignOut.Text = "Log out";
			this.buttonSignOut.UseVisualStyleBackColor = false;
			this.buttonSignOut.Click += new System.EventHandler(this.ButtonSignOut_Click);
			// 
			// buttonAdminProfile
			// 
			this.buttonAdminProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.buttonAdminProfile.FlatAppearance.BorderSize = 0;
			this.buttonAdminProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdminProfile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdminProfile.ForeColor = System.Drawing.Color.Silver;
			this.buttonAdminProfile.Location = new System.Drawing.Point(0, 77);
			this.buttonAdminProfile.Margin = new System.Windows.Forms.Padding(4);
			this.buttonAdminProfile.Name = "buttonAdminProfile";
			this.buttonAdminProfile.Size = new System.Drawing.Size(225, 72);
			this.buttonAdminProfile.TabIndex = 9;
			this.buttonAdminProfile.Text = "Profile picture";
			this.buttonAdminProfile.UseVisualStyleBackColor = false;
			this.buttonAdminProfile.Click += new System.EventHandler(this.ButtonAdminProfile_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.labelAdminLogedInAs);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(225, 74);
			this.panel3.TabIndex = 0;
			// 
			// labelAdminLogedInAs
			// 
			this.labelAdminLogedInAs.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.labelAdminLogedInAs.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAdminLogedInAs.ForeColor = System.Drawing.Color.White;
			this.labelAdminLogedInAs.Location = new System.Drawing.Point(0, 0);
			this.labelAdminLogedInAs.Name = "labelAdminLogedInAs";
			this.labelAdminLogedInAs.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.labelAdminLogedInAs.Size = new System.Drawing.Size(225, 74);
			this.labelAdminLogedInAs.TabIndex = 10;
			this.labelAdminLogedInAs.Text = "Admin";
			this.labelAdminLogedInAs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelAdminLogedInAs.UseCompatibleTextRendering = true;
			// 
			// adminPanel
			// 
			this.adminPanel.BackColor = System.Drawing.Color.White;
			this.adminPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.adminPanel.Location = new System.Drawing.Point(225, 77);
			this.adminPanel.Name = "adminPanel";
			this.adminPanel.Size = new System.Drawing.Size(575, 373);
			this.adminPanel.TabIndex = 30;
			// 
			// labelAdminHeaderNames
			// 
			this.labelAdminHeaderNames.BackColor = System.Drawing.Color.White;
			this.labelAdminHeaderNames.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelAdminHeaderNames.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAdminHeaderNames.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.labelAdminHeaderNames.Location = new System.Drawing.Point(225, 0);
			this.labelAdminHeaderNames.Name = "labelAdminHeaderNames";
			this.labelAdminHeaderNames.Size = new System.Drawing.Size(575, 74);
			this.labelAdminHeaderNames.TabIndex = 29;
			this.labelAdminHeaderNames.Text = "Main page";
			this.labelAdminHeaderNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.labelAdminHeaderNames);
			this.Controls.Add(this.adminPanel);
			this.Controls.Add(this.panelAdminMenu);
			this.Name = "AdminForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminForm";
			this.panelAdminMenu.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelAdminMenu;
		private System.Windows.Forms.Button buttonAdminChangeOldPassword;
		private System.Windows.Forms.Button buttonSignOut;
		private System.Windows.Forms.Button buttonAdminProfile;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.Label labelAdminLogedInAs;
		private System.Windows.Forms.Panel adminPanel;
		private System.Windows.Forms.Button buttonUserList;
		private System.Windows.Forms.Label labelAdminHeaderNames;
	}
}