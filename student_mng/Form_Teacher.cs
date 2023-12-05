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
		DataTable dtStudent = null;
		BL_Teacher blTea = new BL_Teacher();
		Teacher tea = new Teacher();
		public string AccountId { get; set; }
		
		public Form_Teacher()
		{
			InitializeComponent();

		}

		private void Form_Teacher_Load(object sender, EventArgs e)
		{
			lblUsername_gv.Text = AccountId;
			txtMaGiangVien_TimLop.Text= AccountId;
			lblUsernameGv_2.Text= AccountId;
			loadMaLop();
			loadMaLop_Xoa();
		}

		private void btnThemMonHoc_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrWhiteSpace(this.txtTenMonHoc.Text)|| string.IsNullOrEmpty(this.txtTenMonHoc.Text))
				{
					MessageBox.Show("Tên môn học không được để trống");
					return;
				}
				if (int.TryParse(lblUsername_gv.Text, out int teacherId))
				{
					BL_Course blCou = new BL_Course();
					Course cou = new Course();
					cou.CourseName = txtTenMonHoc.Text;
					cou.TeacherId = teacherId;
					cou.NgayBatDau = dpNgayBatDau.Value;
					cou.NgayKetThuc = dpNgayKetThuc.Value;
					
					blCou.ThemMonHoc(cou);

					txtMaGiangVien.ResetText();
					txtTenMonHoc.ResetText();
					MessageBox.Show("Đã thêm môn học");
				}
				else
				{
					MessageBox.Show("Giá trị TeacherId không hợp lệ.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không thêm được. Lỗi: " + ex.Message);
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

		

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadMonHoc(this.txtMaGiangVien_TimLop.Text.ToString());
			loadMaLop();
			loadMaLop_Xoa();
		}

		private void dgvDanhSachLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvDanhSachLopHoc.CurrentCell.RowIndex;
			int maMH = (int)dgvDanhSachLopHoc.Rows[r].Cells[0].Value;
			//this.txtMaMonHoc_Xoa.Text = maMH.ToString();

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
					blCou.XoaMon(ref err, this.cboMaLop_Xoa.Text.ToString());
					blCou.XoaMonHoc(ref err, this.cboMaLop_Xoa.Text.ToString());
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

		
	
		public void LoadListSinhVien(string maLop)
		{
			try
			{
				BL_Teacher blTea = new BL_Teacher();
				dtStudent = new DataTable();
				dtStudent.Clear();
				DataSet ds = blTea.TimListSinhVien(maLop);
				dtStudent = ds.Tables[0];

				dgvListSinhVienTrong1Lop.DataSource = dtStudent;
				dgvListSinhVienTrong1Lop.AutoResizeColumns();

			}
			catch(Exception ex)
			{
				MessageBox.Show("loi",ex.Message);
			}
		}

		private void btnSearchListSinhVien_Click(object sender, EventArgs e)
		{
			LoadListSinhVien(this.cboMaLop_1.Text.ToString());
		}

		private void btnChamDiem_Click(object sender, EventArgs e)
		{
			try
			{
				if (string.IsNullOrEmpty(this.txtMaLop_ChamDiem.Text) || string.IsNullOrWhiteSpace(this.txtMaLop_ChamDiem.Text))
				{
					MessageBox.Show("Mã lớp không được để trống");
					return;
				}
	
				BL_Teacher blTea = new BL_Teacher();
				Grade gr = new Grade();
				gr.MaLop = this.txtMaLop_ChamDiem.Text.ToString();
				gr.MaSv = this.txtMaSinhVien_ChamDiem.Text.ToString();
				gr.Diem = int.Parse(this.txtDiem.Text);
				if (gr.Diem < 0)
				{
					MessageBox.Show("Không được nhập điểm âm");
					return;
				}
				blTea.ChamDiem(gr);

				MessageBox.Show("Da cham diem cho sinh vien");

				txtMaLop_ChamDiem.ResetText();
				txtMaSinhVien_ChamDiem.ResetText();
				txtDiem.ResetText();

			}
			catch(Exception ex)
			{
				MessageBox.Show("Khong cham diem duoc", ex.Message);
			}
		}
		public void loadMaLop()
		{
			DataTable dataTable = new DataTable();
			BL_Teacher bLTea = new BL_Teacher();
			string maGv = this.lblUsernameGv_2.Text;
			dataTable = blTea.ThongTinLop(maGv);

			cboMaLop_1.DataSource = dataTable;
			cboMaLop_1.DisplayMember = "courseId";
			cboMaLop_1.ValueMember = "courseId";
		}
		public void loadMaLop_Xoa()
		{
			DataTable dataTable = new DataTable();
			BL_Teacher bLTea = new BL_Teacher();
			string maGv = this.lblUsername_gv.Text;
			dataTable = blTea.ThongTinLop(maGv);

			cboMaLop_Xoa.DataSource = dataTable;
			cboMaLop_Xoa.DisplayMember = "courseId";
			cboMaLop_Xoa.ValueMember = "courseId";
		}

		private void dgvListSinhVienTrong1Lop_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvListSinhVienTrong1Lop.CurrentCell.RowIndex;
			this.txtDiem.Text = Convert.ToSingle(dgvListSinhVienTrong1Lop.Rows[r].Cells[0].Value).ToString();
			this.txtMaSinhVien_ChamDiem.Text = Convert.ToSingle(dgvListSinhVienTrong1Lop.Rows[r].Cells[1].Value).ToString();
		}
	}
}
