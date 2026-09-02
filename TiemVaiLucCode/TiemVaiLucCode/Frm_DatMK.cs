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

namespace TiemVaiLucCode
{
    public partial class Frm_DatMK : Form
    {
        private string thongTinTaiKhoan = "";
        public Frm_DatMK(string thongTin)
        {
            InitializeComponent();
            thongTinTaiKhoan = thongTin;
        }

        private void lbl_QuayLaiDN_Click(object sender, EventArgs e)
        {
            Frm_DangNhap frm_DangNhap = new Frm_DangNhap();
            frm_DangNhap.Show();
            this.Hide();
        }

        private void btn_UpdateMK_Click(object sender, EventArgs e)
        {
            string passMoi = txt_NhapMK.Text.Trim();
            string passXacNhan = txt_XacNhanMK.Text.Trim();

            // 1.Ktra rỗng hoặc chưa nhập dữ liệu
            if (string.IsNullOrEmpty(passMoi) || passMoi == "Nhập mật khẩu mới")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NhapMK.Focus();
                return;
            }

            if (string.IsNullOrEmpty(passXacNhan) || passXacNhan == "Xác nhận mật khẩu")
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_XacNhanMK.Focus();
                return;
            }

            // 2. Ràng buộc: Kiểm tra trùng khớp
            if (passMoi != passXacNhan)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_XacNhanMK.Focus();
                return;
            }
            // 3. Ràng buộc: Mật khẩu mới không được trùng mật khẩu cũ
            if (passMoi == "123456")
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NhapMK.Focus();
                return;
            }

            // 4. Cập nhật vào cơ sở dữ liệu qua DbContext (Entity Framework)
            try
            {
                using (var db = new TaiKhoanContext())
                {
                    // Tìm tài khoản theo Email/ Số điện thoại đã xác thực
                    var taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.Email == thongTinTaiKhoan || tk.SoDienThoai == thongTinTaiKhoan);

                    // Trường hợp test chạy thẳng form (chưa có thongTinTaiKhoan), tìm theo pass cũ 123456
                    if (taiKhoan == null)
                    {
                        taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.MatKhau == "123456");
                    }

                    if (taiKhoan != null)
                    {
                        // Cập nhật mật khẩu mới
                        taiKhoan.MatKhau = passMoi;
                        db.SaveChanges(); // Lưu thay đổi vào CSDL

                        MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Chuyển hướng về Form Đăng nhập
                        Frm_DangNhap frmDangNhap = new Frm_DangNhap();
                        frmDangNhap.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy tài khoản cần cập nhật trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
