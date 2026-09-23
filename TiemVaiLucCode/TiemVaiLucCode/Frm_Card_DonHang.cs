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
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet1.ChiTietDonHangs' table. You can move, or remove it, as needed.
            this.chiTietDonHangsTableAdapter.Fill(this.tiemVaiDBDataSet1.ChiTietDonHangs);

        }
    }
}
