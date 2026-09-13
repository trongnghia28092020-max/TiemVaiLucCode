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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label maSanPhamLabel;
            System.Windows.Forms.Label tenSanPhamLabel;
            System.Windows.Forms.Label giaBanLabel;
            System.Windows.Forms.Label soLuongTonLabel;
            System.Windows.Forms.Label mauSacLabel;
            System.Windows.Forms.Label chatLieuLabel;
            System.Windows.Forms.Label hinhAnhLabel;
            System.Windows.Forms.Label danhMucIdLabel;
            this.tiemVaiDBDataSet = new TiemVaiLucCode.TiemVaiDBDataSet();
            this.sanPhamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamsTableAdapter = new TiemVaiLucCode.TiemVaiDBDataSetTableAdapters.SanPhamsTableAdapter();
            this.tableAdapterManager = new TiemVaiLucCode.TiemVaiDBDataSetTableAdapters.TableAdapterManager();
            this.tiemVaiDBDataSet1 = new TiemVaiLucCode.TiemVaiDBDataSet1();
            this.donHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donHangsTableAdapter = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.DonHangsTableAdapter();
            this.tableAdapterManager1 = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager();
            this.sanPhamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamsTableAdapter1 = new TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.SanPhamsTableAdapter();
            this.sanPhamsDataGridView = new System.Windows.Forms.DataGridView();
            this.maSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.tenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonTextBox = new System.Windows.Forms.TextBox();
            this.mauSacTextBox = new System.Windows.Forms.TextBox();
            this.chatLieuTextBox = new System.Windows.Forms.TextBox();
            this.hinhAnhTextBox = new System.Windows.Forms.TextBox();
            this.danhMucIdTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maSanPhamLabel = new System.Windows.Forms.Label();
            tenSanPhamLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            mauSacLabel = new System.Windows.Forms.Label();
            chatLieuLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            danhMucIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tiemVaiDBDataSet
            // 
            this.tiemVaiDBDataSet.DataSetName = "TiemVaiDBDataSet";
            this.tiemVaiDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sanPhamsBindingSource
            // 
            this.sanPhamsBindingSource.DataMember = "SanPhams";
            this.sanPhamsBindingSource.DataSource = this.tiemVaiDBDataSet;
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
            this.tableAdapterManager.UpdateOrder = TiemVaiLucCode.TiemVaiDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tiemVaiDBDataSet1
            // 
            this.tiemVaiDBDataSet1.DataSetName = "TiemVaiDBDataSet1";
            this.tiemVaiDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donHangsBindingSource
            // 
            this.donHangsBindingSource.DataMember = "DonHangs";
            this.donHangsBindingSource.DataSource = this.tiemVaiDBDataSet1;
            // 
            // donHangsTableAdapter
            // 
            this.donHangsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiTietDonHangsTableAdapter = null;
            this.tableAdapterManager1.DanhMucsTableAdapter = null;
            this.tableAdapterManager1.DonHangsTableAdapter = this.donHangsTableAdapter;
            this.tableAdapterManager1.KhachHangsTableAdapter = null;
            this.tableAdapterManager1.NhanViensTableAdapter = null;
            this.tableAdapterManager1.SanPhamsTableAdapter = this.sanPhamsTableAdapter1;
            this.tableAdapterManager1.TaiKhoansTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TiemVaiLucCode.TiemVaiDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sanPhamsBindingSource1
            // 
            this.sanPhamsBindingSource1.DataMember = "SanPhams";
            this.sanPhamsBindingSource1.DataSource = this.tiemVaiDBDataSet1;
            // 
            // sanPhamsTableAdapter1
            // 
            this.sanPhamsTableAdapter1.ClearBeforeFill = true;
            // 
            // sanPhamsDataGridView
            // 
            this.sanPhamsDataGridView.AutoGenerateColumns = false;
            this.sanPhamsDataGridView.BackgroundColor = System.Drawing.Color.White;
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
            this.sanPhamsDataGridView.DataSource = this.sanPhamsBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sanPhamsDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.sanPhamsDataGridView.Location = new System.Drawing.Point(38, 315);
            this.sanPhamsDataGridView.Name = "sanPhamsDataGridView";
            this.sanPhamsDataGridView.RowHeadersWidth = 51;
            this.sanPhamsDataGridView.RowTemplate.Height = 24;
            this.sanPhamsDataGridView.Size = new System.Drawing.Size(996, 220);
            this.sanPhamsDataGridView.TabIndex = 0;
            // 
            // maSanPhamLabel
            // 
            maSanPhamLabel.AutoSize = true;
            maSanPhamLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSanPhamLabel.Location = new System.Drawing.Point(33, 42);
            maSanPhamLabel.Name = "maSanPhamLabel";
            maSanPhamLabel.Size = new System.Drawing.Size(147, 26);
            maSanPhamLabel.TabIndex = 1;
            maSanPhamLabel.Text = "Ma San Pham:";
            // 
            // maSanPhamTextBox
            // 
            this.maSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "MaSanPham", true));
            this.maSanPhamTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maSanPhamTextBox.Location = new System.Drawing.Point(224, 39);
            this.maSanPhamTextBox.Name = "maSanPhamTextBox";
            this.maSanPhamTextBox.Size = new System.Drawing.Size(265, 34);
            this.maSanPhamTextBox.TabIndex = 2;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.AutoSize = true;
            tenSanPhamLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSanPhamLabel.Location = new System.Drawing.Point(578, 45);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new System.Drawing.Size(152, 26);
            tenSanPhamLabel.TabIndex = 3;
            tenSanPhamLabel.Text = "Ten San Pham:";
            // 
            // tenSanPhamTextBox
            // 
            this.tenSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "TenSanPham", true));
            this.tenSanPhamTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanPhamTextBox.Location = new System.Drawing.Point(769, 42);
            this.tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            this.tenSanPhamTextBox.Size = new System.Drawing.Size(265, 34);
            this.tenSanPhamTextBox.TabIndex = 4;
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaBanLabel.Location = new System.Drawing.Point(33, 98);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(92, 26);
            giaBanLabel.TabIndex = 5;
            giaBanLabel.Text = "Gia Ban:";
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "GiaBan", true));
            this.giaBanTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaBanTextBox.Location = new System.Drawing.Point(224, 95);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(265, 34);
            this.giaBanTextBox.TabIndex = 6;
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongTonLabel.Location = new System.Drawing.Point(578, 101);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(151, 26);
            soLuongTonLabel.TabIndex = 7;
            soLuongTonLabel.Text = "So Luong Ton:";
            // 
            // soLuongTonTextBox
            // 
            this.soLuongTonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "SoLuongTon", true));
            this.soLuongTonTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongTonTextBox.Location = new System.Drawing.Point(769, 98);
            this.soLuongTonTextBox.Name = "soLuongTonTextBox";
            this.soLuongTonTextBox.Size = new System.Drawing.Size(265, 34);
            this.soLuongTonTextBox.TabIndex = 8;
            // 
            // mauSacLabel
            // 
            mauSacLabel.AutoSize = true;
            mauSacLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mauSacLabel.Location = new System.Drawing.Point(33, 166);
            mauSacLabel.Name = "mauSacLabel";
            mauSacLabel.Size = new System.Drawing.Size(98, 26);
            mauSacLabel.TabIndex = 9;
            mauSacLabel.Text = "Mau Sac:";
            // 
            // mauSacTextBox
            // 
            this.mauSacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "MauSac", true));
            this.mauSacTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mauSacTextBox.Location = new System.Drawing.Point(224, 163);
            this.mauSacTextBox.Name = "mauSacTextBox";
            this.mauSacTextBox.Size = new System.Drawing.Size(265, 34);
            this.mauSacTextBox.TabIndex = 10;
            // 
            // chatLieuLabel
            // 
            chatLieuLabel.AutoSize = true;
            chatLieuLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chatLieuLabel.Location = new System.Drawing.Point(578, 169);
            chatLieuLabel.Name = "chatLieuLabel";
            chatLieuLabel.Size = new System.Drawing.Size(108, 26);
            chatLieuLabel.TabIndex = 11;
            chatLieuLabel.Text = "Chat Lieu:";
            // 
            // chatLieuTextBox
            // 
            this.chatLieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "ChatLieu", true));
            this.chatLieuTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLieuTextBox.Location = new System.Drawing.Point(769, 166);
            this.chatLieuTextBox.Name = "chatLieuTextBox";
            this.chatLieuTextBox.Size = new System.Drawing.Size(265, 34);
            this.chatLieuTextBox.TabIndex = 12;
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhLabel.Location = new System.Drawing.Point(578, 243);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(108, 26);
            hinhAnhLabel.TabIndex = 13;
            hinhAnhLabel.Text = "Hinh Anh:";
            // 
            // hinhAnhTextBox
            // 
            this.hinhAnhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "HinhAnh", true));
            this.hinhAnhTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinhAnhTextBox.Location = new System.Drawing.Point(769, 240);
            this.hinhAnhTextBox.Name = "hinhAnhTextBox";
            this.hinhAnhTextBox.Size = new System.Drawing.Size(265, 34);
            this.hinhAnhTextBox.TabIndex = 14;
            // 
            // danhMucIdLabel
            // 
            danhMucIdLabel.AutoSize = true;
            danhMucIdLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            danhMucIdLabel.Location = new System.Drawing.Point(33, 240);
            danhMucIdLabel.Name = "danhMucIdLabel";
            danhMucIdLabel.Size = new System.Drawing.Size(141, 26);
            danhMucIdLabel.TabIndex = 15;
            danhMucIdLabel.Text = "Danh Muc Id:";
            // 
            // danhMucIdTextBox
            // 
            this.danhMucIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource1, "DanhMucId", true));
            this.danhMucIdTextBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucIdTextBox.Location = new System.Drawing.Point(224, 237);
            this.danhMucIdTextBox.Name = "danhMucIdTextBox";
            this.danhMucIdTextBox.Size = new System.Drawing.Size(265, 34);
            this.danhMucIdTextBox.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSanPham";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Sản Phẩm";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenSanPham";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Sản Phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GiaBan";
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá Bán";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoLuongTon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Số Lượng Tồn";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MauSac";
            this.dataGridViewTextBoxColumn5.HeaderText = "Màu Sắc";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ChatLieu";
            this.dataGridViewTextBoxColumn6.HeaderText = "Chất Liệu";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HinhAnh";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hình Ảnh";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DanhMucId";
            this.dataGridViewTextBoxColumn8.HeaderText = "Mã Danh Mục";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Frm_Card_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(maSanPhamLabel);
            this.Controls.Add(this.maSanPhamTextBox);
            this.Controls.Add(tenSanPhamLabel);
            this.Controls.Add(this.tenSanPhamTextBox);
            this.Controls.Add(giaBanLabel);
            this.Controls.Add(this.giaBanTextBox);
            this.Controls.Add(soLuongTonLabel);
            this.Controls.Add(this.soLuongTonTextBox);
            this.Controls.Add(mauSacLabel);
            this.Controls.Add(this.mauSacTextBox);
            this.Controls.Add(chatLieuLabel);
            this.Controls.Add(this.chatLieuTextBox);
            this.Controls.Add(hinhAnhLabel);
            this.Controls.Add(this.hinhAnhTextBox);
            this.Controls.Add(danhMucIdLabel);
            this.Controls.Add(this.danhMucIdTextBox);
            this.Controls.Add(this.sanPhamsDataGridView);
            this.Name = "Frm_Card_SanPham";
            this.Text = "Frm_Card_SanPham";
            this.Load += new System.EventHandler(this.Frm_Card_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiemVaiDBDataSet tiemVaiDBDataSet;
        private System.Windows.Forms.BindingSource sanPhamsBindingSource;
        private TiemVaiDBDataSetTableAdapters.SanPhamsTableAdapter sanPhamsTableAdapter;
        private TiemVaiDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TiemVaiDBDataSet1 tiemVaiDBDataSet1;
        private System.Windows.Forms.BindingSource donHangsBindingSource;
        private TiemVaiDBDataSet1TableAdapters.DonHangsTableAdapter donHangsTableAdapter;
        private TiemVaiDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private TiemVaiDBDataSet1TableAdapters.SanPhamsTableAdapter sanPhamsTableAdapter1;
        private System.Windows.Forms.BindingSource sanPhamsBindingSource1;
        private System.Windows.Forms.DataGridView sanPhamsDataGridView;
        private System.Windows.Forms.TextBox maSanPhamTextBox;
        private System.Windows.Forms.TextBox tenSanPhamTextBox;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.TextBox soLuongTonTextBox;
        private System.Windows.Forms.TextBox mauSacTextBox;
        private System.Windows.Forms.TextBox chatLieuTextBox;
        private System.Windows.Forms.TextBox hinhAnhTextBox;
        private System.Windows.Forms.TextBox danhMucIdTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}