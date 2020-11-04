using System;
namespace Uzduotis
{
	class Person
	{
		public string name, surname, username, password;
		public DateTime birthDate;

		public Person(string name, string surname, string username, string password, DateTime birthdate)
		{
			birthDate = birthdate;

			if (GetYourAge() > 14)
			{
				if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
					throw new Exception("Fill empty fields!");

				this.name = name;
				this.surname = surname;
				this.username = username;
				this.password = password;
			}
			else
				throw new Exception("You are too young!");
		}

		private int GetYourAge()
		{
			return (int)((DateTime.Now - birthDate).TotalDays / 365);
		}
	}
}
