using BusinessLogicLayer;
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
    public partial class FrmChangePassword : Form
    {
        public string CurrentUserName { get; set; }  // gán khi mở form
        public FrmChangePassword()
        {
            InitializeComponent();
            txtOld.UseSystemPasswordChar = true;
            txtNew.UseSystemPasswordChar = true;
            txtConfirm.UseSystemPasswordChar = true;
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

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(CurrentUserName))
            {
                txtUsername.Text = CurrentUserName;
                txtUsername.ReadOnly = true;
            }
        }

        private void txtOld_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BUserAccount.ChangePassword(
                    txtUsername.Text.Trim(),
                    txtOld.Text,
                    txtNew.Text,
                    txtConfirm.Text);

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể đổi mật khẩu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) 
        {
            Close();
        }
    }
}
