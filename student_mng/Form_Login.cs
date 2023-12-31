﻿using student_mng.BL;
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
	public partial class Form_Login : Form
	{
		BL_Teacher blTea = null;
		DataTable dtStudent = null;
		DataTable dtTeacher = null;
		DataTable dtAdmin = null;
		string err;
		public string maGv { get; private set; }
		public string maSv { get; private set; }
		public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }

		private string taiKhoan;
		public Form_Login()
		{
			InitializeComponent();
			blTea = new BL_Teacher();
		}

		private void btnDangNhap_Sv_Click(object sender, EventArgs e)
		{
			try
			{
				Bl_Student blStudent = new Bl_Student();
				Student stu = new Student();
				bool check = false;
				dtStudent = new DataTable();
				dtStudent.Clear();
				DataSet ds = blStudent.DangNhap(this.txtTaiKhoan_Hs.Text.ToString());
				dtStudent = ds.Tables[0];
                string mk = dtStudent.Rows[0][2].ToString();
                string id = dtStudent.Rows[0][0].ToString();
                if (mk == txtMatKhau_Hs.Text.ToString())
				{
					check = true;
					stu.StudentId= id;
				}
				if (check == true)
				{
					Form_Student formStudent = new Form_Student();
					formStudent.StudentId= stu.StudentId;
					this.Visible = false;
					formStudent.ShowDialog();
					this.Visible = true;
				}
				if (check == false)
				{
					MessageBox.Show("Không đăng nhập được");

				}
			}
			catch
			{
				MessageBox.Show("Không đăng nhập được");
			}
		}



		private void txtMatKhau_Hs_TextChanged(object sender, EventArgs e)
		{
			txtMatKhau_Hs.PasswordChar = '*';
		}

		private void txtMatKhau_Gv_TextChanged(object sender, EventArgs e)
		{
			txtMatKhau_Gv.PasswordChar= '*';
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			try
			{
				BL_Teacher blTeacher = new BL_Teacher();
				Teacher tea = new Teacher();
				bool check = false;
				dtTeacher = new DataTable();
				dtTeacher.Clear();
				DataSet ds = blTeacher.DangNhap(this.txtTaiKhoan_Gv.Text.ToString());
				dtTeacher = ds.Tables[0];
				string mk = dtTeacher.Rows[0][2].ToString();
				string id = dtTeacher.Rows[0][0].ToString();
				if (mk == txtMatKhau_Gv.Text.ToString())
				{
					tea.TeacherId = id;
					check = true;
				}
				if (check == true)
				{
					Form_Teacher formTeacher = new Form_Teacher();
					formTeacher.AccountId = tea.TeacherId;
					this.Visible = false;
					formTeacher.ShowDialog();
					this.Visible = true;
				}
				if (check == false)
				{
					MessageBox.Show("Không đăng nhập được");

				}
			}
			catch
			{
				MessageBox.Show("Không đăng nhập được");
			}
			
		}

		private void btnDangNhap_admin_Click(object sender, EventArgs e)
		{
			BL_Admin blAd = new BL_Admin();
			bool check = false;
			dtAdmin = new DataTable();
			dtAdmin.Clear();
			DataSet ds = blAd.DangNhap(this.txtTaiKhoan_admin.Text.ToString());
			dtAdmin = ds.Tables[0];
			string mk = dtAdmin.Rows[0][2].ToString();
			if (mk == txtMatKhau_admin.Text.ToString())
			{
				check = true;
			}
			if (check == true)
			{
				Form_Admin formad =	new Form_Admin();
				this.Visible = false;
				formad.ShowDialog();
				this.Visible = true;
			}
			if (check == false)
			{
				MessageBox.Show("Không đăng nhập được");

			}

		}

		private void txtMatKhau_admin_TextChanged(object sender, EventArgs e)
		{
			txtMatKhau_admin.PasswordChar = '*';
		}
	}
}
