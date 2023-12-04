namespace student_mng
{
    partial class Form_Student_Detail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDStudentId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDBirthday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSDSex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSDPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSDAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // txtSDStudentId
            // 
            this.txtSDStudentId.Location = new System.Drawing.Point(356, 65);
            this.txtSDStudentId.Name = "txtSDStudentId";
            this.txtSDStudentId.ReadOnly = true;
            this.txtSDStudentId.Size = new System.Drawing.Size(210, 26);
            this.txtSDStudentId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ và tên:";
            // 
            // txtSDFullname
            // 
            this.txtSDFullname.Location = new System.Drawing.Point(356, 117);
            this.txtSDFullname.Name = "txtSDFullname";
            this.txtSDFullname.ReadOnly = true;
            this.txtSDFullname.Size = new System.Drawing.Size(210, 26);
            this.txtSDFullname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày sinh:";
            // 
            // txtSDBirthday
            // 
            this.txtSDBirthday.Location = new System.Drawing.Point(356, 178);
            this.txtSDBirthday.Name = "txtSDBirthday";
            this.txtSDBirthday.ReadOnly = true;
            this.txtSDBirthday.Size = new System.Drawing.Size(210, 26);
            this.txtSDBirthday.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính:";
            // 
            // txtSDSex
            // 
            this.txtSDSex.Location = new System.Drawing.Point(356, 238);
            this.txtSDSex.Name = "txtSDSex";
            this.txtSDSex.ReadOnly = true;
            this.txtSDSex.Size = new System.Drawing.Size(210, 26);
            this.txtSDSex.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện thoại:";
            // 
            // txtSDPhone
            // 
            this.txtSDPhone.Location = new System.Drawing.Point(356, 289);
            this.txtSDPhone.Name = "txtSDPhone";
            this.txtSDPhone.ReadOnly = true;
            this.txtSDPhone.Size = new System.Drawing.Size(210, 26);
            this.txtSDPhone.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ:";
            // 
            // txtSDAddress
            // 
            this.txtSDAddress.Location = new System.Drawing.Point(356, 337);
            this.txtSDAddress.Name = "txtSDAddress";
            this.txtSDAddress.ReadOnly = true;
            this.txtSDAddress.Size = new System.Drawing.Size(210, 26);
            this.txtSDAddress.TabIndex = 1;
            // 
            // Form_Student_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSDAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSDPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSDSex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSDBirthday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSDFullname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDStudentId);
            this.Controls.Add(this.label1);
            this.Name = "Form_Student_Detail";
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.Form_Student_Detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDStudentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDFullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSDPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSDAddress;
    }
}