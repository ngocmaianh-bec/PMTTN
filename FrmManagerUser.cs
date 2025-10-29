using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_thi_trắc_nghiệm
{
    public partial class FrmManagerUser : Form
    {
        public FrmManagerUser()
        {
            InitializeComponent();
        }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmManagerUser_Load(object sender, EventArgs e)
        {

            int defaultAge = 11; // Giả sử tuổi tối thiểu là 11 
            dpkBirthday.Value = DateTime.Now.AddYears(-defaultAge);
            LoadGridUsers(); // Gọi khi form vừa mở


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private UserAccount GetUserInFor()
        {
            UserAccount userAccount = new UserAccount();
            // Gán giá trị từ các TextBox vào các thuộc tính của userAccount
            userAccount.Address = txtAddress.Text.Trim();
            userAccount.Birthday = dpkBirthday.Value;
            userAccount.CreatedAt = DateTime.Now;
            userAccount.CreatedBy = "English Center ILA";
            userAccount.Email = txtEmail.Text.Trim();
            userAccount.FullName = txtFullname.Text.Trim();
            userAccount.ModifiedAt = DateTime.Now;
            userAccount.ModifiedBy = "English Center ILA";
            userAccount.Note = "Learn English with ILA";
            userAccount.Password = txtPassword.Text.Trim(); // Lưu ý: Mật khẩu nên được mã hóa trước khi lưu
            userAccount.PhoneNumber = txtPhoneNumber.Text.Trim();
            userAccount.RoleId = cboRoleId.Text.Trim();
            int.TryParse(txtUserId.Text, out int roleId);
            userAccount.UserId = roleId; // Giả sử UserId là số nguyên
            userAccount.UserName = txtUsername.Text.Trim();
            return userAccount;
        }

        private bool IsValidUser(UserAccount user)
        {
            string strMessage = string.Empty;
            // Kiểm tra tính hợp lệ của dữ liệu
            if (string.IsNullOrEmpty(user.UserName))
            {
                strMessage = "Tài khoản không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.FullName))
            {
                strMessage += "Họ và tên không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                strMessage += "Mật khẩu không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                strMessage += "Email không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.PhoneNumber))
            {
                strMessage += "Điện thoại không được để trống!\n";
            }
            if (string.IsNullOrEmpty(user.Address))
            {
                strMessage += "Địa chỉ không được để trống!\n";
            }
            //Kiểm tra người dung > 11 tuổi
            int minAge = 11;
            if (DateTime.Now.Year - user.Birthday?.Year < minAge)
            {
                strMessage += $"Bạn chưa đủ tuổi! Độ tuổi tối thiểu để sử dụng là {minAge}\n";
            }
            // Kiểm tra xem hợp lệ ko 
            if (!string.IsNullOrEmpty(strMessage))
            {
                MessageBox.Show(strMessage, "Lỗi nhập liệu!\n");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new Entities.UserAccount
            {
                RoleId = cboRoleId.Text.Trim(),       // Admin/Teacher/User
                UserName = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                FullName = txtFullname.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Birthday = dpkBirthday.Value,          // hoặc (DateTime?)dtBirthday.Value

                // CreatedBy/At/Modified* KHÔNG CẦN set — proc tự điền
            };

            btnAdd.Enabled = false;           // chặn double click
            try
            {
                int newId = BusinessLogicLayer.BUserAccount.AddNewUser(u);
                if (newId > 0)
                {
                    MessageBox.Show($"Thêm thành công (UserId = {newId})");
                    LoadGridUsers();
                    //ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnAdd.Enabled = true;
            }
        }

        private void LoadGridUsers()
        {
            var dt = BUserAccount.GetAllUsers();

            grvData.AutoGenerateColumns = false;
            grvData.DataSource = dt;

            grvData.ReadOnly = true;
            grvData.AllowUserToAddRows = false;
            grvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void grvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvData["STT", e.RowIndex].Value = (e.RowIndex < 10 ? "0" : String.Empty) + (e.RowIndex + 1);
        }

        private void grvData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= grvData.Rows.Count)
                return;
            try
            {
                DataGridViewRow row = grvData.Rows[e.RowIndex];
                txtUserId.Text = row.Cells["UserId"].Value.ToString();
                cboRoleId.Text = row.Cells["RoleId"].Value.ToString();
                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtFullname.Text = row.Cells["FullName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                dpkBirthday.Value = Convert.ToDateTime(row.Cells["Birthday"].Value);
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu người dùng: " + ex.Message);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text, out var id))
            {
                MessageBox.Show("Chưa chọn người dùng để sửa."); return;
            }

            var u = new Entities.UserAccount
            {
                UserId = id,
                RoleId = cboRoleId.Text.Trim(),
                UserName = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                FullName = txtFullname.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Birthday = dpkBirthday.Value,              // nếu dùng DateTime? thì: (DateTime?)dtBirthday.Value
            };

            bool ok = BUserAccount.UpdateUser(u);
            MessageBox.Show(ok ? "Cập nhật thành công!" : "Không có bản ghi nào được cập nhật.");
            LoadGridUsers();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(txtUserId.Text, out var id))
            {
                MessageBox.Show("Chưa chọn người dùng cần xóa.");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?",
                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool ok = BusinessLogicLayer.BUserAccount.DeleteUser(id);
                MessageBox.Show(ok ? "Đã xóa." : "Không tìm thấy bản ghi để xóa.");

                if (ok)
                {
                    LoadGridUsers();   // reload DataGridView
                    //ClearInputs();     // dọn ô nhập (nếu có)
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }
    }
}
