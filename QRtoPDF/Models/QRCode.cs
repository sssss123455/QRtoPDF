using QRCoder;
using System.Drawing;


namespace QRtoPDF.Models
{
    public class QRCode
    {
       
        public string Qr { get; set; }
  
        public static QRCode GetOne(string t)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(t, QRCodeGenerator.ECCLevel.Q);
            var imgType = Base64QRCode.ImageType.Jpeg;
            Base64QRCode qrCode = new Base64QRCode(qrCodeData);
            string qrCodeImageAsBase64 = qrCode.GetGraphic(20, Color.Black, Color.White, true, imgType);
            
            var code = new QRCode();
            code.Qr = qrCodeImageAsBase64;
             
            
            return code;
        }
    }
   
}

