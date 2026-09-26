namespace TiemVaiLucCode
{
    partial class Frm_Card_SanPham
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
            System.Windows.Forms.Label maSanPhamLabel;
            System.Windows.Forms.Label tenSanPhamLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label soLuongTonLabel;
            System.Windows.Forms.Label mauSacLabel;
            System.Windows.Forms.Label chatLieuLabel;
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label danhMucIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Card_SanPham));
            this.btn_ChonAnh = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btn_ChonMau = new SiticoneNetFrameworkUI.SiticoneButton();
            this.tiemVaiDBDataSet1 = new TiemVaiLucCode.TiemVaiDBDataSet1();
            this.sanPhamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamsTableAdapter = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.SanPhamsTableAdapter();
            this.tableAdapterManager = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager();
            this.sanPhamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sanPhamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sanPhamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_maSanPham = new System.Windows.Forms.TextBox();
            this.txt_tenSanPham = new System.Windows.Forms.TextBox();
            this.txt_giaBan = new System.Windows.Forms.TextBox();
            this.txt_soLuongTon = new System.Windows.Forms.TextBox();
            this.txt_chatLieu = new System.Windows.Forms.TextBox();
            this.txt_danhMucId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Color_Vai = new System.Windows.Forms.ColorDialog();
            this.btn_ThemSP = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btn_XoaBo = new SiticoneNetFrameworkUI.SiticoneButton();
            this.btn_LamMoi = new SiticoneNetFrameworkUI.SiticoneButton();
            this.ptb_MauSac = new System.Windows.Forms.PictureBox();
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            maSanPhamLabel = new System.Windows.Forms.Label();
            tenSanPhamLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            mauSacLabel = new System.Windows.Forms.Label();
            chatLieuLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            danhMucIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingNavigator)).BeginInit();
            this.sanPhamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MauSac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // maSanPhamLabel
            // 
            maSanPhamLabel.AutoSize = true;
            maSanPhamLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSanPhamLabel.Location = new System.Drawing.Point(39, 47);
            maSanPhamLabel.Name = "maSanPhamLabel";
            maSanPhamLabel.Size = new System.Drawing.Size(106, 19);
            maSanPhamLabel.TabIndex = 21;
            maSanPhamLabel.Text = "Mã Sản Phẩm:";
            maSanPhamLabel.Click += new System.EventHandler(this.maSanPhamLabel_Click);
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.AutoSize = true;
            tenSanPhamLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSanPhamLabel.Location = new System.Drawing.Point(602, 47);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new System.Drawing.Size(104, 19);
            tenSanPhamLabel.TabIndex = 23;
            tenSanPhamLabel.Text = "Tên Sản Phẩm";
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaBanLabel.Location = new System.Drawing.Point(39, 81);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(68, 19);
            giaBanLabel.TabIndex = 25;
            giaBanLabel.Text = "Giá Bán:";
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongTonLabel.Location = new System.Drawing.Point(602, 84);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(105, 19);
            soLuongTonLabel.TabIndex = 27;
            soLuongTonLabel.Text = "Số Lượng Tồn";
            // 
            // mauSacLabel
            // 
            mauSacLabel.AutoSize = true;
            mauSacLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mauSacLabel.Location = new System.Drawing.Point(39, 118);
            mauSacLabel.Name = "mauSacLabel";
            mauSacLabel.Size = new System.Drawing.Size(67, 19);
            mauSacLabel.TabIndex = 29;
            mauSacLabel.Text = "Màu Sắc";
            // 
            // chatLieuLabel
            // 
            chatLieuLabel.AutoSize = true;
            chatLieuLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chatLieuLabel.Location = new System.Drawing.Point(602, 121);
            chatLieuLabel.Name = "chatLieuLabel";
            chatLieuLabel.Size = new System.Drawing.Size(75, 19);
            chatLieuLabel.TabIndex = 31;
            chatLieuLabel.Text = "Chất Liệu";
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhLabel.Location = new System.Drawing.Point(602, 177);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(73, 19);
            hinhAnhLabel.TabIndex = 33;
            hinhAnhLabel.Text = "Hình Ảnh";
            // 
            // danhMucIdLabel
            // 
            danhMucIdLabel.AutoSize = true;
            danhMucIdLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            danhMucIdLabel.Location = new System.Drawing.Point(39, 180);
            danhMucIdLabel.Name = "danhMucIdLabel";
            danhMucIdLabel.Size = new System.Drawing.Size(105, 19);
            danhMucIdLabel.TabIndex = 35;
            danhMucIdLabel.Text = "Mã Danh Mục";
            // 
            // btn_ChonAnh
            // 
            this.btn_ChonAnh.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_ChonAnh.AccessibleName = "...";
            this.btn_ChonAnh.AutoSizeBasedOnText = false;
            this.btn_ChonAnh.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChonAnh.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_ChonAnh.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ChonAnh.BadgeValue = 0;
            this.btn_ChonAnh.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_ChonAnh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_ChonAnh.BorderWidth = 1;
            this.btn_ChonAnh.ButtonBackColor = System.Drawing.Color.White;
            this.btn_ChonAnh.ButtonImage = null;
            this.btn_ChonAnh.ButtonTextLeftPadding = 0;
            this.btn_ChonAnh.CanBeep = true;
            this.btn_ChonAnh.CanGlow = false;
            this.btn_ChonAnh.CanShake = true;
            this.btn_ChonAnh.ContextMenuStripEx = null;
            this.btn_ChonAnh.CornerRadiusBottomLeft = 6;
            this.btn_ChonAnh.CornerRadiusBottomRight = 6;
            this.btn_ChonAnh.CornerRadiusTopLeft = 6;
            this.btn_ChonAnh.CornerRadiusTopRight = 6;
            this.btn_ChonAnh.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChonAnh.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_ChonAnh.EnableLongPress = false;
            this.btn_ChonAnh.EnableRippleEffect = true;
            this.btn_ChonAnh.EnableShadow = false;
            this.btn_ChonAnh.EnableTextWrapping = false;
            this.btn_ChonAnh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F);
            this.btn_ChonAnh.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ChonAnh.GlowIntensity = 100;
            this.btn_ChonAnh.GlowRadius = 20F;
            this.btn_ChonAnh.GradientBackground = false;
            this.btn_ChonAnh.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_ChonAnh.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_ChonAnh.HintText = null;
            this.btn_ChonAnh.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_ChonAnh.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ChonAnh.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonAnh.HoverTransitionDuration = 140;
            this.btn_ChonAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChonAnh.ImagePadding = 5;
            this.btn_ChonAnh.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_ChonAnh.IsRadial = false;
            this.btn_ChonAnh.IsReadOnly = false;
            this.btn_ChonAnh.IsToggleButton = false;
            this.btn_ChonAnh.IsToggled = false;
            this.btn_ChonAnh.Location = new System.Drawing.Point(1003, 180);
            this.btn_ChonAnh.LongPressDurationMS = 1000;
            this.btn_ChonAnh.Name = "btn_ChonAnh";
            this.btn_ChonAnh.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ChonAnh.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_ChonAnh.ParticleCount = 15;
            this.btn_ChonAnh.PressAnimationScale = 0.97F;
            this.btn_ChonAnh.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_ChonAnh.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ChonAnh.PressTransitionDuration = 90;
            this.btn_ChonAnh.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_ChonAnh.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonAnh.RippleRadiusMultiplier = 0.6F;
            this.btn_ChonAnh.ShadowBlur = 5;
            this.btn_ChonAnh.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonAnh.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_ChonAnh.ShakeDuration = 500;
            this.btn_ChonAnh.ShakeIntensity = 5;
            this.btn_ChonAnh.Size = new System.Drawing.Size(31, 24);
            this.btn_ChonAnh.TabIndex = 18;
            this.btn_ChonAnh.Text = "...";
            this.btn_ChonAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ChonAnh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonAnh.TooltipText = null;
            this.btn_ChonAnh.UseAdvancedRendering = true;
            this.btn_ChonAnh.UseParticles = false;
            // 
            // btn_ChonMau
            // 
            this.btn_ChonMau.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_ChonMau.AccessibleName = "Chọn màu";
            this.btn_ChonMau.AutoSizeBasedOnText = false;
            this.btn_ChonMau.BackColor = System.Drawing.Color.Transparent;
            this.btn_ChonMau.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_ChonMau.BadgeFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonMau.BadgeValue = 0;
            this.btn_ChonMau.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_ChonMau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_ChonMau.BorderWidth = 1;
            this.btn_ChonMau.ButtonBackColor = System.Drawing.Color.White;
            this.btn_ChonMau.ButtonImage = null;
            this.btn_ChonMau.ButtonTextLeftPadding = 0;
            this.btn_ChonMau.CanBeep = true;
            this.btn_ChonMau.CanGlow = false;
            this.btn_ChonMau.CanShake = true;
            this.btn_ChonMau.ContextMenuStripEx = null;
            this.btn_ChonMau.CornerRadiusBottomLeft = 6;
            this.btn_ChonMau.CornerRadiusBottomRight = 6;
            this.btn_ChonMau.CornerRadiusTopLeft = 6;
            this.btn_ChonMau.CornerRadiusTopRight = 6;
            this.btn_ChonMau.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ChonMau.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_ChonMau.EnableLongPress = false;
            this.btn_ChonMau.EnableRippleEffect = true;
            this.btn_ChonMau.EnableShadow = false;
            this.btn_ChonMau.EnableTextWrapping = false;
            this.btn_ChonMau.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChonMau.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ChonMau.GlowIntensity = 100;
            this.btn_ChonMau.GlowRadius = 20F;
            this.btn_ChonMau.GradientBackground = false;
            this.btn_ChonMau.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_ChonMau.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_ChonMau.HintText = null;
            this.btn_ChonMau.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_ChonMau.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ChonMau.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonMau.HoverTransitionDuration = 140;
            this.btn_ChonMau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChonMau.ImagePadding = 5;
            this.btn_ChonMau.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_ChonMau.IsRadial = false;
            this.btn_ChonMau.IsReadOnly = false;
            this.btn_ChonMau.IsToggleButton = false;
            this.btn_ChonMau.IsToggled = false;
            this.btn_ChonMau.Location = new System.Drawing.Point(341, 121);
            this.btn_ChonMau.LongPressDurationMS = 1000;
            this.btn_ChonMau.Name = "btn_ChonMau";
            this.btn_ChonMau.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ChonMau.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_ChonMau.ParticleCount = 15;
            this.btn_ChonMau.PressAnimationScale = 0.97F;
            this.btn_ChonMau.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_ChonMau.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ChonMau.PressTransitionDuration = 90;
            this.btn_ChonMau.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_ChonMau.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonMau.RippleRadiusMultiplier = 0.6F;
            this.btn_ChonMau.ShadowBlur = 5;
            this.btn_ChonMau.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonMau.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_ChonMau.ShakeDuration = 500;
            this.btn_ChonMau.ShakeIntensity = 5;
            this.btn_ChonMau.Size = new System.Drawing.Size(130, 34);
            this.btn_ChonMau.TabIndex = 20;
            this.btn_ChonMau.Text = "Chọn màu";
            this.btn_ChonMau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ChonMau.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ChonMau.TooltipText = null;
            this.btn_ChonMau.UseAdvancedRendering = true;
            this.btn_ChonMau.UseParticles = false;
            this.btn_ChonMau.Click += new System.EventHandler(this.btn_ChonMau_Click);
            // 
            // tiemVaiDBDataSet1
            // 
            this.tiemVaiDBDataSet1.DataSetName = "TiemVaiDBDataSet1";
            this.tiemVaiDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamsBindingSource
            // 
            this.sanPhamsBindingSource.DataMember = "SanPhams";
            this.sanPhamsBindingSource.DataSource = this.tiemVaiDBDataSet1;
            // 
            // sanPhamsTableAdapter
            // 
            this.sanPhamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangsTableAdapter = null;
            this.tableAdapterManager.DanhMucsTableAdapter = null;
            this.tableAdapterManager.DonHangsTableAdapter = null;
            this.tableAdapterManager.KhachHangsTableAdapter = null;
            this.tableAdapterManager.NhanViensTableAdapter = null;
            this.tableAdapterManager.SanPhamsTableAdapter = this.sanPhamsTableAdapter;
            this.tableAdapterManager.TaiKhoansTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sanPhamsBindingNavigator
            // 
            this.sanPhamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sanPhamsBindingNavigator.BindingSource = this.sanPhamsBindingSource;
            this.sanPhamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sanPhamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sanPhamsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sanPhamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sanPhamsBindingNavigatorSaveItem});
            this.sanPhamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sanPhamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sanPhamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sanPhamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sanPhamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sanPhamsBindingNavigator.Name = "sanPhamsBindingNavigator";
            this.sanPhamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sanPhamsBindingNavigator.Size = new System.Drawing.Size(1099, 31);
            this.sanPhamsBindingNavigator.TabIndex = 21;
            this.sanPhamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // sanPhamsBindingNavigatorSaveItem
            // 
            this.sanPhamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sanPhamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sanPhamsBindingNavigatorSaveItem.Image")));
            this.sanPhamsBindingNavigatorSaveItem.Name = "sanPhamsBindingNavigatorSaveItem";
            this.sanPhamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.sanPhamsBindingNavigatorSaveItem.Text = "Save Data";
            this.sanPhamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.sanPhamsBindingNavigatorSaveItem_Click_1);
            // 
            // sanPhamsDataGridView
            // 
            this.sanPhamsDataGridView.AutoGenerateColumns = false;
            this.sanPhamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sanPhamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.sanPhamsDataGridView.DataSource = this.sanPhamsBindingSource;
            this.sanPhamsDataGridView.Location = new System.Drawing.Point(10, 39);
            this.sanPhamsDataGridView.Name = "sanPhamsDataGridView";
            this.sanPhamsDataGridView.RowHeadersWidth = 51;
            this.sanPhamsDataGridView.RowTemplate.Height = 24;
            this.sanPhamsDataGridView.Size = new System.Drawing.Size(1026, 246);
            this.sanPhamsDataGridView.TabIndex = 21;
            this.sanPhamsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sanPhamsDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSanPham";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaSanPham";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSanPham";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenSanPham";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "GiaBan";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuongTon";
            this.dataGridViewTextBoxColumn4.HeaderText = "SoLuongTon";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MauSac";
            this.dataGridViewTextBoxColumn5.HeaderText = "MauSac";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChatLieu";
            this.dataGridViewTextBoxColumn6.HeaderText = "ChatLieu";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HinhAnh";
            this.dataGridViewTextBoxColumn7.HeaderText = "HinhAnh";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DanhMucId";
            this.dataGridViewTextBoxColumn8.HeaderText = "DanhMucId";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // txt_maSanPham
            // 
            this.txt_maSanPham.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "MaSanPham", true));
            this.txt_maSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maSanPham.Location = new System.Drawing.Point(240, 44);
            this.txt_maSanPham.Name = "txt_maSanPham";
            this.txt_maSanPham.Size = new System.Drawing.Size(231, 27);
            this.txt_maSanPham.TabIndex = 22;
            this.txt_maSanPham.TextChanged += new System.EventHandler(this.maSanPhamTextBox_TextChanged);
            // 
            // txt_tenSanPham
            // 
            this.txt_tenSanPham.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "TenSanPham", true));
            this.txt_tenSanPham.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenSanPham.Location = new System.Drawing.Point(803, 44);
            this.txt_tenSanPham.Name = "txt_tenSanPham";
            this.txt_tenSanPham.Size = new System.Drawing.Size(231, 27);
            this.txt_tenSanPham.TabIndex = 24;
            // 
            // txt_giaBan
            // 
            this.txt_giaBan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "GiaBan", true));
            this.txt_giaBan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giaBan.Location = new System.Drawing.Point(240, 78);
            this.txt_giaBan.Name = "txt_giaBan";
            this.txt_giaBan.Size = new System.Drawing.Size(231, 27);
            this.txt_giaBan.TabIndex = 26;
            // 
            // txt_soLuongTon
            // 
            this.txt_soLuongTon.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "SoLuongTon", true));
            this.txt_soLuongTon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soLuongTon.Location = new System.Drawing.Point(803, 81);
            this.txt_soLuongTon.Name = "txt_soLuongTon";
            this.txt_soLuongTon.Size = new System.Drawing.Size(231, 27);
            this.txt_soLuongTon.TabIndex = 28;
            // 
            // txt_chatLieu
            // 
            this.txt_chatLieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "ChatLieu", true));
            this.txt_chatLieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chatLieu.Location = new System.Drawing.Point(803, 118);
            this.txt_chatLieu.Name = "txt_chatLieu";
            this.txt_chatLieu.Size = new System.Drawing.Size(231, 27);
            this.txt_chatLieu.TabIndex = 32;
            // 
            // txt_danhMucId
            // 
            this.txt_danhMucId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "DanhMucId", true));
            this.txt_danhMucId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_danhMucId.Location = new System.Drawing.Point(240, 177);
            this.txt_danhMucId.Name = "txt_danhMucId";
            this.txt_danhMucId.Size = new System.Drawing.Size(231, 27);
            this.txt_danhMucId.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sanPhamsDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 291);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BẢNG THÔNG TIN SẢN PHẨM";
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_ThemSP.AccessibleName = "Thêm Sản Phẩm";
            this.btn_ThemSP.AutoSizeBasedOnText = false;
            this.btn_ThemSP.BackColor = System.Drawing.Color.Transparent;
            this.btn_ThemSP.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_ThemSP.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ThemSP.BadgeValue = 0;
            this.btn_ThemSP.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_ThemSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_ThemSP.BorderWidth = 1;
            this.btn_ThemSP.ButtonBackColor = System.Drawing.Color.SteelBlue;
            this.btn_ThemSP.ButtonImage = null;
            this.btn_ThemSP.ButtonTextLeftPadding = 0;
            this.btn_ThemSP.CanBeep = true;
            this.btn_ThemSP.CanGlow = false;
            this.btn_ThemSP.CanShake = true;
            this.btn_ThemSP.ContextMenuStripEx = null;
            this.btn_ThemSP.CornerRadiusBottomLeft = 10;
            this.btn_ThemSP.CornerRadiusBottomRight = 10;
            this.btn_ThemSP.CornerRadiusTopLeft = 10;
            this.btn_ThemSP.CornerRadiusTopRight = 10;
            this.btn_ThemSP.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_ThemSP.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_ThemSP.EnableLongPress = false;
            this.btn_ThemSP.EnableRippleEffect = true;
            this.btn_ThemSP.EnableShadow = false;
            this.btn_ThemSP.EnableTextWrapping = false;
            this.btn_ThemSP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSP.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ThemSP.GlowIntensity = 100;
            this.btn_ThemSP.GlowRadius = 20F;
            this.btn_ThemSP.GradientBackground = false;
            this.btn_ThemSP.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_ThemSP.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_ThemSP.HintText = null;
            this.btn_ThemSP.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ThemSP.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ThemSP.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThemSP.HoverTransitionDuration = 140;
            this.btn_ThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemSP.ImagePadding = 5;
            this.btn_ThemSP.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_ThemSP.IsRadial = false;
            this.btn_ThemSP.IsReadOnly = false;
            this.btn_ThemSP.IsToggleButton = false;
            this.btn_ThemSP.IsToggled = false;
            this.btn_ThemSP.Location = new System.Drawing.Point(43, 233);
            this.btn_ThemSP.LongPressDurationMS = 1000;
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ThemSP.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_ThemSP.ParticleCount = 15;
            this.btn_ThemSP.PressAnimationScale = 0.97F;
            this.btn_ThemSP.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_ThemSP.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_ThemSP.PressTransitionDuration = 90;
            this.btn_ThemSP.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_ThemSP.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThemSP.RippleRadiusMultiplier = 0.6F;
            this.btn_ThemSP.ShadowBlur = 5;
            this.btn_ThemSP.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ThemSP.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_ThemSP.ShakeDuration = 500;
            this.btn_ThemSP.ShakeIntensity = 5;
            this.btn_ThemSP.Size = new System.Drawing.Size(157, 37);
            this.btn_ThemSP.TabIndex = 38;
            this.btn_ThemSP.Text = "Thêm Sản Phẩm";
            this.btn_ThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ThemSP.TextColor = System.Drawing.Color.White;
            this.btn_ThemSP.TooltipText = null;
            this.btn_ThemSP.UseAdvancedRendering = true;
            this.btn_ThemSP.UseParticles = false;
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // btn_XoaBo
            // 
            this.btn_XoaBo.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_XoaBo.AccessibleName = "Xóa Bỏ";
            this.btn_XoaBo.AutoSizeBasedOnText = false;
            this.btn_XoaBo.BackColor = System.Drawing.Color.Transparent;
            this.btn_XoaBo.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_XoaBo.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_XoaBo.BadgeValue = 0;
            this.btn_XoaBo.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_XoaBo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_XoaBo.BorderWidth = 1;
            this.btn_XoaBo.ButtonBackColor = System.Drawing.Color.Red;
            this.btn_XoaBo.ButtonImage = null;
            this.btn_XoaBo.ButtonTextLeftPadding = 0;
            this.btn_XoaBo.CanBeep = true;
            this.btn_XoaBo.CanGlow = false;
            this.btn_XoaBo.CanShake = true;
            this.btn_XoaBo.ContextMenuStripEx = null;
            this.btn_XoaBo.CornerRadiusBottomLeft = 10;
            this.btn_XoaBo.CornerRadiusBottomRight = 10;
            this.btn_XoaBo.CornerRadiusTopLeft = 10;
            this.btn_XoaBo.CornerRadiusTopRight = 10;
            this.btn_XoaBo.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_XoaBo.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_XoaBo.EnableLongPress = false;
            this.btn_XoaBo.EnableRippleEffect = true;
            this.btn_XoaBo.EnableShadow = false;
            this.btn_XoaBo.EnableTextWrapping = false;
            this.btn_XoaBo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaBo.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_XoaBo.GlowIntensity = 100;
            this.btn_XoaBo.GlowRadius = 20F;
            this.btn_XoaBo.GradientBackground = false;
            this.btn_XoaBo.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_XoaBo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_XoaBo.HintText = null;
            this.btn_XoaBo.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaBo.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_XoaBo.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaBo.HoverTransitionDuration = 140;
            this.btn_XoaBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaBo.ImagePadding = 5;
            this.btn_XoaBo.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_XoaBo.IsRadial = false;
            this.btn_XoaBo.IsReadOnly = false;
            this.btn_XoaBo.IsToggleButton = false;
            this.btn_XoaBo.IsToggled = false;
            this.btn_XoaBo.Location = new System.Drawing.Point(224, 233);
            this.btn_XoaBo.LongPressDurationMS = 1000;
            this.btn_XoaBo.Name = "btn_XoaBo";
            this.btn_XoaBo.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_XoaBo.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_XoaBo.ParticleCount = 15;
            this.btn_XoaBo.PressAnimationScale = 0.97F;
            this.btn_XoaBo.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_XoaBo.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_XoaBo.PressTransitionDuration = 90;
            this.btn_XoaBo.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_XoaBo.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaBo.RippleRadiusMultiplier = 0.6F;
            this.btn_XoaBo.ShadowBlur = 5;
            this.btn_XoaBo.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_XoaBo.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_XoaBo.ShakeDuration = 500;
            this.btn_XoaBo.ShakeIntensity = 5;
            this.btn_XoaBo.Size = new System.Drawing.Size(103, 37);
            this.btn_XoaBo.TabIndex = 39;
            this.btn_XoaBo.Text = "Xóa Bỏ";
            this.btn_XoaBo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_XoaBo.TextColor = System.Drawing.Color.White;
            this.btn_XoaBo.TooltipText = null;
            this.btn_XoaBo.UseAdvancedRendering = true;
            this.btn_XoaBo.UseParticles = false;
            this.btn_XoaBo.Click += new System.EventHandler(this.btn_XoaBo_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.btn_LamMoi.AccessibleName = "Làm Mới";
            this.btn_LamMoi.AutoSizeBasedOnText = false;
            this.btn_LamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_LamMoi.BadgeBackColor = System.Drawing.Color.Black;
            this.btn_LamMoi.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.BadgeValue = 0;
            this.btn_LamMoi.BadgeValueForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.btn_LamMoi.BorderWidth = 1;
            this.btn_LamMoi.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_LamMoi.ButtonImage = null;
            this.btn_LamMoi.ButtonTextLeftPadding = 0;
            this.btn_LamMoi.CanBeep = true;
            this.btn_LamMoi.CanGlow = false;
            this.btn_LamMoi.CanShake = true;
            this.btn_LamMoi.ContextMenuStripEx = null;
            this.btn_LamMoi.CornerRadiusBottomLeft = 10;
            this.btn_LamMoi.CornerRadiusBottomRight = 10;
            this.btn_LamMoi.CornerRadiusTopLeft = 10;
            this.btn_LamMoi.CornerRadiusTopRight = 10;
            this.btn_LamMoi.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.btn_LamMoi.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.btn_LamMoi.EnableLongPress = false;
            this.btn_LamMoi.EnableRippleEffect = true;
            this.btn_LamMoi.EnableShadow = false;
            this.btn_LamMoi.EnableTextWrapping = false;
            this.btn_LamMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LamMoi.GlowIntensity = 100;
            this.btn_LamMoi.GlowRadius = 20F;
            this.btn_LamMoi.GradientBackground = false;
            this.btn_LamMoi.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.btn_LamMoi.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_LamMoi.HintText = null;
            this.btn_LamMoi.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_LamMoi.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_LamMoi.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_LamMoi.HoverTransitionDuration = 140;
            this.btn_LamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_LamMoi.ImagePadding = 5;
            this.btn_LamMoi.ImageSize = new System.Drawing.Size(16, 16);
            this.btn_LamMoi.IsRadial = false;
            this.btn_LamMoi.IsReadOnly = false;
            this.btn_LamMoi.IsToggleButton = false;
            this.btn_LamMoi.IsToggled = false;
            this.btn_LamMoi.Location = new System.Drawing.Point(368, 233);
            this.btn_LamMoi.LongPressDurationMS = 1000;
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_LamMoi.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_LamMoi.ParticleCount = 15;
            this.btn_LamMoi.PressAnimationScale = 0.97F;
            this.btn_LamMoi.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.btn_LamMoi.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.btn_LamMoi.PressTransitionDuration = 90;
            this.btn_LamMoi.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_LamMoi.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_LamMoi.RippleRadiusMultiplier = 0.6F;
            this.btn_LamMoi.ShadowBlur = 5;
            this.btn_LamMoi.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_LamMoi.ShadowOffset = new System.Drawing.Point(0, 2);
            this.btn_LamMoi.ShakeDuration = 500;
            this.btn_LamMoi.ShakeIntensity = 5;
            this.btn_LamMoi.Size = new System.Drawing.Size(103, 37);
            this.btn_LamMoi.TabIndex = 40;
            this.btn_LamMoi.Text = "Làm Mới";
            this.btn_LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_LamMoi.TextColor = System.Drawing.Color.White;
            this.btn_LamMoi.TooltipText = null;
            this.btn_LamMoi.UseAdvancedRendering = true;
            this.btn_LamMoi.UseParticles = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // ptb_MauSac
            // 
            this.ptb_MauSac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_MauSac.Location = new System.Drawing.Point(240, 113);
            this.ptb_MauSac.Name = "ptb_MauSac";
            this.ptb_MauSac.Size = new System.Drawing.Size(61, 42);
            this.ptb_MauSac.TabIndex = 19;
            this.ptb_MauSac.TabStop = false;
            // 
            // ptb_HinhAnh
            // 
            this.ptb_HinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_HinhAnh.Location = new System.Drawing.Point(803, 151);
            this.ptb_HinhAnh.Name = "ptb_HinhAnh";
            this.ptb_HinhAnh.Size = new System.Drawing.Size(100, 100);
            this.ptb_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_HinhAnh.TabIndex = 17;
            this.ptb_HinhAnh.TabStop = false;
            // 
            // Frm_Card_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_XoaBo);
            this.Controls.Add(this.btn_ThemSP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(maSanPhamLabel);
            this.Controls.Add(this.txt_maSanPham);
            this.Controls.Add(tenSanPhamLabel);
            this.Controls.Add(this.txt_tenSanPham);
            this.Controls.Add(giaBanLabel);
            this.Controls.Add(this.txt_giaBan);
            this.Controls.Add(soLuongTonLabel);
            this.Controls.Add(this.txt_soLuongTon);
            this.Controls.Add(mauSacLabel);
            this.Controls.Add(chatLieuLabel);
            this.Controls.Add(this.txt_chatLieu);
            this.Controls.Add(hinhAnhLabel);
            this.Controls.Add(danhMucIdLabel);
            this.Controls.Add(this.txt_danhMucId);
            this.Controls.Add(this.sanPhamsBindingNavigator);
            this.Controls.Add(this.btn_ChonMau);
            this.Controls.Add(this.ptb_MauSac);
            this.Controls.Add(this.btn_ChonAnh);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Name = "Frm_Card_SanPham";
            this.Text = "Frm_Card_SanPham";
            this.Load += new System.EventHandler(this.Frm_Card_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingNavigator)).EndInit();
            this.sanPhamsBindingNavigator.ResumeLayout(false);
            this.sanPhamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MauSac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptb_HinhAnh;
        private SiticoneNetFrameworkUI.SiticoneButton btn_ChonAnh;
        private System.Windows.Forms.PictureBox ptb_MauSac;
        private SiticoneNetFrameworkUI.SiticoneButton btn_ChonMau;
        private TiemVaiDBDataSet1 tiemVaiDBDataSet1;
        private System.Windows.Forms.BindingSource sanPhamsBindingSource;
        private TiemVaiDBDataSet1TableAdapters.SanPhamsTableAdapter sanPhamsTableAdapter;
        private TiemVaiDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sanPhamsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sanPhamsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sanPhamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox txt_maSanPham;
        private System.Windows.Forms.TextBox txt_tenSanPham;
        private System.Windows.Forms.TextBox txt_giaBan;
        private System.Windows.Forms.TextBox txt_soLuongTon;
        private System.Windows.Forms.TextBox txt_chatLieu;
        private System.Windows.Forms.TextBox txt_danhMucId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog Color_Vai;
        private SiticoneNetFrameworkUI.SiticoneButton btn_ThemSP;
        private SiticoneNetFrameworkUI.SiticoneButton btn_XoaBo;
        private SiticoneNetFrameworkUI.SiticoneButton btn_LamMoi;
    }
}