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
    public partial class Frm_Card_SanPham : Form
    {
        public Frm_Card_SanPham()
        {
            InitializeComponent();
        }

        private void sanPhamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiemVaiDBDataSet1);

        }

        private void Frm_Card_SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var db = new TaiKhoanContext())
            {
                sanPhamsDataGridView.DataSource = db.SanPhams.ToList();
            }
        }
        private void danhMucIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void sanPhamsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sanPhamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiemVaiDBDataSet1);

        }

        private void maSanPhamTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void maSanPhamLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_ChonMau_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn màu lên
            if (Color_Vai.ShowDialog() == DialogResult.OK)
            {
                // Nếu người dùng nhấn nút OK trong hộp thoại màu
                // Thì mình lấy cái màu họ vừa chọn đổ vào làm màu nền cho PictureBox ptb_MauSac
                ptb_MauSac.BackColor = Color_Vai.Color;

                // (Tùy chọn) Lấy luôn mã màu HEX (như #FF0000) để lưu xuống CSDL nếu muốn
                // string maMau = ColorTranslator.ToHtml(Color_Vai.Color);
                // textBoxMauSac.Text = maMau; // Nhớ đổi tên textBox cho đúng nhé
            }
        }

        private void sanPhamsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Đảm bảo là mình click vào dòng có dữ liệu (không phải click vào tiêu đề cột)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = sanPhamsDataGridView.Rows[e.RowIndex];

                // Dùng chỉ số cột (0, 1, 2...) thay vì tên string để tránh lỗi Name cột
                txt_maSanPham.Text = row.Cells[0].Value?.ToString();    // Cột 0: MaSanPham
                txt_tenSanPham.Text = row.Cells[1].Value?.ToString();   // Cột 1: TenSanPham
                txt_giaBan.Text = row.Cells[2].Value?.ToString();       // Cột 2: GiaBan
                txt_soLuongTon.Text = row.Cells[3].Value?.ToString();   // Cột 3: SoLuongTon

                // Nhớ nha, cột 4 là MauSac, cột 5 mới là ChatLieu
                txt_chatLieu.Text = row.Cells[5].Value?.ToString();     // Cột 5: ChatLieu
                txt_danhMucId.Text = row.Cells[7].Value?.ToString();    // Cột 7: DanhMucId

                // Nếu muốn xử lý Màu Sắc thì nó nằm ở cột số 4 nè
                string mauSac = row.Cells[4].Value?.ToString();
                // panelMauSac.BackColor = Color.FromName(mauSac); // Code đổi màu nếu cần
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            // Trả các TextBox về rỗng
            txt_maSanPham.Clear();
            txt_tenSanPham.Clear();
            txt_giaBan.Clear();
            txt_soLuongTon.Clear();
            txt_chatLieu.Clear();
            txt_danhMucId.Clear();

            // 2. Tìm mã sản phẩm lớn nhất và cộng thêm 1 để hiển thị
            using (var db = new TaiKhoanContext())
            {
                // Kiểm tra xem trong DB có sản phẩm nào chưa, nếu có thì lấy mã lớn nhất, chưa có thì lấy số 0
                int maLonNhat = db.SanPhams.Any() ? db.SanPhams.Max(sp => sp.MaSanPham) : 0;

                // Hiện mã tiếp theo lên ô TextBox
                txt_maSanPham.Text = (maLonNhat + 1).ToString();
            }

            // 3. Khóa ô Mã Sản Phẩm lại, không cho gõ tay vào để tránh lỗi với SQL Server
            txt_maSanPham.ReadOnly = true;

            // Đưa con trỏ chuột nhấp nháy vào ô Tên Sản Phẩm để nhập luôn cho lẹ
            txt_tenSanPham.Focus();
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new TaiKhoanContext())
                {
                    // Lấy dữ liệu từ các ô TextBox và gom thành 1 object SanPham mới
                    var spMoi = new SanPham
                    {
                        TenSanPham = txt_tenSanPham.Text,
                        GiaBan = decimal.Parse(txt_giaBan.Text),
                        SoLuongTon = decimal.Parse(txt_soLuongTon.Text),
                        ChatLieu = txt_chatLieu.Text,
                        DanhMucId = int.Parse(txt_danhMucId.Text),

                        // Lấy tên màu từ ô PictureBox ptb_MauSac
                        MauSac = ptb_MauSac.BackColor.Name
                    };

                    // Thêm vào Database
                    db.SanPhams.Add(spMoi);
                    db.SaveChanges(); // Lưu thay đổi

                    MessageBox.Show("Thêm sản phẩm thành công rồi nha mình ơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(); // Load lại bảng để thấy sản phẩm vừa thêm
                    btn_LamMoi_Click(sender, e); // Gọi luôn nút Làm mới để dọn dẹp ô nhập
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ui, có lỗi nè: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaBo_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn mã sản phẩm chưa
            if (string.IsNullOrEmpty(txt_maSanPham.Text))
            {
                MessageBox.Show("Mình chưa chọn sản phẩm nào để xóa cả!", "Nhắc nhẹ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi lại cho chắc ăn đỡ xóa nhầm
            DialogResult xacNhan = MessageBox.Show("Mình có chắc chắn muốn xóa sản phẩm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                try
                {
                    int maSP = int.Parse(txt_maSanPham.Text);
                    using (var db = new TaiKhoanContext())
                    {
                        // Tìm sản phẩm trong DB theo ID
                        var spXoa = db.SanPhams.Find(maSP);
                        if (spXoa != null)
                        {
                            db.SanPhams.Remove(spXoa); // Bóp cò xóa
                            db.SaveChanges(); // Lưu vào SQL

                            MessageBox.Show("Xóa cái vèo thành công rồi nha!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadData(); // Tải lại bảng
                            btn_LamMoi_Click(sender, e); // Dọn dẹp form
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không xóa được rồi, lỗi nè: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
