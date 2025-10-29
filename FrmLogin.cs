using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Phần_mềm_thi_trắc_nghiệm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private const string USER_PLACEHOLDER = "Tên đăng nhập";
        private const string PASS_PLACEHOLDER = "Mật khẩu";

        // Set color for background gradient 
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }    
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // Username
            txtUsername.Text = USER_PLACEHOLDER;   // "Tên đăng nhập"
            txtUsername.ForeColor = Color.Gray;

            // Password: để hiện chữ "Mật khẩu" thì phải TẮT mask ban đầu
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Text = PASS_PLACEHOLDER;   // "Mật khẩu"
            txtPassword.ForeColor = Color.Gray;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                this.Close(); // Đóng form hiện tại
            }
        }

        private bool IsValidUser(UserAccount user)
        {
            if (string.IsNullOrEmpty(user.UserName))
            {
                MessageBox.Show(
                    "Vui lòng nhập tài khoản!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show(
                    "Vui lòng nhập mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ giao diện 
            UserAccount eUser = new UserAccount()
            {
                UserName = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            // Kiểm tra xem thông tin hợp lệ chưa 
            if (!IsValidUser(eUser))
                return;

            // Kiểm tra tài khoản đăng nhập: cái này phải kết nối với CSDL
            if (BUserAccount.IsExistsAccount(eUser))
            {
                // Đăng nhập thành công
                this.Hide(); // Ẩn form hiện tại (FrmLogin)
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog(); // Hiện form chính (FrmMain)
                this.Show(); // Khi đóng FrmMain thì sẽ hiện lại FrmLogin
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show(
                    "Sai tên đăng nhập hoặc mật khẩu!",
                    "Đăng nhập thất bại",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == USER_PLACEHOLDER)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = USER_PLACEHOLDER;
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == PASS_PLACEHOLDER)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true; // bật mask *
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false; // tắt mask
                txtPassword.Text = PASS_PLACEHOLDER;
                txtPassword.ForeColor = Color.Gray;
            }
        }
    }
}
