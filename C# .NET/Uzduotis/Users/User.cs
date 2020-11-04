using System;

namespace Uzduotis
{
	class User : Person
	{
		public User(string name, string surname, string username, string password, DateTime birthdate)
			: base(name, surname, username, password, birthdate)
		{
		}

		public string GetName()
		{
			return name;
		}

		public string GetSurname()
		{
			return surname;
		}

		public string GetUsername()
		{
			return username;
		}

		public string GetPassword()
		{
			return password;
		}

		public DateTime GetBirthdate()
		{
			return birthDate;
		}
	}
}
