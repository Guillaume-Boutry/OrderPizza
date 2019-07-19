using Core.Interfaces;
using Core.Model;
using IronPdf;

namespace Core.Writer
{
    public class PDFWriter
    {
        private static HtmlToPdf Renderer = new HtmlToPdf();
        
        public static void PrintToPdf(IWritable command, string path){
            string commandStr = command.ToHtmlString();
            var PDF = Renderer.RenderHtmlAsPdf(commandStr);
            PDF.SaveAs(path);
        }
    }
}