using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace TiemVaiLucCode
{
    public partial class Frm_NhapMaXN : Form
    {
        // Tạo 2 biến để lưu trữ OTP và số điện thoại được truyền qua từ form Quên Mật Khẩu[cite: 11]
        public string maOTP_HeThong = "";
        public string sdtHienTai = "";
        public Frm_NhapMaXN(string otp, string sdt)
        {
            InitializeComponent();
            maOTP_HeThong = otp;
            sdtHienTai = sdt;
        }
    }
}
