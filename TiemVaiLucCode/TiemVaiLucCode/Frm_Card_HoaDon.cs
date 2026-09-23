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
using System.IO;
using System.Drawing.Printing;

namespace TiemVaiLucCode
{
    public partial class Frm_Card_HoaDon : Form
    {
        public Frm_Card_HoaDon()
        {
            InitializeComponent();
        }

        private void hoaDonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoaDonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiemVaiDBDataSet2);

        }

        private void Frm_Card_HoaDon_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            using (var db = new TaiKhoanContext()) // Nếu context tên khác thì mình đổi lại nha
            {
                // Lấy dữ liệu gán vào DataGridView
                hoaDonDataGridView.DataSource = db.HoaDons.ToList();
            }
        }

        private void hoaDonDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra tránh click nhầm vào tiêu đề cột
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hoaDonDataGridView.Rows[e.RowIndex];

                // Đổ dữ liệu từ các cột lên TextBox theo đúng thứ tự cột
                txt_maHoaDon.Text = row.Cells[0].Value?.ToString();          // Cột 0
                txt_maDonHang.Text = row.Cells[1].Value?.ToString();         // Cột 1
                txt_nhanVienId.Text = row.Cells[2].Value?.ToString();        // Cột 2

                // Xử lý riêng cho DateTimePicker ngày lập[cite: 17]
                if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayLap))
                {
                    ngayLapDateTimePicker.Value = ngayLap;
                }

                txt_tongTienThanhToan.Text = row.Cells[4].Value?.ToString(); // Cột 4

                // Gán ComboBox (Lưu ý mình gán chéo do cách đặt tên lúc thiết kế nha)[cite: 17]
                cmb_TrangThaiTT.Text = row.Cells[6].Value?.ToString();       // Cột 5: Phương Thức TT
                cmb_PTTT.Text = row.Cells[5].Value?.ToString();             // Cột 6: Trạng Thái TT

                ghiChuTextBox.Text = row.Cells[7].Value?.ToString();         // Cột 7
            }
        }

        private void btn_CapNhatHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_maHoaDon.Text))
            {
                MessageBox.Show("Mình chưa chọn hóa đơn nào để cập nhật kìa!", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new TaiKhoanContext()) // Đổi lại thành TiemVaiContext nếu CSDL chính của mình tên đó nha
                {
                    int maHD = int.Parse(txt_maHoaDon.Text);
                    var hd = db.HoaDons.Find(maHD); // Tìm hóa đơn trong CSDL

                    if (hd != null)
                    {
                        // Cập nhật các thông tin mới từ TextBox/ComboBox vào đối tượng
                        hd.NhanVienId = int.Parse(txt_nhanVienId.Text);
                        hd.NgayLap = ngayLapDateTimePicker.Value;
                        hd.TongTienThanhToan = decimal.Parse(txt_tongTienThanhToan.Text);
                        hd.PhuongThucThanhToan = cmb_PTTT.Text;
                        hd.TrangThaiThanhToan = cmb_TrangThaiTT.Text;
                        hd.GhiChu = ghiChuTextBox.Text;

                        db.SaveChanges(); // Lưu vào SQL Server
                        MessageBox.Show("Cập nhật hóa đơn thành công rực rỡ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData(); // Tải lại bảng để thấy dữ liệu mới
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi mình ơi: " + ex.Message, "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            // 1. Lấy danh sách các dòng đang được chọn (dù mình click 1 ô hay bôi đen nhiều dòng)
            var cacDongDuocChon = hoaDonDataGridView.SelectedCells.Cast<DataGridViewCell>()
                                    .Select(c => c.OwningRow)
                                    .Distinct()
                                    .Where(r => !r.IsNewRow)
                                    .ToList();

            if (cacDongDuocChon.Count == 0)
            {
                MessageBox.Show("Mình nhớ click chọn ít nhất 1 dòng (hoặc kéo chuột chọn nhiều dòng) trên bảng để in nha!", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Dùng StringBuilder để ráp HTML 
            StringBuilder sb = new StringBuilder();

            // Khung sườn HTML & CSS (Có sẵn ma thuật ngắt trang page-break)
            sb.Append(@"
            <html>
            <head>
                <style>
                    body { font-family: 'Segoe UI', Arial, sans-serif; padding: 20px; color: #333; }
                    .header { text-align: center; border-bottom: 2px dashed #000; padding-bottom: 15px; margin-bottom: 15px; }
                    .header h1 { color: #D2691E; margin: 0; font-size: 26px; text-transform: uppercase; }
                    .info p { margin: 5px 0; font-size: 14px; }
                    .table { width: 100%; border-collapse: collapse; margin-top: 15px; }
                    .table th, .table td { border: 1px solid #ddd; padding: 10px; text-align: left; font-size: 14px; }
                    .table th { background-color: #f8f9fa; color: #333; }
                    .total-row { font-size: 18px; font-weight: bold; color: #d9534f; text-align: right; margin-top: 20px; }
                    .footer { text-align: center; margin-top: 30px; font-style: italic; font-size: 13px; color: #666; }
                    .page-break { page-break-after: always; }
                </style>
            </head>
            <body>");

            // 3. Vòng lặp đẻ ra Hóa Đơn dựa trên số dòng mình đã chọn
            for (int i = 0; i < cacDongDuocChon.Count; i++)
            {
                DataGridViewRow row = cacDongDuocChon[i];

                string maHD = row.Cells[0].Value?.ToString();
                string maDH = row.Cells[1].Value?.ToString();
                string nhanVienId = row.Cells[2].Value?.ToString();

                string ngayLap = "";
                if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime dt))
                    ngayLap = dt.ToString("dd/MM/yyyy HH:mm");

                string tongTienStr = row.Cells[4].Value?.ToString() ?? "0";
                string tienChu = decimal.Parse(tongTienStr).ToString("N0") + " VNĐ";
                string pttt = row.Cells[5].Value?.ToString();
                string trangThai = row.Cells[6].Value?.ToString();
                string ghiChu = row.Cells[7].Value?.ToString();

                sb.Append($@"
                <div class='header'>
                    <h1>🎀 TIỆM VẢI LỰC CODE 🎀</h1>
                    <p>Địa chỉ: Mỹ Ngãi, Cao Lãnh, Đồng Tháp</p>
                    <p>Điện thoại: 0987.654.321</p>
                </div>
        
                <div class='info'>
                    <p><b>Mã Hóa Đơn:</b> #{maHD}</p>
                    <p><b>Ngày Lập:</b> {ngayLap}</p>
                    <p><b>Thu Ngân:</b> Nhân viên ID {nhanVienId}</p>
                    <p><b>Hình Thức:</b> {pttt} - {trangThai}</p>
                    <p><b>Ghi Chú:</b> {ghiChu}</p>
                </div>

                <table class='table'>
                    <tr>
                        <th>Nội dung thanh toán</th>
                        <th style='text-align: right;'>Thành tiền</th>
                    </tr>
                    <tr>
                        <td>Thanh toán cho Đơn Hàng mã số #{maDH}</td>
                        <td style='text-align: right;'>{tienChu}</td>
                    </tr>
                </table>

                <div class='total-row'>
                    TỔNG THANH TOÁN: {tienChu}
                </div>

                <div class='footer'>
                    <p>*** Cảm ơn quý khách đã ủng hộ Tiệm Vải Lực Code! ***</p>
                    <p>Hàng mua rồi vui lòng đổi trả trong vòng 3 ngày (Kèm bill)</p>
                </div>");

                // Ngắt trang nếu chưa phải là tờ bill cuối cùng trong nhóm đang chọn
                if (i < cacDongDuocChon.Count - 1)
                {
                    sb.Append("<div class='page-break'></div>");
                }
            }

            sb.Append("</body></html>");

            // 4. Bung lụa Form xem trước
            Form frmPreview = new Form();
            frmPreview.Text = "Xem Trước Hóa Đơn - Tiệm Vải Lực Code";
            frmPreview.WindowState = FormWindowState.Maximized;
            frmPreview.Icon = SystemIcons.Information;

            WebBrowser wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            wb.DocumentText = sb.ToString();

            Button btnPrint = new Button();
            btnPrint.Text = $"🖨️ XÁC NHẬN IN {cacDongDuocChon.Count} HÓA ĐƠN";
            btnPrint.Dock = DockStyle.Top;
            btnPrint.Height = 60;
            btnPrint.Font = new Font("Times New Roman", 16, FontStyle.Bold);
            btnPrint.BackColor = Color.MediumTurquoise;
            btnPrint.ForeColor = Color.White;
            btnPrint.Cursor = Cursors.Hand;

            btnPrint.Click += (s, ev) =>
            {
                wb.ShowPrintPreviewDialog();
            };

            frmPreview.Controls.Add(wb);
            frmPreview.Controls.Add(btnPrint);
            frmPreview.ShowDialog();
        }

        private void btn_XuatHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mình đã chọn hóa đơn nào trên giao diện chưa
            if (string.IsNullOrEmpty(txt_maHoaDon.Text))
            {
                MessageBox.Show("Mình nhớ click chọn 1 dòng hóa đơn trên bảng để xuất nha!", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel File|*.xls";
            sfd.Title = "Lưu chi tiết hóa đơn";
            sfd.FileName = "HoaDon_" + txt_maHoaDon.Text + "_" + DateTime.Now.ToString("ddMMyyyy") + ".xls";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int maHD = int.Parse(txt_maHoaDon.Text);
                    int maDH = int.Parse(txt_maDonHang.Text);

                    using (var db = new TaiKhoanContext()) // Đổi thành TiemVaiContext nếu cần nha
                    {
                        var donHang = db.DonHangs.Find(maDH);
                        var khachHang = db.KhachHangs.Find(donHang.MaKhachHang);
                        var chiTietList = db.ChiTietDonHangs.Where(ct => ct.MaDonHang == maDH).ToList();

                        StringBuilder sb = new StringBuilder();

                        // Set form chuẩn Excel (bỏ luôn thẻ <style> gây lỗi)
                        sb.Append("<html xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:x='urn:schemas-microsoft-com:office:excel' xmlns='http://www.w3.org/TR/REC-html40'>");
                        sb.Append("<head><meta charset='utf-8'></head><body>");

                        // Đưa font Times New Roman và size 14px vào thẳng thẻ Table tổng
                        sb.Append("<table style='width: 600px; margin: auto; font-family: \"Times New Roman\", Times, serif; font-size: 14px;'>");

                        // --- PHẦN 1: HEADER TIỆM VẢI ---
                        sb.Append("<tr><td colspan='6' style='text-align: center; font-weight: bold; font-size: 16px;'>TIỆM VẢI LỰC CODE</td></tr>");
                        sb.Append("<tr><td colspan='6' style='text-align: center;'>Địa chỉ: Trường Đại Học Đồng Tháp, Phường Cao Lãnh, Đồng Tháp</td></tr>");
                        sb.Append("<tr><td colspan='6' style='text-align: center;'>SĐT: 0354.455.321 | Email: trongnghia.28092020@gmail.com</td></tr>");
                        sb.Append("<tr><td colspan='6'></td></tr>"); // Dòng trống

                        sb.Append("<tr><td colspan='6' style='text-align: center; font-weight: bold; font-size: 15px;'>HÓA ĐƠN BÁN HÀNG</td></tr>");
                        sb.Append($"<tr><td colspan='6' style='text-align: center;'>Số: HD{maHD:D7}</td></tr>");
                        sb.Append($"<tr><td colspan='6' style='text-align: center; border-bottom: 1px dashed #000;'>Ngày: {ngayLapDateTimePicker.Value.ToString("dd/MM/yyyy")}</td></tr>");

                        // --- PHẦN 2: THÔNG TIN KHÁCH HÀNG ---
                        string tenKhach = khachHang != null ? khachHang.HoTenKhachHang : "Khách vãng lai";
                        string sdtKhach = khachHang != null ? khachHang.SoDienThoai : "Không có";

                        sb.Append("<tr><td colspan='6' style='font-weight: bold; padding-top: 10px;'>KHÁCH HÀNG</td></tr>");
                        sb.Append($"<tr><td colspan='6'>Họ tên: {tenKhach}</td></tr>");
                        sb.Append($"<tr><td colspan='6'>Số điện thoại: {sdtKhach}</td></tr>");
                        sb.Append($"<tr><td colspan='6' style='border-bottom: 1px dashed #000;'>Địa chỉ: {donHang.DiaChiGiaoHang}</td></tr>");

                        // --- PHẦN 3: BẢNG SẢN PHẨM ---
                        sb.Append("<tr style='background-color: #f2f2f2; font-weight: bold; text-align: center;'>");
                        sb.Append("<td style='border: 1px solid #000;'>STT</td><td style='border: 1px solid #000;'>TÊN SẢN PHẨM</td><td style='border: 1px solid #000;'>ĐVT</td><td style='border: 1px solid #000;'>SỐ LƯỢNG</td><td style='border: 1px solid #000;'>ĐƠN GIÁ</td><td style='border: 1px solid #000;'>THÀNH TIỀN</td>");
                        sb.Append("</tr>");

                        int stt = 1;
                        decimal tongTienHang = 0;

                        // Chạy vòng lặp lấy từng loại vải khách mua đổ vô form
                        foreach (var item in chiTietList)
                        {
                            var sp = db.SanPhams.Find(item.SanPhamId);
                            string tenSP = sp != null ? sp.TenSanPham : "Vải không xác định";
                            decimal thanhTien = item.SoLuongMet * item.DonGia;
                            tongTienHang += thanhTien;

                            sb.Append("<tr>");
                            sb.Append($"<td style='text-align: center; border: 1px solid #000;'>{stt++}</td>");
                            sb.Append($"<td style='border: 1px solid #000;'>{tenSP}</td>");
                            sb.Append($"<td style='text-align: center; border: 1px solid #000;'>Mét</td>");
                            sb.Append($"<td style='text-align: center; border: 1px solid #000;'>{item.SoLuongMet}</td>");

                            // Format số tiền có dấu phẩy phân cách ngàn
                            sb.Append($"<td style=\"text-align: right; border: 1px solid #000; mso-number-format:'\\#\\,\\#\\#0'\">{item.DonGia}</td>");
                            sb.Append($"<td style=\"text-align: right; border: 1px solid #000; mso-number-format:'\\#\\,\\#\\#0'\">{thanhTien}</td>");
                            sb.Append("</tr>");
                        }

                        // --- PHẦN 4: TỔNG KẾT VÀ TÍNH TIỀN ---
                        decimal tongThanhToan = decimal.Parse(txt_tongTienThanhToan.Text);
                        decimal giamGia = tongTienHang - tongThanhToan;
                        if (giamGia < 0) giamGia = 0;

                        sb.Append("<tr><td colspan='6' style='border-top: 1px dashed #000;'></td></tr>");
                        sb.Append($"<tr><td colspan='4' style='text-align: right;'>Tạm tính |</td><td colspan='2' style=\"text-align: right; mso-number-format:'\\#\\,\\#\\#0'\">{tongTienHang}</td></tr>");
                        sb.Append($"<tr><td colspan='4' style='text-align: right;'>Giảm giá |</td><td colspan='2' style=\"text-align: right; mso-number-format:'\\#\\,\\#\\#0'\">{giamGia}</td></tr>");
                        sb.Append($"<tr><td colspan='4' style='text-align: right; font-weight: bold;'>TỔNG CỘNG |</td><td colspan='2' style=\"text-align: right; font-weight: bold; border-bottom: 1px dashed #000; mso-number-format:'\\#\\,\\#\\#0'\">{tongThanhToan}</td></tr>");

                        // --- PHẦN 5: CHỮ KÝ VÀ LỜI CẢM ƠN ---
                        sb.Append($"<tr><td colspan='6' style='padding-top: 10px;'>Bằng chữ: ..........................................................................</td></tr>");
                        sb.Append($"<tr><td colspan='6' style='border-bottom: 1px dashed #000;'>Phương thức thanh toán: {cmb_PTTT.Text}</td></tr>");
                        sb.Append("<tr><td colspan='6'></td></tr>");

                        sb.Append("<tr><td colspan='3' style='text-align: center; font-weight: bold;'>NGƯỜI LẬP HÓA ĐƠN</td><td colspan='3' style='text-align: center; font-weight: bold;'>KHÁCH HÀNG</td></tr>");
                        sb.Append("<tr><td colspan='3' style='text-align: center;'>(Ký, ghi rõ họ tên)</td><td colspan='3' style='text-align: center;'>(Ký, ghi rõ họ tên)</td></tr>");
                        sb.Append("<tr><td colspan='6' height='70'></td></tr>");
                        sb.Append("<tr><td colspan='6' style='text-align: center; border-top: 1px dashed #000; font-style: italic; padding-top: 10px;'>Cảm ơn Quý khách đã mua hàng và ủng hộ Tiệm Vải!</td></tr>");

                        sb.Append("</table></body></html>");

                        // Ghi ra file
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            sw.Write(sb.ToString());
                        }

                        MessageBox.Show("Đã xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            // Lấy chữ người dùng vừa gõ (chuyển hết về chữ thường để dễ so sánh)
            string tuKhoa = txt_timKiem.Text.Trim().ToLower();

            using (var db = new TaiKhoanContext())
            {
                // Nếu ô tìm kiếm rỗng thì load lại toàn bộ dữ liệu ban đầu
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    hoaDonDataGridView.DataSource = db.HoaDons.ToList();
                }
                else
                {
                    // Lọc dữ liệu: Nếu Mã HĐ, Mã Đơn Hàng, hoặc Trạng Thái có chứa từ khóa thì lấy ra
                    var ketQua = db.HoaDons.Where(hd =>
                        hd.MaHoaDon.ToString().Contains(tuKhoa) ||
                        hd.MaDonHang.ToString().Contains(tuKhoa) ||
                        hd.TrangThaiThanhToan.ToLower().Contains(tuKhoa) ||
                        hd.PhuongThucThanhToan.ToLower().Contains(tuKhoa)
                    ).ToList();

                    // Đổ kết quả vừa lọc được lên bảng
                    hoaDonDataGridView.DataSource = ketQua;
                }
            }
        }
    }
}
