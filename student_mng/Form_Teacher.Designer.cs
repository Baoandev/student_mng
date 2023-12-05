namespace student_mng
{
	partial class Form_Teacher
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.cboMaMonHoc = new System.Windows.Forms.TabPage();
			this.label17 = new System.Windows.Forms.Label();
			this.lblUsername_gv = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaGiangVien_TimLop = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.dpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
			this.dpNgayBatDau = new System.Windows.Forms.DateTimePicker();
			this.dgvDanhSachLopHoc = new System.Windows.Forms.DataGridView();
			this.btnXoaMon = new System.Windows.Forms.Button();
			this.txtMaGiangVien = new System.Windows.Forms.TextBox();
			this.txtTenMonHoc = new System.Windows.Forms.TextBox();
			this.btnThemMonHoc = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblUsernameGv_2 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.cboMaLop_1 = new System.Windows.Forms.ComboBox();
			this.txtDiem = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.btnSearchListSinhVien = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.dgvListSinhVienTrong1Lop = new System.Windows.Forms.DataGridView();
			this.label11 = new System.Windows.Forms.Label();
			this.btnChamDiem = new System.Windows.Forms.Button();
			this.txtMaSinhVien_ChamDiem = new System.Windows.Forms.TextBox();
			this.txtMaLop_ChamDiem = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cboMaLop_Xoa = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.cboMaMonHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVienTrong1Lop)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.cboMaMonHoc);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(996, 585);
			this.tabControl1.TabIndex = 1;
			// 
			// cboMaMonHoc
			// 
			this.cboMaMonHoc.Controls.Add(this.cboMaLop_Xoa);
			this.cboMaMonHoc.Controls.Add(this.label17);
			this.cboMaMonHoc.Controls.Add(this.lblUsername_gv);
			this.cboMaMonHoc.Controls.Add(this.label2);
			this.cboMaMonHoc.Controls.Add(this.txtMaGiangVien_TimLop);
			this.cboMaMonHoc.Controls.Add(this.btnSearch);
			this.cboMaMonHoc.Controls.Add(this.label7);
			this.cboMaMonHoc.Controls.Add(this.dpNgayKetThuc);
			this.cboMaMonHoc.Controls.Add(this.dpNgayBatDau);
			this.cboMaMonHoc.Controls.Add(this.dgvDanhSachLopHoc);
			this.cboMaMonHoc.Controls.Add(this.btnXoaMon);
			this.cboMaMonHoc.Controls.Add(this.txtMaGiangVien);
			this.cboMaMonHoc.Controls.Add(this.txtTenMonHoc);
			this.cboMaMonHoc.Controls.Add(this.btnThemMonHoc);
			this.cboMaMonHoc.Controls.Add(this.label6);
			this.cboMaMonHoc.Controls.Add(this.label5);
			this.cboMaMonHoc.Controls.Add(this.label4);
			this.cboMaMonHoc.Controls.Add(this.label3);
			this.cboMaMonHoc.Controls.Add(this.label1);
			this.cboMaMonHoc.Location = new System.Drawing.Point(4, 22);
			this.cboMaMonHoc.Name = "cboMaMonHoc";
			this.cboMaMonHoc.Padding = new System.Windows.Forms.Padding(3);
			this.cboMaMonHoc.Size = new System.Drawing.Size(988, 559);
			this.cboMaMonHoc.TabIndex = 0;
			this.cboMaMonHoc.Text = "Lớp học";
			this.cboMaMonHoc.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(489, 14);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(124, 20);
			this.label17.TabIndex = 26;
			this.label17.Text = "Mã giảng viên:";
			// 
			// lblUsername_gv
			// 
			this.lblUsername_gv.AutoSize = true;
			this.lblUsername_gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername_gv.Location = new System.Drawing.Point(594, 14);
			this.lblUsername_gv.Name = "lblUsername_gv";
			this.lblUsername_gv.Size = new System.Drawing.Size(0, 20);
			this.lblUsername_gv.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 321);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nhập mã lớp cần xóa:";
			// 
			// txtMaGiangVien_TimLop
			// 
			this.txtMaGiangVien_TimLop.Location = new System.Drawing.Point(648, 55);
			this.txtMaGiangVien_TimLop.Name = "txtMaGiangVien_TimLop";
			this.txtMaGiangVien_TimLop.ReadOnly = true;
			this.txtMaGiangVien_TimLop.Size = new System.Drawing.Size(100, 20);
			this.txtMaGiangVien_TimLop.TabIndex = 21;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(796, 58);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 20;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(489, 58);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Các lớp của giảng viên:";
			// 
			// dpNgayKetThuc
			// 
			this.dpNgayKetThuc.Location = new System.Drawing.Point(114, 213);
			this.dpNgayKetThuc.Name = "dpNgayKetThuc";
			this.dpNgayKetThuc.Size = new System.Drawing.Size(200, 20);
			this.dpNgayKetThuc.TabIndex = 17;
			// 
			// dpNgayBatDau
			// 
			this.dpNgayBatDau.Location = new System.Drawing.Point(114, 165);
			this.dpNgayBatDau.Name = "dpNgayBatDau";
			this.dpNgayBatDau.Size = new System.Drawing.Size(200, 20);
			this.dpNgayBatDau.TabIndex = 16;
			// 
			// dgvDanhSachLopHoc
			// 
			this.dgvDanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachLopHoc.Location = new System.Drawing.Point(492, 99);
			this.dgvDanhSachLopHoc.Name = "dgvDanhSachLopHoc";
			this.dgvDanhSachLopHoc.RowHeadersWidth = 51;
			this.dgvDanhSachLopHoc.Size = new System.Drawing.Size(438, 393);
			this.dgvDanhSachLopHoc.TabIndex = 14;
			this.dgvDanhSachLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLopHoc_CellClick);
			this.dgvDanhSachLopHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLopHoc_CellContentClick);
			// 
			// btnXoaMon
			// 
			this.btnXoaMon.Location = new System.Drawing.Point(263, 319);
			this.btnXoaMon.Name = "btnXoaMon";
			this.btnXoaMon.Size = new System.Drawing.Size(75, 23);
			this.btnXoaMon.TabIndex = 12;
			this.btnXoaMon.Text = "Xóa";
			this.btnXoaMon.UseVisualStyleBackColor = true;
			this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
			// 
			// txtMaGiangVien
			// 
			this.txtMaGiangVien.Location = new System.Drawing.Point(114, 114);
			this.txtMaGiangVien.Name = "txtMaGiangVien";
			this.txtMaGiangVien.ReadOnly = true;
			this.txtMaGiangVien.Size = new System.Drawing.Size(100, 20);
			this.txtMaGiangVien.TabIndex = 9;
			// 
			// txtTenMonHoc
			// 
			this.txtTenMonHoc.Location = new System.Drawing.Point(114, 65);
			this.txtTenMonHoc.Name = "txtTenMonHoc";
			this.txtTenMonHoc.Size = new System.Drawing.Size(100, 20);
			this.txtTenMonHoc.TabIndex = 8;
			// 
			// btnThemMonHoc
			// 
			this.btnThemMonHoc.Location = new System.Drawing.Point(114, 257);
			this.btnThemMonHoc.Name = "btnThemMonHoc";
			this.btnThemMonHoc.Size = new System.Drawing.Size(75, 23);
			this.btnThemMonHoc.TabIndex = 6;
			this.btnThemMonHoc.Text = "Thêm";
			this.btnThemMonHoc.UseVisualStyleBackColor = true;
			this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 219);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ngày kết thúc:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày bắt đầu:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mã giảng viên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên môn học:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(48, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thêm môn học";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lblUsernameGv_2);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.cboMaLop_1);
			this.tabPage2.Controls.Add(this.txtDiem);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.btnSearchListSinhVien);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.dgvListSinhVienTrong1Lop);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.btnChamDiem);
			this.tabPage2.Controls.Add(this.txtMaSinhVien_ChamDiem);
			this.tabPage2.Controls.Add(this.txtMaLop_ChamDiem);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(988, 559);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chấm điểm";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lblUsernameGv_2
			// 
			this.lblUsernameGv_2.AutoSize = true;
			this.lblUsernameGv_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsernameGv_2.Location = new System.Drawing.Point(714, 30);
			this.lblUsernameGv_2.Name = "lblUsernameGv_2";
			this.lblUsernameGv_2.Size = new System.Drawing.Size(0, 24);
			this.lblUsernameGv_2.TabIndex = 26;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(567, 29);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(147, 24);
			this.label18.TabIndex = 25;
			this.label18.Text = "Mã giảng viên:";
			// 
			// cboMaLop_1
			// 
			this.cboMaLop_1.FormattingEnabled = true;
			this.cboMaLop_1.Location = new System.Drawing.Point(130, 277);
			this.cboMaLop_1.Name = "cboMaLop_1";
			this.cboMaLop_1.Size = new System.Drawing.Size(121, 21);
			this.cboMaLop_1.TabIndex = 24;
			this.cboMaLop_1.SelectionChangeCommitted += new System.EventHandler(this.cboMaLop_1_SelectionChangeCommitted);
			// 
			// txtDiem
			// 
			this.txtDiem.Location = new System.Drawing.Point(151, 171);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.Size = new System.Drawing.Size(100, 20);
			this.txtDiem.TabIndex = 23;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(49, 176);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(34, 13);
			this.label16.TabIndex = 22;
			this.label16.Text = "Điểm:";
			// 
			// btnSearchListSinhVien
			// 
			this.btnSearchListSinhVien.Location = new System.Drawing.Point(271, 275);
			this.btnSearchListSinhVien.Name = "btnSearchListSinhVien";
			this.btnSearchListSinhVien.Size = new System.Drawing.Size(75, 23);
			this.btnSearchListSinhVien.TabIndex = 20;
			this.btnSearchListSinhVien.Text = "SEARCH";
			this.btnSearchListSinhVien.UseVisualStyleBackColor = true;
			this.btnSearchListSinhVien.Click += new System.EventHandler(this.btnSearchListSinhVien_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(49, 280);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 13);
			this.label14.TabIndex = 18;
			this.label14.Text = "Mã lớp:";
			// 
			// dgvListSinhVienTrong1Lop
			// 
			this.dgvListSinhVienTrong1Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListSinhVienTrong1Lop.Location = new System.Drawing.Point(461, 100);
			this.dgvListSinhVienTrong1Lop.Name = "dgvListSinhVienTrong1Lop";
			this.dgvListSinhVienTrong1Lop.RowHeadersWidth = 51;
			this.dgvListSinhVienTrong1Lop.Size = new System.Drawing.Size(521, 395);
			this.dgvListSinhVienTrong1Lop.TabIndex = 17;
			this.dgvListSinhVienTrong1Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSinhVienTrong1Lop_CellClick);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(49, 239);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(253, 20);
			this.label11.TabIndex = 14;
			this.label11.Text = "Danh sách sinh viên của 1 lớp:";
			// 
			// btnChamDiem
			// 
			this.btnChamDiem.Location = new System.Drawing.Point(290, 171);
			this.btnChamDiem.Name = "btnChamDiem";
			this.btnChamDiem.Size = new System.Drawing.Size(75, 23);
			this.btnChamDiem.TabIndex = 9;
			this.btnChamDiem.Text = "OK";
			this.btnChamDiem.UseVisualStyleBackColor = true;
			this.btnChamDiem.Click += new System.EventHandler(this.btnChamDiem_Click);
			// 
			// txtMaSinhVien_ChamDiem
			// 
			this.txtMaSinhVien_ChamDiem.Location = new System.Drawing.Point(151, 129);
			this.txtMaSinhVien_ChamDiem.Name = "txtMaSinhVien_ChamDiem";
			this.txtMaSinhVien_ChamDiem.ReadOnly = true;
			this.txtMaSinhVien_ChamDiem.Size = new System.Drawing.Size(100, 20);
			this.txtMaSinhVien_ChamDiem.TabIndex = 8;
			// 
			// txtMaLop_ChamDiem
			// 
			this.txtMaLop_ChamDiem.Location = new System.Drawing.Point(151, 89);
			this.txtMaLop_ChamDiem.Name = "txtMaLop_ChamDiem";
			this.txtMaLop_ChamDiem.ReadOnly = true;
			this.txtMaLop_ChamDiem.Size = new System.Drawing.Size(100, 20);
			this.txtMaLop_ChamDiem.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(49, 129);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Mã sinh viên:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(49, 89);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 1;
			this.label9.Text = "Mã lớp:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(389, 29);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 25);
			this.label8.TabIndex = 0;
			this.label8.Text = "Chấm điểm";
			// 
			// cboMaLop_Xoa
			// 
			this.cboMaLop_Xoa.FormattingEnabled = true;
			this.cboMaLop_Xoa.Location = new System.Drawing.Point(125, 319);
			this.cboMaLop_Xoa.Name = "cboMaLop_Xoa";
			this.cboMaLop_Xoa.Size = new System.Drawing.Size(121, 21);
			this.cboMaLop_Xoa.TabIndex = 27;
			// 
			// Form_Teacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(996, 588);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form_Teacher";
			this.Text = "Giảng viên";
			this.Load += new System.EventHandler(this.Form_Teacher_Load);
			this.tabControl1.ResumeLayout(false);
			this.cboMaMonHoc.ResumeLayout(false);
			this.cboMaMonHoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVienTrong1Lop)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage cboMaMonHoc;
		private System.Windows.Forms.DataGridView dgvDanhSachLopHoc;
		private System.Windows.Forms.Button btnXoaMon;
		private System.Windows.Forms.TextBox txtMaGiangVien;
		private System.Windows.Forms.TextBox txtTenMonHoc;
		private System.Windows.Forms.Button btnThemMonHoc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DateTimePicker dpNgayKetThuc;
		private System.Windows.Forms.DateTimePicker dpNgayBatDau;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtMaGiangVien_TimLop;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnChamDiem;
		private System.Windows.Forms.TextBox txtMaSinhVien_ChamDiem;
		private System.Windows.Forms.TextBox txtMaLop_ChamDiem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnSearchListSinhVien;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dgvListSinhVienTrong1Lop;
		private System.Windows.Forms.TextBox txtDiem;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblUsername_gv;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.ComboBox cboMaLop_1;
		private System.Windows.Forms.Label lblUsernameGv_2;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cboMaLop_Xoa;
	}
}