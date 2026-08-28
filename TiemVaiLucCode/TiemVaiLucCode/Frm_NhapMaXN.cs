using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace TiemVaiLucCode
{
    public partial class Frm_NhapMaXN : Form
    {
        // Tạo 2 biến để lưu trữ OTP và số điện thoại được truyền qua từ form Quên Mật Khẩu[cite: 11]
        public string maOTP_HeThong = "";
        public string sdtHienTai = "";
        // Hai biến dùng cho đếm ngược
        private int demNguoc = 30;
        
        public Frm_NhapMaXN(string otp, string sdt)
        {
            InitializeComponent();
            maOTP_HeThong = otp;
            sdtHienTai = sdt;
            // 3. Kết nối với Timer kéo thả
            timer_GuiLai.Interval = 1000; // Cứ 1 giây tíc tắc 1 lần
            timer_GuiLai.Tick += timer_GuiLai_Tick;

            BatDauDemNguoc();
        }
        private void BatDauDemNguoc()
        {
            demNguoc = 30;
            label4.ForeColor = Color.Gray;
            label4.Cursor = Cursors.Default;
            label4.Text = $"Chưa nhận được mã. Gửi lại sau ({demNguoc}s)";
            timer_GuiLai.Start(); // Bấm nút start cho đồng hồ chạy
        }

        private void timer_GuiLai_Tick(object sender, EventArgs e)
        {
            demNguoc--;
            if (demNguoc > 0)
            {
                label4.Text = $"Chưa nhận được mã. Gửi lại sau ({demNguoc}s)";
            }
            else
            {
                // Hết 30 giây thì dừng đồng hồ
                timer_GuiLai.Stop();
                label4.Text = "Gửi lại mã";
                label4.ForeColor = Color.Peru;
                label4.Cursor = Cursors.Hand; // Đổi thành hình bàn tay dễ thương
            }
        }

        private async void label4_Click(object sender, EventArgs e)
        {
            if (demNguoc > 0) return; // Chưa hết giờ thì không cho bấm

            label4.Text = "Đang gửi lại mã...";
            label4.Cursor = Cursors.Default;
            label4.ForeColor = Color.Gray;

            Random rand = new Random();
            maOTP_HeThong = rand.Next(100000, 999999).ToString();

            string emailGui = "trongnghia.28092020@gmail.com";
            string matKhauUngDung = "azbc itxw fxxf hnia";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(emailGui);
                mail.To.Add(sdtHienTai);
                mail.Subject = "GỬI LẠI: Mã xác nhận từ Tiệm Vải Lực Code";
                mail.Body = $"Chào mình,\n\nMã xác nhận khôi phục mật khẩu MỚI của mình là: {maOTP_HeThong}\n\nĐừng đưa mã này cho ai nhé!";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(emailGui, matKhauUngDung);

                await smtp.SendMailAsync(mail);
                MessageBox.Show("Đã gửi lại mã xác nhận mới vào Email của mình rồi nha!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BatDauDemNguoc(); // Gửi xong thì quay lại đếm ngược
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa gửi được mã rồi, mình check mạng lại nghen: " + ex.Message, "Lỗi báo về", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label4.Text = "Gửi lại mã";
                label4.ForeColor = Color.Peru;
                label4.Cursor = Cursors.Hand;
            }
        }

        private void Txt_Ma_TextChanged(object sender, EventArgs e)
        {
            SiticoneNetFrameworkUI.SiticoneTextBox txt = sender as SiticoneNetFrameworkUI.SiticoneTextBox;
            if (txt != null && txt.Text.Length > 0)
            {
                // Nếu mình Ctrl+V nguyên 1 chuỗi 6 số vào ô đầu tiên
                if (txt.Name == "siticoneTextBox1" && txt.Text.Length == 6)
                {
                    string pasted = txt.Text;
                    siticoneTextBox1.Text = pasted[0].ToString();
                    siticoneTextBox2.Text = pasted[1].ToString();
                    siticoneTextBox3.Text = pasted[2].ToString();
                    siticoneTextBox4.Text = pasted[3].ToString();
                    siticoneTextBox5.Text = pasted[4].ToString();
                    siticoneTextBox6.Text = pasted[5].ToString();

                    btn_.Focus(); // Tự động nhảy con trỏ sang nút Xác nhận luôn
                    return;
                }

                // Nếu người dùng gõ tay từng số thì tự động nhảy sang ô tiếp theo
                if (txt.Text.Length == 1)
                {
                    if (txt.Name == "siticoneTextBox1") siticoneTextBox2.Focus();
                    else if (txt.Name == "siticoneTextBox2") siticoneTextBox3.Focus();
                    else if (txt.Name == "siticoneTextBox3") siticoneTextBox4.Focus();
                    else if (txt.Name == "siticoneTextBox4") siticoneTextBox5.Focus();
                    else if (txt.Name == "siticoneTextBox5") siticoneTextBox6.Focus();
                    else if (txt.Name == "siticoneTextBox6") btn_.Focus();
                }
            }
        }

        private void lbl_QuayLai_Click(object sender, EventArgs e)
        {
            
            Frm_QuenMK frmQuenMK = new Frm_QuenMK();
            frmQuenMK.Show();
            this.Hide();
        }
    }
}
