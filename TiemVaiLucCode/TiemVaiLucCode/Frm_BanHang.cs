using System;
using System.Linq;
using System.Windows.Forms;
using TiemVaiLucCode.Models;

namespace TiemVaiLucCode
{
    public partial class Frm_BanHang : Form
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                decimal soMet = numericUpDown7.Value;

                if (soMet <= 0)
                {
                    MessageBox.Show(
                        "Vui lòng chọn số mét vải muốn mua!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                using (var db = new TaiKhoanContext())
                {
                    
                    var sanPham = db.SanPhams
                        .FirstOrDefault(x =>
                            x.TenSanPham == "Vải lụa satin");

                    if (sanPham == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy sản phẩm \"Vải lụa satin\" trong cơ sở dữ liệu!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    
                    GioHangItem item = new GioHangItem
                    {
                        SanPhamId = sanPham.MaSanPham,
                        TenSanPham = sanPham.TenSanPham,
                        MauSac = "Chưa chọn",
                        SoLuongMet = soMet,
                        DonGia = sanPham.GiaBan
                    };

                    
                    GioHangManager.Them(item);
                }

                
                MessageBox.Show(
                    "Đã thêm Vải lụa satin vào giỏ hàng!\n\n" +
                    "Số lượng: " + soMet + " mét",
                    "Thêm vào giỏ hàng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                
                Form_GioHang gioHang = new Form_GioHang();

                gioHang.ShowDialog();

               
                numericUpDown21.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Đã xảy ra lỗi khi thêm sản phẩm vào giỏ hàng!\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =====================================================
        // CÁC EVENT KHÁC CỦA FORM
        // =====================================================

        private void button22_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
        }
    }
}