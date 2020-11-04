using System;
using System.Windows.Forms;
using Uzduotis.AdminControllers;

namespace Uzduotis
{
	public partial class AdminForm : Form
	{
		readonly UserProfilePictureController profileController = new UserProfilePictureController();
		readonly AdminUserListController adminController = new AdminUserListController();
		readonly AdminPasswordChangeController adminpassword = new AdminPasswordChangeController();

		public AdminForm()
		{
			InitializeComponent();
		}

		private void ButtonAdminProfile_Click(object sender, EventArgs e)
		{
			labelAdminHeaderNames.Text = buttonAdminProfile.Text;

			adminPanel.Controls.Clear();
			adminPanel.Controls.Add(profileController);
			profileController.Show();
		}

		private void ButtonUserList_Click(object sender, EventArgs e)
		{
		
			labelAdminHeaderNames.Text = buttonUserList.Text;
			adminPanel.Controls.Clear();
			adminPanel.Controls.Add(adminController);
			adminController.Show();
		}

		private void ButtonSignOut_Click(object sender, EventArgs e)
		{
			LoginForm login = new LoginForm();
			login.Show();

			Visible = false;
		}

		private void ButtonAdminChangeOldPassword_Click(object sender, EventArgs e)
		{
			labelAdminHeaderNames.Text = buttonAdminChangeOldPassword.Text;

			adminPanel.Controls.Clear();
			adminPanel.Controls.Add(adminpassword);
			adminpassword.Show();
		}
	}
}
