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
    public partial class Frm_Card_HoaDon : Form
    {
        public Frm_Card_HoaDon()
        {
            InitializeComponent();
        }

        private void hoaDonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoaDonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiemVaiDBDataSet2);

        }

        private void Frm_Card_HoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet2.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.tiemVaiDBDataSet2.HoaDon);

        }
    }
}
