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
using System.Windows.Forms.DataVisualization.Charting;


namespace TiemVaiLucCode
{
    public partial class Frm_TrangChu_Admin : Form
    {
        // Khai báo biến để nhớ form con nào đang mở
        private Form formDangMo;

        public Frm_TrangChu_Admin()
        {
            InitializeComponent();
            CapNhatThongKe(); // Cập nhật thống kê khi form được khởi tạo

        }

        // --- HÀM TÍNH TOÁN & CẬP NHẬT 4 Ô THỐNG KÊ ---
        private void CapNhatThongKe()
        {
            try
            {
                using (var db = new TaiKhoanContext())
                {
                    DateTime homNay = DateTime.Now;

                    // 1. CỘNG DOANH THU HÔM NAY: 
                    // Lọc những hóa đơn có trạng thái "Đã Thanh Toán" và lập trong ngày hôm nay
                    var doanhThu = db.HoaDons
                        .Where(hd => hd.TrangThaiThanhToan == "Đã Thanh Toán"
                                  && hd.NgayLap.Year == homNay.Year
                                  && hd.NgayLap.Month == homNay.Month
                                  && hd.NgayLap.Day == homNay.Day)
                        .Sum(hd => (decimal?)hd.TongTienThanhToan) ?? 0;

                    txt_DoanhThu.Text = doanhThu.ToString("N0") + " VNĐ"; // Định dạng tiền có dấu phẩy

                    // 2. ĐẾM SỐ ĐƠN HÀNG: Khách đặt bao nhiêu thì đếm bấy nhiêu
                    int soDonHang = db.DonHangs.Count();
                    txt_DonHang.Text = soDonHang.ToString();

                    // 3. ĐẾM SỐ SẢN PHẨM: Đổ vào siticoneTextBox1
                    int soSanPham = db.SanPhams.Count();
                    siticoneTextBox1.Text = soSanPham.ToString();

                    // 4. ĐẾM SỐ HÓA ĐƠN: Đổ vào siticoneTextBox2
                    int soHoaDon = db.HoaDons.Count();
                    siticoneTextBox2.Text = soHoaDon.ToString();
                }
            }
            catch (Exception ex)
            {
                // Bắt lỗi nhẹ lỡ CSDL chưa có dữ liệu để chương trình không bị văng
                Console.WriteLine("Lỗi thống kê: " + ex.Message);
            }
        }

        private void LoadChart_DoanhThuTheoSanPham()
        {
            try
            {
                using (var db = new TaiKhoanContext()) //
                {
                    // Lấy dữ liệu chi tiết đơn hàng, gom nhóm theo Tên sản phẩm và tính tổng tiền
                    // (Giả định bảng ChiTietDonHangs có kết nối tới SanPham và có SoLuong, DonGia)
                    var data = db.ChiTietDonHangs
                                 .GroupBy(ct => ct.SanPham.TenSanPham)
                                 .Select(g => new
                                 {
                                     TenSanPham = g.Key,
                                     // Tính tổng doanh thu = Số lượng * Đơn giá
                                     TongDoanhThu = g.Sum(x => x.SoLuongMet * x.DonGia)
                                 })
                                 .OrderByDescending(x => x.TongDoanhThu) // Sắp xếp giảm dần để đưa SP bán chạy lên đầu
                                 .Take(5) // Chỉ lấy Top 5 sản phẩm bán chạy nhất để biểu đồ không bị rối
                                 .ToList();

                    // Làm sạch chart trước khi vẽ
                    chart_TongSPBanChay.Series.Clear();
                    chart_TongSPBanChay.Titles.Clear();

                    // Thêm tiêu đề
                    chart_TongSPBanChay.Titles.Add("Top 5 Sản Phẩm Có Doanh Thu Cao Nhất");
                    chart_TongSPBanChay.Titles[0].Font = new Font("Times New Roman", 14, FontStyle.Bold);

                    // Tạo Series mới dạng cột (Column) - nếu mình thích biểu đồ tròn thì đổi thành .Pie nha
                    var series = chart_TongSPBanChay.Series.Add("DoanhThuSanPham");
                    series.ChartType = SeriesChartType.Column;

                    // Đổ dữ liệu vào Chart
                    foreach (var item in data)
                    {
                        series.Points.AddXY(item.TenSanPham, item.TongDoanhThu);
                    }

                    // Hiển thị số tiền trực tiếp trên đầu mỗi cột
                    series.IsValueShownAsLabel = true;
                    series.LabelFormat = "{0:N0} đ"; // Định dạng tiền tệ có dấu phẩy

                    // Trang trí thêm cho cột
                    series.Palette = ChartColorPalette.Pastel;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi vẽ biểu đồ: " + ex.Message);
            }
        }

        private void TinhTongDoanhThuThang(int thang)
        {
            try
            {
                using (var db = new TaiKhoanContext())
                {
                    int namHienTai = DateTime.Now.Year;

                    // Lọc hóa đơn "Đã Thanh Toán", đúng tháng được chọn và đúng năm hiện tại
                    var doanhThuThang = db.HoaDons
                        .Where(hd => hd.TrangThaiThanhToan == "Đã Thanh Toán"
                                  && hd.NgayLap.Month == thang
                                  && hd.NgayLap.Year == namHienTai)
                        .Sum(hd => (decimal?)hd.TongTienThanhToan) ?? 0;

                    // Hiển thị kết quả lên ô textbox
                    txt_TongDoanhThu.Text = doanhThuThang.ToString("N0") + " VNĐ";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tính doanh thu tháng: " + ex.Message);
                txt_TongDoanhThu.Text = "0 VNĐ";
            }
        }

        private void Mo_Card_ChildFrom(Form childForm)
        {
            // Nếu có form nào đang mở thì đóng nó lại
            if (formDangMo != null)
            {
                formDangMo.Close();
            }

            formDangMo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; // Lấp đầy Panel

            // Cho form con vào pnl_ManHinhChinh
            pnl_ManHinhChinh.Controls.Add(childForm);
            pnl_ManHinhChinh.Tag = childForm;

            // Kéo form con lên trên cùng để che cái Dashboard tổng quan đi
            childForm.BringToFront();
            childForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Card_SanPham_Click(object sender, EventArgs e)
        {
            Mo_Card_ChildFrom(new Frm_Card_SanPham());
        }

        private void Card_TongQuan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bé form con nào đang đứng trên sân khấu không
            if (formDangMo != null)
            {
                formDangMo.Close(); // Có thì đóng cửa đuổi ẻm xuống
                formDangMo = null;  // Xóa trí nhớ, đánh dấu là sân khấu đang trống
            }
            CapNhatThongKe();
        }

        private void pnl_DonHang_Click(object sender, EventArgs e)
        {
            Mo_Card_ChildFrom(new Frm_Card_DonHang());
        }

        private void pnl_HoaDon_Click(object sender, EventArgs e)
        {
            Mo_Card_ChildFrom(new Frm_Card_HoaDon());
        }

        private void Frm_TrangChu_Admin_Load(object sender, EventArgs e)
        {
            LoadChart_DoanhThuTheoSanPham();
        }

        private void cmb_ChonThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy index của tháng được chọn (index bắt đầu từ 0 nên phải cộng thêm 1)
            // Ví dụ: Chọn "Tháng 1" (index 0) => thang = 1
            int thangDuocChon = cmb_ChonThang.SelectedIndex + 1;

            // Gọi hàm tính tiền
            TinhTongDoanhThuThang(thangDuocChon);
        }
    }
}
