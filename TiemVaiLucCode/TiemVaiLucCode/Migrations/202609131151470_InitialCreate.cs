namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDonHangs",
                c => new
                    {
                        ChiTietDonHangId = c.Int(nullable: false, identity: true),
                        MaDonHang = c.Int(nullable: false),
                        SanPhamId = c.Int(nullable: false),
                        SoLuongMet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ChiTietDonHangId)
                .ForeignKey("dbo.DonHangs", t => t.MaDonHang, cascadeDelete: true)
                .ForeignKey("dbo.SanPhams", t => t.SanPhamId, cascadeDelete: true)
                .Index(t => t.MaDonHang)
                .Index(t => t.SanPhamId);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        MaDonHang = c.Int(nullable: false, identity: true),
                        MaKhachHang = c.Int(nullable: false),
                        NgayDat = c.DateTime(nullable: false),
                        TongTien = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TrangThai = c.String(nullable: false, maxLength: 50),
                        DiaChiGiaoHang = c.String(nullable: false),
                        SoDienThoaiNhan = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.MaDonHang)
                .ForeignKey("dbo.KhachHangs", t => t.MaKhachHang, cascadeDelete: true)
                .Index(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.Int(nullable: false, identity: true),
                        TaiKhoanId = c.Int(),
                        HoTenKhachHang = c.String(nullable: false, maxLength: 100),
                        SoDienThoai = c.String(maxLength: 15),
                        DiaChi = c.String(),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.MaKhachHang)
                .ForeignKey("dbo.TaiKhoans", t => t.TaiKhoanId)
                .Index(t => t.TaiKhoanId);
            
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TenDangNhap = c.String(nullable: false, maxLength: 50),
                        MatKhau = c.String(nullable: false),
                        HoTen = c.String(nullable: false, maxLength: 100),
                        Email = c.String(maxLength: 100),
                        SoDienThoai = c.String(maxLength: 15),
                        VaiTro = c.String(nullable: false),
                        NgayTao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        MaSanPham = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(nullable: false, maxLength: 150),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuongTon = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MauSac = c.String(),
                        ChatLieu = c.String(),
                        HinhAnh = c.String(),
                        DanhMucId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaSanPham)
                .ForeignKey("dbo.DanhMucs", t => t.DanhMucId, cascadeDelete: true)
                .Index(t => t.DanhMucId);
            
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        MaDanhMuc = c.Int(nullable: false, identity: true),
                        TenDanhMuc = c.String(nullable: false, maxLength: 100),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.MaDanhMuc);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.Int(nullable: false, identity: true),
                        TaiKhoanId = c.Int(nullable: false),
                        HoTenNhanVien = c.String(nullable: false, maxLength: 100),
                        SoDienThoai = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        ChucVu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.TaiKhoans", t => t.TaiKhoanId, cascadeDelete: true)
                .Index(t => t.TaiKhoanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "TaiKhoanId", "dbo.TaiKhoans");
            DropForeignKey("dbo.ChiTietDonHangs", "SanPhamId", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "DanhMucId", "dbo.DanhMucs");
            DropForeignKey("dbo.KhachHangs", "TaiKhoanId", "dbo.TaiKhoans");
            DropForeignKey("dbo.DonHangs", "MaKhachHang", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "MaDonHang", "dbo.DonHangs");
            DropIndex("dbo.NhanViens", new[] { "TaiKhoanId" });
            DropIndex("dbo.SanPhams", new[] { "DanhMucId" });
            DropIndex("dbo.KhachHangs", new[] { "TaiKhoanId" });
            DropIndex("dbo.DonHangs", new[] { "MaKhachHang" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "SanPhamId" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "MaDonHang" });
            DropTable("dbo.NhanViens");
            DropTable("dbo.DanhMucs");
            DropTable("dbo.SanPhams");
            DropTable("dbo.TaiKhoans");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.ChiTietDonHangs");
        }
    }
}
