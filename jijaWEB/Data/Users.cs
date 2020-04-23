using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jijaWEB.Data
{
    public class Users
    {
		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private string _login;

		public string login
		{
			get { return _login; }
			set { _login = value; }
		}
		private string _password;

		public string password
		{
			get { return _password; }
			set {  _password = value; }
		}

		public static implicit operator DbSet<object>(Users v)
		{
			throw new NotImplementedException();
		}
	}
}
