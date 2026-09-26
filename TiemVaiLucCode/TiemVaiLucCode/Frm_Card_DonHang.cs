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

namespace TiemVaiLucCode
{
    public partial class Frm_Card_DonHang : Form
    {
        public Frm_Card_DonHang()
        {
            InitializeComponent();
        }

        private void chiTietDonHangsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.chiTietDonHangsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiemVaiDBDataSet1);

        }

        private void Frm_Card_DonHang_Load(object sender, EventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            using (var db = new TaiKhoanContext()) // Nếu context tên khác thì mình đổi lại nha
            {
                // Lấy dữ liệu gán vào DataGridView
                chiTietDonHangsDataGridView.DataSource = db.ChiTietDonHangs.ToList();
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_TimKiem.Text.Trim().ToLower();

            using (var db = new TaiKhoanContext())
            {
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    // Trống thì load toàn bộ lại
                    chiTietDonHangsDataGridView.DataSource = db.ChiTietDonHangs.ToList();
                }
                else
                {
                    // Lọc theo Mã Đơn Hàng, Mã Sản Phẩm hoặc ID Chi tiết
                    var ketQua = db.ChiTietDonHangs.Where(ct =>
                        ct.MaDonHang.ToString().Contains(tuKhoa) ||
                        ct.SanPhamId.ToString().Contains(tuKhoa) ||
                        ct.ChiTietDonHangId.ToString().Contains(tuKhoa)
                    ).ToList();

                    // Đổ lên DataGridView
                    chiTietDonHangsDataGridView.DataSource = ketQua;
                }
            }
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            txt_TimKiem.Clear();

            // 2. Gọi lại hàm LoadData để cập nhật lỡ có đơn hàng mới vừa được khách đặt
            LoadData();

            // 3. Đưa con trỏ chuột nhấp nháy lại vào ô tìm kiếm cho tiện
            txt_TimKiem.Focus();
        }

        private void chiTietDonHangsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem đang vẽ dữ liệu ở cột "MaDonHang" đúng không
            if (chiTietDonHangsDataGridView.Columns[e.ColumnIndex].DataPropertyName == "MaDonHang" && e.Value != null)
            {
                // Gắn thêm chữ DH đằng trước con số thật
                e.Value = "DH" + e.Value.ToString();
                e.FormattingApplied = true; // Báo cho hệ thống biết là "Tui trang điểm xong rồi nha"
            }
        }
    }
}
