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
    public partial class Frm_TrangChu_Admin : Form
    {
        // Khai báo biến để nhớ form con nào đang mở
        private Form formDangMo;

        public Frm_TrangChu_Admin()
        {
            InitializeComponent();
        }

        private void Mo_Card_ChildFrom(Form childForm)
        {
            // Nếu có form nào đang mở thì đóng nó lại
            if (formDangMo != null)
            {
                formDangMo.Close();
            }

            formDangMo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Lấp đầy Panel

            // Cho form con vào pnl_ManHinhChinh
            pnl_ManHinhChinh.Controls.Add(childForm);
            pnl_ManHinhChinh.Tag = childForm;

            // Kéo form con lên trên cùng để che cái Dashboard tổng quan đi
            childForm.BringToFront();
            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Card_SanPham_Click(object sender, EventArgs e)
        {
            Mo_Card_ChildFrom(new Frm_Card_SanPham());
        }

        private void Card_TongQuan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bé form con nào đang đứng trên sân khấu không
            if (formDangMo != null)
            {
                formDangMo.Close(); // Có thì đóng cửa đuổi ẻm xuống
                formDangMo = null;  // Xóa trí nhớ, đánh dấu là sân khấu đang trống
            }
        }

        private void pnl_DonHang_Click(object sender, EventArgs e)
        {
            Mo_Card_ChildFrom(new Frm_Card_DonHang());
        }
    }
}
