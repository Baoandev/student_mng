using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Teacher : Person
	{
        private string teacherId;

        public Teacher() : base()
        {

        }

        public Teacher(string username, string password, string fullName, DateTime birthday, string sex, string phone, string address, string teacherId) : base(username, password, fullName, birthday, sex, phone, address)
        {
            this.TeacherId = teacherId;
        }

        public string TeacherId { get => teacherId; set => teacherId = value; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            return;
        }
    }
}
