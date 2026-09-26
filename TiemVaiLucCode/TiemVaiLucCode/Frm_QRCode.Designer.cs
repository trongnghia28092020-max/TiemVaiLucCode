namespace TiemVaiLucCode
{
    partial class Frm_QRCode
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Instruction = new System.Windows.Forms.Label();
            this.ptb_QRCode = new System.Windows.Forms.PictureBox();
            this.lbl_SoTienText = new System.Windows.Forms.Label();
            this.lbl_SoTien = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DeepPink;
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(380, 50);
            this.pnl_Header.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(380, 50);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "THANH TOÁN CHUYỂN KHOẢN";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Instruction
            // 
            this.lbl_Instruction.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instruction.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Instruction.Location = new System.Drawing.Point(12, 60);
            this.lbl_Instruction.Name = "lbl_Instruction";
            this.lbl_Instruction.Size = new System.Drawing.Size(356, 25);
            this.lbl_Instruction.TabIndex = 1;
            this.lbl_Instruction.Text = "Quét mã QR qua ứng dụng Ngân hàng/Momo";
            this.lbl_Instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb_QRCode
            // 
            this.ptb_QRCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ptb_QRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_QRCode.Location = new System.Drawing.Point(65, 95);
            this.ptb_QRCode.Name = "ptb_QRCode";
            this.ptb_QRCode.Size = new System.Drawing.Size(250, 250);
            this.ptb_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_QRCode.TabIndex = 2;
            this.ptb_QRCode.TabStop = false;
            // 
            // lbl_SoTienText
            // 
            this.lbl_SoTienText.AutoSize = true;
            this.lbl_SoTienText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTienText.Location = new System.Drawing.Point(135, 360);
            this.lbl_SoTienText.Name = "lbl_SoTienText";
            this.lbl_SoTienText.Size = new System.Drawing.Size(110, 22);
            this.lbl_SoTienText.TabIndex = 3;
            this.lbl_SoTienText.Text = "Số tiền cần thanh toán:";
            this.lbl_SoTienText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SoTien
            // 
            this.lbl_SoTien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTien.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_SoTien.Location = new System.Drawing.Point(12, 385);
            this.lbl_SoTien.Name = "lbl_SoTien";
            this.lbl_SoTien.Size = new System.Drawing.Size(356, 35);
            this.lbl_SoTien.TabIndex = 4;
            this.lbl_SoTien.Text = "0 VNĐ";
            this.lbl_SoTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_XacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.ForeColor = System.Drawing.Color.White;
            this.btn_XacNhan.Location = new System.Drawing.Point(30, 440);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(320, 45);
            this.btn_XacNhan.TabIndex = 5;
            this.btn_XacNhan.Text = "ĐÃ NHẬN TIỀN (XÁC NHẬN)";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.LightGray;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.FlatAppearance.BorderSize = 0;
            this.btn_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Huy.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.Black;
            this.btn_Huy.Location = new System.Drawing.Point(135, 500);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(110, 35);
            this.btn_Huy.TabIndex = 6;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // Frm_QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 560);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.lbl_SoTien);
            this.Controls.Add(this.lbl_SoTienText);
            this.Controls.Add(this.ptb_QRCode);
            this.Controls.Add(this.lbl_Instruction);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_QRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quét mã QR";
            this.Load += new System.EventHandler(this.Frm_QRCode_Load);
            this.pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_QRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Instruction;
        private System.Windows.Forms.PictureBox ptb_QRCode;
        private System.Windows.Forms.Label lbl_SoTienText;
        private System.Windows.Forms.Label lbl_SoTien;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Huy;
    }
}