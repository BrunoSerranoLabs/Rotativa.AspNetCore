using System.Threading.Tasks;

namespace Rotativa.AspNetCore
{
    public class TransformToPdf : TransformToPdfBase
    {
        public byte[] Transform(string html) => WkhtmltopdfDriver.ConvertHtml(this.WkhtmlPath, this.GetConvertOptions(), html);
    }
}
