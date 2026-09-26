using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TiemVaiLucCode.Models;

namespace TiemVaiLucCode
{
    public partial class Frm_TT_KhachHang : Form
    {
        private bool daThanhToan = false;
        private int maHoaDonCuoi = 0;

        public Frm_TT_KhachHang()
        {
            InitializeComponent();
        }

        // =====================================================
        // HIỂN THỊ GIỎ HÀNG
        // =====================================================
        private void LoadGioHang()
        {
            dataGridView1.Rows.Clear();

            int stt = 1;

            foreach (GioHangItem item in GioHangManager.DanhSach)
            {
                dataGridView1.Rows.Add(
                    stt,
                    item.TenSanPham,
                    item.DonGia.ToString("N0"),
                    item.SoLuongMet,
                    item.MauSac,
                    item.ThanhTien.ToString("N0")
                );

                stt++;
            }

            // Tính tổng tiền
            decimal tongTien = GioHangManager.TongTien();

            txtTongTien.Text =
                tongTien.ToString("N0") + " VNĐ";
        }


        // =====================================================
        // LOAD FORM THANH TOÁN
        // =====================================================
        private void Frm_TT_KhachHang_Load(object sender, EventArgs e)
        {
            LoadGioHang();

            // Ngày mua
            txtNgayMua.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Phương thức thanh toán
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Tiền mặt");
            comboBox1.Items.Add("Chuyển khoản");
            comboBox1.Items.Add("Thanh toán khi nhận hàng");

            comboBox1.SelectedIndex = 0;
        }


        // =====================================================
        // NÚT XÁC NHẬN THANH TOÁN
        // =====================================================
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // =====================================================
                // 1. KIỂM TRA GIỎ HÀNG
                // =====================================================
                if (GioHangManager.DanhSach.Count == 0)
                {
                    MessageBox.Show(
                        "Giỏ hàng đang trống!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // =====================================================
                // 2. KIỂM TRA THÔNG TIN KHÁCH HÀNG
                // =====================================================
                if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập tên khách hàng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTenKH.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập số điện thoại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtSDT.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập địa chỉ!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDiaChi.Focus();
                    return;
                }

                // =====================================================
                // 3. KIỂM TRA PHƯƠNG THỨC THANH TOÁN
                // =====================================================
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn phương thức thanh toán!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    comboBox1.Focus();
                    return;
                }

                // =====================================================
                // 4. TÍNH TỔNG TIỀN
                // =====================================================
                decimal tongTien = GioHangManager.TongTien();

                // =====================================================
                // 5. XÁC NHẬN
                // =====================================================
                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có chắc chắn muốn thanh toán không?\n\n" +
                    "Khách hàng: " + txtTenKH.Text + "\n" +
                    "Số điện thoại: " + txtSDT.Text + "\n" +
                    "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n" +
                    "Phương thức: " + comboBox1.Text,
                    "Xác nhận thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (xacNhan != DialogResult.Yes)
                {
                    return;
                }

