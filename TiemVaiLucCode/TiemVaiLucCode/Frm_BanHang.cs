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
        private void ThemVaoGioHang(
    string tenSanPham,
    ComboBox comboMau,
    NumericUpDown soLuong)
        {
            // Kiểm tra màu
            if (string.IsNullOrWhiteSpace(comboMau.Text))
            {
                MessageBox.Show(
                    "Vui lòng chọn màu sắc!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                comboMau.Focus();
                return;
            }

            // Kiểm tra số lượng
            if (soLuong.Value <= 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn số lượng vải!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                soLuong.Focus();
                return;
            }

            try
            {
                using (var db = new TaiKhoanContext())
                {
                    // Tìm đúng loại vải được truyền vào
                    var sanPham = db.SanPhams
                        .FirstOrDefault(x =>
                            x.TenSanPham == tenSanPham);

                    if (sanPham == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy sản phẩm:\n" + tenSanPham,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    // Kiểm tra tồn kho
                    if (soLuong.Value > sanPham.SoLuongTon)
                    {
                        MessageBox.Show(
                            "Không đủ hàng!\n\n" +
                            "Sản phẩm: " + sanPham.TenSanPham + "\n" +
                            "Tồn kho: " + sanPham.SoLuongTon + " mét\n" +
                            "Bạn muốn mua: " + soLuong.Value + " mét",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // Tạo sản phẩm trong giỏ
                    GioHangItem item = new GioHangItem
                    {
                        SanPhamId = sanPham.MaSanPham,
                        TenSanPham = sanPham.TenSanPham,
                        MauSac = comboMau.Text,
                        SoLuongMet = soLuong.Value,
                        DonGia = sanPham.GiaBan
                    };

                    // Thêm vào giỏ
                    GioHangManager.Them(item);
                }

                MessageBox.Show(
                    "Đã thêm " + tenSanPham +
                    " vào giỏ hàng!\n\n" +
                    "Màu: " + comboMau.Text + "\n" +
                    "Số lượng: " + soLuong.Value + " mét",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Sau khi thêm thì đưa số lượng về 0
                soLuong.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi khi thêm sản phẩm:\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {

        }

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

        private void Frm_BanHang_Load_1(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang(
        "Vải lụa satin",
        cmbmausac,
        numericUpDown7);
        }

        private void but2_Click(object sender, EventArgs e)
        {
            
            ThemVaoGioHang(
                "Vải chiffon",
                cmb2,
                numericUpDown6);
        
    }

        private void but3_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang(
               "Vải kate",
               cmb3,
               numericUpDown5);
        }

        private void but4_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang(
               "Vải cotton 100%",
               cmb4,
               numericUpDown2);
        }

        private void but5_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang(
               "Vải gấm",
               cmb5,
               numericUpDown1);
        }

        private void but6_Click(object sender, EventArgs e)
        {
            ThemVaoGioHang(
               "Vải ren",
               cmb6,
               numericUpDown3);
        }
    }
}