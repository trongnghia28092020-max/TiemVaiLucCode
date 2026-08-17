using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    internal class TaiKhoanContext: DbContext
    {
       
        public TaiKhoanContext() : base("TiemVaiConnection") { }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DanhMuc> DanhMucs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }

    }
}
