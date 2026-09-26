namespace TiemVaiLucCode
{
    partial class Frm_Card_DonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Card_DonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tiemVaiDBDataSet1 = new TiemVaiLucCode.TiemVaiDBDataSet1();
            this.chiTietDonHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDonHangsTableAdapter = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.ChiTietDonHangsTableAdapter();
            this.tableAdapterManager = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager();
            this.chiTietDonHangsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.chiTietDonHangsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chiTietDonHangsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lamMoi = new SiticoneNetFrameworkUI.SiticoneButton();
            this.txt_TimKiem = new SiticoneNetFrameworkUI.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangsBindingNavigator)).BeginInit();
            this.chiTietDonHangsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tiemVaiDBDataSet1
            // 
            this.tiemVaiDBDataSet1.DataSetName = "TiemVaiDBDataSet1";
            this.tiemVaiDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietDonHangsBindingSource
            // 
            this.chiTietDonHangsBindingSource.DataMember = "ChiTietDonHangs";
            this.chiTietDonHangsBindingSource.DataSource = this.tiemVaiDBDataSet1;
            // 
            // chiTietDonHangsTableAdapter
            // 
            this.chiTietDonHangsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangsTableAdapter = this.chiTietDonHangsTableAdapter;
            this.tableAdapterManager.DanhMucsTableAdapter = null;
            this.tableAdapterManager.DonHangsTableAdapter = null;
            this.tableAdapterManager.KhachHangsTableAdapter = null;
            this.tableAdapterManager.NhanViensTableAdapter = null;
            this.tableAdapterManager.SanPhamsTableAdapter = null;
            this.tableAdapterManager.TaiKhoansTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // chiTietDonHangsBindingNavigator
            // 
            this.chiTietDonHangsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.chiTietDonHangsBindingNavigator.BindingSource = this.chiTietDonHangsBindingSource;
            this.chiTietDonHangsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.chiTietDonHangsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.chiTietDonHangsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.chiTietDonHangsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.chiTietDonHangsBindingNavigatorSaveItem});
            this.chiTietDonHangsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.chiTietDonHangsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.chiTietDonHangsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.chiTietDonHangsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.chiTietDonHangsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.chiTietDonHangsBindingNavigator.Name = "chiTietDonHangsBindingNavigator";
            this.chiTietDonHangsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.chiTietDonHangsBindingNavigator.Size = new System.Drawing.Size(1099, 27);
            this.chiTietDonHangsBindingNavigator.TabIndex = 0;
            this.chiTietDonHangsBindingNavigator.Text = "bindingNavigator1";
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
            // chiTietDonHangsBindingNavigatorSaveItem
            // 
            this.chiTietDonHangsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chiTietDonHangsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chiTietDonHangsBindingNavigatorSaveItem.Image")));
            this.chiTietDonHangsBindingNavigatorSaveItem.Name = "chiTietDonHangsBindingNavigatorSaveItem";
            this.chiTietDonHangsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.chiTietDonHangsBindingNavigatorSaveItem.Text = "Save Data";
            this.chiTietDonHangsBindingNavigatorSaveItem.Click += new System.EventHandler(this.chiTietDonHangsBindingNavigatorSaveItem_Click);
            // 
            // chiTietDonHangsDataGridView
            // 
            this.chiTietDonHangsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chiTietDonHangsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.chiTietDonHangsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietDonHangsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.chiTietDonHangsDataGridView.DataSource = this.chiTietDonHangsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chiTietDonHangsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.chiTietDonHangsDataGridView.Location = new System.Drawing.Point(72, 132);
            this.chiTietDonHangsDataGridView.Name = "chiTietDonHangsDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chiTietDonHangsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.chiTietDonHangsDataGridView.RowHeadersWidth = 51;
            this.chiTietDonHangsDataGridView.RowTemplate.Height = 24;
            this.chiTietDonHangsDataGridView.Size = new System.Drawing.Size(902, 436);
            this.chiTietDonHangsDataGridView.TabIndex = 1;
            this.chiTietDonHangsDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.chiTietDonHangsDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ChiTietDonHangId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ChiTietDonHangId";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SanPhamId";
            this.dataGridViewTextBoxColumn3.HeaderText = "SanPhamId";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuongMet";
            this.dataGridViewTextBoxColumn4.HeaderText = "SoLuongMet";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DonGia";
            this.dataGridViewTextBoxColumn5.HeaderText = "DonGia";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // btn_lamMoi
            // 
            this.btn_lamMoi.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_lamMoi.AccessibleName = "Làm mới";
            this.btn_lamMoi.AutoSizeBasedOnText = false;
            this.btn_lamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_lamMoi.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_lamMoi.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_lamMoi.BadgeValue = 0;
            this.btn_lamMoi.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_lamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_lamMoi.BorderWidth = 1;
            this.btn_lamMoi.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_lamMoi.ButtonImage = null;
            this.btn_lamMoi.ButtonTextLeftPadding = 0;
            this.btn_lamMoi.CanBeep = true;
            this.btn_lamMoi.CanGlow = false;
            this.btn_lamMoi.CanShake = true;
            this.btn_lamMoi.ContextMenuStripEx = null;
            this.btn_lamMoi.CornerRadiusBottomLeft = 10;
            this.btn_lamMoi.CornerRadiusBottomRight = 10;
            this.btn_lamMoi.CornerRadiusTopLeft = 10;
            this.btn_lamMoi.CornerRadiusTopRight = 10;
            this.btn_lamMoi.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_lamMoi.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_lamMoi.EnableLongPress = false;
            this.btn_lamMoi.EnableRippleEffect = true;
            this.btn_lamMoi.EnableShadow = false;
            this.btn_lamMoi.EnableTextWrapping = false;
            this.btn_lamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lamMoi.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_lamMoi.GlowIntensity = 100;
            this.btn_lamMoi.GlowRadius = 20F;
            this.btn_lamMoi.GradientBackground = false;
            this.btn_lamMoi.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_lamMoi.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_lamMoi.HintText = null;
            this.btn_lamMoi.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_lamMoi.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_lamMoi.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_lamMoi.HoverTransitionDuration = 140;
            this.btn_lamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lamMoi.ImagePadding = 5;
            this.btn_lamMoi.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_lamMoi.IsRadial = false;
            this.btn_lamMoi.IsReadOnly = false;
            this.btn_lamMoi.IsToggleButton = false;
            this.btn_lamMoi.IsToggled = false;
            this.btn_lamMoi.Location = new System.Drawing.Point(897, 50);
            this.btn_lamMoi.LongPressDurationMS = 1000;
            this.btn_lamMoi.Name = "btn_lamMoi";
            this.btn_lamMoi.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_lamMoi.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_lamMoi.ParticleCount = 15;
            this.btn_lamMoi.PressAnimationScale = 0.97F;
            this.btn_lamMoi.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_lamMoi.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_lamMoi.PressTransitionDuration = 90;
            this.btn_lamMoi.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_lamMoi.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_lamMoi.RippleRadiusMultiplier = 0.6F;
            this.btn_lamMoi.ShadowBlur = 5;
            this.btn_lamMoi.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_lamMoi.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_lamMoi.ShakeDuration = 500;
            this.btn_lamMoi.ShakeIntensity = 5;
            this.btn_lamMoi.Size = new System.Drawing.Size(130, 35);
            this.btn_lamMoi.TabIndex = 3;
            this.btn_lamMoi.Text = "Làm mới";
            this.btn_lamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_lamMoi.TextColor = System.Drawing.Color.White;
            this.btn_lamMoi.TooltipText = null;
            this.btn_lamMoi.UseAdvancedRendering = true;
            this.btn_lamMoi.UseParticles = false;
            this.btn_lamMoi.Click += new System.EventHandler(this.btn_lamMoi_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.AccessibleDescription = "A customizable text input field.";
            this.txt_TimKiem.AccessibleName = "Text Box";
            this.txt_TimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.txt_TimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txt_TimKiem.BlinkCount = 3;
            this.txt_TimKiem.BlinkShadow = false;
            this.txt_TimKiem.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.txt_TimKiem.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.txt_TimKiem.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.CanShake = true;
            this.txt_TimKiem.ContinuousBlink = false;
            this.txt_TimKiem.CornerRadiusBottomLeft = 20;
            this.txt_TimKiem.CornerRadiusBottomRight = 20;
            this.txt_TimKiem.CornerRadiusTopLeft = 20;
            this.txt_TimKiem.CornerRadiusTopRight = 20;
            this.txt_TimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiem.CursorBlinkRate = 500;
            this.txt_TimKiem.CursorColor = System.Drawing.Color.Black;
            this.txt_TimKiem.CursorHeight = 26;
            this.txt_TimKiem.CursorOffset = 0;
            this.txt_TimKiem.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.txt_TimKiem.CursorWidth = 1;
            this.txt_TimKiem.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.txt_TimKiem.DisabledTextColor = System.Drawing.Color.Gray;
            this.txt_TimKiem.EnableDropShadow = false;
            this.txt_TimKiem.FillColor1 = System.Drawing.Color.White;
            this.txt_TimKiem.FillColor2 = System.Drawing.Color.White;
            this.txt_TimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.txt_TimKiem.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.txt_TimKiem.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.txt_TimKiem.IsEnabled = true;
            this.txt_TimKiem.Location = new System.Drawing.Point(376, 50);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.PlaceholderColor = System.Drawing.Color.Gray;
            this.txt_TimKiem.PlaceholderText = "Nhập thông tin tiềm kiếm...";
            this.txt_TimKiem.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.txt_TimKiem.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.txt_TimKiem.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.txt_TimKiem.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_TimKiem.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.ShadowAnimationDuration = 1;
            this.txt_TimKiem.ShadowBlur = 10;
            this.txt_TimKiem.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_TimKiem.Size = new System.Drawing.Size(515, 35);
            this.txt_TimKiem.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.txt_TimKiem.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.txt_TimKiem.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.txt_TimKiem.SolidFillColor = System.Drawing.Color.White;
            this.txt_TimKiem.TabIndex = 4;
            this.txt_TimKiem.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txt_TimKiem.ValidationErrorMessage = "Invalid input.";
            this.txt_TimKiem.ValidationFunction = null;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // Frm_Card_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.btn_lamMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chiTietDonHangsDataGridView);
            this.Controls.Add(this.chiTietDonHangsBindingNavigator);
            this.Name = "Frm_Card_DonHang";
            this.Text = "Frm_Card_DonHang";
            this.Load += new System.EventHandler(this.Frm_Card_DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangsBindingNavigator)).EndInit();
            this.chiTietDonHangsBindingNavigator.ResumeLayout(false);
            this.chiTietDonHangsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiemVaiDBDataSet1 tiemVaiDBDataSet1;
        private System.Windows.Forms.BindingSource chiTietDonHangsBindingSource;
        private TiemVaiDBDataSet1TableAdapters.ChiTietDonHangsTableAdapter chiTietDonHangsTableAdapter;
        private TiemVaiDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator chiTietDonHangsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton chiTietDonHangsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView chiTietDonHangsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private SiticoneNetFrameworkUI.SiticoneButton btn_lamMoi;
        private SiticoneNetFrameworkUI.SiticoneTextBox txt_TimKiem;
    }
}