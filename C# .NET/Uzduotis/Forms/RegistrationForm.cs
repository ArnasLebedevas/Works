using System;
using System.Windows.Forms;
using Uzduotis.Data;

namespace Uzduotis
{
	public partial class RegistrationForm : Form
	{
		private readonly LoginForm login = new LoginForm();

		public RegistrationForm()
		{
			InitializeComponent();
		}

		private void LabelLogin_Click(object sender, EventArgs e)
		{
			Visible = false;
			login.Show();
		}

		private void ButtonRegister_Click(object sender, EventArgs e)
		{
			try
			{
				UserRepository repository = new UserRepository();
				User user = new User(txtRegistrationName.Text, txtRegistrationSurname.Text, txtRegistrationUsername.Text, txtRegistrationPassword.Text, dateTimeBirthday.Value);
				repository.Register(user);
				login.Show();
				Visible = false;
			}
			catch (Exception exc)
			{
				txtWarning.Visible = true;
				txtWarning.Text = exc.Message;
			}
		}
	}
}