                // =====================================================
                // 6. KẾT NỐI DATABASE
                // =====================================================
                using (var db = new TaiKhoanContext())
                {
                    // =================================================
                    // 7. TÌM / TẠO KHÁCH HÀNG
                    // =================================================
                    var khachHang = db.KhachHangs
                        .FirstOrDefault(x => x.SoDienThoai == txtSDT.Text.Trim());

                    if (khachHang == null)
                    {
                        khachHang = new KhachHang
                        {
                            HoTenKhachHang = txtTenKH.Text.Trim(),
                            SoDienThoai = txtSDT.Text.Trim(),
                            DiaChi = txtDiaChi.Text.Trim()
                        };

                        db.KhachHangs.Add(khachHang);

                        // Lưu để SQL tạo MaKhachHang
                        db.SaveChanges();
                    }
                    else
                    {
                        // Cập nhật thông tin nếu khách hàng đã tồn tại
                        khachHang.HoTenKhachHang = txtTenKH.Text.Trim();
                        khachHang.DiaChi = txtDiaChi.Text.Trim();

                        db.SaveChanges();
                    }

                    // =================================================
                    // 8. KIỂM TRA TỒN KHO
                    // =================================================
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var sanPham = db.SanPhams
                            .FirstOrDefault(x => x.MaSanPham == item.SanPhamId);

                        if (sanPham == null)
                        {
                            MessageBox.Show(
                                "Không tìm thấy sản phẩm:\n" +
                                item.TenSanPham,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            return;
                        }

                        if (item.SoLuongMet > sanPham.SoLuongTon)
                        {
                            MessageBox.Show(
                                "Không đủ số lượng trong kho!\n\n" +
                                "Sản phẩm: " + sanPham.TenSanPham + "\n" +
                                "Tồn kho: " + sanPham.SoLuongTon + " mét\n" +
                                "Bạn mua: " + item.SoLuongMet + " mét",
                                "Không đủ hàng",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    // =================================================
                    // 9. TẠO ĐƠN HÀNG TRƯỚC
                    // =================================================
                    var donHang = new DonHang
                    {
                        MaKhachHang = khachHang.MaKhachHang,
                        DiaChiGiaoHang = txtDiaChi.Text.Trim()
                    };

                    db.DonHangs.Add(donHang);

                    // RẤT QUAN TRỌNG
                    // Lưu DonHang trước để SQL tạo MaDonHang
                    db.SaveChanges();

                    // Lúc này:
                    // donHang.MaDonHang đã có giá trị
                    int maDonHang = donHang.MaDonHang;

                    // =================================================
                    // 10. TẠO CHI TIẾT ĐƠN HÀNG
                    // =================================================
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var chiTiet = new ChiTietDonHang
                        {
                            MaDonHang = maDonHang,
                            SanPhamId = item.SanPhamId,
                            SoLuongMet = item.SoLuongMet,
                            DonGia = item.DonGia
                        };

                        db.ChiTietDonHangs.Add(chiTiet);
                    }

                    // =================================================
                    // 11. TẠO HÓA ĐƠN
                    // =================================================
                    var hoaDon = new HoaDon
                    {
                        MaDonHang = maDonHang,
                        NgayLap = DateTime.Now,
                        TongTienThanhToan = tongTien,
                        TrangThaiThanhToan = "Đã Thanh Toán"
                    };

                    db.HoaDons.Add(hoaDon);

                    // =================================================
                    // 12. TRỪ TỒN KHO
                    // =================================================
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var sanPham = db.SanPhams
                            .FirstOrDefault(x => x.MaSanPham == item.SanPhamId);

                        if (sanPham != null)
                        {
                            sanPham.SoLuongTon -= item.SoLuongMet;
                        }
                    }

                    // =================================================
                    // 13. LƯU TẤT CẢ
                    // =================================================
                    db.SaveChanges();

                    // Lưu mã hóa đơn để nút IN HÓA ĐƠN sử dụng
                    maHoaDonCuoi = hoaDon.MaHoaDon;

                    daThanhToan = true;
                }

                // =====================================================
                // 14. XÓA GIỎ HÀNG
                // =====================================================
                GioHangManager.XoaTatCa();

                // =====================================================
                // 15. HIỂN THỊ GIỎ HÀNG TRỐNG
                // =====================================================
                LoadGioHang();

                // =====================================================
                // 16. THÔNG BÁO
                // =====================================================
                MessageBox.Show(
                    "THANH TOÁN THÀNH CÔNG!\n\n" +
                    "Mã hóa đơn: " + maHoaDonCuoi + "\n" +
                    "Mã đơn hàng: Đã tạo\n" +
                    "Khách hàng: " + txtTenKH.Text + "\n" +
                    "Phương thức: " + comboBox1.Text + "\n" +
                    "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n\n" +
                    "Số lượng tồn kho đã được cập nhật.",
                    "Thanh toán thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;

                if (ex.InnerException != null)
                {
                    loi += "\n\nINNER EXCEPTION:\n" +
                           ex.InnerException.Message;

                    if (ex.InnerException.InnerException != null)
                    {
                        loi += "\n\nCHI TIẾT:\n" +
                               ex.InnerException.InnerException.Message;
                    }
                }

                MessageBox.Show(
                    loi,
                    "Lỗi thanh toán",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // =====================================================
        // NÚT HỦY
        // =====================================================
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn hủy thanh toán không?",

                "Xác nhận",

                MessageBoxButtons.YesNo,

                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        // =====================================================
        // CÁC EVENT CŨ CỦA BẠN
        // =====================================================

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(
            object sender,
            DateRangeEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void textBox6_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        

            try
            {
                // ==========================================
                // 1. KIỂM TRA GIỎ HÀNG
                // ==========================================
                if (GioHangManager.DanhSach.Count == 0)
                {
                    MessageBox.Show(
                        "Giỏ hàng đang trống!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // ==========================================
                // 2. KIỂM TRA TÊN KHÁCH HÀNG
                // ==========================================
                if (string.IsNullOrWhiteSpace(txtTenKH.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập tên khách hàng!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtTenKH.Focus();
                    return;
                }

                // ==========================================
                // 3. KIỂM TRA SỐ ĐIỆN THOẠI
                // ==========================================
                if (string.IsNullOrWhiteSpace(txtSDT.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập số điện thoại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtSDT.Focus();
                    return;
                }

                // ==========================================
                // 4. KIỂM TRA ĐỊA CHỈ
                // ==========================================
                if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
                {
                    MessageBox.Show(
                        "Vui lòng nhập địa chỉ!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDiaChi.Focus();
                    return;
                }

                // ==========================================
                // 5. KIỂM TRA PHƯƠNG THỨC THANH TOÁN
                // ==========================================
                if (string.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show(
                        "Vui lòng chọn phương thức thanh toán!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    comboBox1.Focus();
                    return;
                }

                // ==========================================
                // 6. HỎI XÁC NHẬN
                // ==========================================
                decimal tongTien = GioHangManager.TongTien();

                DialogResult xacNhan = MessageBox.Show(
                    "Bạn có chắc chắn muốn thanh toán không?\n\n" +
                    "Khách hàng: " + txtTenKH.Text + "\n" +
                    "Số điện thoại: " + txtSDT.Text + "\n" +
                    "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n" +
                    "Thanh toán: " + comboBox1.Text,
                    "Xác nhận thanh toán",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (xacNhan != DialogResult.Yes)
                {
                    return;
                }

                // ==========================================
                // 7. KẾT NỐI DATABASE
                // ==========================================
                using (var db = new TaiKhoanContext())
                {
                    // ==========================================
                    // 8. KIỂM TRA TỒN KHO LẦN CUỐI
                    // ==========================================
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var sanPham = db.SanPhams
                            .FirstOrDefault(x =>
                                x.MaSanPham == item.SanPhamId);

                        if (sanPham == null)
                        {
                            MessageBox.Show(
                                "Không tìm thấy sản phẩm:\n" +
                                item.TenSanPham,
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            return;
                        }

                        if (item.SoLuongMet > sanPham.SoLuongTon)
                        {
                            MessageBox.Show(
                                "Không đủ số lượng trong kho!\n\n" +
                                "Sản phẩm: " + sanPham.TenSanPham + "\n" +
                                "Tồn kho: " + sanPham.SoLuongTon + " mét\n" +
                                "Bạn mua: " + item.SoLuongMet + " mét",
                                "Không đủ hàng",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                    }

                    // ==========================================
                    // 9. TẠO HÓA ĐƠN
                    // ==========================================
                    var hoaDon = new HoaDon
                    {
                        NgayLap = DateTime.Now,
                        TongTienThanhToan = tongTien,
                        TrangThaiThanhToan = "Đã Thanh Toán"
                    };

                    db.HoaDons.Add(hoaDon);

                    // ==========================================
                    // 10. TRỪ SỐ LƯỢNG TỒN KHO
                    // ==========================================
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var sanPham = db.SanPhams
                            .FirstOrDefault(x =>
                                x.MaSanPham == item.SanPhamId);

                        if (sanPham != null)
                        {
                            sanPham.SoLuongTon -= item.SoLuongMet;
                        }
                    }

                    // ==========================================
                    // 11. LƯU DATABASE
                    // ==========================================
                    db.SaveChanges();
                    maHoaDonCuoi = hoaDon.MaHoaDon;
                    daThanhToan = true;
                }

                // ==========================================
                // 12. XÓA GIỎ HÀNG
                // ==========================================
                GioHangManager.XoaTatCa();

                // ==========================================
                // 13. THÔNG BÁO THÀNH CÔNG
                // ==========================================
                MessageBox.Show(
                    "THANH TOÁN THÀNH CÔNG!\n\n" +
                    "Khách hàng: " + txtTenKH.Text + "\n" +
                    "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ\n\n" +
                    "Số lượng trong kho đã được cập nhật.",
                    "Thanh toán thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // ==========================================
                // 14. HIỂN THỊ GIỎ HÀNG TRỐNG
                // ==========================================
                LoadGioHang();
            }
            catch (Exception ex)
            {
                string loi = ex.Message;

                if (ex.InnerException != null)
                {
                    loi += "\n\nINNER EXCEPTION:\n" + ex.InnerException.Message;

                    if (ex.InnerException.InnerException != null)
                    {
                        loi += "\n\nCHI TIẾT:\n" +
                               ex.InnerException.InnerException.Message;
                    }
                }

                MessageBox.Show(
                    loi,
                    "Lỗi thanh toán",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!daThanhToan || maHoaDonCuoi == 0)
            {
                MessageBox.Show(
                    "Vui lòng xác nhận thanh toán trước khi in hóa đơn!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (var db = new TaiKhoanContext())
                {
                    var hoaDon = db.HoaDons
                        .FirstOrDefault(x => x.MaHoaDon == maHoaDonCuoi);

                    if (hoaDon == null)
                    {
                        MessageBox.Show(
                            "Không tìm thấy hóa đơn!",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    // Tạo nội dung hóa đơn
                    string noiDung =
                        "========================================\n" +
                        "          TIỆM VẢI VĂN LỰC\n" +
                        "             HÓA ĐƠN\n" +
                        "========================================\n\n" +

                        "Mã hóa đơn: " + hoaDon.MaHoaDon + "\n" +
                        "Ngày mua: " + hoaDon.NgayLap.ToString("dd/MM/yyyy HH:mm") + "\n" +
                        "Khách hàng: " + txtTenKH.Text + "\n" +
                        "Số điện thoại: " + txtSDT.Text + "\n" +
                        "Địa chỉ: " + txtDiaChi.Text + "\n" +
                        "Phương thức: " + comboBox1.Text + "\n\n" +

                        "----------------------------------------\n" +
                        "TỔNG TIỀN: " +
                        hoaDon.TongTienThanhToan.ToString("N0") +
                        " VNĐ\n" +
                        "----------------------------------------\n\n" +

                        "       CẢM ƠN QUÝ KHÁCH!\n";

                    // Hiển thị hóa đơn để người dùng xem
                    MessageBox.Show(
                        noiDung,
                        "Hóa đơn",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Có lỗi khi lấy hóa đơn!\n\n" +
                    ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
       "Bạn có chắc muốn hủy thanh toán không?",
       "Xác nhận hủy",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}