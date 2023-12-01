using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Admin
	{
		private string username;
		private string password;

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
	}
}
