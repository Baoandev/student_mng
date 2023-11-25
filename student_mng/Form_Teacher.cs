using student_mng.BL;
using student_mng.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_mng
{
	public partial class Form_Teacher : Form
	{
		DataTable dtCourse = null;
		string err;
		public Form_Teacher()
		{
			InitializeComponent();
			//LoadMaGiangVien();
		}

		private void Form_Teacher_Load(object sender, EventArgs e)
		{

		}

		private void btnThemMonHoc_Click(object sender, EventArgs e)
		{
			try
			{
				BL_Course blCou = new BL_Course();
				Course cou = new Course();
				cou.CourseName = txtTenMonHoc.Text.ToString();
				cou.TeacherId = int.Parse(txtMaGiangVien.Text);
				cou.NgayBatDau = dpNgayBatDau.Value;
				cou.NgayKetThuc = dpNgayKetThuc.Value;

				blCou.ThemMonHoc(cou);

				txtMaGiangVien.ResetText();
				txtTenMonHoc.ResetText();
				MessageBox.Show("Đã thêm môn học");
			}
			catch
			{
				MessageBox.Show("Không thêm được");
			}
		}
		public void LoadMonHoc(string maGv)
		{
			try
			{
				BL_Course blCou = new BL_Course();
				dtCourse= new DataTable();
				dtCourse.Clear();
				DataSet ds = blCou.TimMonHocTheoMaGiangVien(maGv);
				dtCourse = ds.Tables[0];

				dgvDanhSachLopHoc.DataSource = dtCourse;
				dgvDanhSachLopHoc.AutoResizeColumns();

			}
			catch
			{
				MessageBox.Show("loi");
			}
		}
		
		/*public void LoadMaGiangVien()
		{
			DataTable dt = new DataTable();
			BL_Course bLCou = new BL_Course();
			dt = bLCou.layMaGiangVien();
			foreach (DataRow dr in dt.Rows)
			{
				cboMaGiangVien_TimMon.Items.Add(dr["teacherId"].ToString());
			}
		}*/

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadMonHoc(this.txtMaGiangVien_TimLop.Text.ToString());
		}

		private void dgvDanhSachLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvDanhSachLopHoc.CurrentCell.RowIndex;
			int maMH = (int)dgvDanhSachLopHoc.Rows[r].Cells[0].Value;
			this.txtMaMonHoc_Xoa.Text = maMH.ToString();

		}

		private void btnXoaMon_Click(object sender, EventArgs e)
		{
			try
			{
				BL_Course blCou = new BL_Course();
				DialogResult traloi;
				traloi = MessageBox.Show("Chắc xóa môn học này không?", "Trả lời",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (traloi == DialogResult.Yes)
				{
					blCou.XoaMonHoc(ref err, this.txtMaMonHoc_Xoa.Text.ToString());

					MessageBox.Show("Đã xóa xong!");
				}
				else
				{
					MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Không xóa được. Lỗi rồi!");
			}
		}
	}
}
