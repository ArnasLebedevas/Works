using System;

namespace Uzduotis
{
	class Admin : User
	{
		public Admin(string name, string surname, string username, string password, DateTime birthdate)
			: base(name, surname, username, password, birthdate)
		{
		}
	}
}
