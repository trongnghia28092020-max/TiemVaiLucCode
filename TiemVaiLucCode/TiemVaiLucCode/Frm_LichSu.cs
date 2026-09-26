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
    public partial class Frm_LichSu : Form
    {
        public Frm_LichSu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Frm_LichSu_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho ngày tháng và trạng thái
            dateTimePicker1.Value = DateTime.Now.AddMonths(-1); // Lùi lại 1 tháng
            dateTimePicker2.Value = DateTime.Now;

            cmb_TrangThai.Items.Clear();
            cmb_TrangThai.Items.Add("Tất cả");
            cmb_TrangThai.Items.Add("Hoàn Thành");
            cmb_TrangThai.Items.Add("Đang Chờ");
            cmb_TrangThai.Items.Add("Đã Hủy");
            cmb_TrangThai.SelectedIndex = 0;

            // Load dữ liệu lần đầu
            LoadLichSuMuaHang();
        }
        private void LoadLichSuMuaHang()
        {
            dataGridView1.Rows.Clear();

            using (var db = new TaiKhoanContext())
            {
                DateTime tuNgay = dateTimePicker1.Value.Date;
                DateTime denNgay = dateTimePicker2.Value.Date.AddDays(1).AddTicks(-1); // Kéo dài đến hết ngày hôm đó
                string tuKhoa = textBox1.Text.Trim().ToLower();
                string trangThai = cmb_TrangThai.Text;

                // Lọc cơ bản theo khoảng thời gian
                var query = db.DonHangs.Where(dh => dh.NgayDat >= tuNgay && dh.NgayDat <= denNgay).AsQueryable();

                // Lọc theo trạng thái nếu không chọn "Tất cả"
                if (trangThai != "Tất cả")
                {
                    query = query.Where(dh => dh.TrangThai == trangThai);
                }

                var danhSach = query.ToList();

                // Lọc tiếp theo từ khóa mã đơn hàng (nếu có gõ)
                if (!string.IsNullOrEmpty(tuKhoa))
                {
                    danhSach = danhSach.Where(dh => dh.MaDonHang.ToString().Contains(tuKhoa)).ToList();
                }

                // Đổ dữ liệu lên bảng
                int stt = 1;
                foreach (var dh in danhSach.OrderByDescending(d => d.NgayDat))
                {
                    dataGridView1.Rows.Add(
                        stt++,
                        "DH" + dh.MaDonHang,
                        dh.NgayDat.ToString("dd/MM/yyyy HH:mm"),
                        dh.TrangThai,
                        dh.TongTien.ToString("N0") + " VNĐ"
                    );
                }
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            LoadLichSuMuaHang();
        }

        private void cmb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLichSuMuaHang();
        }
    }
}
