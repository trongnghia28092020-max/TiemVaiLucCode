namespace TiemVaiLucCode
{
    partial class Form_GioHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_GioHang = new System.Windows.Forms.DataGridView();
            this.clstt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clthanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txt_TimKiem = new SiticoneNetFrameworkUI.SiticoneTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "GIỎ HÀNG CỦA BẠN";
            // 
            // dataGridView_GioHang
            // 
            this.dataGridView_GioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_GioHang.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_GioHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clstt,
            this.Column1,
            this.cldongia,
            this.clsoluong,
            this.clmau,
            this.clthanhtien});
            this.dataGridView_GioHang.Location = new System.Drawing.Point(35, 144);
            this.dataGridView_GioHang.Name = "dataGridView_GioHang";
            this.dataGridView_GioHang.RowHeadersWidth = 51;
            this.dataGridView_GioHang.RowTemplate.Height = 24;
            this.dataGridView_GioHang.Size = new System.Drawing.Size(1190, 374);
            this.dataGridView_GioHang.TabIndex = 36;
            this.dataGridView_GioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clstt
            // 
            this.clstt.HeaderText = "STT";
            this.clstt.MinimumWidth = 6;
            this.clstt.Name = "clstt";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // cldongia
            // 
            this.cldongia.HeaderText = "Đơn giá";
            this.cldongia.MinimumWidth = 6;
            this.cldongia.Name = "cldongia";
            // 
            // clsoluong
            // 
            this.clsoluong.HeaderText = "Số Lượng";
            this.clsoluong.MinimumWidth = 6;
            this.clsoluong.Name = "clsoluong";
            // 
            // clmau
            // 
            this.clmau.HeaderText = "Màu sắc";
            this.clmau.MinimumWidth = 6;
            this.clmau.Name = "clmau";
            // 
            // clthanhtien
            // 
            this.clthanhtien.HeaderText = "Thành tiền";
            this.clthanhtien.MinimumWidth = 6;
            this.clthanhtien.Name = "clthanhtien";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(853, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 37;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Thistle;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1080, 567);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 38;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Image = global::TiemVaiLucCode.Properties.Resources.e2d5dbf16b2bf4a2556004b9f3704d2e_3_;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1289, 699);
            this.pictureBox9.TabIndex = 35;
            this.pictureBox9.TabStop = false;
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
            this.txt_TimKiem.Location = new System.Drawing.Point(35, 91);
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
            this.txt_TimKiem.TabIndex = 39;
            this.txt_TimKiem.TextPadding = new System.Windows.Forms.Padding(16, 0, 6, 0);
            this.txt_TimKiem.ValidationErrorMessage = "Invalid input.";
            this.txt_TimKiem.ValidationFunction = null;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // Form_GioHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1289, 699);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_GioHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox9);
            this.MaximumSize = new System.Drawing.Size(1307, 746);
            this.MinimumSize = new System.Drawing.Size(1307, 746);
            this.Name = "Form_GioHang";
            this.Text = "Form_GioHang";
            this.Load += new System.EventHandler(this.Form_GioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.DataGridView dataGridView_GioHang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clstt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clthanhtien;
        private SiticoneNetFrameworkUI.SiticoneTextBox txt_TimKiem;
    }
}