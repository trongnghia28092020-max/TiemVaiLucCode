namespace TiemVaiLucCode
{
    partial class Frm_Card_HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maHoaDonLabel;
            System.Windows.Forms.Label maDonHangLabel;
            System.Windows.Forms.Label nhanVienIdLabel;
            System.Windows.Forms.Label ngayLapLabel;
            System.Windows.Forms.Label tongTienThanhToanLabel;
            System.Windows.Forms.Label phuongThucThanhToanLabel;
            System.Windows.Forms.Label trangThaiThanhToanLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Card_HoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tiemVaiDBDataSet2 = new TiemVaiLucCode.TiemVaiDBDataSet2();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonTableAdapter = new TiemVaiLucCode.TiemVaiDBDataSet2TableAdapters.HoaDonTableAdapter();
            this.tableAdapterManager = new TiemVaiLucCode.TiemVaiDBDataSet2TableAdapters.TableAdapterManager();
            this.hoaDonBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hoaDonBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.hoaDonDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_timKiem = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.txt_maHoaDon = new System.Windows.Forms.TextBox();
            this.txt_maDonHang = new System.Windows.Forms.TextBox();
            this.txt_nhanVienId = new System.Windows.Forms.TextBox();
            this.ngayLapDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txt_tongTienThanhToan = new System.Windows.Forms.TextBox();
            this.ghiChuTextBox = new System.Windows.Forms.TextBox();
            this.cmb_PTTT = new System.Windows.Forms.ComboBox();
            this.cmb_TrangThaiTT = new System.Windows.Forms.ComboBox();
            this.btn_InHD = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btn_XuatHD = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btn_CapNhatHD = new SiticoneNetFrameworkUI.SiticoneButton();
            maHoaDonLabel = new System.Windows.Forms.Label();
            maDonHangLabel = new System.Windows.Forms.Label();
            nhanVienIdLabel = new System.Windows.Forms.Label();
            ngayLapLabel = new System.Windows.Forms.Label();
            tongTienThanhToanLabel = new System.Windows.Forms.Label();
            phuongThucThanhToanLabel = new System.Windows.Forms.Label();
            trangThaiThanhToanLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingNavigator)).BeginInit();
            this.hoaDonBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maHoaDonLabel
            // 
            maHoaDonLabel.AutoSize = true;
            maHoaDonLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maHoaDonLabel.Location = new System.Drawing.Point(18, 93);
            maHoaDonLabel.Name = "maHoaDonLabel";
            maHoaDonLabel.Size = new System.Drawing.Size(101, 19);
            maHoaDonLabel.TabIndex = 3;
            maHoaDonLabel.Text = "Ma Hoa Don:";
            // 
            // maDonHangLabel
            // 
            maDonHangLabel.AutoSize = true;
            maDonHangLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maDonHangLabel.Location = new System.Drawing.Point(601, 96);
            maDonHangLabel.Name = "maDonHangLabel";
            maDonHangLabel.Size = new System.Drawing.Size(108, 19);
            maDonHangLabel.TabIndex = 5;
            maDonHangLabel.Text = "Ma Don Hang:";
            // 
            // nhanVienIdLabel
            // 
            nhanVienIdLabel.AutoSize = true;
            nhanVienIdLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nhanVienIdLabel.Location = new System.Drawing.Point(18, 136);
            nhanVienIdLabel.Name = "nhanVienIdLabel";
            nhanVienIdLabel.Size = new System.Drawing.Size(101, 19);
            nhanVienIdLabel.TabIndex = 7;
            nhanVienIdLabel.Text = "Nhan Vien Id:";
            // 
            // ngayLapLabel
            // 
            ngayLapLabel.AutoSize = true;
            ngayLapLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ngayLapLabel.Location = new System.Drawing.Point(601, 137);
            ngayLapLabel.Name = "ngayLapLabel";
            ngayLapLabel.Size = new System.Drawing.Size(78, 19);
            ngayLapLabel.TabIndex = 9;
            ngayLapLabel.Text = "Ngay Lap:";
            // 
            // tongTienThanhToanLabel
            // 
            tongTienThanhToanLabel.AutoSize = true;
            tongTienThanhToanLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tongTienThanhToanLabel.Location = new System.Drawing.Point(18, 181);
            tongTienThanhToanLabel.Name = "tongTienThanhToanLabel";
            tongTienThanhToanLabel.Size = new System.Drawing.Size(160, 19);
            tongTienThanhToanLabel.TabIndex = 11;
            tongTienThanhToanLabel.Text = "Tong Tien Thanh Toan:";
            // 
            // phuongThucThanhToanLabel
            // 
            phuongThucThanhToanLabel.AutoSize = true;
            phuongThucThanhToanLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phuongThucThanhToanLabel.Location = new System.Drawing.Point(601, 181);
            phuongThucThanhToanLabel.Name = "phuongThucThanhToanLabel";
            phuongThucThanhToanLabel.Size = new System.Drawing.Size(182, 19);
            phuongThucThanhToanLabel.TabIndex = 13;
            phuongThucThanhToanLabel.Text = "Phuong Thuc Thanh Toan:";
            // 
            // trangThaiThanhToanLabel
            // 
            trangThaiThanhToanLabel.AutoSize = true;
            trangThaiThanhToanLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            trangThaiThanhToanLabel.Location = new System.Drawing.Point(18, 219);
            trangThaiThanhToanLabel.Name = "trangThaiThanhToanLabel";
            trangThaiThanhToanLabel.Size = new System.Drawing.Size(164, 19);
            trangThaiThanhToanLabel.TabIndex = 15;
            trangThaiThanhToanLabel.Text = "Trang Thai Thanh Toan:";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ghiChuLabel.Location = new System.Drawing.Point(601, 222);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(70, 19);
            ghiChuLabel.TabIndex = 17;
            ghiChuLabel.Text = "Ghi Chu:";
            // 
            // tiemVaiDBDataSet2
            // 
            this.tiemVaiDBDataSet2.DataSetName = "TiemVaiDBDataSet2";
            this.tiemVaiDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.tiemVaiDBDataSet2;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangsTableAdapter = null;
            this.tableAdapterManager.DanhMucsTableAdapter = null;
            this.tableAdapterManager.DonHangsTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = this.hoaDonTableAdapter;
            this.tableAdapterManager.KhachHangsTableAdapter = null;
            this.tableAdapterManager.NhanViensTableAdapter = null;
            this.tableAdapterManager.SanPhamsTableAdapter = null;
            this.tableAdapterManager.TaiKhoansTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TiemVaiLucCode.TiemVaiDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // hoaDonBindingNavigator
            // 
            this.hoaDonBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hoaDonBindingNavigator.BindingSource = this.hoaDonBindingSource;
            this.hoaDonBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hoaDonBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hoaDonBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hoaDonBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hoaDonBindingNavigatorSaveItem});
            this.hoaDonBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hoaDonBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hoaDonBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hoaDonBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hoaDonBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hoaDonBindingNavigator.Name = "hoaDonBindingNavigator";
            this.hoaDonBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hoaDonBindingNavigator.Size = new System.Drawing.Size(1099, 27);
            this.hoaDonBindingNavigator.TabIndex = 0;
            this.hoaDonBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // hoaDonBindingNavigatorSaveItem
            // 
            this.hoaDonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hoaDonBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hoaDonBindingNavigatorSaveItem.Image")));
            this.hoaDonBindingNavigatorSaveItem.Name = "hoaDonBindingNavigatorSaveItem";
            this.hoaDonBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.hoaDonBindingNavigatorSaveItem.Text = "Save Data";
            this.hoaDonBindingNavigatorSaveItem.Click += new System.EventHandler(this.hoaDonBindingNavigatorSaveItem_Click);
            // 
            // hoaDonDataGridView
            // 
            this.hoaDonDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hoaDonDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.hoaDonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoaDonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hoaDonDataGridView.DataSource = this.hoaDonBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hoaDonDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.hoaDonDataGridView.Location = new System.Drawing.Point(21, 273);
            this.hoaDonDataGridView.Name = "hoaDonDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hoaDonDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.hoaDonDataGridView.RowHeadersWidth = 51;
            this.hoaDonDataGridView.RowTemplate.Height = 24;
            this.hoaDonDataGridView.Size = new System.Drawing.Size(1058, 315);
            this.hoaDonDataGridView.TabIndex = 1;
            this.hoaDonDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoaDonDataGridView_CellClick);
            this.hoaDonDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hoaDonDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaHoaDon";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaDonHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaDonHang";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NhanVienId";
            this.dataGridViewTextBoxColumn3.HeaderText = "NhanVienId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayLap";
            this.dataGridViewTextBoxColumn4.HeaderText = "NgayLap";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TongTienThanhToan";
            this.dataGridViewTextBoxColumn5.HeaderText = "TongTienThanhToan";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PhuongThucThanhToan";
            this.dataGridViewTextBoxColumn6.HeaderText = "PhuongThucThanhToan";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TrangThaiThanhToan";
            this.dataGridViewTextBoxColumn7.HeaderText = "TrangThaiThanhToan";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn8.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // txt_timKiem
            // 
            this.txt_timKiem.AccessibleDescription = "A customizable text input field.";
            this.txt_timKiem.AccessibleName = "Text Box";
            this.txt_timKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_timKiem.BackColor = System.Drawing.Color.Transparent;
            this.txt_timKiem.BlinkCount = 3;
            this.txt_timKiem.BlinkShadow = false;
            this.txt_timKiem.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.txt_timKiem.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.txt_timKiem.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_timKiem.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_timKiem.CanShake = true;
            this.txt_timKiem.ContinuousBlink = false;
            this.txt_timKiem.CornerRadiusBottomLeft = 10;
            this.txt_timKiem.CornerRadiusBottomRight = 10;
            this.txt_timKiem.CornerRadiusTopLeft = 10;
            this.txt_timKiem.CornerRadiusTopRight = 10;
            this.txt_timKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timKiem.CursorBlinkRate = 500;
            this.txt_timKiem.CursorColor = System.Drawing.Color.Black;
            this.txt_timKiem.CursorHeight = 26;
            this.txt_timKiem.CursorOffset = 0;
            this.txt_timKiem.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txt_timKiem.CursorWidth = 1;
            this.txt_timKiem.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_timKiem.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txt_timKiem.DisabledTextColor = System.Drawing.Color.Gray;
            this.txt_timKiem.EnableDropShadow = false;
            this.txt_timKiem.FillColor1 = System.Drawing.Color.White;
            this.txt_timKiem.FillColor2 = System.Drawing.Color.White;
            this.txt_timKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_timKiem.ForeColor = System.Drawing.Color.DimGray;
            this.txt_timKiem.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txt_timKiem.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txt_timKiem.IsEnabled = true;
            this.txt_timKiem.Location = new System.Drawing.Point(21, 31);
            this.txt_timKiem.Name = "txt_timKiem";
            this.txt_timKiem.PlaceholderColor = System.Drawing.Color.Gray;
            this.txt_timKiem.PlaceholderText = " ";
            this.txt_timKiem.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txt_timKiem.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txt_timKiem.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txt_timKiem.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txt_timKiem.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_timKiem.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_timKiem.ShadowAnimationDuration = 1;
            this.txt_timKiem.ShadowBlur = 10;
            this.txt_timKiem.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_timKiem.Size = new System.Drawing.Size(503, 40);
            this.txt_timKiem.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txt_timKiem.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_timKiem.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txt_timKiem.SolidFillColor = System.Drawing.Color.White;
            this.txt_timKiem.TabIndex = 2;
            this.txt_timKiem.Text = "Tìm kiếm theo mã HĐ,....";
            this.txt_timKiem.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txt_timKiem.ValidationErrorMessage = "Invalid input.";
            this.txt_timKiem.ValidationFunction = null;
            this.txt_timKiem.TextChanged += new System.EventHandler(this.txt_timKiem_TextChanged);
            // 
            // txt_maHoaDon
            // 
            this.txt_maHoaDon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaHoaDon", true));
            this.txt_maHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maHoaDon.Location = new System.Drawing.Point(251, 88);
            this.txt_maHoaDon.Name = "txt_maHoaDon";
            this.txt_maHoaDon.Size = new System.Drawing.Size(240, 27);
            this.txt_maHoaDon.TabIndex = 4;
            // 
            // txt_maDonHang
            // 
            this.txt_maDonHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "MaDonHang", true));
            this.txt_maDonHang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maDonHang.Location = new System.Drawing.Point(821, 93);
            this.txt_maDonHang.Name = "txt_maDonHang";
            this.txt_maDonHang.Size = new System.Drawing.Size(258, 27);
            this.txt_maDonHang.TabIndex = 6;
            // 
            // txt_nhanVienId
            // 
            this.txt_nhanVienId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "NhanVienId", true));
            this.txt_nhanVienId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhanVienId.Location = new System.Drawing.Point(251, 131);
            this.txt_nhanVienId.Name = "txt_nhanVienId";
            this.txt_nhanVienId.Size = new System.Drawing.Size(240, 27);
            this.txt_nhanVienId.TabIndex = 8;
            // 
            // ngayLapDateTimePicker
            // 
            this.ngayLapDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hoaDonBindingSource, "NgayLap", true));
            this.ngayLapDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayLapDateTimePicker.Location = new System.Drawing.Point(821, 133);
            this.ngayLapDateTimePicker.Name = "ngayLapDateTimePicker";
            this.ngayLapDateTimePicker.Size = new System.Drawing.Size(258, 27);
            this.ngayLapDateTimePicker.TabIndex = 10;
            // 
            // txt_tongTienThanhToan
            // 
            this.txt_tongTienThanhToan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "TongTienThanhToan", true));
            this.txt_tongTienThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongTienThanhToan.Location = new System.Drawing.Point(251, 176);
            this.txt_tongTienThanhToan.Name = "txt_tongTienThanhToan";
            this.txt_tongTienThanhToan.Size = new System.Drawing.Size(240, 27);
            this.txt_tongTienThanhToan.TabIndex = 12;
            // 
            // ghiChuTextBox
            // 
            this.ghiChuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hoaDonBindingSource, "GhiChu", true));
            this.ghiChuTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghiChuTextBox.Location = new System.Drawing.Point(821, 219);
            this.ghiChuTextBox.Name = "ghiChuTextBox";
            this.ghiChuTextBox.Size = new System.Drawing.Size(258, 27);
            this.ghiChuTextBox.TabIndex = 18;
            // 
            // cmb_PTTT
            // 
            this.cmb_PTTT.FormattingEnabled = true;
            this.cmb_PTTT.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển Khoản"});
            this.cmb_PTTT.Location = new System.Drawing.Point(821, 178);
            this.cmb_PTTT.Name = "cmb_PTTT";
            this.cmb_PTTT.Size = new System.Drawing.Size(258, 24);
            this.cmb_PTTT.TabIndex = 19;
            // 
            // cmb_TrangThaiTT
            // 
            this.cmb_TrangThaiTT.FormattingEnabled = true;
            this.cmb_TrangThaiTT.Items.AddRange(new object[] {
            "Đã Thanh Toán",
            "Chờ Thanh Toán",
            "Đã Hủy"});
            this.cmb_TrangThaiTT.Location = new System.Drawing.Point(251, 216);
            this.cmb_TrangThaiTT.Name = "cmb_TrangThaiTT";
            this.cmb_TrangThaiTT.Size = new System.Drawing.Size(240, 24);
            this.cmb_TrangThaiTT.TabIndex = 20;
            // 
            // btn_InHD
            // 
            this.btn_InHD.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_InHD.AccessibleName = "In Hóa Đơn";
            this.btn_InHD.AutoSizeBasedOnText = false;
            this.btn_InHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_InHD.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_InHD.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_InHD.BadgeValue = 0;
            this.btn_InHD.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_InHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_InHD.BorderWidth = 1;
            this.btn_InHD.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_InHD.ButtonImage = null;
            this.btn_InHD.ButtonTextLeftPadding = 0;
            this.btn_InHD.CanBeep = true;
            this.btn_InHD.CanGlow = false;
            this.btn_InHD.CanShake = true;
            this.btn_InHD.ContextMenuStripEx = null;
            this.btn_InHD.CornerRadiusBottomLeft = 6;
            this.btn_InHD.CornerRadiusBottomRight = 6;
            this.btn_InHD.CornerRadiusTopLeft = 6;
            this.btn_InHD.CornerRadiusTopRight = 6;
            this.btn_InHD.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_InHD.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_InHD.EnableLongPress = false;
            this.btn_InHD.EnableRippleEffect = true;
            this.btn_InHD.EnableShadow = false;
            this.btn_InHD.EnableTextWrapping = false;
            this.btn_InHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_InHD.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_InHD.GlowIntensity = 100;
            this.btn_InHD.GlowRadius = 20F;
            this.btn_InHD.GradientBackground = false;
            this.btn_InHD.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_InHD.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_InHD.HintText = null;
            this.btn_InHD.HoverBackColor = System.Drawing.Color.Aqua;
            this.btn_InHD.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_InHD.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_InHD.HoverTransitionDuration = 140;
            this.btn_InHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_InHD.ImagePadding = 5;
            this.btn_InHD.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_InHD.IsRadial = false;
            this.btn_InHD.IsReadOnly = false;
            this.btn_InHD.IsToggleButton = false;
            this.btn_InHD.IsToggled = false;
            this.btn_InHD.Location = new System.Drawing.Point(790, 30);
            this.btn_InHD.LongPressDurationMS = 1000;
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_InHD.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_InHD.ParticleCount = 15;
            this.btn_InHD.PressAnimationScale = 0.97F;
            this.btn_InHD.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_InHD.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_InHD.PressTransitionDuration = 90;
            this.btn_InHD.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_InHD.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_InHD.RippleRadiusMultiplier = 0.6F;
            this.btn_InHD.ShadowBlur = 5;
            this.btn_InHD.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_InHD.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_InHD.ShakeDuration = 500;
            this.btn_InHD.ShakeIntensity = 5;
            this.btn_InHD.Size = new System.Drawing.Size(135, 40);
            this.btn_InHD.TabIndex = 21;
            this.btn_InHD.Text = "In Hóa Đơn";
            this.btn_InHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_InHD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_InHD.TooltipText = null;
            this.btn_InHD.UseAdvancedRendering = true;
            this.btn_InHD.UseParticles = false;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // btn_XuatHD
            // 
            this.btn_XuatHD.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_XuatHD.AccessibleName = "Xuất Hóa Đơn";
            this.btn_XuatHD.AutoSizeBasedOnText = false;
            this.btn_XuatHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_XuatHD.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_XuatHD.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_XuatHD.BadgeValue = 0;
            this.btn_XuatHD.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_XuatHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_XuatHD.BorderWidth = 1;
            this.btn_XuatHD.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_XuatHD.ButtonImage = null;
            this.btn_XuatHD.ButtonTextLeftPadding = 0;
            this.btn_XuatHD.CanBeep = true;
            this.btn_XuatHD.CanGlow = false;
            this.btn_XuatHD.CanShake = true;
            this.btn_XuatHD.ContextMenuStripEx = null;
            this.btn_XuatHD.CornerRadiusBottomLeft = 6;
            this.btn_XuatHD.CornerRadiusBottomRight = 6;
            this.btn_XuatHD.CornerRadiusTopLeft = 6;
            this.btn_XuatHD.CornerRadiusTopRight = 6;
            this.btn_XuatHD.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_XuatHD.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_XuatHD.EnableLongPress = false;
            this.btn_XuatHD.EnableRippleEffect = true;
            this.btn_XuatHD.EnableShadow = false;
            this.btn_XuatHD.EnableTextWrapping = false;
            this.btn_XuatHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_XuatHD.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XuatHD.GlowIntensity = 100;
            this.btn_XuatHD.GlowRadius = 20F;
            this.btn_XuatHD.GradientBackground = false;
            this.btn_XuatHD.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_XuatHD.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_XuatHD.HintText = null;
            this.btn_XuatHD.HoverBackColor = System.Drawing.Color.OrangeRed;
            this.btn_XuatHD.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_XuatHD.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XuatHD.HoverTransitionDuration = 140;
            this.btn_XuatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XuatHD.ImagePadding = 5;
            this.btn_XuatHD.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_XuatHD.IsRadial = false;
            this.btn_XuatHD.IsReadOnly = false;
            this.btn_XuatHD.IsToggleButton = false;
            this.btn_XuatHD.IsToggled = false;
            this.btn_XuatHD.Location = new System.Drawing.Point(944, 30);
            this.btn_XuatHD.LongPressDurationMS = 1000;
            this.btn_XuatHD.Name = "btn_XuatHD";
            this.btn_XuatHD.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_XuatHD.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_XuatHD.ParticleCount = 15;
            this.btn_XuatHD.PressAnimationScale = 0.97F;
            this.btn_XuatHD.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_XuatHD.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_XuatHD.PressTransitionDuration = 90;
            this.btn_XuatHD.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_XuatHD.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XuatHD.RippleRadiusMultiplier = 0.6F;
            this.btn_XuatHD.ShadowBlur = 5;
            this.btn_XuatHD.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XuatHD.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_XuatHD.ShakeDuration = 500;
            this.btn_XuatHD.ShakeIntensity = 5;
            this.btn_XuatHD.Size = new System.Drawing.Size(135, 40);
            this.btn_XuatHD.TabIndex = 22;
            this.btn_XuatHD.Text = "Xuất Hóa Đơn";
            this.btn_XuatHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_XuatHD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XuatHD.TooltipText = null;
            this.btn_XuatHD.UseAdvancedRendering = true;
            this.btn_XuatHD.UseParticles = false;
            this.btn_XuatHD.Click += new System.EventHandler(this.btn_XuatHD_Click);
            // 
            // btn_CapNhatHD
            // 
            this.btn_CapNhatHD.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_CapNhatHD.AccessibleName = "Cập Nhật Đơn";
            this.btn_CapNhatHD.AutoSizeBasedOnText = false;
            this.btn_CapNhatHD.BackColor = System.Drawing.Color.Transparent;
            this.btn_CapNhatHD.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_CapNhatHD.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_CapNhatHD.BadgeValue = 0;
            this.btn_CapNhatHD.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_CapNhatHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_CapNhatHD.BorderWidth = 1;
            this.btn_CapNhatHD.ButtonBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_CapNhatHD.ButtonImage = null;
            this.btn_CapNhatHD.ButtonTextLeftPadding = 0;
            this.btn_CapNhatHD.CanBeep = true;
            this.btn_CapNhatHD.CanGlow = false;
            this.btn_CapNhatHD.CanShake = true;
            this.btn_CapNhatHD.ContextMenuStripEx = null;
            this.btn_CapNhatHD.CornerRadiusBottomLeft = 6;
            this.btn_CapNhatHD.CornerRadiusBottomRight = 6;
            this.btn_CapNhatHD.CornerRadiusTopLeft = 6;
            this.btn_CapNhatHD.CornerRadiusTopRight = 6;
            this.btn_CapNhatHD.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_CapNhatHD.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_CapNhatHD.EnableLongPress = false;
            this.btn_CapNhatHD.EnableRippleEffect = true;
            this.btn_CapNhatHD.EnableShadow = false;
            this.btn_CapNhatHD.EnableTextWrapping = false;
            this.btn_CapNhatHD.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_CapNhatHD.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CapNhatHD.GlowIntensity = 100;
            this.btn_CapNhatHD.GlowRadius = 20F;
            this.btn_CapNhatHD.GradientBackground = false;
            this.btn_CapNhatHD.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_CapNhatHD.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_CapNhatHD.HintText = null;
            this.btn_CapNhatHD.HoverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_CapNhatHD.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_CapNhatHD.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CapNhatHD.HoverTransitionDuration = 140;
            this.btn_CapNhatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhatHD.ImagePadding = 5;
            this.btn_CapNhatHD.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_CapNhatHD.IsRadial = false;
            this.btn_CapNhatHD.IsReadOnly = false;
            this.btn_CapNhatHD.IsToggleButton = false;
            this.btn_CapNhatHD.IsToggled = false;
            this.btn_CapNhatHD.Location = new System.Drawing.Point(633, 30);
            this.btn_CapNhatHD.LongPressDurationMS = 1000;
            this.btn_CapNhatHD.Name = "btn_CapNhatHD";
            this.btn_CapNhatHD.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_CapNhatHD.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_CapNhatHD.ParticleCount = 15;
            this.btn_CapNhatHD.PressAnimationScale = 0.97F;
            this.btn_CapNhatHD.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_CapNhatHD.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_CapNhatHD.PressTransitionDuration = 90;
            this.btn_CapNhatHD.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_CapNhatHD.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CapNhatHD.RippleRadiusMultiplier = 0.6F;
            this.btn_CapNhatHD.ShadowBlur = 5;
            this.btn_CapNhatHD.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CapNhatHD.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_CapNhatHD.ShakeDuration = 500;
            this.btn_CapNhatHD.ShakeIntensity = 5;
            this.btn_CapNhatHD.Size = new System.Drawing.Size(135, 40);
            this.btn_CapNhatHD.TabIndex = 23;
            this.btn_CapNhatHD.Text = "Cập Nhật Đơn";
            this.btn_CapNhatHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CapNhatHD.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_CapNhatHD.TooltipText = null;
            this.btn_CapNhatHD.UseAdvancedRendering = true;
            this.btn_CapNhatHD.UseParticles = false;
            this.btn_CapNhatHD.Click += new System.EventHandler(this.btn_CapNhatHD_Click);
            // 
            // Frm_Card_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.btn_CapNhatHD);
            this.Controls.Add(this.btn_XuatHD);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.cmb_TrangThaiTT);
            this.Controls.Add(this.cmb_PTTT);
            this.Controls.Add(maHoaDonLabel);
            this.Controls.Add(this.txt_maHoaDon);
            this.Controls.Add(maDonHangLabel);
            this.Controls.Add(this.txt_maDonHang);
            this.Controls.Add(nhanVienIdLabel);
            this.Controls.Add(this.txt_nhanVienId);
            this.Controls.Add(ngayLapLabel);
            this.Controls.Add(this.ngayLapDateTimePicker);
            this.Controls.Add(tongTienThanhToanLabel);
            this.Controls.Add(this.txt_tongTienThanhToan);
            this.Controls.Add(phuongThucThanhToanLabel);
            this.Controls.Add(trangThaiThanhToanLabel);
            this.Controls.Add(ghiChuLabel);
            this.Controls.Add(this.ghiChuTextBox);
            this.Controls.Add(this.txt_timKiem);
            this.Controls.Add(this.hoaDonDataGridView);
            this.Controls.Add(this.hoaDonBindingNavigator);
            this.MaximumSize = new System.Drawing.Size(1117, 647);
            this.MinimumSize = new System.Drawing.Size(1117, 647);
            this.Name = "Frm_Card_HoaDon";
            this.Text = "Frm_Card_HoaDon";
            this.Load += new System.EventHandler(this.Frm_Card_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingNavigator)).EndInit();
            this.hoaDonBindingNavigator.ResumeLayout(false);
            this.hoaDonBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiemVaiDBDataSet2 tiemVaiDBDataSet2;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private TiemVaiDBDataSet2TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private TiemVaiDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hoaDonBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hoaDonBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hoaDonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private SiticoneNetFrameworkUI.SiticoneTextBox txt_timKiem;
        private System.Windows.Forms.TextBox txt_maHoaDon;
        private System.Windows.Forms.TextBox txt_maDonHang;
        private System.Windows.Forms.TextBox txt_nhanVienId;
        private System.Windows.Forms.DateTimePicker ngayLapDateTimePicker;
        private System.Windows.Forms.TextBox txt_tongTienThanhToan;
        private System.Windows.Forms.TextBox ghiChuTextBox;
        private System.Windows.Forms.ComboBox cmb_PTTT;
        private System.Windows.Forms.ComboBox cmb_TrangThaiTT;
        private SiticoneNetFrameworkUI.SiticoneButton btn_InHD;
        private SiticoneNetFrameworkUI.SiticoneButton btn_XuatHD;
        private SiticoneNetFrameworkUI.SiticoneButton btn_CapNhatHD;
    }
}