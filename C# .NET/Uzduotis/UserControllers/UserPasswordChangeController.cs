using System;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis
{
	public partial class UserPasswordChangeController : UserControl
	{
		public UserPasswordChangeController()
		{
			InitializeComponent();
		}

		private void buttonChangePassword_Click(object sender, EventArgs e)
		{
			UserRepository repository = new UserRepository();
			repository.UserPasswordChange(textBoxUsername.Text, textBoxPasswordMatch.Text, textBoxNewPassword.Text);
		}
	}
}
