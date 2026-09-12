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
            System.Windows.Forms.Label sanPhamIdLabel;
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
            this.sanPhamIdTextBox = new System.Windows.Forms.TextBox();
            this.tenSanPhamTextBox = new System.Windows.Forms.TextBox();
            this.giaBanTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonTextBox = new System.Windows.Forms.TextBox();
            this.mauSacTextBox = new System.Windows.Forms.TextBox();
            this.chatLieuTextBox = new System.Windows.Forms.TextBox();
            this.hinhAnhTextBox = new System.Windows.Forms.TextBox();
            this.danhMucIdTextBox = new System.Windows.Forms.TextBox();
            sanPhamIdLabel = new System.Windows.Forms.Label();
            tenSanPhamLabel = new System.Windows.Forms.Label();
            giaBanLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            mauSacLabel = new System.Windows.Forms.Label();
            chatLieuLabel = new System.Windows.Forms.Label();
            hinhAnhLabel = new System.Windows.Forms.Label();
            danhMucIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).BeginInit();
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
            // sanPhamIdLabel
            // 
            sanPhamIdLabel.AutoSize = true;
            sanPhamIdLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sanPhamIdLabel.Location = new System.Drawing.Point(48, 52);
            sanPhamIdLabel.Name = "sanPhamIdLabel";
            sanPhamIdLabel.Size = new System.Drawing.Size(101, 19);
            sanPhamIdLabel.TabIndex = 1;
            sanPhamIdLabel.Text = "Mã Sản Phẩm";
            // 
            // sanPhamIdTextBox
            // 
            this.sanPhamIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "SanPhamId", true));
            this.sanPhamIdTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanPhamIdTextBox.Location = new System.Drawing.Point(153, 49);
            this.sanPhamIdTextBox.Name = "sanPhamIdTextBox";
            this.sanPhamIdTextBox.Size = new System.Drawing.Size(100, 27);
            this.sanPhamIdTextBox.TabIndex = 2;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.AutoSize = true;
            tenSanPhamLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSanPhamLabel.Location = new System.Drawing.Point(48, 81);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new System.Drawing.Size(104, 19);
            tenSanPhamLabel.TabIndex = 3;
            tenSanPhamLabel.Text = "Tên Sản Phẩm";
            // 
            // tenSanPhamTextBox
            // 
            this.tenSanPhamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "TenSanPham", true));
            this.tenSanPhamTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanPhamTextBox.Location = new System.Drawing.Point(153, 82);
            this.tenSanPhamTextBox.Name = "tenSanPhamTextBox";
            this.tenSanPhamTextBox.Size = new System.Drawing.Size(100, 27);
            this.tenSanPhamTextBox.TabIndex = 4;
            // 
            // giaBanLabel
            // 
            giaBanLabel.AutoSize = true;
            giaBanLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            giaBanLabel.Location = new System.Drawing.Point(48, 118);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new System.Drawing.Size(68, 19);
            giaBanLabel.TabIndex = 5;
            giaBanLabel.Text = "Giá Bán:";
            // 
            // giaBanTextBox
            // 
            this.giaBanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "GiaBan", true));
            this.giaBanTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giaBanTextBox.Location = new System.Drawing.Point(153, 115);
            this.giaBanTextBox.Name = "giaBanTextBox";
            this.giaBanTextBox.Size = new System.Drawing.Size(100, 27);
            this.giaBanTextBox.TabIndex = 6;
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soLuongTonLabel.Location = new System.Drawing.Point(48, 151);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(105, 19);
            soLuongTonLabel.TabIndex = 7;
            soLuongTonLabel.Text = "Số Lượng Tồn";
            // 
            // soLuongTonTextBox
            // 
            this.soLuongTonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "SoLuongTon", true));
            this.soLuongTonTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongTonTextBox.Location = new System.Drawing.Point(153, 148);
            this.soLuongTonTextBox.Name = "soLuongTonTextBox";
            this.soLuongTonTextBox.Size = new System.Drawing.Size(100, 27);
            this.soLuongTonTextBox.TabIndex = 8;
            // 
            // mauSacLabel
            // 
            mauSacLabel.AutoSize = true;
            mauSacLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mauSacLabel.Location = new System.Drawing.Point(676, 57);
            mauSacLabel.Name = "mauSacLabel";
            mauSacLabel.Size = new System.Drawing.Size(67, 19);
            mauSacLabel.TabIndex = 9;
            mauSacLabel.Text = "Màu Sắc";
            // 
            // mauSacTextBox
            // 
            this.mauSacTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "MauSac", true));
            this.mauSacTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mauSacTextBox.Location = new System.Drawing.Point(781, 54);
            this.mauSacTextBox.Name = "mauSacTextBox";
            this.mauSacTextBox.Size = new System.Drawing.Size(100, 27);
            this.mauSacTextBox.TabIndex = 10;
            // 
            // chatLieuLabel
            // 
            chatLieuLabel.AutoSize = true;
            chatLieuLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chatLieuLabel.Location = new System.Drawing.Point(676, 90);
            chatLieuLabel.Name = "chatLieuLabel";
            chatLieuLabel.Size = new System.Drawing.Size(75, 19);
            chatLieuLabel.TabIndex = 11;
            chatLieuLabel.Text = "Chất Liệu";
            // 
            // chatLieuTextBox
            // 
            this.chatLieuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "ChatLieu", true));
            this.chatLieuTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLieuTextBox.Location = new System.Drawing.Point(781, 87);
            this.chatLieuTextBox.Name = "chatLieuTextBox";
            this.chatLieuTextBox.Size = new System.Drawing.Size(100, 27);
            this.chatLieuTextBox.TabIndex = 12;
            // 
            // hinhAnhLabel
            // 
            hinhAnhLabel.AutoSize = true;
            hinhAnhLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hinhAnhLabel.Location = new System.Drawing.Point(676, 123);
            hinhAnhLabel.Name = "hinhAnhLabel";
            hinhAnhLabel.Size = new System.Drawing.Size(73, 19);
            hinhAnhLabel.TabIndex = 13;
            hinhAnhLabel.Text = "Hình Ảnh";
            // 
            // hinhAnhTextBox
            // 
            this.hinhAnhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "HinhAnh", true));
            this.hinhAnhTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hinhAnhTextBox.Location = new System.Drawing.Point(781, 120);
            this.hinhAnhTextBox.Name = "hinhAnhTextBox";
            this.hinhAnhTextBox.Size = new System.Drawing.Size(100, 27);
            this.hinhAnhTextBox.TabIndex = 14;
            // 
            // danhMucIdLabel
            // 
            danhMucIdLabel.AutoSize = true;
            danhMucIdLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            danhMucIdLabel.Location = new System.Drawing.Point(676, 156);
            danhMucIdLabel.Name = "danhMucIdLabel";
            danhMucIdLabel.Size = new System.Drawing.Size(79, 19);
            danhMucIdLabel.TabIndex = 15;
            danhMucIdLabel.Text = "Danh Mục";
            // 
            // danhMucIdTextBox
            // 
            this.danhMucIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sanPhamsBindingSource, "DanhMucId", true));
            this.danhMucIdTextBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucIdTextBox.Location = new System.Drawing.Point(781, 153);
            this.danhMucIdTextBox.Name = "danhMucIdTextBox";
            this.danhMucIdTextBox.Size = new System.Drawing.Size(100, 27);
            this.danhMucIdTextBox.TabIndex = 16;
            // 
            // Frm_Card_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 579);
            this.Controls.Add(sanPhamIdLabel);
            this.Controls.Add(this.sanPhamIdTextBox);
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
            this.Name = "Frm_Card_SanPham";
            this.Text = "Frm_Card_SanPham";
            this.Load += new System.EventHandler(this.Frm_Card_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tiemVaiDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TiemVaiDBDataSet tiemVaiDBDataSet;
        private System.Windows.Forms.BindingSource sanPhamsBindingSource;
        private TiemVaiDBDataSetTableAdapters.SanPhamsTableAdapter sanPhamsTableAdapter;
        private TiemVaiDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox sanPhamIdTextBox;
        private System.Windows.Forms.TextBox tenSanPhamTextBox;
        private System.Windows.Forms.TextBox giaBanTextBox;
        private System.Windows.Forms.TextBox soLuongTonTextBox;
        private System.Windows.Forms.TextBox mauSacTextBox;
        private System.Windows.Forms.TextBox chatLieuTextBox;
        private System.Windows.Forms.TextBox hinhAnhTextBox;
        private System.Windows.Forms.TextBox danhMucIdTextBox;
    }
}