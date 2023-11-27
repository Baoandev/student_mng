using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Student
	{
		private string username;
		private string password;
		private string fullName;
		private DateTime birthday;
		private string sex;
		private string phone;
		private string address;

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string FullName { get => fullName; set => fullName = value; }
		public DateTime Birthday { get => birthday; set => birthday = value; }
		public string Sex { get => sex; set => sex = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Address { get => address; set => address = value; }
	}
}
