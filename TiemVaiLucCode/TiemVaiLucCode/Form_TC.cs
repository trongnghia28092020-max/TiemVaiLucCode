using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiemVaiLucCode
{
    
    public partial class Form_TC : Form
    {
        private Form currentFormChild;
        public Form_TC()
        {
            InitializeComponent();
        }

        private void Form_TC_Load(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void SanPham_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frm_BanHang());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void OpenChildForm(Form childForm)
        {
            // Nếu đang có một form nào đó nằm sẵn trong panel, mình đóng nó lại trước cho gọn
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;

            // Tắt tính năng cửa sổ độc lập (TopLevel) để form con chịu làm "bé ngoan" chui vào panel
            childForm.TopLevel = false;

            // Bỏ luôn viền cửa sổ đi cho mượt mà, nhìn sẽ liền mạch với Form_TC
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Cho form lấp đầy toàn bộ không gian của pnl_Chinh
            childForm.Dock = DockStyle.Fill;

            // Thêm form vào panel và hô biến cho nó hiện lên nè
            pnl_Chinh.Controls.Add(childForm);
            pnl_Chinh.Tag = childForm;
            // Gọi cái panel chính lên mặt tiền che hết mấy thứ của trang chủ đi nè
            pnl_Chinh.BringToFront();
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrangChu_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            // Đẩy pnl_Chinh xuống dưới đáy để lộ ra lại các hình ảnh của trang chủ
            pnl_Chinh.SendToBack();
        }
    }
}
