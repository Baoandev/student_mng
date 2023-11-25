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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.cboMaMonHoc = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnThemMonHoc = new System.Windows.Forms.Button();
			this.txtTenMonHoc = new System.Windows.Forms.TextBox();
			this.txtMaGiangVien = new System.Windows.Forms.TextBox();
			this.btnXoaMon = new System.Windows.Forms.Button();
			this.dgvDanhSachLopHoc = new System.Windows.Forms.DataGridView();
			this.dpNgayBatDau = new System.Windows.Forms.DateTimePicker();
			this.dpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtMaGiangVien_TimLop = new System.Windows.Forms.TextBox();
			this.txtMaMonHoc_Xoa = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.cboMaMonHoc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.cboMaMonHoc);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1076, 630);
			this.tabControl1.TabIndex = 1;
			// 
			// cboMaMonHoc
			// 
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
			this.cboMaMonHoc.Location = new System.Drawing.Point(4, 22);
			this.cboMaMonHoc.Name = "cboMaMonHoc";
			this.cboMaMonHoc.Padding = new System.Windows.Forms.Padding(3);
			this.cboMaMonHoc.Size = new System.Drawing.Size(1068, 604);
			this.cboMaMonHoc.TabIndex = 0;
			this.cboMaMonHoc.Text = "tabPage1";
			this.cboMaMonHoc.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 74);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(44, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Thêm môn học";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tên môn học:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mã giảng viên:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày bắt đầu:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ngày kết thúc:";
			// 
			// btnThemMonHoc
			// 
			this.btnThemMonHoc.Location = new System.Drawing.Point(11, 228);
			this.btnThemMonHoc.Name = "btnThemMonHoc";
			this.btnThemMonHoc.Size = new System.Drawing.Size(75, 23);
			this.btnThemMonHoc.TabIndex = 6;
			this.btnThemMonHoc.Text = "Thêm";
			this.btnThemMonHoc.UseVisualStyleBackColor = true;
			this.btnThemMonHoc.Click += new System.EventHandler(this.btnThemMonHoc_Click);
			// 
			// txtTenMonHoc
			// 
			this.txtTenMonHoc.Location = new System.Drawing.Point(114, 58);
			this.txtTenMonHoc.Name = "txtTenMonHoc";
			this.txtTenMonHoc.Size = new System.Drawing.Size(100, 20);
			this.txtTenMonHoc.TabIndex = 8;
			// 
			// txtMaGiangVien
			// 
			this.txtMaGiangVien.Location = new System.Drawing.Point(114, 99);
			this.txtMaGiangVien.Name = "txtMaGiangVien";
			this.txtMaGiangVien.Size = new System.Drawing.Size(100, 20);
			this.txtMaGiangVien.TabIndex = 9;
			// 
			// btnXoaMon
			// 
			this.btnXoaMon.Location = new System.Drawing.Point(114, 228);
			this.btnXoaMon.Name = "btnXoaMon";
			this.btnXoaMon.Size = new System.Drawing.Size(75, 23);
			this.btnXoaMon.TabIndex = 12;
			this.btnXoaMon.Text = "Xóa";
			this.btnXoaMon.UseVisualStyleBackColor = true;
			this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
			// 
			// dgvDanhSachLopHoc
			// 
			this.dgvDanhSachLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachLopHoc.Location = new System.Drawing.Point(11, 317);
			this.dgvDanhSachLopHoc.Name = "dgvDanhSachLopHoc";
			this.dgvDanhSachLopHoc.Size = new System.Drawing.Size(455, 280);
			this.dgvDanhSachLopHoc.TabIndex = 14;
			this.dgvDanhSachLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLopHoc_CellClick);
			// 
			// dpNgayBatDau
			// 
			this.dpNgayBatDau.Location = new System.Drawing.Point(114, 142);
			this.dpNgayBatDau.Name = "dpNgayBatDau";
			this.dpNgayBatDau.Size = new System.Drawing.Size(200, 20);
			this.dpNgayBatDau.TabIndex = 16;
			// 
			// dpNgayKetThuc
			// 
			this.dpNgayKetThuc.Location = new System.Drawing.Point(114, 183);
			this.dpNgayKetThuc.Name = "dpNgayKetThuc";
			this.dpNgayKetThuc.Size = new System.Drawing.Size(200, 20);
			this.dpNgayKetThuc.TabIndex = 17;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 288);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Tìm lớp theo mã giảng viên:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(323, 288);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 20;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtMaGiangVien_TimLop
			// 
			this.txtMaGiangVien_TimLop.Location = new System.Drawing.Point(188, 288);
			this.txtMaGiangVien_TimLop.Name = "txtMaGiangVien_TimLop";
			this.txtMaGiangVien_TimLop.Size = new System.Drawing.Size(100, 20);
			this.txtMaGiangVien_TimLop.TabIndex = 21;
			// 
			// txtMaMonHoc_Xoa
			// 
			this.txtMaMonHoc_Xoa.Location = new System.Drawing.Point(214, 231);
			this.txtMaMonHoc_Xoa.Name = "txtMaMonHoc_Xoa";
			this.txtMaMonHoc_Xoa.Size = new System.Drawing.Size(100, 20);
			this.txtMaMonHoc_Xoa.TabIndex = 22;
			// 
			// Form_Teacher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 631);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form_Teacher";
			this.Text = "Giảng viên";
			this.Load += new System.EventHandler(this.Form_Teacher_Load);
			this.tabControl1.ResumeLayout(false);
			this.cboMaMonHoc.ResumeLayout(false);
			this.cboMaMonHoc.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLopHoc)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
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
	}
}