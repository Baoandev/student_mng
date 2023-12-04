namespace student_mng
{
	partial class Form_Student
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername_SV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnDangKi = new System.Windows.Forms.Button();
            this.dgvListLopCuaSinhVienDaDangKi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnXuatKetQua = new System.Windows.Forms.Button();
            this.btStudentDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLopCuaSinhVienDaDangKi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(872, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            // 
            // lblUsername_SV
            // 
            this.lblUsername_SV.AutoSize = true;
            this.lblUsername_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername_SV.Location = new System.Drawing.Point(1057, 29);
            this.lblUsername_SV.Name = "lblUsername_SV";
            this.lblUsername_SV.Size = new System.Drawing.Size(0, 29);
            this.lblUsername_SV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đăng kí môn";
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(14, 165);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.RowHeadersWidth = 51;
            this.dgvDanhSachLop.RowTemplate.Height = 24;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(824, 437);
            this.dgvDanhSachLop.TabIndex = 4;
            this.dgvDanhSachLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã lớp:";
            // 
            // txtMaSv
            // 
            this.txtMaSv.Location = new System.Drawing.Point(243, 620);
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.ReadOnly = true;
            this.txtMaSv.Size = new System.Drawing.Size(112, 26);
            this.txtMaSv.TabIndex = 7;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(243, 689);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(112, 26);
            this.txtMaLop.TabIndex = 8;
            // 
            // btnDangKi
            // 
            this.btnDangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKi.Location = new System.Drawing.Point(93, 732);
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(116, 45);
            this.btnDangKi.TabIndex = 9;
            this.btnDangKi.Text = "Đăng kí";
            this.btnDangKi.UseVisualStyleBackColor = true;
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // dgvListLopCuaSinhVienDaDangKi
            // 
            this.dgvListLopCuaSinhVienDaDangKi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLopCuaSinhVienDaDangKi.Location = new System.Drawing.Point(878, 165);
            this.dgvListLopCuaSinhVienDaDangKi.Name = "dgvListLopCuaSinhVienDaDangKi";
            this.dgvListLopCuaSinhVienDaDangKi.RowHeadersWidth = 51;
            this.dgvListLopCuaSinhVienDaDangKi.RowTemplate.Height = 24;
            this.dgvListLopCuaSinhVienDaDangKi.Size = new System.Drawing.Size(582, 437);
            this.dgvListLopCuaSinhVienDaDangKi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(870, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 38);
            this.label5.TabIndex = 11;
            this.label5.Text = "Các lớp đã đăng kí";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(1320, 109);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(116, 45);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnXuatKetQua
            // 
            this.btnXuatKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatKetQua.Location = new System.Drawing.Point(878, 649);
            this.btnXuatKetQua.Name = "btnXuatKetQua";
            this.btnXuatKetQua.Size = new System.Drawing.Size(292, 45);
            this.btnXuatKetQua.TabIndex = 13;
            this.btnXuatKetQua.Text = "Xuất kết quả đăng kí";
            this.btnXuatKetQua.UseVisualStyleBackColor = true;
            this.btnXuatKetQua.Click += new System.EventHandler(this.btnXuatKetQua_Click);
            // 
            // btStudentDetail
            // 
            this.btStudentDetail.Location = new System.Drawing.Point(1287, 24);
            this.btStudentDetail.Name = "btStudentDetail";
            this.btStudentDetail.Size = new System.Drawing.Size(149, 44);
            this.btStudentDetail.TabIndex = 14;
            this.btStudentDetail.Text = "Xem thông tin";
            this.btStudentDetail.UseVisualStyleBackColor = true;
            this.btStudentDetail.Click += new System.EventHandler(this.btStudentDetail_Click);
            // 
            // Form_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 842);
            this.Controls.Add(this.btStudentDetail);
            this.Controls.Add(this.btnXuatKetQua);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListLopCuaSinhVienDaDangKi);
            this.Controls.Add(this.btnDangKi);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txtMaSv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDanhSachLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername_SV);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_Student";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.Form_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLopCuaSinhVienDaDangKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUsername_SV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvDanhSachLop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMaSv;
		private System.Windows.Forms.TextBox txtMaLop;
		private System.Windows.Forms.Button btnDangKi;
		private System.Windows.Forms.DataGridView dgvListLopCuaSinhVienDaDangKi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnShow;
		private System.Windows.Forms.Button btnXuatKetQua;
        private System.Windows.Forms.Button btStudentDetail;
    }
}