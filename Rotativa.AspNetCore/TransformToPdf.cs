using System.Threading.Tasks;

namespace Rotativa.AspNetCore
{
    public class TransformToPdf : AsPdfResultBase
    {
        public async Task<byte[]> Transform(string html)
        {
            return WkhtmltopdfDriver.ConvertHtml(this.WkhtmlPath, this.GetConvertOptions(), html);
        }
    }
}
