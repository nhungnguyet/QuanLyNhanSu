using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS_CSDL
{
    public partial class fHeThong : Form
    {
        public fHeThong()
        {
            InitializeComponent();
        }

        private void buttLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttHuy_Click(object sender, EventArgs e)
        {
            txbmkcu.Text = "";
            txbMKMoi.Text = "";
            txtMLMKC.Text = "";
            // Đưa focus về ô đầu tiên nếu muốn
            txbmkcu.Focus();
        }

        private void buttsaoluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sao lưu tệp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttdong_Click(object sender, EventArgs e)
        {

            // Giả sử tabControl tên là tabControl1 và tab "Đổi mật khẩu" là tab đầu tiên
            tabControl1.SelectedIndex = 0;
        }
    }
    
}

