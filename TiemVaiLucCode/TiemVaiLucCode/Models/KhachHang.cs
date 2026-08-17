using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class KhachHang
    {
            [Key]
            public int KhachHangId { get; set; }

            public int? TaiKhoanId { get; set; }

            [ForeignKey("TaiKhoanId")]
            public virtual TaiKhoan TaiKhoan { get; set; }

            [Required]
            [StringLength(100)]
            public string HoTenKhachHang { get; set; }

            [StringLength(15)]
            public string SoDienThoai { get; set; }

            public string DiaChi { get; set; }

            [StringLength(100)]
            public string Email { get; set; }

            public virtual ICollection<DonHang> DonHangs { get; set; }
        }
    }
