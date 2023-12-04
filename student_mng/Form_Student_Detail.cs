using student_mng.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_mng
{
    public partial class Form_Student_Detail : Form
    {
        private Student detailStudent;

        public Student DetailStudent
        {
            get { return detailStudent; }
            set
            {
                detailStudent = value;
            }
        }

        public Form_Student_Detail()
        {
            InitializeComponent();
            
        }

        private void LoadDetail()
        {
            if (detailStudent != null)
            {
                txtSDStudentId.Text = detailStudent.StudentId.ToString();
                txtSDFullname.Text = detailStudent.FullName.ToString();
                txtSDBirthday.Text = detailStudent.Birthday.ToString();
                txtSDSex.Text = detailStudent.Sex.ToString();
                txtSDPhone.Text = detailStudent.Phone.ToString();
                txtSDAddress.Text = detailStudent.Address.ToString();
            }
        }

        private void Form_Student_Detail_Load(object sender, EventArgs e)
        {
            LoadDetail();
        }
    }
}
