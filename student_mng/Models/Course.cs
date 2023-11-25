using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace student_mng.Models
{
	public class Course
	{
		private int courseId;
		private string courseName;
		private int teacherId;
		private DateTime ngayBatDau;
		private DateTime ngayKetThuc;

		public int CourseId { get => courseId; set => courseId = value; }
		public string CourseName { get => courseName; set => courseName = value; }
		public int TeacherId { get => teacherId; set => teacherId = value; }
		public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
		public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
	}
}
