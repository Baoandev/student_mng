using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Teacher
	{
		private string fullname;
		private string birthday;
		private string sex;
		private string phone;
		private string address;

		private string accountId;

		public string Fullname { get => fullname; set => fullname = value; }
		public string Birthday { get => birthday; set => birthday = value; }
		public string Sex { get => sex; set => sex = value; }
		public string Phone { get => phone; set => phone = value; }
		public string Address { get => address; set => address = value; }
		public string AccountId { get => accountId; set => accountId = value; }
	}
}
