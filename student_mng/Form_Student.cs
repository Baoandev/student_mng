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
	public partial class Form_Student : Form
	{
		
		DataTable dtCou = null;
		Bl_Student blStu = new Bl_Student();
		string err;
		public string StudentId { get; set; }
		public Form_Student()
		{
			InitializeComponent();
			LoadData();
		
		}
		private void Form_Student_Load(object sender, EventArgs e)
		{
			lblUsername_SV.Text = StudentId;
			txtMaSv.Text = StudentId;
		}

		public void loadMaSv()
		{
			string value = lblUsername_SV.Text;
			txtMaSv.Text = value;
		}
		public void LoadData()
		{
			try
			{
				dtCou = new DataTable();
				dtCou.Clear();
				DataSet ds = blStu.LayDataMonHoc();
				dtCou = ds.Tables[0];

				dgvDanhSachLop.DataSource = dtCou;
				dgvDanhSachLop.AutoResizeColumns();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Loi khong lay duoc noi dung", ex.Message);
			}
		}

		private void btnDangKi_Click(object sender, EventArgs e)
		{
			try
			{
				Bl_Student blStu = new Bl_Student();
				string maLop = this.txtMaLop.Text.ToString();
				string maSv = lblUsername_SV.Text.ToString();
				string diem = "0";

				// Kiểm tra kết quả từ hàm DangKiMon
				if (!blStu.DangKiMon(maLop, maSv, diem, ref err))
				{
					MessageBox.Show("Không đăng kí được: " + err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return; // Dừng lại nếu có lỗi
				}

				txtMaLop.ResetText();
				txtMaSv.ResetText();
				MessageBox.Show("Đã đăng kí");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không đăng kí được", ex.Message);
			}

		}

		private void dgvDanhSachLop_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvDanhSachLop.CurrentCell.RowIndex;

			if (dgvDanhSachLop.Rows[r].Cells[0].Value != null)
			{
				if (int.TryParse(dgvDanhSachLop.Rows[r].Cells[0].Value.ToString(), out int maLop))
				{
					this.txtMaLop.Text = maLop.ToString();
				}
				else
				{
					// Xử lý trường hợp giá trị không hợp lệ
					MessageBox.Show("Không có lớp học phần.");
				}
			}
			else
			{
				MessageBox.Show("Giá trị là null.");
			}
		}

		public void LoadMonHoc(string maSv)
		{
			try
			{
				
				Bl_Student blStu = new Bl_Student();
				dtCou = new DataTable();
				dtCou.Clear();
				DataSet ds = blStu.LayLopTuMaSV(maSv);
				dtCou = ds.Tables[0];

				dgvListLopCuaSinhVienDaDangKi.DataSource = dtCou;
				dgvListLopCuaSinhVienDaDangKi.AutoResizeColumns();

			}
			catch
			{
				MessageBox.Show("Lỗi!");
			}
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			LoadMonHoc(this.lblUsername_SV.Text.ToString());
		}

		private void btnXuatKetQua_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string filePath = saveFileDialog.FileName;

				using (StreamWriter writer = new StreamWriter(filePath))
				{
					for (int i = 0; i < dgvListLopCuaSinhVienDaDangKi.ColumnCount; i++)
					{
						writer.Write(dgvListLopCuaSinhVienDaDangKi.Columns[i].HeaderText);
						if (i < dgvListLopCuaSinhVienDaDangKi.ColumnCount - 1)
							writer.Write("\t");
						else
							writer.Write("\n");
					}

					// Ghi dữ liệu từ DataGridView
					for (int i = 0; i < dgvListLopCuaSinhVienDaDangKi.RowCount; i++)
					{
						for (int j = 0; j < dgvListLopCuaSinhVienDaDangKi.ColumnCount; j++)
						{
							writer.Write(dgvListLopCuaSinhVienDaDangKi.Rows[i].Cells[j].Value);
							if (j < dgvListLopCuaSinhVienDaDangKi.ColumnCount - 1)
								writer.Write("\t"); // Tách cột bằng dấu tab
							else
								writer.Write("\n"); // Xuống dòng sau khi ghi hết dữ liệu cột
						}
					}
				}

				MessageBox.Show("Dữ liệu đã được xuất ra tập tin thành công!");
			}
		}
	}
}
