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
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void pnlCard_DangNhap_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbldk_Click(object sender, EventArgs e)
        {
            pnlCard_DangKy.BringToFront();
        }

        private void lbldn_Click(object sender, EventArgs e)
        {
            pnlCard_DangNhap.BringToFront();
        }

        private void txt_DangNhap_Click(object sender, EventArgs e)
        {
        }

        private void txt_DangNhap_Enter(object sender, EventArgs e)
        {

            if (txt_DangNhap.Text == "Tên đăng nhập")
            {
                txt_DangNhap.Text = "";
                txt_DangNhap.ForeColor = Color.Black;
            }
        }

        private void txt_DangNhap_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_DangNhap.Text))
            {
                txt_DangNhap.Text = "Tên đăng nhập";
                txt_DangNhap.ForeColor = Color.Gray;
            }
        }

        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "Mật khẩu")
            {
                txt_MatKhau.Text = "";
                txt_MatKhau.ForeColor = Color.Black;
            }
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_MatKhau.Text))
            {
                txt_MatKhau.Text = "Mật khẩu";
                txt_MatKhau.ForeColor = Color.Gray;
            }
        }
    }
}
