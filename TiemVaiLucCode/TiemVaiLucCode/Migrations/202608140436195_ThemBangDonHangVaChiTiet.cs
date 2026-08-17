namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemBangDonHangVaChiTiet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDonHangs",
                c => new
                    {
                        ChiTietDonHangId = c.Int(nullable: false, identity: true),
                        DonHangId = c.Int(nullable: false),
                        SanPhamId = c.Int(nullable: false),
                        SoLuongMet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DonGia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ChiTietDonHangId)
                .ForeignKey("dbo.DonHangs", t => t.DonHangId, cascadeDelete: true)
                .ForeignKey("dbo.SanPhams", t => t.SanPhamId, cascadeDelete: true)
                .Index(t => t.DonHangId)
                .Index(t => t.SanPhamId);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        DonHangId = c.Int(nullable: false, identity: true),
                        KhachHangId = c.Int(nullable: false),
                        NgayDat = c.DateTime(nullable: false),
                        TongTien = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TrangThai = c.String(nullable: false, maxLength: 50),
                        DiaChiGiaoHang = c.String(nullable: false),
                        SoDienThoaiNhan = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.DonHangId)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHangId, cascadeDelete: true)
                .Index(t => t.KhachHangId);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangId = c.Int(nullable: false, identity: true),
                        TaiKhoanId = c.Int(),
                        HoTenKhachHang = c.String(nullable: false, maxLength: 100),
                        SoDienThoai = c.String(maxLength: 15),
                        DiaChi = c.String(),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.KhachHangId)
                .ForeignKey("dbo.TaiKhoans", t => t.TaiKhoanId)
                .Index(t => t.TaiKhoanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDonHangs", "SanPhamId", "dbo.SanPhams");
            DropForeignKey("dbo.KhachHangs", "TaiKhoanId", "dbo.TaiKhoans");
            DropForeignKey("dbo.DonHangs", "KhachHangId", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "DonHangId", "dbo.DonHangs");
            DropIndex("dbo.KhachHangs", new[] { "TaiKhoanId" });
            DropIndex("dbo.DonHangs", new[] { "KhachHangId" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "SanPhamId" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "DonHangId" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.ChiTietDonHangs");
        }
    }
}
