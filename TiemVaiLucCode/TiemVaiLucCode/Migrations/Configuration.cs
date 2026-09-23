namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TiemVaiLucCode.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TiemVaiLucCode.Models.TaiKhoanContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TiemVaiLucCode.Models.TaiKhoanContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            // 1. Cập nhật 6 Danh Mục vải
            context.DanhMucs.AddOrUpdate(
                d => d.TenDanhMuc,
                new DanhMuc { MaDanhMuc = 1, TenDanhMuc = "Vải lụa satin", MoTa = "Mềm mại, óng ả, độ bóng tự nhiên" },
                new DanhMuc { MaDanhMuc = 2, TenDanhMuc = "Vải chiffon", MoTa = "Mỏng nhẹ, bay bổng, hơi trong suốt" },
                new DanhMuc { MaDanhMuc = 3, TenDanhMuc = "Vải kate", MoTa = "Thoáng mát, dễ ủi, phù hợp may sơ mi" },
                new DanhMuc { MaDanhMuc = 4, TenDanhMuc = "Vải cotton", MoTa = "Thấm hút mồ hôi siêu tốt, co giãn thoải mái" },
                new DanhMuc { MaDanhMuc = 5, TenDanhMuc = "Vải gấm", MoTa = "Sang trọng, hoa văn chìm tinh tế" },
                new DanhMuc { MaDanhMuc = 6, TenDanhMuc = "Vải ren", MoTa = "Hoa văn sắc nét, quyến rũ, dùng phối viền" }
            );

            // 2. Thêm 6 Sản Phẩm vải
            context.SanPhams.AddOrUpdate(
                s => s.TenSanPham,
                new SanPham { MaSanPham = 1, TenSanPham = "Vải lụa satin", GiaBan = 80000, SoLuongTon = 100, 
                    MauSac = "Xanh cổ vịt", ChatLieu = "Lụa Satin", HinhAnh = "vai_lua_satin.jpg", DanhMucId = 1 },
                new SanPham { MaSanPham = 2, TenSanPham = "Vải chiffon", GiaBan = 60000, SoLuongTon = 100, 
                    MauSac = "Trắng sữa", ChatLieu = "Chiffon", HinhAnh = "vai_chiffon.jpg", DanhMucId = 2 },
                new SanPham { MaSanPham = 3, TenSanPham = "Vải kate", GiaBan = 50000, SoLuongTon = 150, 
                    MauSac = "Sọc caro", ChatLieu = "Kate", HinhAnh = "vai_kate.jpg", DanhMucId = 3 },
                new SanPham { MaSanPham = 4, TenSanPham = "Vải cotton 100%", GiaBan = 70000, SoLuongTon = 200, 
                    MauSac = "Vàng cam", ChatLieu = "100% Cotton", HinhAnh = "vai_cotton.jpg", DanhMucId = 4 },
                new SanPham { MaSanPham = 5, TenSanPham = "Vải gấm", GiaBan = 120000, SoLuongTon = 50, 
                    MauSac = "Trắng kem", ChatLieu = "Gấm", HinhAnh = "vai_gam.jpg", DanhMucId = 5 },
                new SanPham { MaSanPham = 6, TenSanPham = "Vải ren", GiaBan = 100000, SoLuongTon = 80, 
                    MauSac = "Trắng tinh", ChatLieu = "Ren", HinhAnh = "vai_ren.jpg", DanhMucId = 6 }
            );


            // 3. Thêm Tài Khoản (1 Quản lý, 1 Khách hàng)
            context.TaiKhoans.AddOrUpdate(
                t => t.ID, // AddOrUpdate theo ID để không bị trùng
                new TaiKhoan { ID = 1, TenDangNhap = "admin02", MatKhau = "123456", HoTen = "Bé Di", Email = "tranthuyduy2006@gmail.com", 
                    SoDienThoai = "0123456789", VaiTro = "Admin", NgayTao = DateTime.Now },
                new TaiKhoan { ID = 2, TenDangNhap = "khach01", MatKhau = "123456", HoTen = "Bé Khách Hàng", Email = "khach@gmail.com", 
                    SoDienThoai = "0987654321", VaiTro = "KhachHang", NgayTao = DateTime.Now }
            );

            // 4. Thêm Nhân Viên (Liên kết với TaiKhoan ID = 1 ở trên)
            context.NhanViens.AddOrUpdate(
                nv => nv.MaNhanVien,
                new NhanVien { MaNhanVien = 1, TaiKhoanId = 1, HoTenNhanVien = "Bé Di", SoDienThoai = "0123456789", Email = "tranthuyduy2006@gmail.com", ChucVu = "QuanLy" }
            );

            // 5. Thêm Khách Hàng (Giữ khách cũ, đẻ thêm 2 khách VIP mới)
            context.KhachHangs.AddOrUpdate(
                kh => kh.MaKhachHang,
                new KhachHang { MaKhachHang = 1, TaiKhoanId = 2, HoTenKhachHang = "Bé Khách Hàng", SoDienThoai = "0987654321", 
                    DiaChi = "Mỹ Ngãi, Đồng Tháp", Email = "khach@gmail.com" },
                new KhachHang { MaKhachHang = 2, TaiKhoanId = null, HoTenKhachHang = "Chị Đẹp Sài Gòn", SoDienThoai = "0909123456", 
                    DiaChi = "Quận 1, TP.HCM", Email = "chidep@gmail.com" },
                new KhachHang { MaKhachHang = 3, TaiKhoanId = null, HoTenKhachHang = "Cô Ba Sa Đéc", SoDienThoai = "0911222333", 
                    DiaChi = "Sa Đéc, Đồng Tháp", Email = "" }
            );

            // 6. Thêm Đơn Hàng (Tổng cộng 7 đơn hàng cho xôm tụ)
            context.DonHangs.AddOrUpdate(
                dh => dh.MaDonHang,
                new DonHang { MaDonHang = 1, MaKhachHang = 1, NgayDat = DateTime.Now.AddDays(-5), TongTien = 230000, 
                    TrangThai = "Hoàn Thành", DiaChiGiaoHang = "Mỹ Ngãi, Đồng Tháp", SoDienThoaiNhan = "0987654321" },
                new DonHang { MaDonHang = 2, MaKhachHang = 1, NgayDat = DateTime.Now.AddDays(-4), TongTien = 420000, 
                    TrangThai = "Hoàn Thành", DiaChiGiaoHang = "Mỹ Ngãi, Đồng Tháp", SoDienThoaiNhan = "0987654321" },
                new DonHang { MaDonHang = 3, MaKhachHang = 1, NgayDat = DateTime.Now.AddDays(-1), TongTien = 150000, 
                    TrangThai = "Đang Chờ", DiaChiGiaoHang = "Mỹ Ngãi, Đồng Tháp", SoDienThoaiNhan = "0987654321" },
                // Khách 2 mua sắm:
                new DonHang { MaDonHang = 4, MaKhachHang = 2, NgayDat = DateTime.Now.AddDays(-3), TongTien = 150000, 
                    TrangThai = "Hoàn Thành", DiaChiGiaoHang = "Quận 1, TP.HCM", SoDienThoaiNhan = "0909123456" },
                new DonHang { MaDonHang = 5, MaKhachHang = 2, NgayDat = DateTime.Now.AddDays(-2), TongTien = 320000, 
                    TrangThai = "Hoàn Thành", DiaChiGiaoHang = "Quận 1, TP.HCM", SoDienThoaiNhan = "0909123456" },
                // Khách 3 mua sắm:
                new DonHang { MaDonHang = 6, MaKhachHang = 3, NgayDat = DateTime.Now.AddDays(-1), TongTien = 350000, 
                    TrangThai = "Hoàn Thành", DiaChiGiaoHang = "Sa Đéc, Đồng Tháp", SoDienThoaiNhan = "0911222333" },
                new DonHang { MaDonHang = 7, MaKhachHang = 3, NgayDat = DateTime.Now, TongTien = 120000, 
                    TrangThai = "Hoàn Thành", DiaChiGiaoHang = "Sa Đéc, Đồng Tháp", SoDienThoaiNhan = "0911222333" }
            );

            // 7. Thêm Chi Tiết Đơn Hàng (Rải đều các loại vải)
            context.ChiTietDonHangs.AddOrUpdate(
                ct => ct.ChiTietDonHangId,
                // Đơn 1, 2, 3 (của Bé Khách Hàng)
                new ChiTietDonHang { ChiTietDonHangId = 1, MaDonHang = 1, SanPhamId = 1, SoLuongMet = 2m, DonGia = 80000m },
                new ChiTietDonHang { ChiTietDonHangId = 2, MaDonHang = 1, SanPhamId = 4, SoLuongMet = 1m, DonGia = 70000m },
                new ChiTietDonHang { ChiTietDonHangId = 3, MaDonHang = 2, SanPhamId = 2, SoLuongMet = 3m, DonGia = 60000m },
                new ChiTietDonHang { ChiTietDonHangId = 4, MaDonHang = 2, SanPhamId = 5, SoLuongMet = 2m, DonGia = 120000m },
                new ChiTietDonHang { ChiTietDonHangId = 5, MaDonHang = 3, SanPhamId = 6, SoLuongMet = 1.5m, DonGia = 100000m },

                // Đơn 4 (Chị Đẹp mua 3m Kate) => 3 * 50k = 150k
                new ChiTietDonHang { ChiTietDonHangId = 6, MaDonHang = 4, SanPhamId = 3, SoLuongMet = 3m, DonGia = 50000m },

                // Đơn 5 (Chị Đẹp gom 3 loại vải) => 160k + 100k + 60k = 320k
                new ChiTietDonHang { ChiTietDonHangId = 7, MaDonHang = 5, SanPhamId = 1, SoLuongMet = 2m, DonGia = 80000m }, // Lụa
                new ChiTietDonHang { ChiTietDonHangId = 8, MaDonHang = 5, SanPhamId = 6, SoLuongMet = 1m, DonGia = 100000m }, // Ren
                new ChiTietDonHang { ChiTietDonHangId = 9, MaDonHang = 5, SanPhamId = 2, SoLuongMet = 1m, DonGia = 60000m }, // Chiffon

                // Đơn 6 (Cô Ba mua sỉ 5m Cotton) => 5 * 70k = 350k
                new ChiTietDonHang { ChiTietDonHangId = 10, MaDonHang = 6, SanPhamId = 4, SoLuongMet = 5m, DonGia = 70000m },

                // Đơn 7 (Cô Ba mua 1m Gấm) => 1 * 120k = 120k
                new ChiTietDonHang { ChiTietDonHangId = 11, MaDonHang = 7, SanPhamId = 5, SoLuongMet = 1m, DonGia = 120000m }
            );

            // 8. Thêm Hóa Đơn (Đổ ra 6 cái hóa đơn đẹp mắt, trừ đơn 3 đang chờ duyệt)
            context.HoaDons.AddOrUpdate(
                hd => hd.MaHoaDon,
                new HoaDon { MaHoaDon = 1, MaDonHang = 1, NhanVienId = 1, NgayLap = DateTime.Now.AddDays(-5), TongTienThanhToan = 230000, 
                    PhuongThucThanhToan = "Chuyển Khoản", TrangThaiThanhToan = "Đã Thanh Toán", GhiChu = "Khách chuyển khoản đủ" },
                new HoaDon { MaHoaDon = 2, MaDonHang = 2, NhanVienId = 1, NgayLap = DateTime.Now.AddDays(-4), TongTienThanhToan = 420000, 
                    PhuongThucThanhToan = "Tiền Mặt", TrangThaiThanhToan = "Đã Thanh Toán", GhiChu = "Ship COD nhận tiền mặt" },
                new HoaDon { MaHoaDon = 3, MaDonHang = 4, NhanVienId = 1, NgayLap = DateTime.Now.AddDays(-3), TongTienThanhToan = 150000, 
                    PhuongThucThanhToan = "Tiền Mặt", TrangThaiThanhToan = "Đã Thanh Toán", GhiChu = "Quét MOMO" },
                new HoaDon { MaHoaDon = 4, MaDonHang = 5, NhanVienId = 1, NgayLap = DateTime.Now.AddDays(-2), TongTienThanhToan = 320000, 
                    PhuongThucThanhToan = "Chuyển Khoản", TrangThaiThanhToan = "Đã Thanh Toán", GhiChu = "Đã nhận qua Vietcombank" },
                new HoaDon { MaHoaDon = 5, MaDonHang = 6, NhanVienId = 1, NgayLap = DateTime.Now.AddDays(-1), TongTienThanhToan = 350000, 
                    PhuongThucThanhToan = "Tiền Mặt", TrangThaiThanhToan = "Đã Thanh Toán", GhiChu = "Thu tiền mặt tại quầy" },
                new HoaDon { MaHoaDon = 6, MaDonHang = 7, NhanVienId = 1, NgayLap = DateTime.Now, TongTienThanhToan = 120000, 
                    PhuongThucThanhToan = "Tiền Mặt", TrangThaiThanhToan = "Đã Thanh Toán", GhiChu = "Thu tiền mặt tại quầy" }
            );
        }
    }
}
