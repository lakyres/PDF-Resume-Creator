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

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace pdf_resume_creator
{
    public partial class JSON : Form
    {
        private readonly string jsonfile = @"C:\Users\angel\source\repos\pdf resume creator\json file\resume.json";
        public JSON()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                string jsonFile;
                using (var read = new StreamReader(jsonfile))
                {
                    jsonFile = read.ReadToEnd();
                }

                txt_displayread.Text = jsonFile;

                var customerFromJson = JsonConvert.DeserializeObject<Resume>(jsonFile);
            }

            catch (Exception)
            {
                // ignored
            }
        }

        private void btn_write_Click(object sender, EventArgs e)
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
                Elementary = "KALALAKE ELEMENTARY SCHOOL",
                JuniorHighSchool = "OLONGAPO CITY NATIONAL HIGH SCHOOL",
                SeniorHighSchool = "GORDON COLLEGE",
                College = "POLYTECHNIC UNIVERSITY OF THE PHILIPPINES (STA. MESA)",
                ExperienceAccomplishment = "Salutatorian (2nd honor), Campus Journalist, Active Girl Scout, Consistent MTAP Contestant, Australian Mathematics Qualifier, Science Contestant (District), Campus Journalist (News Writing), CAT Officer(2nd / Lt.Alpha Company 1st Platoon Leader), President's Lister (1st sem)",
                Competencies1 = "Proficient in 3 programming",
                Competencies2 = "Fluent in Filipino, English, and Japanese",
                Competencies3 = "Excellent communication skills",
                ContactInformation1 = "09285797337",
                ContactInformation2 = "kylamarjes11@gmail.com",
                ContactInformation3 = "#83-B Irving St., New Kalalake, Olongapo City, Zambales",



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
            public string Elementary { get; set; }
            public string JuniorHighSchool { get; set; }
            public string SeniorHighSchool { get; set; }
            public string College { get; set; }
            public string ExperienceAccomplishment { get; set; }
            public string Competencies1 { get; set; }
            public string Competencies2 { get; set; }
            public string Competencies3 { get; set; }
            public string ContactInformation1 { get; set; }
            public string ContactInformation2 { get; set; }
            public string ContactInformation3 { get; set; }




        }

		

		

		

		
	}
}
