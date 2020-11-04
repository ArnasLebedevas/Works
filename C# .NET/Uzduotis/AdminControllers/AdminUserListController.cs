using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Uzduotis
{
	public partial class AdminUserListController : UserControl
	{
		readonly SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AV3DN7CM\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");

		public AdminUserListController()
		{
			InitializeComponent();
		}

		private void AdminUserListController_Load(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				DisplayingUsersInListView();
			}
			catch(SqlException ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.ExitThread();
			}
		}

		private void DisplayingUsersInListView()
		{
			listView1.Items.Clear();

			SqlCommand command = new SqlCommand("SELECT * FROM Registration_Data ORDER BY username", connection);

			try
			{
				SqlDataReader dataReader = command.ExecuteReader();
				while (dataReader.Read())
				{
					ListViewItem items = new ListViewItem(dataReader["name"].ToString());
					items.SubItems.Add(dataReader["surname"].ToString());
					items.SubItems.Add(dataReader["username"].ToString());
					items.SubItems.Add(dataReader["password"].ToString());
					items.SubItems.Add(dataReader["birthdate"].ToString());
					listView1.Items.Add(items);
				}
				dataReader.Close();
				dataReader.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ButtonDeleteUser_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("DELETE FROM Registration_Data WHERE username = @username", connection);
			command.Parameters.AddWithValue("@username", listView1.SelectedItems[0].Text);
			try
			{
				command.ExecuteNonQuery();
				DisplayingUsersInListView();
				buttonDeleteUser.Enabled = false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listView1.SelectedItems.Count > 0)
			{
				buttonDeleteUser.Enabled = true;
			}
			else
			{
				buttonDeleteUser.Enabled = false;
			}
		}
	}
}
