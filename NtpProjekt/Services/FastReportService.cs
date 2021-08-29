using FastReport;
using FastReport.Export.Pdf;
using FastReport.Export.RichText;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NtpProjekt.Services
{
    public class ReportService
    {
        public ReportService()
        {

        }
        public static void SveKnjigeReport(List<Knjige> lista)
        {
            Report rpt = new Report();
            rpt.Load(UcitajIzvjestajIzStreama("SveKnjigeReport"));
            rpt.RegisterData(lista, "Podaci");
            rpt.Show();
        }
        public static void ReportToPDF(List<Knjige> lista)
        {
            Report rpt = new Report();
            rpt.Load(UcitajIzvjestajIzStreama("SveKnjigeReport"));
            rpt.RegisterData(lista, "Podaci");

            rpt.Prepare();

            PDFExport pdf = new PDFExport();
            RTFExport rtf = new RTFExport();
            rpt.Export(pdf, "E:\\Reports\\ExportPDF.pdf");
            rpt.Export(rtf, "E:\\Reports\\ExportRTF.rtf");
        }
        private static Stream UcitajIzvjestajIzStreama(string fileName)
        {
            return Assembly.GetExecutingAssembly().GetManifestResourceStream($"NtpProjekt.{fileName}.frx");
        }
    }
}