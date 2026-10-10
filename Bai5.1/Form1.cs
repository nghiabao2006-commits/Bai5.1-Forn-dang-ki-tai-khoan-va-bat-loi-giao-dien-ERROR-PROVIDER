using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            epCheck.Clear();

            bool ok = true;

            // Username required
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                epCheck.SetError(txtUsername, "Tên đăng nhập không được để trống");
                ok = false;
            }

            // Password required
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                epCheck.SetError(txtPassword, "Mật khẩu không được để trống");
                ok = false;
            }

            // Confirm matches
            if (!string.Equals(txtPassword.Text, txtConfirm.Text))
            {
                epCheck.SetError(txtConfirm, "Xác nhận mật khẩu không khớp");
                ok = false;
            }

            // Age >= 18
            int age = CalculateAge(dtpDob.Value, DateTime.Today);
            if (age < 18)
            {
                epCheck.SetError(dtpDob, "Bạn phải ít nhất 18 tuổi");
                ok = false;
            }

            // Terms checked
            if (!chkTerms.Checked)
            {
                epCheck.SetError(chkTerms, "Bạn phải đồng ý với điều khoản dịch vụ");
                ok = false;
            }

            if (ok)
            {
                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirm.Clear();
            dtpDob.Value = DateTime.Today.AddYears(-18);
            rbMale.Checked = false;
            rbFemale.Checked = false;
            chkTerms.Checked = false;
            epCheck.Clear();
        }

        private int CalculateAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(age)) age--;
            return age;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDob_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
