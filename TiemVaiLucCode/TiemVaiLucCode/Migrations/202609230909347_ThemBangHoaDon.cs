namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemBangHoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDon",
                c => new
                    {
                        MaHoaDon = c.Int(nullable: false, identity: true),
                        MaDonHang = c.Int(nullable: false),
                        NhanVienId = c.Int(),
                        NgayLap = c.DateTime(nullable: false),
                        TongTienThanhToan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PhuongThucThanhToan = c.String(maxLength: 50),
                        TrangThaiThanhToan = c.String(maxLength: 50),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.MaHoaDon)
                .ForeignKey("dbo.DonHangs", t => t.MaDonHang, cascadeDelete: true)
                .ForeignKey("dbo.NhanViens", t => t.NhanVienId)
                .Index(t => t.MaDonHang)
                .Index(t => t.NhanVienId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDon", "NhanVienId", "dbo.NhanViens");
            DropForeignKey("dbo.HoaDon", "MaDonHang", "dbo.DonHangs");
            DropIndex("dbo.HoaDon", new[] { "NhanVienId" });
            DropIndex("dbo.HoaDon", new[] { "MaDonHang" });
            DropTable("dbo.HoaDon");
        }
    }
}
