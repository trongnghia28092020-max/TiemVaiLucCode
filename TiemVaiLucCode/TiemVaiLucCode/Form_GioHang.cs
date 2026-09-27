using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TiemVaiLucCode.Models;

namespace TiemVaiLucCode
{
    public partial class Form_GioHang : Form
    {
        public Form_GioHang()
        {
            InitializeComponent();
        }

        private void Form_GioHang_Load(object sender, EventArgs e)
        {
            dataGridView_GioHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_GioHang.MultiSelect = false;

            LoadGioHang();
        }

        // ==========================================
        // HIỂN THỊ GIỎ HÀNG
        // ==========================================
        private void LoadGioHang()
        {
            dataGridView_GioHang.Rows.Clear();

            int stt = 1;

            foreach (GioHangItem item in GioHangManager.DanhSach)
            {
                dataGridView_GioHang.Rows.Add(
                    stt,
                    item.TenSanPham,
                    item.DonGia.ToString("N0"),
                    item.SoLuongMet,
                    item.MauSac,
                    item.ThanhTien.ToString("N0")
                );

                stt++;
            }
        }

        // ==========================================
        // NÚT XÓA
        // ==========================================
        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn chưa
            if (dataGridView_GioHang.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm muốn xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int index = dataGridView_GioHang.CurrentRow.Index;

            // Kiểm tra index hợp lệ
            if (index < 0 || index >= GioHangManager.DanhSach.Count)
            {
                MessageBox.Show(
                    "Không xác định được sản phẩm cần xóa!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            // Lấy sản phẩm đang chọn
            GioHangItem item = GioHangManager.DanhSach[index];

            // Xác nhận
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa:\n\n" +
                item.TenSanPham + "\n" +
                "Màu: " + item.MauSac + "\n" +
                "Số lượng: " + item.SoLuongMet + " mét",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa khỏi danh sách giỏ hàng
                GioHangManager.DanhSach.RemoveAt(index);

                // Load lại DataGridView
                LoadGioHang();

                MessageBox.Show(
                    "Đã xóa sản phẩm khỏi giỏ hàng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GioHangManager.DanhSach.Count == 0)
            {
                MessageBox.Show(
                    "Giỏ hàng đang trống!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Mở form thanh toán
            Frm_TT_KhachHang frmThanhToan = new Frm_TT_KhachHang();

            frmThanhToan.ShowDialog();

            // Sau khi thanh toán xong thì cập nhật lại giỏ hàng
            LoadGioHang();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_TimKiem.Text.Trim().ToLower();

            using (var db = new TaiKhoanContext())
            {
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    // Trống thì load toàn bộ lại
                    dataGridView_GioHang.DataSource = db.ChiTietDonHangs.ToList();
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
                    dataGridView_GioHang.DataSource = ketQua;
                }
            }
        }
    }
    public class GioHangItem
    {
        public int SanPhamId { get; set; }

        public string TenSanPham { get; set; }

        public string MauSac { get; set; }

        public decimal SoLuongMet { get; set; }

        public decimal DonGia { get; set; }

        public decimal ThanhTien
        {
            get
            {
                return SoLuongMet * DonGia;
            }
        }
    }
    public static class GioHangManager
    {
        public static List<GioHangItem> DanhSach =
            new List<GioHangItem>();

        public static void Them(GioHangItem item)
        {
            var sanPhamCu = DanhSach.FirstOrDefault(x =>
                x.SanPhamId == item.SanPhamId &&
                x.MauSac == item.MauSac);

            if (sanPhamCu != null)
            {
                sanPhamCu.SoLuongMet += item.SoLuongMet;
            }
            else
            {
                DanhSach.Add(item);
            }
        }

        public static void Xoa(GioHangItem item)
        {
            DanhSach.Remove(item);
        }

        public static void XoaTatCa()
        {
            DanhSach.Clear();
        }

        public static decimal TongTien()
        {
            return DanhSach.Sum(x => x.ThanhTien);
        }
    }
}