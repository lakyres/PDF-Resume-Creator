using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdf_resume_creator
{
    public partial class PDFcreator : Form
    {
        
        public PDFcreator()
        {
            InitializeComponent();
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_jsontest_Click(object sender, EventArgs e)
        {
            JSON otherform = new JSON();
            otherform.Show();

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            Document pdf = new Document(PageSize.A4, 20f, 20f, 30f, 30f);
            PdfWriter pdfwrite = PdfWriter.GetInstance(pdf, new FileStream("C:\\Users\\angel\\source\\repos\\pdf resume creator\\generated pdf\\Resume.pdf", FileMode.Create));

            Paragraph pargrph = new Paragraph("RESUME");
            pdf.Add(pargrph);
            pdf.Close();
        }
    }
}
