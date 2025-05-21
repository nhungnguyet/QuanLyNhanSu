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
    public partial class fQLNS : Form
    {
        private int marqueeDirection = 1;
        public fQLNS()
        {
            InitializeComponent();
           
        }

 
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fQLNS_Load(object sender, EventArgs e)
        {
            
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttHUy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btSaoluu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sao lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttHeThong_Click(object sender, EventArgs e)
        {

            fHeThong frm = new fHeThong();
            this.Hide(); // Ẩn form hiện tại nếu muốn
            frm.ShowDialog();
            this.Show();
        }

        private void bttQLNS_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Di chuyển label
            lblMarquee.Left += marqueeDirection * 2; // 2 là tốc độ, có thể chỉnh

            // Nếu label chạm biên phải thì đổi hướng sang trái
            if (lblMarquee.Right >= this.ClientSize.Width)
                marqueeDirection = -1;

            // Nếu label chạm biên trái thì đổi hướng sang phải
            if (lblMarquee.Left <= 0)
                marqueeDirection = 1;
        }
    }
}

