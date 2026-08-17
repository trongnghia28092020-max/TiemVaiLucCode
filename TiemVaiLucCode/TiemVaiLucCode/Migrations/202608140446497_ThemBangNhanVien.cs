namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemBangNhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienId = c.Int(nullable: false, identity: true),
                        TaiKhoanId = c.Int(nullable: false),
                        HoTenNhanVien = c.String(nullable: false, maxLength: 100),
                        SoDienThoai = c.String(maxLength: 15),
                        Email = c.String(maxLength: 100),
                        ChucVu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NhanVienId)
                .ForeignKey("dbo.TaiKhoans", t => t.TaiKhoanId, cascadeDelete: true)
                .Index(t => t.TaiKhoanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "TaiKhoanId", "dbo.TaiKhoans");
            DropIndex("dbo.NhanViens", new[] { "TaiKhoanId" });
            DropTable("dbo.NhanViens");
        }
    }
}
