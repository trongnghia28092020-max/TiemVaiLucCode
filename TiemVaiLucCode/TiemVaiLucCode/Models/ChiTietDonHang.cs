using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int ChiTietDonHangId { get; set; }

        [Required]
        public int DonHangId { get; set; }

        [ForeignKey("DonHangId")]
        public virtual DonHang DonHang { get; set; }

        [Required]
        public int SanPhamId { get; set; }

        [ForeignKey("SanPhamId")]
        public virtual SanPham SanPham { get; set; }

        [Required]
        public decimal SoLuongMet { get; set; } // Số mét vải khách mua (ví dụ: 2.5 mét)

        [Required]
        public decimal DonGia { get; set; } // Giá của 1 mét vải tại thời điểm mua
    }
}
