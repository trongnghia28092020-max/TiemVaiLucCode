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
            this.tableAdapterManager.UpdateAll(this.tiemVaiDBDataSet);

        }

        private void Frm_Card_SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiemVaiDBDataSet.SanPhams' table. You can move, or remove it, as needed.
            this.sanPhamsTableAdapter.Fill(this.tiemVaiDBDataSet.SanPhams);

        }
    }
}
