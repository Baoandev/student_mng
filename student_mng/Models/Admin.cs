using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Admin : Person
	{
        private string adminId;

        public Admin() : base()
        {

        }

        public Admin(string username, string password, string fullName, DateTime birthday, string sex, string phone, string address, string adminId) : base(username, password, fullName, birthday, sex, phone, address)
        {
            this.AdminId = adminId;
        }

        public string AdminId { get => adminId; set => adminId = value; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            return;
        }
    }
}
