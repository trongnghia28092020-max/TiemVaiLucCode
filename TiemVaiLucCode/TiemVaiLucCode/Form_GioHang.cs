using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadGioHang();
        }

        // ==========================================
        // HIỂN THỊ GIỎ HÀNG
        // ==========================================
        private void LoadGioHang()
        {
            dataGridView1.Rows.Clear();

            int stt = 1;

            foreach (GioHangItem item in GioHangManager.DanhSach)
            {
                dataGridView1.Rows.Add(
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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm muốn xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int index = dataGridView1.CurrentRow.Index;

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