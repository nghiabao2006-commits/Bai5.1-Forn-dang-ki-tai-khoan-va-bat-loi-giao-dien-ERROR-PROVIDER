namespace Bai5._1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.chkTerms = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(24, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(148, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(24, 52);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 16);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(148, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(24, 82);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(119, 16);
            this.lblConfirm.TabIndex = 4;
            this.lblConfirm.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(148, 79);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(200, 22);
            this.txtConfirm.TabIndex = 5;
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TextChanged += new System.EventHandler(this.txtConfirm_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 140);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin bổ sung";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(24, 160);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(67, 16);
            this.lblDob.TabIndex = 8;
            this.lblDob.Text = "Ngày sinh";
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDob.Location = new System.Drawing.Point(148, 154);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(200, 22);
            this.dtpDob.TabIndex = 9;
            this.dtpDob.ValueChanged += new System.EventHandler(this.dtpDob_ValueChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(24, 190);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 16);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(135, 188);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(200, 188);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(45, 20);
            this.rbFemale.TabIndex = 12;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // chkTerms
            // 
            this.chkTerms.AutoSize = true;
            this.chkTerms.Location = new System.Drawing.Point(27, 220);
            this.chkTerms.Name = "chkTerms";
            this.chkTerms.Size = new System.Drawing.Size(228, 20);
            this.chkTerms.TabIndex = 13;
            this.chkTerms.Text = "Tôi đồng ý với điều khoản dịch vụ";
            this.chkTerms.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(60, 300);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(200, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 361);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkTerms);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "Form1";
            this.Text = "Đăng Ký Tài Khoản";
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox chkTerms;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}

