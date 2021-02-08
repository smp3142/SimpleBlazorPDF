using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace MakePDF
{
    public static class MyPDF
    {
        public static byte[] Hello(string greeting)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            PdfWriter pdfWriter = new PdfWriter(memoryStream);
            PdfDocument pdfDocument = new PdfDocument(pdfWriter);
            Document document = new Document(pdfDocument);
            Paragraph paragraph = new Paragraph(greeting)
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(paragraph);
            document.Close();
            return memoryStream.ToArray();
        }
    }
}
