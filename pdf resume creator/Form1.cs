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
            pdf.Open();

            iTextSharp.text.Font titlefont = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 30,
                iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            Paragraph title = new Paragraph("RESUME", titlefont);

            title.Alignment = Element.ALIGN_CENTER;

            pdf.Add(title);

            System.Drawing.Image mypicture = System.Drawing.Image.FromFile("C:\\Users\\angel\\source\\repos\\pdf resume creator\\pics\\me.jpg");
            iTextSharp.text.Image mypicturetext = iTextSharp.text.Image.GetInstance(mypicture, System.Drawing.Imaging.ImageFormat.Jpeg);
            mypicturetext.Alignment = Element.ALIGN_CENTER;
            pdf.Add(mypicturetext);

            iTextSharp.text.Font txtfont = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 12,
                iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            Paragraph infos = new Paragraph(txt_displayread.Text, txtfont);

            infos.Alignment = Element.ALIGN_CENTER;

            pdf.Add(infos);

            
            pdf.Close();
        }
    }
}
