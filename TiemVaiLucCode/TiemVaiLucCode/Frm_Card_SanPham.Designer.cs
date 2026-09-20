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
            this.ptb_HinhAnh = new System.Windows.Forms.PictureBox();
            this.btn_ChonAnh = new SiticoneNetFrameworkUI.SiticoneButton();
            this.ptb_MauSac = new System.Windows.Forms.PictureBox();
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
            this.maSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.tenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonTextBox = new System.Windows.Forms.TextBox();
            this.chatLieuTextBox = new System.Windows.Forms.TextBox();
            this.danhMucIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Color_Vai = new System.Windows.Forms.ColorDialog();
            this.siticoneButton1 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneButton2 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneButton3 = new SiticoneNetFrameworkUI.SiticoneButton();
            maSanPhamLabel = new System.Windows.Forms.Label();
            tenSanPhamLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            mauSacLabel = new System.Windows.Forms.Label();
            chatLieuLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            danhMucIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MauSac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingNavigator)).BeginInit();
            this.sanPhamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // ptb_MauSac
            // 
            this.ptb_MauSac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_MauSac.Location = new System.Drawing.Point(240, 113);
            this.ptb_MauSac.Name = "ptb_MauSac";
            this.ptb_MauSac.Size = new System.Drawing.Size(61, 42);
            this.ptb_MauSac.TabIndex = 19;
            this.ptb_MauSac.TabStop = false;
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
            this.sanPhamsBindingNavigator.Size = new System.Drawing.Size(1099, 27);
            this.sanPhamsBindingNavigator.TabIndex = 21;
            this.sanPhamsBindingNavigator.Text = "bindingNavigator1";
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
            // maSanPhamTextBox
            // 
            this.maSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "MaSanPham", true));
            this.maSanPhamTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSanPhamTextBox.Location = new System.Drawing.Point(240, 44);
            this.maSanPhamTextBox.Name = "maSanPhamTextBox";
            this.maSanPhamTextBox.Size = new System.Drawing.Size(231, 27);
            this.maSanPhamTextBox.TabIndex = 22;
            this.maSanPhamTextBox.TextChanged += new System.EventHandler(this.maSanPhamTextBox_TextChanged);
            // 
            // tenSanPhamTextBox
            // 
            this.tenSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "TenSanPham", true));
            this.tenSanPhamTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanPhamTextBox.Location = new System.Drawing.Point(803, 44);
            this.tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            this.tenSanPhamTextBox.Size = new System.Drawing.Size(231, 27);
            this.tenSanPhamTextBox.TabIndex = 24;
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "GiaBan", true));
            this.giaBanTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaBanTextBox.Location = new System.Drawing.Point(240, 78);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(231, 27);
            this.giaBanTextBox.TabIndex = 26;
            // 
            // soLuongTonTextBox
            // 
            this.soLuongTonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "SoLuongTon", true));
            this.soLuongTonTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongTonTextBox.Location = new System.Drawing.Point(803, 81);
            this.soLuongTonTextBox.Name = "soLuongTonTextBox";
            this.soLuongTonTextBox.Size = new System.Drawing.Size(231, 27);
            this.soLuongTonTextBox.TabIndex = 28;
            // 
            // chatLieuTextBox
            // 
            this.chatLieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "ChatLieu", true));
            this.chatLieuTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLieuTextBox.Location = new System.Drawing.Point(803, 118);
            this.chatLieuTextBox.Name = "chatLieuTextBox";
            this.chatLieuTextBox.Size = new System.Drawing.Size(231, 27);
            this.chatLieuTextBox.TabIndex = 32;
            // 
            // danhMucIdTextBox
            // 
            this.danhMucIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "DanhMucId", true));
            this.danhMucIdTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucIdTextBox.Location = new System.Drawing.Point(240, 177);
            this.danhMucIdTextBox.Name = "danhMucIdTextBox";
            this.danhMucIdTextBox.Size = new System.Drawing.Size(231, 27);
            this.danhMucIdTextBox.TabIndex = 36;
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
            // siticoneButton1
            // 
            this.siticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton1.AccessibleName = "Thêm Sản Phẩm";
            this.siticoneButton1.AutoSizeBasedOnText = false;
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BadgeBackColor = System.Drawing.Color.Black;
            this.siticoneButton1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.BadgeValue = 0;
            this.siticoneButton1.BadgeValueForeColor = System.Drawing.Color.White;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.siticoneButton1.BorderWidth = 1;
            this.siticoneButton1.ButtonBackColor = System.Drawing.Color.SteelBlue;
            this.siticoneButton1.ButtonImage = null;
            this.siticoneButton1.ButtonTextLeftPadding = 0;
            this.siticoneButton1.CanBeep = true;
            this.siticoneButton1.CanGlow = false;
            this.siticoneButton1.CanShake = true;
            this.siticoneButton1.ContextMenuStripEx = null;
            this.siticoneButton1.CornerRadiusBottomLeft = 10;
            this.siticoneButton1.CornerRadiusBottomRight = 10;
            this.siticoneButton1.CornerRadiusTopLeft = 10;
            this.siticoneButton1.CornerRadiusTopRight = 10;
            this.siticoneButton1.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.siticoneButton1.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.siticoneButton1.EnableLongPress = false;
            this.siticoneButton1.EnableRippleEffect = true;
            this.siticoneButton1.EnableShadow = false;
            this.siticoneButton1.EnableTextWrapping = false;
            this.siticoneButton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton1.GlowIntensity = 100;
            this.siticoneButton1.GlowRadius = 20F;
            this.siticoneButton1.GradientBackground = false;
            this.siticoneButton1.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.siticoneButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton1.HintText = null;
            this.siticoneButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton1.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.HoverTransitionDuration = 140;
            this.siticoneButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButton1.ImagePadding = 5;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton1.IsRadial = false;
            this.siticoneButton1.IsReadOnly = false;
            this.siticoneButton1.IsToggleButton = false;
            this.siticoneButton1.IsToggled = false;
            this.siticoneButton1.Location = new System.Drawing.Point(43, 233);
            this.siticoneButton1.LongPressDurationMS = 1000;
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.siticoneButton1.ParticleCount = 15;
            this.siticoneButton1.PressAnimationScale = 0.97F;
            this.siticoneButton1.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.siticoneButton1.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton1.PressTransitionDuration = 90;
            this.siticoneButton1.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.siticoneButton1.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.RippleRadiusMultiplier = 0.6F;
            this.siticoneButton1.ShadowBlur = 5;
            this.siticoneButton1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.ShadowOffset = new System.Drawing.Point(0, 2);
            this.siticoneButton1.ShakeDuration = 500;
            this.siticoneButton1.ShakeIntensity = 5;
            this.siticoneButton1.Size = new System.Drawing.Size(142, 37);
            this.siticoneButton1.TabIndex = 38;
            this.siticoneButton1.Text = "Thêm Sản Phẩm";
            this.siticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton1.TextColor = System.Drawing.Color.White;
            this.siticoneButton1.TooltipText = null;
            this.siticoneButton1.UseAdvancedRendering = true;
            this.siticoneButton1.UseParticles = false;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton2.AccessibleName = "Xóa Bỏ";
            this.siticoneButton2.AutoSizeBasedOnText = false;
            this.siticoneButton2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton2.BadgeBackColor = System.Drawing.Color.Black;
            this.siticoneButton2.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.BadgeValue = 0;
            this.siticoneButton2.BadgeValueForeColor = System.Drawing.Color.White;
            this.siticoneButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.siticoneButton2.BorderWidth = 1;
            this.siticoneButton2.ButtonBackColor = System.Drawing.Color.Red;
            this.siticoneButton2.ButtonImage = null;
            this.siticoneButton2.ButtonTextLeftPadding = 0;
            this.siticoneButton2.CanBeep = true;
            this.siticoneButton2.CanGlow = false;
            this.siticoneButton2.CanShake = true;
            this.siticoneButton2.ContextMenuStripEx = null;
            this.siticoneButton2.CornerRadiusBottomLeft = 10;
            this.siticoneButton2.CornerRadiusBottomRight = 10;
            this.siticoneButton2.CornerRadiusTopLeft = 10;
            this.siticoneButton2.CornerRadiusTopRight = 10;
            this.siticoneButton2.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.siticoneButton2.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.siticoneButton2.EnableLongPress = false;
            this.siticoneButton2.EnableRippleEffect = true;
            this.siticoneButton2.EnableShadow = false;
            this.siticoneButton2.EnableTextWrapping = false;
            this.siticoneButton2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton2.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton2.GlowIntensity = 100;
            this.siticoneButton2.GlowRadius = 20F;
            this.siticoneButton2.GradientBackground = false;
            this.siticoneButton2.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.siticoneButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton2.HintText = null;
            this.siticoneButton2.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton2.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.HoverTransitionDuration = 140;
            this.siticoneButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButton2.ImagePadding = 5;
            this.siticoneButton2.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton2.IsRadial = false;
            this.siticoneButton2.IsReadOnly = false;
            this.siticoneButton2.IsToggleButton = false;
            this.siticoneButton2.IsToggled = false;
            this.siticoneButton2.Location = new System.Drawing.Point(224, 233);
            this.siticoneButton2.LongPressDurationMS = 1000;
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton2.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.siticoneButton2.ParticleCount = 15;
            this.siticoneButton2.PressAnimationScale = 0.97F;
            this.siticoneButton2.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.siticoneButton2.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton2.PressTransitionDuration = 90;
            this.siticoneButton2.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.siticoneButton2.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.RippleRadiusMultiplier = 0.6F;
            this.siticoneButton2.ShadowBlur = 5;
            this.siticoneButton2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton2.ShadowOffset = new System.Drawing.Point(0, 2);
            this.siticoneButton2.ShakeDuration = 500;
            this.siticoneButton2.ShakeIntensity = 5;
            this.siticoneButton2.Size = new System.Drawing.Size(103, 37);
            this.siticoneButton2.TabIndex = 39;
            this.siticoneButton2.Text = "Xóa Bỏ";
            this.siticoneButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton2.TextColor = System.Drawing.Color.White;
            this.siticoneButton2.TooltipText = null;
            this.siticoneButton2.UseAdvancedRendering = true;
            this.siticoneButton2.UseParticles = false;
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton3.AccessibleName = "Làm Mới";
            this.siticoneButton3.AutoSizeBasedOnText = false;
            this.siticoneButton3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton3.BadgeBackColor = System.Drawing.Color.Black;
            this.siticoneButton3.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton3.BadgeValue = 0;
            this.siticoneButton3.BadgeValueForeColor = System.Drawing.Color.White;
            this.siticoneButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.siticoneButton3.BorderWidth = 1;
            this.siticoneButton3.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton3.ButtonImage = null;
            this.siticoneButton3.ButtonTextLeftPadding = 0;
            this.siticoneButton3.CanBeep = true;
            this.siticoneButton3.CanGlow = false;
            this.siticoneButton3.CanShake = true;
            this.siticoneButton3.ContextMenuStripEx = null;
            this.siticoneButton3.CornerRadiusBottomLeft = 10;
            this.siticoneButton3.CornerRadiusBottomRight = 10;
            this.siticoneButton3.CornerRadiusTopLeft = 10;
            this.siticoneButton3.CornerRadiusTopRight = 10;
            this.siticoneButton3.CustomCursor = System.Windows.Forms.Cursors.Default;
            this.siticoneButton3.DisabledTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.siticoneButton3.EnableLongPress = false;
            this.siticoneButton3.EnableRippleEffect = true;
            this.siticoneButton3.EnableShadow = false;
            this.siticoneButton3.EnableTextWrapping = false;
            this.siticoneButton3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton3.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton3.GlowIntensity = 100;
            this.siticoneButton3.GlowRadius = 20F;
            this.siticoneButton3.GradientBackground = false;
            this.siticoneButton3.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.siticoneButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton3.HintText = null;
            this.siticoneButton3.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton3.HoverFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton3.HoverTransitionDuration = 140;
            this.siticoneButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siticoneButton3.ImagePadding = 5;
            this.siticoneButton3.ImageSize = new System.Drawing.Size(16, 16);
            this.siticoneButton3.IsRadial = false;
            this.siticoneButton3.IsReadOnly = false;
            this.siticoneButton3.IsToggleButton = false;
            this.siticoneButton3.IsToggled = false;
            this.siticoneButton3.Location = new System.Drawing.Point(368, 233);
            this.siticoneButton3.LongPressDurationMS = 1000;
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.NormalFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton3.ParticleColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.siticoneButton3.ParticleCount = 15;
            this.siticoneButton3.PressAnimationScale = 0.97F;
            this.siticoneButton3.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.siticoneButton3.PressedFontStyle = System.Drawing.FontStyle.Regular;
            this.siticoneButton3.PressTransitionDuration = 90;
            this.siticoneButton3.ReadOnlyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.siticoneButton3.RippleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton3.RippleRadiusMultiplier = 0.6F;
            this.siticoneButton3.ShadowBlur = 5;
            this.siticoneButton3.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton3.ShadowOffset = new System.Drawing.Point(0, 2);
            this.siticoneButton3.ShakeDuration = 500;
            this.siticoneButton3.ShakeIntensity = 5;
            this.siticoneButton3.Size = new System.Drawing.Size(103, 37);
            this.siticoneButton3.TabIndex = 40;
            this.siticoneButton3.Text = "Làm Mới";
            this.siticoneButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton3.TextColor = System.Drawing.Color.White;
            this.siticoneButton3.TooltipText = null;
            this.siticoneButton3.UseAdvancedRendering = true;
            this.siticoneButton3.UseParticles = false;
            // 
            // Frm_Card_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.siticoneButton3);
            this.Controls.Add(this.siticoneButton2);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(maSanPhamLabel);
            this.Controls.Add(this.maSanPhamTextBox);
            this.Controls.Add(tenSanPhamLabel);
            this.Controls.Add(this.tenSanPhamTextBox);
            this.Controls.Add(giaBanLabel);
            this.Controls.Add(this.giaBanTextBox);
            this.Controls.Add(soLuongTonLabel);
            this.Controls.Add(this.soLuongTonTextBox);
            this.Controls.Add(mauSacLabel);
            this.Controls.Add(chatLieuLabel);
            this.Controls.Add(this.chatLieuTextBox);
            this.Controls.Add(hinhAnhLabel);
            this.Controls.Add(danhMucIdLabel);
            this.Controls.Add(this.danhMucIdTextBox);
            this.Controls.Add(this.sanPhamsBindingNavigator);
            this.Controls.Add(this.btn_ChonMau);
            this.Controls.Add(this.ptb_MauSac);
            this.Controls.Add(this.btn_ChonAnh);
            this.Controls.Add(this.ptb_HinhAnh);
            this.Name = "Frm_Card_SanPham";
            this.Text = "Frm_Card_SanPham";
            this.Load += new System.EventHandler(this.Frm_Card_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_MauSac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingNavigator)).EndInit();
            this.sanPhamsBindingNavigator.ResumeLayout(false);
            this.sanPhamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox maSanPhamTextBox;
        private System.Windows.Forms.TextBox tenSanPhamTextBox;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.TextBox soLuongTonTextBox;
        private System.Windows.Forms.TextBox chatLieuTextBox;
        private System.Windows.Forms.TextBox danhMucIdTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog Color_Vai;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton1;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton2;
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton3;
    }
}