using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void LamMoiTrangThanhToan()
        {
            // 1. Dọn dẹp ô nhập liệu khách hàng
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();

            // 2. Trả ngày mua và phương thức thanh toán về mặc định
            txtNgayMua.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            // 3. Quét sạch giỏ hàng và cập nhật lại bảng hiển thị (trống trơn)
            GioHangManager.XoaTatCa();
            LoadGioHang();

            // 4. Tính toán sẵn Mã Khách Hàng và Mã Đơn Hàng cho người mua tiếp theo
            using (var db = new TaiKhoanContext())
            {
                int maKHLonNhat = db.KhachHangs.Any() ? db.KhachHangs.Max(k => k.MaKhachHang) : 0;
                txtMaKH.Text = (maKHLonNhat + 1).ToString();

                int maDHLonNhat = db.DonHangs.Any() ? db.DonHangs.Max(d => d.MaDonHang) : 0;
                txt_MaDH.Text = (maDHLonNhat + 1).ToString();
            }
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
            // Hiển thị ngày mua mặc định là ngày hiện tại
            txtNgayMua.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //  Hiển thị phương thức thanh toán mặc định là "Tiền mặt"
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Tiền mặt");
            comboBox1.Items.Add("Chuyển khoản");
            comboBox1.Items.Add("Thanh toán khi nhận hàng");

            comboBox1.SelectedIndex = 0;

            // Khóa 2 ô mã lại, tô màu xám cho đẹp
            txtMaKH.ReadOnly = true;
            txtMaKH.BackColor = Color.LightGray;

            txt_MaDH.ReadOnly = true;
            txt_MaDH.BackColor = Color.LightGray;

            using (var db = new TaiKhoanContext())
            {
                // 1. Tính mã Khách Hàng tiếp theo
                int maKHLonNhat = db.KhachHangs.Any() ? db.KhachHangs.Max(k => k.MaKhachHang) : 0;
                txtMaKH.Text = (maKHLonNhat + 1).ToString();

                // 2. Tính mã Đơn Hàng tiếp theo
                int maDHLonNhat = db.DonHangs.Any() ? db.DonHangs.Max(d => d.MaDonHang) : 0;
                txt_MaDH.Text = (maDHLonNhat + 1).ToString();
            }
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
                // 6. KẾT NỐI DATABASE (LUỒNG CHUẨN ENTITY FRAMEWORK)
                // =====================================================
                using (var db = new TaiKhoanContext())
                {
                    // 7. KHÁCH HÀNG (Lưu trước để lấy mã KH chuẩn)
                    var khachHang = db.KhachHangs.FirstOrDefault(x => x.SoDienThoai == txtSDT.Text.Trim());
                    if (khachHang == null)
                    {
                        khachHang = new KhachHang
                        {
                            HoTenKhachHang = txtTenKH.Text.Trim(),
                            SoDienThoai = txtSDT.Text.Trim(),
                            DiaChi = txtDiaChi.Text.Trim()
                        };
                        db.KhachHangs.Add(khachHang);
                    }
                    else
                    {
                        khachHang.HoTenKhachHang = txtTenKH.Text.Trim();
                        khachHang.DiaChi = txtDiaChi.Text.Trim();
                    }
                    db.SaveChanges(); // Chốt lưu Khách Hàng

                    // 8. KIỂM TRA TỒN KHO LẦN CUỐI
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var spCheck = db.SanPhams.FirstOrDefault(x => x.MaSanPham == item.SanPhamId);
                        if (spCheck == null || item.SoLuongMet > spCheck.SoLuongTon)
                        {
                            MessageBox.Show($"Không đủ hàng cho sản phẩm: {item.TenSanPham}", "Lỗi Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 9. TẠO ĐƠN HÀNG (TUYỆT ĐỐI KHÔNG GÁN MaDonHang - ĐỂ EF TỰ LO)
                    var donHangMoi = new DonHang
                    {
                        MaKhachHang = khachHang.MaKhachHang,
                        DiaChiGiaoHang = txtDiaChi.Text.Trim(),
                        TongTien = tongTien,
                        TrangThai = "Hoàn Thành",
                        SoDienThoaiNhan = txtSDT.Text.Trim(),
                        NgayDat = DateTime.Now,
                        ChiTietDonHangs = new List<ChiTietDonHang>() // Khởi tạo giỏ chứa chi tiết
                    };

                    // 10. TẠO CHI TIẾT & TRỪ KHO
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        // Nhét thẳng chi tiết vào giỏ của Đơn Hàng (KHÔNG cần gán ID MaDonHang)
                        donHangMoi.ChiTietDonHangs.Add(new ChiTietDonHang
                        {
                            SanPhamId = item.SanPhamId,
                            SoLuongMet = item.SoLuongMet,
                            DonGia = item.DonGia
                        });

                        // Trừ tồn kho
                        var sanPham = db.SanPhams.FirstOrDefault(x => x.MaSanPham == item.SanPhamId);
                        if (sanPham != null) sanPham.SoLuongTon -= item.SoLuongMet;
                    }

                    // 11. TẠO HÓA ĐƠN
                    var hoaDonMoi = new HoaDon
                    {
                        DonHang = donHangMoi, // QUAN TRỌNG: Gắn nguyên đối tượng Đơn Hàng vào Hóa Đơn
                        NgayLap = DateTime.Now,
                        TongTienThanhToan = tongTien,
                        TrangThaiThanhToan = "Đã Thanh Toán",
                        PhuongThucThanhToan = comboBox1.Text
                    };

                    // 12. THÊM HÓA ĐƠN VÀ LƯU 1 LẦN DUY NHẤT
                    db.HoaDons.Add(hoaDonMoi);

                    // EF sẽ tự động lưu Đơn Hàng -> Lấy ID tự sinh -> Lưu Chi tiết -> Lưu Hóa Đơn
                    db.SaveChanges();

                    maHoaDonCuoi = hoaDonMoi.MaHoaDon;
                    daThanhToan = true;

                    // 13. Tự động lấy mã đơn hàng EF vừa sinh ra cộng thêm 1 để hiển thị sẵn cho đơn sau
                    txt_MaDH.Text = (donHangMoi.MaDonHang + 1).ToString();
                }

                // =====================================================
                // 14. XÓA GIỎ HÀNG
                // =====================================================
                LamMoiTrangThanhToan();

                // =====================================================
                // 15. HIỂN THỊ GIỎ HÀNG TRỐNG
                // =====================================================
                LamMoiTrangThanhToan();

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
                LamMoiTrangThanhToan();
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

                // =====================================================
                // 6. KẾT NỐI DATABASE VÀ LƯU 1 LẦN DUY NHẤT
                // =====================================================
                using (var db = new TaiKhoanContext())
                {
                    // 7. KHÁCH HÀNG (Tìm cũ hoặc tạo mới)
                    var khachHang = db.KhachHangs.FirstOrDefault(x => x.SoDienThoai == txtSDT.Text.Trim());
                    if (khachHang == null)
                    {
                        khachHang = new KhachHang
                        {
                            HoTenKhachHang = txtTenKH.Text.Trim(),
                            SoDienThoai = txtSDT.Text.Trim(),
                            DiaChi = txtDiaChi.Text.Trim()
                        };
                        db.KhachHangs.Add(khachHang);
                        db.SaveChanges(); // Chốt lưu Khách Hàng để CSDL cấp mã
                    }
                    else
                    {
                        khachHang.HoTenKhachHang = txtTenKH.Text.Trim();
                        khachHang.DiaChi = txtDiaChi.Text.Trim();
                        db.SaveChanges();
                    }

                    // 8. KIỂM TRA TỒN KHO LẦN CUỐI
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        var spCheck = db.SanPhams.FirstOrDefault(x => x.MaSanPham == item.SanPhamId);
                        if (spCheck == null || item.SoLuongMet > spCheck.SoLuongTon)
                        {
                            MessageBox.Show($"Không đủ hàng cho sản phẩm: {item.TenSanPham}", "Lỗi Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // 9. TẠO ĐƠN HÀNG (TUYỆT ĐỐI KHÔNG GÁN MaDonHang - ĐỂ HỆ THỐNG TỰ LO)
                    var donHangMoi = new DonHang
                    {
                        MaKhachHang = khachHang.MaKhachHang,
                        DiaChiGiaoHang = txtDiaChi.Text.Trim(),
                        TongTien = tongTien,
                        TrangThai = "Hoàn Thành",
                        SoDienThoaiNhan = txtSDT.Text.Trim(),
                        NgayDat = DateTime.Now,
                        ChiTietDonHangs = new List<ChiTietDonHang>() // Khởi tạo giỏ chứa chi tiết
                    };

                    // 10. NHÉT CHI TIẾT & TRỪ KHO
                    foreach (GioHangItem item in GioHangManager.DanhSach)
                    {
                        // Bỏ thẳng Chi tiết vào giỏ của Đơn Hàng (KHÔNG cần gán ID MaDonHang)
                        donHangMoi.ChiTietDonHangs.Add(new ChiTietDonHang
                        {
                            SanPhamId = item.SanPhamId,
                            SoLuongMet = item.SoLuongMet,
                            DonGia = item.DonGia
                        });

                        var sanPham = db.SanPhams.FirstOrDefault(x => x.MaSanPham == item.SanPhamId);
                        if (sanPham != null) sanPham.SoLuongTon -= item.SoLuongMet;
                    }

                    // 11. TẠO HÓA ĐƠN VÀ LIÊN KẾT CHẶT VỚI ĐƠN HÀNG
                    var hoaDonMoi = new HoaDon
                    {
                        DonHang = donHangMoi, // BÍ QUYẾT: Gán nguyên object Đơn Hàng vào đây!
                        NgayLap = DateTime.Now,
                        TongTienThanhToan = tongTien,
                        TrangThaiThanhToan = "Đã Thanh Toán",
                        PhuongThucThanhToan = comboBox1.Text
                    };

                    // 12. THÊM HÓA ĐƠN VÀ LƯU TẤT CẢ (1 NHÁT DUY NHẤT)
                    db.HoaDons.Add(hoaDonMoi);
                    db.SaveChanges(); // Hệ thống sẽ tự động cấp mã Đơn Hàng và móc nối chính xác 100%

                    // Lưu thông tin để lát in Bill
                    maHoaDonCuoi = hoaDonMoi.MaHoaDon;
                    daThanhToan = true;

                    // 13. Tự động mồi ô mã Đơn Hàng trên giao diện cho đơn tiếp theo
                    txt_MaDH.Text = (donHangMoi.MaDonHang + 1).ToString();
                }

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