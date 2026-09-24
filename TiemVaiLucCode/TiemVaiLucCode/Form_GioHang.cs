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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn sản phẩm muốn xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (index >= 0 &&
                index < GioHangManager.DanhSach.Count)
            {
                GioHangManager.DanhSach.RemoveAt(index);
            }

            LoadGioHang();
        }

        // ==========================================
        // NÚT THANH TOÁN
        // ==========================================
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

            decimal tongTien = GioHangManager.TongTien();

            MessageBox.Show(
                "Tổng tiền: " +
                tongTien.ToString("N0") +
                " VNĐ",
                "Thanh toán",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Bước tiếp theo sẽ mở Frm_TT_KhachHang
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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