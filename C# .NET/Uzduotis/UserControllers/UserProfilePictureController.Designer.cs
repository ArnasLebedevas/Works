namespace Uzduotis
{
	partial class UserProfilePictureController
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfilePictureController));
			this.buttonPictureUpload = new System.Windows.Forms.Button();
			this.profilePicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonPictureUpload
			// 
			this.buttonPictureUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
			this.buttonPictureUpload.FlatAppearance.BorderSize = 0;
			this.buttonPictureUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPictureUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPictureUpload.ForeColor = System.Drawing.SystemColors.Control;
			this.buttonPictureUpload.Location = new System.Drawing.Point(212, 294);
			this.buttonPictureUpload.Margin = new System.Windows.Forms.Padding(4);
			this.buttonPictureUpload.Name = "buttonPictureUpload";
			this.buttonPictureUpload.Size = new System.Drawing.Size(139, 46);
			this.buttonPictureUpload.TabIndex = 12;
			this.buttonPictureUpload.Text = "Upload picture";
			this.buttonPictureUpload.UseVisualStyleBackColor = false;
			this.buttonPictureUpload.Click += new System.EventHandler(this.ButtonPictureUpload_Click);
			// 
			// profilePicture
			// 
			this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
			this.profilePicture.Location = new System.Drawing.Point(155, 11);
			this.profilePicture.Name = "profilePicture";
			this.profilePicture.Size = new System.Drawing.Size(256, 263);
			this.profilePicture.TabIndex = 11;
			this.profilePicture.TabStop = false;
			// 
			// UserProfilePictureController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.buttonPictureUpload);
			this.Controls.Add(this.profilePicture);
			this.Name = "UserProfilePictureController";
			this.Size = new System.Drawing.Size(522, 348);
			((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonPictureUpload;
		private System.Windows.Forms.PictureBox profilePicture;
	}
}
