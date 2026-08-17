namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        DanhMucId = c.Int(nullable: false, identity: true),
                        TenDanhMuc = c.String(nullable: false, maxLength: 100),
                        MoTa = c.String(),
                    })
                .PrimaryKey(t => t.DanhMucId);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        SanPhamId = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(nullable: false, maxLength: 150),
                        GiaBan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SoLuongTon = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MauSac = c.String(),
                        ChatLieu = c.String(),
                        HinhAnh = c.String(),
                        DanhMucId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SanPhamId)
                .ForeignKey("dbo.DanhMucs", t => t.DanhMucId, cascadeDelete: true)
                .Index(t => t.DanhMucId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SanPhams", "DanhMucId", "dbo.DanhMucs");
            DropIndex("dbo.SanPhams", new[] { "DanhMucId" });
            DropTable("dbo.SanPhams");
            DropTable("dbo.DanhMucs");
        }
    }
}
