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
			this.txtMaMonHoc_Xoa = new System.Windows.Forms.TextBox();
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
			this.txtDiem = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnSearchListSinhVien = new System.Windows.Forms.Button();
			this.txtMaLop_TimListSinhVien = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.dgvListSinhVienTrong1Lop = new System.Windows.Forms.DataGridView();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMaLop_Tim = new System.Windows.Forms.TextBox();
			this.txtMaSv_Tim = new System.Windows.Forms.TextBox();
			this.btnTimSinhVien = new System.Windows.Forms.Button();
			this.dgvLaySVTuEnroll = new System.Windows.Forms.DataGridView();
			this.btnChamDiem = new System.Windows.Forms.Button();
			this.txtMaSinhVien_ChamDiem = new System.Windows.Forms.TextBox();
			this.txtMaLop_ChamDiem = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.cboMaMonHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListSinhVienTrong1Lop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLaySVTuEnroll)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.cboMaMonHoc);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1328, 720);
			this.tabControl1.TabIndex = 1;
			// 
			// cboMaMonHoc
			// 
			this.cboMaMonHoc.Controls.Add(this.label17);
			this.cboMaMonHoc.Controls.Add(this.lblUsername_gv);
			this.cboMaMonHoc.Controls.Add(this.label2);
			this.cboMaMonHoc.Controls.Add(this.txtMaMonHoc_Xoa);
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
			this.cboMaMonHoc.Location = new System.Drawing.Point(4, 25);
			this.cboMaMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboMaMonHoc.Name = "cboMaMonHoc";
			this.cboMaMonHoc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cboMaMonHoc.Size = new System.Drawing.Size(1320, 691);
			this.cboMaMonHoc.TabIndex = 0;
			this.cboMaMonHoc.Text = "Lớp học";
			this.cboMaMonHoc.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(652, 17);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(122, 25);
			this.label17.TabIndex = 26;
			this.label17.Text = "Giảng viên:";
			// 
			// lblUsername_gv
			// 
			this.lblUsername_gv.AutoSize = true;
			this.lblUsername_gv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsername_gv.Location = new System.Drawing.Point(792, 17);
			this.lblUsername_gv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblUsername_gv.Name = "lblUsername_gv";
			this.lblUsername_gv.Size = new System.Drawing.Size(97, 25);
			this.lblUsername_gv.TabIndex = 25;
			this.lblUsername_gv.Text = "mmmmm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 395);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 16);
			this.label2.TabIndex = 23;
			this.label2.Text = "Nhập mã lớp cần xóa:";
			// 
			// txtMaMonHoc_Xoa
			// 
			this.txtMaMonHoc_Xoa.Location = new System.Drawing.Point(167, 391);
			this.txtMaMonHoc_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaMonHoc_Xoa.Name = "txtMaMonHoc_Xoa";
			this.txtMaMonHoc_Xoa.Size = new System.Drawing.Size(132, 22);
			this.txtMaMonHoc_Xoa.TabIndex = 22;
			// 
			// txtMaGiangVien_TimLop
			// 
			this.txtMaGiangVien_TimLop.Location = new System.Drawing.Point(864, 68);
			this.txtMaGiangVien_TimLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaGiangVien_TimLop.Name = "txtMaGiangVien_TimLop";
			this.txtMaGiangVien_TimLop.Size = new System.Drawing.Size(132, 22);
			this.txtMaGiangVien_TimLop.TabIndex = 21;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(1061, 71);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(100, 28);
			this.btnSearch.TabIndex = 20;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(652, 71);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Tìm lớp theo mã giảng viên:";
			// 
			// dpNgayKetThuc
			// 
			this.dpNgayKetThuc.Location = new System.Drawing.Point(152, 262);
			this.dpNgayKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dpNgayKetThuc.Name = "dpNgayKetThuc";
			this.dpNgayKetThuc.Size = new System.Drawing.Size(265, 22);
			this.dpNgayKetThuc.TabIndex = 17;
			// 
			// dpNgayBatDau
			// 
			this.dpNgayBatDau.Location = new System.Drawing.Point(152, 203);
			this.dpNgayBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dpNgayBatDau.Name = "dpNgayBatDau";
			this.dpNgayBatDau.Size = new System.Drawing.Size(265, 22);
			this.dpNgayBatDau.TabIndex = 16;
			// 
			// dgvDanhSachLopHoc
			// 
			this.dgvDanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachLopHoc.Location = new System.Drawing.Point(656, 122);
			this.dgvDanhSachLopHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvDanhSachLopHoc.Name = "dgvDanhSachLopHoc";
			this.dgvDanhSachLopHoc.RowHeadersWidth = 51;
			this.dgvDanhSachLopHoc.Size = new System.Drawing.Size(584, 484);
			this.dgvDanhSachLopHoc.TabIndex = 14;
			this.dgvDanhSachLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLopHoc_CellClick);
			// 
			// btnXoaMon
			// 
			this.btnXoaMon.Location = new System.Drawing.Point(319, 389);
			this.btnXoaMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnXoaMon.Name = "btnXoaMon";
			this.btnXoaMon.Size = new System.Drawing.Size(100, 28);
			this.btnXoaMon.TabIndex = 12;
			this.btnXoaMon.Text = "Xóa";
			this.btnXoaMon.UseVisualStyleBackColor = true;
			this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
			// 
			// txtMaGiangVien
			// 
			this.txtMaGiangVien.Location = new System.Drawing.Point(152, 140);
			this.txtMaGiangVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaGiangVien.Name = "txtMaGiangVien";
			this.txtMaGiangVien.ReadOnly = true;
			this.txtMaGiangVien.Size = new System.Drawing.Size(132, 22);
			this.txtMaGiangVien.TabIndex = 9;
			// 
			// txtTenMonHoc
			// 
			this.txtTenMonHoc.Location = new System.Drawing.Point(152, 80);
			this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTenMonHoc.Name = "txtTenMonHoc";
			this.txtTenMonHoc.Size = new System.Drawing.Size(132, 22);
			this.txtTenMonHoc.TabIndex = 8;
			// 
			// btnThemMonHoc
			// 
			this.btnThemMonHoc.Location = new System.Drawing.Point(152, 316);
			this.btnThemMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnThemMonHoc.Name = "btnThemMonHoc";
			this.btnThemMonHoc.Size = new System.Drawing.Size(100, 28);
			this.btnThemMonHoc.TabIndex = 6;
			this.btnThemMonHoc.Text = "Thêm";
			this.btnThemMonHoc.UseVisualStyleBackColor = true;
			this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 270);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 16);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ngày kết thúc:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 212);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày bắt đầu:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 149);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mã giảng viên:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 84);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên môn học:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thêm môn học";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.txtDiem);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.btnSearchListSinhVien);
			this.tabPage2.Controls.Add(this.txtMaLop_TimListSinhVien);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.dgvListSinhVienTrong1Lop);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label12);
			this.tabPage2.Controls.Add(this.label11);
			this.tabPage2.Controls.Add(this.txtMaLop_Tim);
			this.tabPage2.Controls.Add(this.txtMaSv_Tim);
			this.tabPage2.Controls.Add(this.btnTimSinhVien);
			this.tabPage2.Controls.Add(this.dgvLaySVTuEnroll);
			this.tabPage2.Controls.Add(this.btnChamDiem);
			this.tabPage2.Controls.Add(this.txtMaSinhVien_ChamDiem);
			this.tabPage2.Controls.Add(this.txtMaLop_ChamDiem);
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tabPage2.Size = new System.Drawing.Size(1320, 691);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Chấm điểm";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// txtDiem
			// 
			this.txtDiem.Location = new System.Drawing.Point(201, 210);
			this.txtDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDiem.Name = "txtDiem";
			this.txtDiem.Size = new System.Drawing.Size(132, 22);
			this.txtDiem.TabIndex = 23;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(65, 217);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 16);
			this.label16.TabIndex = 22;
			this.label16.Text = "Điểm:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(811, 94);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(139, 16);
			this.label15.TabIndex = 21;
			this.label15.Text = "Tìm sinh viên theo lớp:";
			// 
			// btnSearchListSinhVien
			// 
			this.btnSearchListSinhVien.Location = new System.Drawing.Point(361, 302);
			this.btnSearchListSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSearchListSinhVien.Name = "btnSearchListSinhVien";
			this.btnSearchListSinhVien.Size = new System.Drawing.Size(100, 28);
			this.btnSearchListSinhVien.TabIndex = 20;
			this.btnSearchListSinhVien.Text = "SEARCH";
			this.btnSearchListSinhVien.UseVisualStyleBackColor = true;
			this.btnSearchListSinhVien.Click += new System.EventHandler(this.btnSearchListSinhVien_Click);
			// 
			// txtMaLop_TimListSinhVien
			// 
			this.txtMaLop_TimListSinhVien.Location = new System.Drawing.Point(163, 298);
			this.txtMaLop_TimListSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaLop_TimListSinhVien.Name = "txtMaLop_TimListSinhVien";
			this.txtMaLop_TimListSinhVien.Size = new System.Drawing.Size(132, 22);
			this.txtMaLop_TimListSinhVien.TabIndex = 19;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(65, 302);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(51, 16);
			this.label14.TabIndex = 18;
			this.label14.Text = "Mã lớp:";
			// 
			// dgvListSinhVienTrong1Lop
			// 
			this.dgvListSinhVienTrong1Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListSinhVienTrong1Lop.Location = new System.Drawing.Point(69, 336);
			this.dgvListSinhVienTrong1Lop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvListSinhVienTrong1Lop.Name = "dgvListSinhVienTrong1Lop";
			this.dgvListSinhVienTrong1Lop.RowHeadersWidth = 51;
			this.dgvListSinhVienTrong1Lop.Size = new System.Drawing.Size(560, 306);
			this.dgvListSinhVienTrong1Lop.TabIndex = 17;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(811, 193);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(84, 16);
			this.label13.TabIndex = 16;
			this.label13.Text = "Mã sinh viên:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(811, 140);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(51, 16);
			this.label12.TabIndex = 15;
			this.label12.Text = "Mã lớp:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(65, 260);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(186, 16);
			this.label11.TabIndex = 14;
			this.label11.Text = "Danh sách sinh viên của 1 lớp:";
			// 
			// txtMaLop_Tim
			// 
			this.txtMaLop_Tim.Location = new System.Drawing.Point(941, 132);
			this.txtMaLop_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaLop_Tim.Name = "txtMaLop_Tim";
			this.txtMaLop_Tim.Size = new System.Drawing.Size(132, 22);
			this.txtMaLop_Tim.TabIndex = 13;
			// 
			// txtMaSv_Tim
			// 
			this.txtMaSv_Tim.Location = new System.Drawing.Point(941, 193);
			this.txtMaSv_Tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaSv_Tim.Name = "txtMaSv_Tim";
			this.txtMaSv_Tim.Size = new System.Drawing.Size(132, 22);
			this.txtMaSv_Tim.TabIndex = 12;
			// 
			// btnTimSinhVien
			// 
			this.btnTimSinhVien.Location = new System.Drawing.Point(1131, 191);
			this.btnTimSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTimSinhVien.Name = "btnTimSinhVien";
			this.btnTimSinhVien.Size = new System.Drawing.Size(100, 28);
			this.btnTimSinhVien.TabIndex = 11;
			this.btnTimSinhVien.Text = "SEARCH";
			this.btnTimSinhVien.UseVisualStyleBackColor = true;
			this.btnTimSinhVien.Click += new System.EventHandler(this.btnTimSinhVien_Click);
			// 
			// dgvLaySVTuEnroll
			// 
			this.dgvLaySVTuEnroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLaySVTuEnroll.Location = new System.Drawing.Point(747, 336);
			this.dgvLaySVTuEnroll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvLaySVTuEnroll.Name = "dgvLaySVTuEnroll";
			this.dgvLaySVTuEnroll.RowHeadersWidth = 51;
			this.dgvLaySVTuEnroll.Size = new System.Drawing.Size(560, 306);
			this.dgvLaySVTuEnroll.TabIndex = 10;
			// 
			// btnChamDiem
			// 
			this.btnChamDiem.Location = new System.Drawing.Point(387, 210);
			this.btnChamDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnChamDiem.Name = "btnChamDiem";
			this.btnChamDiem.Size = new System.Drawing.Size(100, 28);
			this.btnChamDiem.TabIndex = 9;
			this.btnChamDiem.Text = "OK";
			this.btnChamDiem.UseVisualStyleBackColor = true;
			this.btnChamDiem.Click += new System.EventHandler(this.btnChamDiem_Click);
			// 
			// txtMaSinhVien_ChamDiem
			// 
			this.txtMaSinhVien_ChamDiem.Location = new System.Drawing.Point(201, 159);
			this.txtMaSinhVien_ChamDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaSinhVien_ChamDiem.Name = "txtMaSinhVien_ChamDiem";
			this.txtMaSinhVien_ChamDiem.Size = new System.Drawing.Size(132, 22);
			this.txtMaSinhVien_ChamDiem.TabIndex = 8;
			// 
			// txtMaLop_ChamDiem
			// 
			this.txtMaLop_ChamDiem.Location = new System.Drawing.Point(201, 110);
			this.txtMaLop_ChamDiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtMaLop_ChamDiem.Name = "txtMaLop_ChamDiem";
			this.txtMaLop_ChamDiem.Size = new System.Drawing.Size(132, 22);
			this.txtMaLop_ChamDiem.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(65, 159);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(84, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "Mã sinh viên:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(65, 110);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 16);
			this.label9.TabIndex = 1;
			this.label9.Text = "Mã lớp:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(519, 36);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 31);
			this.label8.TabIndex = 0;
			this.label8.Text = "Chấm điểm";
			// 
			// Form_Teacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1328, 724);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
			((System.ComponentModel.ISupportInitialize)(this.dgvLaySVTuEnroll)).EndInit();
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
		private System.Windows.Forms.TextBox txtMaMonHoc_Xoa;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvLaySVTuEnroll;
		private System.Windows.Forms.Button btnChamDiem;
		private System.Windows.Forms.TextBox txtMaSinhVien_ChamDiem;
		private System.Windows.Forms.TextBox txtMaLop_ChamDiem;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMaLop_Tim;
		private System.Windows.Forms.TextBox txtMaSv_Tim;
		private System.Windows.Forms.Button btnTimSinhVien;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnSearchListSinhVien;
		private System.Windows.Forms.TextBox txtMaLop_TimListSinhVien;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dgvListSinhVienTrong1Lop;
		private System.Windows.Forms.TextBox txtDiem;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lblUsername_gv;
		private System.Windows.Forms.Label label17;
	}
}