using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class DonHang
    {
        [Key]
        public int DonHangId { get; set; }

        [Required]
        public int KhachHangId { get; set; } 

        [ForeignKey("KhachHangId")]
        public virtual KhachHang KhachHang { get; set; }

        public DateTime NgayDat { get; set; } = DateTime.Now;

        [Required]
        public decimal TongTien { get; set; }

        [Required]
        [StringLength(50)]
        public string TrangThai { get; set; }

        [Required]
        public string DiaChiGiaoHang { get; set; }

        [StringLength(15)]
        public string SoDienThoaiNhan { get; set; }

        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
