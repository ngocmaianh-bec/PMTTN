using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Phần_mềm_thi_trắc_nghiệm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // FrmMain.cs
        private T OpenChild<T>() where T : Form, new()
        {
            // Nếu đã mở → kích hoạt form cũ
            foreach (Form f in this.MdiChildren)
                if (f is T)
                {
                    if (f.WindowState == FormWindowState.Minimized) f.WindowState = FormWindowState.Normal;
                    f.Activate();
                    return (T)f;
                }

            // Chưa có → tạo mới
            var child = new T
            {
                MdiParent = this,
                StartPosition = FormStartPosition.CenterParent,
                WindowState = FormWindowState.Normal // giữ kích thước thiết kế
            };
            child.Show();
            return child;
        }


        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng form
            FrmManagerUser frm = new FrmManagerUser();

            // Tùy chọn hiển thị
            frm.StartPosition = FormStartPosition.CenterScreen; // căn giữa màn hình
            frm.Show(); 
        }

        private void thayĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmChangePassword();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);
        }
    }
}
