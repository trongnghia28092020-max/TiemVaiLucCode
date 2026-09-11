using FontAwesome.Sharp;
using SiticoneNetFrameworkUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiemVaiLucCode.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TiemVaiLucCode
{
    public partial class Frm_DangNhap : Form
    {
        // Khai báo biến rand ở ngoài để dùng chung, giúp random ra số mới liên tục mà không bị trùng
        private Random rand = new Random();

        // Biến lưu mã hiện tại để sau này mình so sánh lúc nhấn nút Đăng Nhập
        public string maCaptchaHienTai = "";
        public Frm_DangNhap()
        {
            InitializeComponent();
            SetupIconMat();
            TaoMaCaptchaMoi();
        }
        
        private void pnlCard_DangNhap_Paint(object sender, PaintEventArgs e)
        { 
        
        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void lbldk_Click(object sender, EventArgs e)
        {
            pnlCard_DangKy.BringToFront();
        }

        private void lbldn_Click(object sender, EventArgs e)
        {
            pnlCard_DangNhap.BringToFront();
        }

        private void txt_DangNhap_Click(object sender, EventArgs e)
        {
        }

        private void txt_DangNhap_Enter(object sender, EventArgs e)
        {

            if (txt_DangNhap.Text == "Email/Tên đăng nhập")
            {
                txt_DangNhap.Text = "";
                txt_DangNhap.ForeColor = Color.Black;
            }
        }

        private void txt_DangNhap_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_DangNhap.Text))
            {
                txt_DangNhap.Text = "Email/Tên đăng nhập";
                txt_DangNhap.ForeColor = Color.Gray;
            }
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "Mật khẩu")
            {
                txt_MatKhau.Text = "";
                txt_MatKhau.ForeColor = Color.Black;
            }
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                txt_MatKhau.Text = "Mật khẩu";
                txt_MatKhau.ForeColor = Color.Gray;
            }
        }

        private void SetupIconMat()
        {
            // 1. Cài đặt trạng thái ban đầu: Ẩn mật khẩu và hiện icon mắt gạch chéo
            txt_MatKhau.UseSystemPasswordChar = true;
            ipb_IconMat.IconChar = IconChar.EyeSlash;
            ipb_IconMat.IconColor = Color.Gray;
            ipb_IconMat.Cursor = Cursors.Hand; // Đổi con trỏ thành bàn tay khi rê vào

            //icon mat cho dangky
            txt_MatKhau_DK.UseSystemPasswordChar = true;
            ipb_IconEye1.IconChar = IconChar.EyeSlash;
            ipb_IconEye1.IconColor = Color.Gray;
            ipb_IconEye1.Cursor = Cursors.Hand;

            txt_XacNhanMK_DK.UseSystemPasswordChar = true;
            ipb_IconEye2.IconChar = IconChar.EyeSlash;
            ipb_IconEye2.IconColor = Color.Gray;
            ipb_IconEye2.Cursor = Cursors.Hand;

        }
        private void ipb_IconMat_Click(object sender, EventArgs e)
        {
            // Đảo trạng thái ẩn / hiện mật khẩu
            txt_MatKhau.UseSystemPasswordChar = !txt_MatKhau.UseSystemPasswordChar;

            if (txt_MatKhau.UseSystemPasswordChar)
            {
                // Đang ẩn -> Đổi về mắt gạch chéo, màu xám
                ipb_IconMat.IconChar = IconChar.EyeSlash;
                ipb_IconMat.IconColor = Color.Gray;
            }
            else
            {
                // Đang hiện -> Đổi sang mắt mở, màu xanh cho nổi bật
                ipb_IconMat.IconChar = IconChar.Eye;
                ipb_IconMat.IconColor = Color.DodgerBlue;
            }
        }

        private void TaoMaCaptchaMoi()
        {
            // Tập hợp các ký tự cho phép (Từ A-Z và 0-9)
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            maCaptchaHienTai = "";

            // Cho vòng lặp chạy 4 lần để bốc ra 4 ký tự ngẫu nhiên
            for (int i = 0; i < 4; i++)
            {
                // Chọn ngẫu nhiên 1 vị trí trong chuỗi chars
                int viTriNgauNhien = rand.Next(chars.Length);
                maCaptchaHienTai += chars[viTriNgauNhien];
            }

            // Gán mã vừa tạo vào Label để hiển thị lên Form
            lbl_MaCaptcha.Text = maCaptchaHienTai;
        }

        private void ptb_TaoMaMoi_Click(object sender, EventArgs e)
        {
            TaoMaCaptchaMoi();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu mình nhập từ các ô trên Form
            string taiKhoan = txt_DangNhap.Text.Trim();
            string matKhau = txt_MatKhau.Text.Trim();
            string vaiTro = cmb_VaiTro.Text.Trim();
            string maCaptchaNhap = txt_MaCaptCha.Text.Trim();

            // 2. Kiểm tra xem có ô nào bị bỏ trống không
            if (string.IsNullOrEmpty(taiKhoan) || taiKhoan == "Email/Tên đăng nhập" ||
                string.IsNullOrEmpty(matKhau) || matKhau == "Mật khẩu" ||
                string.IsNullOrEmpty(vaiTro) || string.IsNullOrEmpty(maCaptchaNhap))
            {
                MessageBox.Show("Mình vui lòng điền đầy đủ thông tin nha!", "Nhắc nhở nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (maCaptchaNhap != maCaptchaHienTai)
            {
                MessageBox.Show("Mã Captcha chưa chính xác rồi, mình nhập lại chữ in hoa cho đúng nhé!", "Lỗi Captcha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaoMaCaptchaMoi();      // Reset lại mã mới luôn[cite: 8]
                txt_MaCaptCha.Clear();  // Xóa trắng ô nhập cũ[cite: 8]
                txt_MaCaptCha.Focus();  // Trỏ chuột lại vào ô Captcha[cite: 8]
                return;
            }

            // 4. Kiểm tra trong Cơ sở dữ liệu (Database)
            // Giả sử mình đang dùng Entity Framework (vì mình thấy mình có tạo class Models.TaiKhoan)
            try
            {
                // LƯU Ý: Thay "Tên_DbContext_Của_Mình" bằng tên file DbContext thực tế trong project của mình nha
                using (var db = new TaiKhoanContext())
                {
                    // Truy vấn kiểm tra: 
                    // (Tên đăng nhập == taiKhoan HOẶC Email == taiKhoan) VÀ Mật khẩu == matKhau VÀ Vai trò == vaiTro
                    var user = db.TaiKhoans.FirstOrDefault(t =>
                        (t.TenDangNhap == taiKhoan || t.Email == taiKhoan) &&
                        t.MatKhau == matKhau &&
                        t.VaiTro == vaiTro);

                    if (user != null)
                    {
                        // Đăng nhập thành công!
                        MessageBox.Show($"Đăng nhập thành công! Chào mừng {user.HoTen} nha ❤️", "Tuyệt vời", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Code chuyển form (ẩn form đăng nhập, mở form hệ thống)
                        this.Hide();
                        Frm_TrangChu_Admin frmTrangChu = new Frm_TrangChu_Admin();
                        frmTrangChu.Show();
                    }
                    else
                    {
                        // Đăng nhập thất bại do sai 1 trong 3 thông tin
                        MessageBox.Show("Tài khoản, email, mật khẩu hoặc vai trò chưa chính xác. Mình kiểm tra lại nhé!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi kết nối dữ liệu nè: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llbl_QuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_QuenMK frmQuenMK = new Frm_QuenMK();
            frmQuenMK.Show();
            this.Hide();
        }

        private void ipb_IconEye1_Click(object sender, EventArgs e)
        {
            txt_MatKhau_DK.UseSystemPasswordChar = !txt_MatKhau_DK.UseSystemPasswordChar;
            if (txt_MatKhau_DK.UseSystemPasswordChar)
            {
                ipb_IconEye1.IconChar = IconChar.EyeSlash;
                ipb_IconEye1.IconColor = Color.Gray;
            }
            else
            {
                ipb_IconEye1.IconChar = IconChar.Eye;
                ipb_IconEye1.IconColor = Color.DodgerBlue;
            }
        }

        private void ipb_IconEye2_Click(object sender, EventArgs e)
        {
            txt_XacNhanMK_DK.UseSystemPasswordChar = !txt_XacNhanMK_DK.UseSystemPasswordChar;
            if (txt_XacNhanMK_DK.UseSystemPasswordChar)
            {
                ipb_IconEye2.IconChar = IconChar.EyeSlash;
                ipb_IconEye2.IconColor = Color.Gray;
            }
            else
            {
                ipb_IconEye2.IconChar = IconChar.Eye;
                ipb_IconEye2.IconColor = Color.DodgerBlue;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các ô nhập
            string hoTen = txt_HoTen.Text.Trim();
            string email = txt_Email.Text.Trim();
            string sdt = txt_SoDT.Text.Trim();
            string vaiTro = cmb_VTro.Text.Trim();
            string matKhau = txt_MatKhau_DK.Text.Trim();
            string xacNhanMK = txt_XacNhanMK_DK.Text.Trim();

            // 1. Ràng buộc: Không được để trống hoặc để nguyên chữ mặc định (Placeholder)
            if (string.IsNullOrEmpty(hoTen) || hoTen == "Họ và Tên" ||
                string.IsNullOrEmpty(email) || email == "Email" ||
                string.IsNullOrEmpty(sdt) || sdt == "Số Điện Thoại" ||
                string.IsNullOrEmpty(vaiTro) ||
                string.IsNullOrEmpty(matKhau) || matKhau == "Mật Khẩu" ||
                string.IsNullOrEmpty(xacNhanMK) || xacNhanMK == "Xác Nhận Mật Khẩu")
            {
                MessageBox.Show("Mình vui lòng điền đầy đủ thông tin để đăng ký nha!", "Nhắc nhở nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ràng buộc: Email phải có chữ @ và dấu chấm
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email có vẻ chưa đúng định dạng rồi, mình kiểm tra lại nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return;
            }

            // 3. Ràng buộc: Số điện thoại phải từ 10 số trở lên và chỉ chứa chữ số
            if (sdt.Length < 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải từ 10 chữ số trở lên và chỉ chứa số thôi mình nhé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_SoDT.Focus();
                return;
            }

            // 4. Ràng buộc: Hai mật khẩu phải khớp nhau
            if (matKhau != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu xác nhận chưa khớp với mật khẩu ở trên rồi kìa!", "Lỗi xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_XacNhanMK_DK.Focus();
                return;
            }

            // 5. Lưu vào Database
            try
            {
                using (var db = new TaiKhoanContext())
                {
                    // Kiểm tra xem Email hoặc Số điện thoại đã bị ai đăng ký chưa
                    bool daTonTai = db.TaiKhoans.Any(tk => tk.Email == email || tk.SoDienThoai == sdt);
                    if (daTonTai)
                    {
                        MessageBox.Show("Email hoặc Số điện thoại này đã được đăng ký rồi, mình thử dùng tài khoản khác nha!", "Trùng thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Gán Tên đăng nhập mặc định là Email luôn để mốt dễ đăng nhập
                    string tenDangNhap = email;
                    // Đóng gói thông tin thành 1 tài khoản mới
                    TaiKhoan taiKhoanMoi = new TaiKhoan()
                    {
                        HoTen = hoTen,
                        Email = email,
                        SoDienThoai = sdt,
                        VaiTro = vaiTro,
                        MatKhau = matKhau,
                        TenDangNhap = tenDangNhap,
                        NgayTao = DateTime.Now
                    };

                    // Lưu vào CSDL
                    db.TaiKhoans.Add(taiKhoanMoi);
                    db.SaveChanges();

                    MessageBox.Show("Đăng ký thành công mỹ mãn! Chào mừng mình đến với Tiệm Vải Lực Code nha ❤️", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đăng ký xong thì tự động lật tấm thẻ về mặt Đăng Nhập cho người ta login luôn
                    pnlCard_DangNhap.BringToFront();

                    // Tiện tay điền sẵn email vừa đăng ký vào ô đăng nhập luôn cho xịn
                    //txt_DangNhap.Text = email;
                    //txt_DangNhap.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi lúc lưu dữ liệu rồi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
