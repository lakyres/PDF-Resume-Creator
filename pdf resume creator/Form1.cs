using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
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
        private readonly string jsonfile = @"C:\Users\angel\source\repos\pdf resume creator\json file\resume.json";
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
            PdfWriter pdfwrite = PdfWriter.GetInstance(pdf, new FileStream("C:\\Users\\angel\\source\\repos\\pdf resume creator\\generated pdf\\MARJES_KYLA.pdf", FileMode.Create));
            pdf.Open();

            iTextSharp.text.Font titlefont = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 30,
                iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            Paragraph title = new Paragraph("RESUME", titlefont);

            title.Alignment = Element.ALIGN_CENTER;

            pdf.Add(title);

            System.Drawing.Image mypicture = System.Drawing.Image.FromFile("C:\\Users\\angel\\source\\repos\\pdf resume creator\\generated pdf\\pics\\me.jpg");
            iTextSharp.text.Image mypicturetext = iTextSharp.text.Image.GetInstance(mypicture, System.Drawing.Imaging.ImageFormat.Jpeg);
            mypicturetext.Alignment = Element.ALIGN_CENTER;
            pdf.Add(mypicturetext);

            iTextSharp.text.Font txtfont = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.HELVETICA.ToString(), 12,
                iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);

            Paragraph infos = new Paragraph(txt_displayread.Text, txtfont);

            infos.Alignment = Element.ALIGN_CENTER;

            pdf.Add(infos);

            
            pdf.Close();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFile;
                using (var read = new StreamReader(jsonfile))
                {
                    jsonFile = read.ReadToEnd();
                }

                txt_displayread.Text = jsonFile;

                var resumeFromJson = JsonConvert.DeserializeObject<Resume>(jsonFile);
            }

            catch (Exception)
            {
                // ignored
            }
        }

        private Resume GetResume()
        {
            var resume = new Resume
            {

                FirstName = "Kyla",
                MiddleName = "Naranjo",
                LastName = "Marjes",
                BirthDate = "October 11, 2002",
                BirthPlace = "Quezon City",
                Sex = "Female",
                CivilStatus = "Single",
                Citizenship = "Filipino",
                Religion = "Roman Catholic",
                Introduction = "My extensive knowledge of computer usage and internet navigation can contribute to your company's innovative and supportive work environment. ",
                Elementary = "Kalalake Elementary School",
                JuniorHighSchool = "Olongapo City National High School",
                SeniorHighSchool = "Gordon College",
                College = "Polytechnic University of the Phillipines (Sta. Mesa)",
                Accomplishment = "Salutatorian (2nd honor), Campus Journalist, Active Girl Scout, Consistent MTAP Contestant, Australian Mathematics Qualifier, Science Contestant (District), Campus Journalist (News Writing), CAT Officer (2nd / Lt. Alpha Company 1st Platoon Leader), President's Lister (1st sem)",
                Competencies = "Proficient in 3 programming; Fluent in Filipino, English, and Japanese; Excellent communication skills ",
                ContactNumber = "09285797337",
                Email = "kylamarjes11@gmail.com",
                Address = "#83-B Irving St., New Kalalake, Olongapo City, Zambales",

            };

            return resume;
        }

        private class Resume
        {

            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string BirthDate { get; set; }
            public string BirthPlace { get; set; }
            public string Sex { get; set; }
            public string CivilStatus { get; set; }
            public string Citizenship { get; set; }
            public string Religion { get; set; }
            public string Introduction { get; set; }
            public string Elementary { get; set; }
            public string JuniorHighSchool { get; set; }
            public string SeniorHighSchool { get; set; }
            public string College { get; set; }
            public string Accomplishment { get; set; }
            public string Competencies { get; set; }
            public string ContactNumber { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }




        }

        private void btn_write_Click_1(object sender, EventArgs e)
        {
            try
            {
                var resume = GetResume();

                var jsonToWrite = JsonConvert.SerializeObject(resume, Formatting.Indented);

                using (var write = new StreamWriter(jsonfile))
                {
                    write.Write(jsonToWrite);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
}
