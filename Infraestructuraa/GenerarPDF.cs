using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
namespace Infraestructura
{
    public class GenerarPDF
    {
        public void GuardarPDF(List<Persona> personas, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddTitle("Reporte  PULSACIONES");
            document.AddCreator("PULSACIONES ");
            document.AddAuthor("Laureano Esteban Castrellon Perez");
            document.Open();
            document.Add(new Paragraph("Reporte Personas En El Sistema"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(personas));
            document.Close();
        }
        public PdfPTable LlenarTabla(List<Persona> personas)
        {
            PdfPTable tabla = new PdfPTable(6);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Edad"));
            tabla.AddCell(new Paragraph("Sexo"));
            tabla.AddCell(new Paragraph("Email"));
            tabla.AddCell(new Paragraph("Pulsacion"));
            foreach (var item in personas)
            {
                tabla.AddCell(new Paragraph(item.Identificacion));
                tabla.AddCell(new Paragraph(item.Nombre));
                tabla.AddCell(new Paragraph(item.Edad.ToString()));
                tabla.AddCell(new Paragraph(item.Sexo));
                tabla.AddCell(new Paragraph(item.Email));
                tabla.AddCell(new Paragraph(item.Pulsacion.ToString()));
            }
            return tabla;

        }
    }
}
