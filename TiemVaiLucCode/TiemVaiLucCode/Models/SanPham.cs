using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class SanPham
    {
        [Key]
        public int SanPhamId { get; set; }

        [Required]
        [StringLength(150)]
        public string TenSanPham { get; set; }

        public decimal GiaBan { get; set; } // Giá trên mỗi mét vải

        public decimal SoLuongTon { get; set; } // Số mét tồn kho

        public string MauSac { get; set; }

        public string ChatLieu { get; set; }

        public string HinhAnh { get; set; }

        // Khóa ngoại liên kết với DanhMuc
        public int DanhMucId { get; set; }

        [ForeignKey("DanhMucId")]
        public virtual DanhMuc DanhMuc { get; set; }
    }
}
