using System.IO;
using System.Web;
using Gizmox.WebGUI.Common.Interfaces;
using Limilabs.Barcode;

namespace GizmoxVisualWebGui_CS
{
    public class BarcodeHandler : IGatewayHandler
    {
        private readonly string _number;

        public BarcodeHandler(string number)
        {
            this._number = number;
        }

        public void ProcessGatewayRequest(IContext context, IRegisteredComponent component)
        {
            BaseBarcode b = BarcodeFactory.GetBarcode(Symbology.EAN128);
            b.Number = _number;
            WriteBarcodeImageToStream(b);
        }

        private static void WriteBarcodeImageToStream(BaseBarcode b)
        {
            HttpContext.Current.Response.ContentType = "image/png";
            MemoryStream ms = new MemoryStream();
            b.Save(ms, ImageType.Png);
            WriteMemoryStream(ms);
        }

        private static void WriteMemoryStream(Stream ms)
        {
            ms.Position = 0;
            byte[] buffer = new byte[1024];
            int read;
            while ((read = ms.Read(buffer, 0, 1024)) != 0)
            {
                HttpContext.Current.Response.OutputStream.Write(buffer, 0, read);
            }

        }
    } ;
}