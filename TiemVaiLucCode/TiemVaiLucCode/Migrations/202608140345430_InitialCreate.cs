namespace TiemVaiLucCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TaiKhoans");
        }
    }
}
