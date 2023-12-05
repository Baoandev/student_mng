using student_mng.BL;
using student_mng.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_mng
{
	public partial class Form_Admin : Form
	{

		public Form_Admin()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try 
			{
				BL_Admin blAd = new BL_Admin();
				Student stu = new Student();
				stu.FullName=this.txtHoTenSV.Text.ToString();
				stu.Birthday = dpNgaySinh_SV.Value;
				stu.Sex = this.txtGioiTinh_SV.Text.ToString();
				stu.Phone = this.txtSoDienThoai_SV.Text.ToString();
				stu.Address = this.txtDiaChi_SV.Text.ToString();
				stu.Username = this.txtUsername_SV.Text.ToString();
				stu.Password = this.txtMatKhau_SV.Text.ToString();

				blAd.ThemSinhVien(stu);

				MessageBox.Show("Da them sinh vien");

				txtHoTenSV.ResetText();
				txtGioiTinh_SV.ResetText();
				txtSoDienThoai_SV.ResetText();
				txtDiaChi_SV.ResetText();
				txtMatKhau_SV.ResetText();
				txtUsername_SV.ResetText();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Loi",ex.Message);
			}
		}

        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            string path = @"D:\Report\course_report.txt";
            BL_Admin blAd = new BL_Admin();

            try
            {
                DataSet ds = blAd.ReportCourse();
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    using (TextWriter wrt = new StreamWriter(path))
                    {
                        int columnWidth = 20; // Chiều rộng cột
                        string separatorLine = new string('-', dt.Columns.Count * (columnWidth + 1)); // Dòng phân cách

                        // Define the format for each column in the header
                        string headerFormat = "{0,-" + columnWidth + "}\t{1,-" + columnWidth + "}\t{2,-" + columnWidth + "}\t{3,-" + columnWidth + "}\t{4,-" + columnWidth + "}";

                        // Apply the format to the header values
                        string header = string.Format(headerFormat, "Mã môn học", "Tên môn học", "Mã giáo viên", "Ngày bắt đầu", "Ngày kết thúc");

                        wrt.WriteLine(header);
                        wrt.WriteLine(separatorLine);

                        foreach (DataRow row in dt.Rows)
                        {
                            // Define the format for each column in the data row
                            string rowFormat = "{0,-" + columnWidth + "}\t{1,-" + columnWidth + "}\t{2,-" + columnWidth + "}\t{3,-" + columnWidth + "}\t{4,-" + columnWidth + "}";

                            // Apply the format to the data row values
                            string rowData = string.Format(rowFormat,
                                row["courseId"],
                                row["courseName"],
                                row["teacherId"],
                                ((DateTime)row["start_date"]).ToString("dd-MM-yyyy"),
                                ((DateTime)row["end_date"]).ToString("dd-MM-yyyy"));
                            wrt.WriteLine(rowData);
                            wrt.WriteLine(separatorLine);
                        }

                        MessageBox.Show("Ghi file thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để ghi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStudentReport_Click(object sender, EventArgs e)
        {
            string path = @"D:\Report\student_report.txt";
            BL_Admin blAd = new BL_Admin();

            try
            {
                DataSet dsStuReport = blAd.ReportStudent();
                DataTable dtStuReport = dsStuReport.Tables[0];

                if (dtStuReport.Rows.Count > 0)
                {
                    using (TextWriter wrt = new StreamWriter(path))
                    {
                        int columnWidth = 20; // Chiều rộng cột
                        string separatorLine = new string('-', dtStuReport.Columns.Count * (columnWidth + 1)); // Dòng phân cách

                        // Define the format for each column in the header
                        string headerFormat = "{0,-" + columnWidth + "}\t{1,-" + columnWidth + "}\t{2,-" + columnWidth + "}\t{3,-" + columnWidth + "}\t{4,-" + columnWidth + "}\t{5,-" + columnWidth + "}";

                        // Apply the format to the header values
                        string header = string.Format(headerFormat, "Mã sinh viên", "Họ và tên", "Ngày Sinh", "Giới tính", "Số điện thoại", "Địa chỉ");

                        wrt.WriteLine(header);
                        wrt.WriteLine(separatorLine);

                        foreach (DataRow row in dtStuReport.Rows)
                        {
                            // Define the format for each column in the data row
                            string rowFormat = "{0,-" + columnWidth + "}\t{1,-" + columnWidth + "}\t{2,-" + columnWidth + "}\t{3,-" + columnWidth + "}\t{4,-" + columnWidth + "}\t{5,-" + columnWidth + "}";

                            // Apply the format to the data row values
                            string rowData = string.Format(rowFormat,
                                row["studentId"],
                                row["fullName"],
                                ((DateTime)row["Birthday"]).ToString("dd-MM-yyyy"),
                                row["sex"],
                                row["phone"],
                                row["address"]);

                            wrt.WriteLine(rowData);
                            wrt.WriteLine(separatorLine);
                        }

                        MessageBox.Show("Ghi file thành công");
                    }


                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để ghi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGradeReport_Click(object sender, EventArgs e)
        {
            string path = @"D:\Report\grade_report.txt";
            BL_Admin blAd = new BL_Admin();

            try
            {
                DataSet ds = blAd.ReportGrade();
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    using (TextWriter wrt = new StreamWriter(path))
                    {
                        int columnWidth = 20; // Chiều rộng cột
                        string separatorLine = new string('-', dt.Columns.Count * (columnWidth + 1)); // Dòng phân cách

                        // Define the format for each column in the header
                        string headerFormat = "{0,-" + columnWidth + "}\t{1,-" + columnWidth + "}\t{2,-" + columnWidth + "}\t{3,-" + columnWidth + "}";

                        // Apply the format to the header values
                        string header = string.Format(headerFormat, "Mã môn học", "Tên môn học", "Họ tên học sinh", "Điểm");

                        wrt.WriteLine(header);
                        wrt.WriteLine(separatorLine);

                        foreach (DataRow row in dt.Rows)
                        {
                            // Define the format for each column in the data row
                            string rowFormat = "{0,-" + columnWidth + "}\t{1,-" + columnWidth + "}\t{2,-" + columnWidth + "}\t{3,-" + columnWidth + "}";

                            // Apply the format to the data row values
                            string rowData = string.Format(rowFormat,
                                row["courseId"],
                                row["courseName"],
                                row["fullName"],
                                row["grade"]);
                            wrt.WriteLine(rowData);
                            wrt.WriteLine(separatorLine);
                        }

                        MessageBox.Show("Ghi file thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để ghi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
