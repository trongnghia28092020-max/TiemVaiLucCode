using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet1.SanPhams' table. You can move, or remove it, as needed.
            this.sanPhamsTableAdapter.Fill(this.tiemVaiDBDataSet1.SanPhams);
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet1.SanPhams' table. You can move, or remove it, as needed.
            this.sanPhamsTableAdapter.Fill(this.tiemVaiDBDataSet1.SanPhams);
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet1.DonHangs' table. You can move, or remove it, as needed.
            //this.donHangsTableAdapter.Fill(this.tiemVaiDBDataSet1.DonHangs);
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet.SanPhams' table. You can move, or remove it, as needed.
            this.sanPhamsTableAdapter.Fill(this.tiemVaiDBDataSet1.SanPhams);

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
    }
}
