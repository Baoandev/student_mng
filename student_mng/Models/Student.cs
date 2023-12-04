using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Student : Person
	{
		private string studentId;

        public Student() : base()
        {

        }

        public Student(string username, string password, string fullName, DateTime birthday, string sex, string phone, string address, string studentId) : base(username, password, fullName, birthday, sex, phone, address)
        {
            this.StudentId = studentId;
        }

        public string StudentId { get => studentId; set => studentId = value; }

        public override void PrintDetails()
        {
            base.PrintDetails();
			return;
        }
    }
}
