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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Card_DonHang));
            this.tiemVaiDBDataSet1 = new TiemVaiLucCode.TiemVaiDBDataSet1();
            this.chiTietDonHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chiTietDonHangsTableAdapter = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.ChiTietDonHangsTableAdapter();
            this.tableAdapterManager = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager();
            this.chiTietDonHangsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.chiTietDonHangsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new SiticoneNetFrameworkUI.SiticoneButton();
            this.siticoneTextBox1 = new SiticoneNetFrameworkUI.SiticoneTextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.chiTietDonHangsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            this.chiTietDonHangsBindingNavigator.Size = new System.Drawing.Size(1099, 31);
            this.chiTietDonHangsBindingNavigator.TabIndex = 0;
            this.chiTietDonHangsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // chiTietDonHangsDataGridView
            // 
            this.chiTietDonHangsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chiTietDonHangsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.chiTietDonHangsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietDonHangsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.chiTietDonHangsDataGridView.DataSource = this.chiTietDonHangsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.chiTietDonHangsDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.chiTietDonHangsDataGridView.Location = new System.Drawing.Point(39, 119);
            this.chiTietDonHangsDataGridView.Name = "chiTietDonHangsDataGridView";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.chiTietDonHangsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.chiTietDonHangsDataGridView.RowHeadersWidth = 51;
            this.chiTietDonHangsDataGridView.RowTemplate.Height = 24;
            this.chiTietDonHangsDataGridView.Size = new System.Drawing.Size(988, 448);
            this.chiTietDonHangsDataGridView.TabIndex = 1;
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
            // siticoneButton1
            // 
            this.siticoneButton1.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard" +
    "";
            this.siticoneButton1.AccessibleName = "Làm mới";
            this.siticoneButton1.AutoSizeBasedOnText = false;
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BadgeBackColor = System.Drawing.Color.Black;
            this.siticoneButton1.BadgeFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.BadgeValue = 0;
            this.siticoneButton1.BadgeValueForeColor = System.Drawing.Color.White;
            this.siticoneButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.siticoneButton1.BorderWidth = 1;
            this.siticoneButton1.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
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
            this.siticoneButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.siticoneButton1.GlowIntensity = 100;
            this.siticoneButton1.GlowRadius = 20F;
            this.siticoneButton1.GradientBackground = false;
            this.siticoneButton1.GradientColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(227)))), ((int)(((byte)(64)))));
            this.siticoneButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneButton1.HintText = null;
            this.siticoneButton1.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.siticoneButton1.Location = new System.Drawing.Point(897, 50);
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
            this.siticoneButton1.Size = new System.Drawing.Size(130, 35);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "Làm mới";
            this.siticoneButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.siticoneButton1.TextColor = System.Drawing.Color.White;
            this.siticoneButton1.TooltipText = null;
            this.siticoneButton1.UseAdvancedRendering = true;
            this.siticoneButton1.UseParticles = false;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.AccessibleDescription = "A customizable text input field.";
            this.siticoneTextBox1.AccessibleName = "Text Box";
            this.siticoneTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.siticoneTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTextBox1.BlinkCount = 3;
            this.siticoneTextBox1.BlinkShadow = false;
            this.siticoneTextBox1.BorderColor1 = System.Drawing.Color.LightSlateGray;
            this.siticoneTextBox1.BorderColor2 = System.Drawing.Color.LightSlateGray;
            this.siticoneTextBox1.BorderFocusColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.BorderFocusColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.CanShake = true;
            this.siticoneTextBox1.ContinuousBlink = false;
            this.siticoneTextBox1.CornerRadiusBottomLeft = 20;
            this.siticoneTextBox1.CornerRadiusBottomRight = 20;
            this.siticoneTextBox1.CornerRadiusTopLeft = 20;
            this.siticoneTextBox1.CornerRadiusTopRight = 20;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.CursorBlinkRate = 500;
            this.siticoneTextBox1.CursorColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.CursorHeight = 26;
            this.siticoneTextBox1.CursorOffset = 0;
            this.siticoneTextBox1.CursorStyle = SiticoneNetFrameworkUI.Helpers.DrawingStyle.SiticoneDrawingStyle.Solid;
            this.siticoneTextBox1.CursorWidth = 1;
            this.siticoneTextBox1.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.siticoneTextBox1.DisabledBorderColor = System.Drawing.Color.LightGray;
            this.siticoneTextBox1.DisabledTextColor = System.Drawing.Color.Gray;
            this.siticoneTextBox1.EnableDropShadow = false;
            this.siticoneTextBox1.FillColor1 = System.Drawing.Color.White;
            this.siticoneTextBox1.FillColor2 = System.Drawing.Color.White;
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.HoverBorderColor1 = System.Drawing.Color.Gray;
            this.siticoneTextBox1.HoverBorderColor2 = System.Drawing.Color.Gray;
            this.siticoneTextBox1.IsEnabled = true;
            this.siticoneTextBox1.Location = new System.Drawing.Point(376, 50);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PlaceholderColor = System.Drawing.Color.Gray;
            this.siticoneTextBox1.PlaceholderText = "Nhập thông tin tiềm kiếm...";
            this.siticoneTextBox1.ReadOnlyBorderColor1 = System.Drawing.Color.LightGray;
            this.siticoneTextBox1.ReadOnlyBorderColor2 = System.Drawing.Color.LightGray;
            this.siticoneTextBox1.ReadOnlyFillColor1 = System.Drawing.Color.WhiteSmoke;
            this.siticoneTextBox1.ReadOnlyFillColor2 = System.Drawing.Color.WhiteSmoke;
            this.siticoneTextBox1.ReadOnlyPlaceholderColor = System.Drawing.Color.DarkGray;
            this.siticoneTextBox1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.ShadowAnimationDuration = 1;
            this.siticoneTextBox1.ShadowBlur = 10;
            this.siticoneTextBox1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneTextBox1.Size = new System.Drawing.Size(515, 35);
            this.siticoneTextBox1.SolidBorderColor = System.Drawing.Color.LightSlateGray;
            this.siticoneTextBox1.SolidBorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.SolidBorderHoverColor = System.Drawing.Color.Gray;
            this.siticoneTextBox1.SolidFillColor = System.Drawing.Color.White;
            this.siticoneTextBox1.TabIndex = 4;
            this.siticoneTextBox1.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.siticoneTextBox1.ValidationErrorMessage = "Invalid input.";
            this.siticoneTextBox1.ValidationFunction = null;
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
            // chiTietDonHangsBindingNavigatorSaveItem
            // 
            this.chiTietDonHangsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chiTietDonHangsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("chiTietDonHangsBindingNavigatorSaveItem.Image")));
            this.chiTietDonHangsBindingNavigatorSaveItem.Name = "chiTietDonHangsBindingNavigatorSaveItem";
            this.chiTietDonHangsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.chiTietDonHangsBindingNavigatorSaveItem.Text = "Save Data";
            this.chiTietDonHangsBindingNavigatorSaveItem.Click += new System.EventHandler(this.chiTietDonHangsBindingNavigatorSaveItem_Click);
            // 
            // Frm_Card_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.siticoneButton1);
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
        private SiticoneNetFrameworkUI.SiticoneButton siticoneButton1;
        private SiticoneNetFrameworkUI.SiticoneTextBox siticoneTextBox1;
    }
}