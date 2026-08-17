using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
    public class DanhMuc
    {
        [Key]
        public int DanhMucId { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDanhMuc { get; set; }

        public string MoTa { get; set; }

        // Mối quan hệ: Một danh mục có nhiều sản phẩm
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
