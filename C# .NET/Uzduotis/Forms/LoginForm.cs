using System;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis
{
	public partial class LoginForm : Form
	{
		private readonly UserRepository repository = new UserRepository();

		public LoginForm()
		{
			InitializeComponent();
			repository.InsertAdmin();
		}
		private void LabelRegister_Click(object sender, EventArgs e)
		{
			RegistrationForm registration = new RegistrationForm();
			Visible = false;
			registration.Show();
		}
		private void ButtonLogin_Click(object sender, EventArgs e)
		{
			try
			{
				repository.Login(txtUsernameLogin.Text, txtPasswordLogin.Text);
				Visible = false;
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
	}
}
