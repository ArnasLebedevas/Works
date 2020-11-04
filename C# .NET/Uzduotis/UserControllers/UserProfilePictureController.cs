using System;
using System.Windows.Forms;

namespace Uzduotis
{
	public partial class UserProfilePictureController : UserControl
	{
		public UserProfilePictureController()
		{
			InitializeComponent();

		}

		private void ButtonPictureUpload_Click(object sender, EventArgs e)
		{
			ProfilePicture();
		}

		private void ProfilePicture()
		{ 
			try
			{
				OpenFileDialog dialog = new OpenFileDialog
				{
					Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png"
				};

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					string imageLocation = dialog.FileName;

					profilePicture.ImageLocation = imageLocation;
				}

			}
			catch (Exception)
			{
				MessageBox.Show("Wrong file format!");
			}
		}
	}
}
