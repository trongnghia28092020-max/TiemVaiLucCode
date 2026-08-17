using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class NhanVien
    {
        [Key]
        public int NhanVienId { get; set; }

        // Liên kết 1-1 với bảng TaiKhoans để lấy thông tin đăng nhập
        public int TaiKhoanId { get; set; }

        [ForeignKey("TaiKhoanId")]
        public virtual TaiKhoan TaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string HoTenNhanVien { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string ChucVu
        {
            get; set; } // Ví dụ: "QuanLy", "NhanVienBanHang"
        }
    }

