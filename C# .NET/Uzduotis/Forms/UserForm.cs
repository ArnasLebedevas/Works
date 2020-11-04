using System;
using System.Windows.Forms;

namespace Uzduotis.Forms
{
	public partial class UserForm : Form
	{
		
		readonly UserProfilePictureController profileController = new UserProfilePictureController();
		readonly UserPasswordChangeController passwordController = new UserPasswordChangeController();

		public UserForm(string userUsername)
		{
			InitializeComponent();
			labelLogedInAs.Text = userUsername;
		}

		private void ButtonProfile_Click_1(object sender, EventArgs e)
		{
			labelHeaderNames.Text = buttonProfile.Text;

			userPanel.Controls.Clear();
			userPanel.Controls.Add(profileController);
			profileController.Show();
		}

		private void ButtonSignOut_Click(object sender, EventArgs e)
		{
			LoginForm login = new LoginForm();
			login.Show();

			Visible = false;
		}

		private void ButtonChangeOldPassword_Click(object sender, EventArgs e)
		{
			labelHeaderNames.Text = buttonChangeOldPassword.Text;

			userPanel.Controls.Clear();
			userPanel.Controls.Add(passwordController);
			passwordController.Show();
		}
	}
}
