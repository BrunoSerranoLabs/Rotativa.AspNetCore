namespace Rotativa.NetStandard
{
    public class TransformToPdf : TransformToPdfBase
    {
        public byte[] Transform(string html) => WkhtmltopdfDriver.ConvertHtml(WkhtmlPath, GetConvertOptions(), html);
    }
}
