namespace student_mng
{
	partial class Form_Login
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.txtMatKhau_Gv = new System.Windows.Forms.TextBox();
			this.txtTaiKhoan_Gv = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnDangNhap_Sv = new System.Windows.Forms.Button();
			this.txtMatKhau_Hs = new System.Windows.Forms.TextBox();
			this.txtTaiKhoan_Hs = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnDangNhap_admin = new System.Windows.Forms.Button();
			this.txtMatKhau_admin = new System.Windows.Forms.TextBox();
			this.txtTaiKhoan_admin = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(2, 1);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(598, 363);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.CadetBlue;
			this.tabPage1.Controls.Add(this.btnDangNhap);
			this.tabPage1.Controls.Add(this.txtMatKhau_Gv);
			this.tabPage1.Controls.Add(this.txtTaiKhoan_Gv);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(590, 337);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Giảng viên";
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap.Location = new System.Drawing.Point(124, 152);
			this.btnDangNhap.Margin = new System.Windows.Forms.Padding(2);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(122, 29);
			this.btnDangNhap.TabIndex = 6;
			this.btnDangNhap.Text = "Đăng nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// txtMatKhau_Gv
			// 
			this.txtMatKhau_Gv.Location = new System.Drawing.Point(124, 114);
			this.txtMatKhau_Gv.Margin = new System.Windows.Forms.Padding(2);
			this.txtMatKhau_Gv.Name = "txtMatKhau_Gv";
			this.txtMatKhau_Gv.Size = new System.Drawing.Size(170, 20);
			this.txtMatKhau_Gv.TabIndex = 5;
			this.txtMatKhau_Gv.TextChanged += new System.EventHandler(this.txtMatKhau_Gv_TextChanged);
			// 
			// txtTaiKhoan_Gv
			// 
			this.txtTaiKhoan_Gv.Location = new System.Drawing.Point(124, 72);
			this.txtTaiKhoan_Gv.Margin = new System.Windows.Forms.Padding(2);
			this.txtTaiKhoan_Gv.Name = "txtTaiKhoan_Gv";
			this.txtTaiKhoan_Gv.Size = new System.Drawing.Size(170, 20);
			this.txtTaiKhoan_Gv.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(20, 111);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(20, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Username:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(227, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "TEACHER";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.CadetBlue;
			this.tabPage2.Controls.Add(this.btnDangNhap_Sv);
			this.tabPage2.Controls.Add(this.txtMatKhau_Hs);
			this.tabPage2.Controls.Add(this.txtTaiKhoan_Hs);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage2.Size = new System.Drawing.Size(590, 337);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Sinh viên";
			// 
			// btnDangNhap_Sv
			// 
			this.btnDangNhap_Sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap_Sv.Location = new System.Drawing.Point(133, 161);
			this.btnDangNhap_Sv.Margin = new System.Windows.Forms.Padding(2);
			this.btnDangNhap_Sv.Name = "btnDangNhap_Sv";
			this.btnDangNhap_Sv.Size = new System.Drawing.Size(105, 29);
			this.btnDangNhap_Sv.TabIndex = 7;
			this.btnDangNhap_Sv.Text = "Đăng nhập";
			this.btnDangNhap_Sv.UseVisualStyleBackColor = true;
			this.btnDangNhap_Sv.Click += new System.EventHandler(this.btnDangNhap_Sv_Click);
			// 
			// txtMatKhau_Hs
			// 
			this.txtMatKhau_Hs.Location = new System.Drawing.Point(133, 115);
			this.txtMatKhau_Hs.Margin = new System.Windows.Forms.Padding(2);
			this.txtMatKhau_Hs.Name = "txtMatKhau_Hs";
			this.txtMatKhau_Hs.Size = new System.Drawing.Size(170, 20);
			this.txtMatKhau_Hs.TabIndex = 6;
			this.txtMatKhau_Hs.TextChanged += new System.EventHandler(this.txtMatKhau_Hs_TextChanged);
			// 
			// txtTaiKhoan_Hs
			// 
			this.txtTaiKhoan_Hs.Location = new System.Drawing.Point(133, 74);
			this.txtTaiKhoan_Hs.Margin = new System.Windows.Forms.Padding(2);
			this.txtTaiKhoan_Hs.Name = "txtTaiKhoan_Hs";
			this.txtTaiKhoan_Hs.Size = new System.Drawing.Size(170, 20);
			this.txtTaiKhoan_Hs.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(22, 111);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 20);
			this.label6.TabIndex = 4;
			this.label6.Text = "Password:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(19, 71);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Username:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(218, 26);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 26);
			this.label3.TabIndex = 1;
			this.label3.Text = "STUDENT";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.CadetBlue;
			this.tabPage3.Controls.Add(this.btnDangNhap_admin);
			this.tabPage3.Controls.Add(this.txtMatKhau_admin);
			this.tabPage3.Controls.Add(this.txtTaiKhoan_admin);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(590, 337);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Admin";
			// 
			// btnDangNhap_admin
			// 
			this.btnDangNhap_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDangNhap_admin.Location = new System.Drawing.Point(145, 127);
			this.btnDangNhap_admin.Margin = new System.Windows.Forms.Padding(2);
			this.btnDangNhap_admin.Name = "btnDangNhap_admin";
			this.btnDangNhap_admin.Size = new System.Drawing.Size(105, 29);
			this.btnDangNhap_admin.TabIndex = 8;
			this.btnDangNhap_admin.Text = "Đăng nhập";
			this.btnDangNhap_admin.UseVisualStyleBackColor = true;
			this.btnDangNhap_admin.Click += new System.EventHandler(this.btnDangNhap_admin_Click);
			// 
			// txtMatKhau_admin
			// 
			this.txtMatKhau_admin.Location = new System.Drawing.Point(145, 78);
			this.txtMatKhau_admin.Margin = new System.Windows.Forms.Padding(2);
			this.txtMatKhau_admin.Name = "txtMatKhau_admin";
			this.txtMatKhau_admin.Size = new System.Drawing.Size(170, 20);
			this.txtMatKhau_admin.TabIndex = 7;
			this.txtMatKhau_admin.TextChanged += new System.EventHandler(this.txtMatKhau_admin_TextChanged);
			// 
			// txtTaiKhoan_admin
			// 
			this.txtTaiKhoan_admin.Location = new System.Drawing.Point(145, 38);
			this.txtTaiKhoan_admin.Margin = new System.Windows.Forms.Padding(2);
			this.txtTaiKhoan_admin.Name = "txtTaiKhoan_admin";
			this.txtTaiKhoan_admin.Size = new System.Drawing.Size(170, 20);
			this.txtTaiKhoan_admin.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label8.Location = new System.Drawing.Point(28, 76);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 20);
			this.label8.TabIndex = 4;
			this.label8.Text = "Password:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new System.Drawing.Point(28, 36);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(87, 20);
			this.label7.TabIndex = 3;
			this.label7.Text = "Username:";
			// 
			// Form_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.tabControl1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form_Login";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.TextBox txtMatKhau_Gv;
		private System.Windows.Forms.TextBox txtTaiKhoan_Gv;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMatKhau_Hs;
		private System.Windows.Forms.TextBox txtTaiKhoan_Hs;
		private System.Windows.Forms.Button btnDangNhap_Sv;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnDangNhap_admin;
		private System.Windows.Forms.TextBox txtMatKhau_admin;
		private System.Windows.Forms.TextBox txtTaiKhoan_admin;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}

