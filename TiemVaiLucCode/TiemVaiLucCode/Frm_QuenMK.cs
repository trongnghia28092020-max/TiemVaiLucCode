using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Net.Mail;
namespace TiemVaiLucCode
{
    public partial class Frm_QuenMK : Form
    {
        public Frm_QuenMK()
        {
            InitializeComponent();
        }

        private void Frm_QuenMK_Load(object sender, EventArgs e)
        {

        }

        private async void btn_MaXacNhan_Click(object sender, EventArgs e)
        {
            string input = txt_QuenMK.Text.Trim();

            // 1. Kiểm tra xem có nhập dữ liệu chưa nè
            if (string.IsNullOrEmpty(input) || input == "Nhập Email hoặc số điện thoại")
            {
                MessageBox.Show("Mình vui lòng nhập địa chỉ Email nha!", "Thông báo xíu xiu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string emailNhan = input;

            // 2. Random mã OTP 6 chữ số cho may mắn
            Random rand = new Random();
            string otp = rand.Next(100000, 999999).ToString();

            // 3. Cấu hình thông tin Gmail của mình để làm trạm gửi đi
            // LƯU Ý: Nhớ đổi thành Email của mình và "Mật khẩu ứng dụng" nha!
            string emailGui = "trongnghia.28092020@gmail.com";
            string matKhauUngDung = "azbc itxw fxxf hnia";

            try
            {
                // Đổi chữ trên nút xíu cho người dùng biết là đang chạy nè
                btn_MaXacNhan.Text = "ĐANG GỬI MÃ...";
                btn_MaXacNhan.Enabled = false;

                // Soạn thư gửi đi
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailGui);
                mail.To.Add(emailNhan);
                mail.Subject = "Mã xác nhận khôi phục mật khẩu từ Tiệm Vải Lực Code";
                mail.Body = $"Chào mình,\n\nMã xác nhận khôi phục mật khẩu của mình là: {otp}\n\nĐừng đưa mã này cho ai nhé, lộ hết bí mật đó!";

                // Thiết lập trạm bưu điện SMTP của Google
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587; // Port chuẩn của Gmail
                smtp.EnableSsl = true; // Bật bảo mật lên
                smtp.Credentials = new NetworkCredential(emailGui, matKhauUngDung);

                // 4. Bắt đầu gửi thư đi (dùng Async để form không bị đơ)
                await smtp.SendMailAsync(mail);

                // 5. Ting ting! Gửi thành công thì chuyển sang form nhập mã
                MessageBox.Show("Gửi mã xác nhận thành công! Mình mau mở điện thoại kiểm tra Email nha.", "Thành công rồi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gọi và truyền dữ liệu sang Frm_NhapMaXN
                Frm_NhapMaXN frmNhapMa = new Frm_NhapMaXN(otp, emailNhan);
                this.Hide();
                frmNhapMa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa gửi được mã rồi, mình kiểm tra lại kết nối mạng hoặc địa chỉ Email xem sao nhé!\nChi tiết lỗi: " + ex.Message, "Báo lỗi nè", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Dù thành công hay thất bại thì cũng trả lại nút như cũ cho người ta bấm tiếp
                btn_MaXacNhan.Text = "GỬI MÃ XÁC NHẬN";
                btn_MaXacNhan.Enabled = true;
            }
        }
    }
    
}
