using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using Uzduotis.Forms;

namespace Uzduotis.Data
{
	class UserRepository
	{
		private readonly SqlConnection connection;
		
		public UserRepository()
		{
			connection = new SqlConnection("Data Source=LAPTOP-AV3DN7CM\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
		}

		public void Register(User user)
		{
			try
			{
				string selectQuery = "select * from Registration_Data where username = @username";

				SqlCommand commandSelectionQuery = new SqlCommand(selectQuery, connection);

				commandSelectionQuery.Parameters.AddWithValue("@username", user.GetUsername());

				SqlDataAdapter dataAdapter = new SqlDataAdapter(commandSelectionQuery);

				DataTable dataTable = new DataTable();
				dataAdapter.Fill(dataTable);

				if (dataTable.Rows.Count >= 1)
				{
					MessageBox.Show("Username Already Exists!");
				}
				else
				{
					string insertQuery = "insert into Registration_Data(name,surname,username,password,birthdate)" +
					"values (@name, @surname, @username, @password, @birthdate)";

					SqlCommand commandInsertionQuery = new SqlCommand(insertQuery, connection);

					commandInsertionQuery.Parameters.AddWithValue("@name", user.GetName());
					commandInsertionQuery.Parameters.AddWithValue("@surname", user.GetSurname());
					commandInsertionQuery.Parameters.AddWithValue("@username", user.GetUsername());
					commandInsertionQuery.Parameters.AddWithValue("@password", user.GetPassword());
					commandInsertionQuery.Parameters.AddWithValue("@birthdate", user.GetBirthdate());

					connection.Open();
					commandInsertionQuery.ExecuteNonQuery();
					MessageBox.Show("Registrated Successfully!");
					connection.Close();
				}
			}
			catch(Exception exc)
			{
				throw new Exception(exc.Message);
			}
		}

		public void Login(string username, string password)
		{
			try
			{
				string query = "select * from Registration_Data where username = @username and password = @password";

				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				SqlDataAdapter adapter = new SqlDataAdapter(command);

				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@password", password);

				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);

				if (dataTable.Rows.Count > 0)
				{
					for (int i = 0; i < dataTable.Rows.Count; i++)
					{
						if (dataTable.Rows[i]["username"].ToString() == "Admin")
						{
							AdminForm adminForm = new AdminForm();
							adminForm.Show();
							connection.Close();
						}
						else
						{
							UserForm userForm = new UserForm(username);
							userForm.Show();
							connection.Close();
						}
					}
				}
				else
				{
					connection.Close();
					throw new Exception("Login Failed");
				}
			}
			catch(Exception exc)
			{
				throw new Exception(exc.Message);
			}
		}

		public void UserPasswordChange(string username, string passwordMatch, string newPassword)
		{
			string passwordMatchQuery = "select * from Registration_Data where username = @username and password = @password";
			connection.Open();
			SqlCommand command = new SqlCommand(passwordMatchQuery, connection);
			
			command.Parameters.AddWithValue("@username", username);
			command.Parameters.AddWithValue("@password", passwordMatch);

			SqlDataReader dataReader = command.ExecuteReader();

			if(dataReader.Read())
			{
				connection.Close();
				if (string.IsNullOrEmpty(newPassword))
				{
					MessageBox.Show("Password textbox is empty");
				}
				else
				{
					string passwordChangeQuery = "update Registration_Data set password = @password where username = @username";
					connection.Open();
					SqlCommand changePasswordCommand = new SqlCommand(passwordChangeQuery, connection);

					changePasswordCommand.Parameters.AddWithValue("@password", newPassword);
					changePasswordCommand.Parameters.AddWithValue("@username", username);

					SqlDataAdapter dataAdapter = new SqlDataAdapter(changePasswordCommand);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);

					changePasswordCommand.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Password Changed Successfully");
				}
			}
			else
			{
				MessageBox.Show("Invalid Password Match");
			}
		}

		public void InsertAdmin()
		{
			string selectAdminQuery = "select * from Registration_Data where username = @username";

			SqlCommand commandSelectionQuery = new SqlCommand(selectAdminQuery, connection);

			commandSelectionQuery.Parameters.AddWithValue("@username", "Admin");

			SqlDataAdapter dataAdapter = new SqlDataAdapter(commandSelectionQuery);

			DataTable dataTable = new DataTable();
			dataAdapter.Fill(dataTable);

			if (dataTable.Rows.Count.Equals(0))
			{
				string insertAdminQuery = "insert into Registration_Data(name,surname,username,password,birthdate)" +
				"values (@name, @surname, @username, @password, @birthdate)";

				SqlCommand commandInsertionQuery = new SqlCommand(insertAdminQuery, connection);

				commandInsertionQuery.Parameters.AddWithValue("@name", "Arnas");
				commandInsertionQuery.Parameters.AddWithValue("@surname", "Lebedevas");
				commandInsertionQuery.Parameters.AddWithValue("@username", "Admin");
				commandInsertionQuery.Parameters.AddWithValue("@password", "Admin");
				commandInsertionQuery.Parameters.AddWithValue("@birthdate", "2000-02-09");

				connection.Open();
				commandInsertionQuery.ExecuteNonQuery();
				connection.Close();
			}
		}

		public void AdminPasswordChange(string passwordMatch, string newPassword)
		{
			string passwordMatchQuery = "select * from Registration_Data where username = @username and password = @password";
			connection.Open();
			SqlCommand command = new SqlCommand(passwordMatchQuery, connection);

			command.Parameters.AddWithValue("@username", "Admin");
			command.Parameters.AddWithValue("@password", passwordMatch);

			SqlDataReader dataReader = command.ExecuteReader();

			if (dataReader.Read())
			{
				connection.Close();
				if (string.IsNullOrEmpty(newPassword))
				{
					MessageBox.Show("New Password textbox is empty");
				}
				else
				{
					string passwordChangeQuery = "update Registration_Data set password = @password where username = @username";
					connection.Open();
					SqlCommand changePasswordCommand = new SqlCommand(passwordChangeQuery, connection);

					changePasswordCommand.Parameters.AddWithValue("@password", newPassword);
					changePasswordCommand.Parameters.AddWithValue("@username", "Admin");

					SqlDataAdapter dataAdapter = new SqlDataAdapter(changePasswordCommand);
					DataTable dataTable = new DataTable();
					dataAdapter.Fill(dataTable);

					changePasswordCommand.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Password Changed Successfully");
				}
			}
			else
			{
				MessageBox.Show("Invalid Password Match!");
			}	
		}
	}
}
