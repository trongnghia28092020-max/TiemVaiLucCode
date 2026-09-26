using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace TiemVaiLucCode
{
    public partial class Frm_QRCode : Form
    {
       
        private decimal tongTienCanThanhToan;
        public Frm_QRCode(decimal tongTien)
        {
            InitializeComponent();
            tongTienCanThanhToan = tongTien;
        }
        private void Frm_QRCode_Load(object sender, EventArgs e)
        {
            // Hiển thị số tiền to bự màu đỏ lên Form
            lbl_SoTien.Text = tongTienCanThanhToan.ToString("N0") + " VNĐ";

            // --- THÔNG TIN TÀI KHOẢN CHUẨN PVCOMBANK ---
            string nganHang = "PVCB"; // Mã của PVcomBank đây nha =))
            string soTaiKhoan = "108002753898";
            string tenTaiKhoan = "NGUYEN BUI TRONG NGHIA";

            // Nội dung chuyển khoản
            string noiDungCK = "Thanh toan mua vai " + DateTime.Now.ToString("ddMMyy");

            // Xử lý mã hóa khoảng trắng trong tên và nội dung để làm link URL không bị gãy
            string tenTKEncoded = Uri.EscapeDataString(tenTaiKhoan);
            string noiDungEncoded = Uri.EscapeDataString(noiDungCK);

            // Ráp thành một đường link VietQR hoàn chỉnh (compact2 để hiện logo PVcomBank cho xịn)
            string urlQR = $"https://img.vietqr.io/image/{nganHang}-{soTaiKhoan}-compact2.jpg?amount={tongTienCanThanhToan}&addInfo={noiDungEncoded}&accountName={tenTKEncoded}";

            // Dùng LoadAsync để tải hình QR cực mượt không làm giật form
            ptb_QRCode.LoadAsync(urlQR);
        }

        private Image TaoMaQR_ZXing(string noiDung)
        {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            barcodeWriter.Format = BarcodeFormat.QR_CODE; // Định dạng là mã QR

            // Chỉnh kích thước và lề cho đẹp
            barcodeWriter.Options = new EncodingOptions
            {
                Width = 250,      // Phải bằng với kích thước của ptb_QRCode trên giao diện
                Height = 250,
                Margin = 1,       // Lề trắng mỏng thôi cho mã QR bự lên
                PureBarcode = false
            };
            Bitmap qrCodeImage = barcodeWriter.Write(noiDung);
            return qrCodeImage;
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            // Báo hiệu đã thanh toán thành công
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            // Báo hiệu khách hủy thanh toán
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
