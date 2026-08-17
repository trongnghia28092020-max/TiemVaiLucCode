using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class TaiKhoan
    {
        [Key] // Khóa chính
        public int ID { get; set; }

        [Required] // Bắt buộc nhập
        [StringLength(50)] // Giới hạn độ dài
        public string TenDangNhap { get; set; }

        [Required]
        public string MatKhau { get; set; } // Nên lưu dưới dạng đã Hash nhé mình

        [Required]
        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(15)]
        public string SoDienThoai { get; set; }

        [Required]
        public string VaiTro { get; set; } //Admin or KhachHang

        public DateTime NgayTao { get; set; } = DateTime.Now;
    
}
}
