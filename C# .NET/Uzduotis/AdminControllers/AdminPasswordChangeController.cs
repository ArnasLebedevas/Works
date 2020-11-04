using System;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis.AdminControllers
{
	public partial class AdminPasswordChangeController : UserControl
	{
		public AdminPasswordChangeController()
		{
			InitializeComponent();
		}

		private void ButtonChangePassword_Click_1(object sender, EventArgs e)
		{
			UserRepository repository = new UserRepository();
			repository.AdminPasswordChange(textBoxPasswordMatch.Text, textBoxNewPassword.Text);
		}
	}
}
