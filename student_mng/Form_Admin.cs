using student_mng.BL;
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
	}
}
