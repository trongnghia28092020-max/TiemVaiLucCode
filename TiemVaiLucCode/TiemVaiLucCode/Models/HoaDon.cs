using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemVaiLucCode.Models
{
        [Table("HoaDon")]
        public class HoaDon
        {
            [Key]
            public int MaHoaDon { get; set; }

            // Liên kết với đơn hàng đã đặt
            [Required]
            public int MaDonHang { get; set; }

            [ForeignKey("MaDonHang")]
            public virtual DonHang DonHang { get; set; }

            // Liên kết với nhân viên lập hóa đơn (có thể cho phép null nếu hệ thống tự động chốt)
            public int? NhanVienId { get; set; }

            [ForeignKey("NhanVienId")]
            public virtual NhanVien NhanVien { get; set; }

            public DateTime NgayLap { get; set; } = DateTime.Now;

            [Required]
            public decimal TongTienThanhToan { get; set; } // Có thể bằng tổng đơn hàng + phí ship hoặc trừ mã giảm giá

            [StringLength(50)]
            public string PhuongThucThanhToan { get; set; } // Ví dụ: "TienMat", "ChuyenKhoan", "QuetMaQR"

            [StringLength(50)]
            public string TrangThaiThanhToan { get; set; } // Ví dụ: "DaThanhToan", "ChuaThanhToan"

            public string GhiChu { get; set; } // Ghi chú thêm (VD: "Khách chuyển khoản thiếu 2k cho qua luôn")
        }
    }

