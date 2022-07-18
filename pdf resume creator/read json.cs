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
                string jsonFromFile;
                using (var reader = new StreamReader(jsonfile))
                {
                    jsonFromFile = reader.ReadToEnd();
                }

                txt_displayread.Text = jsonFromFile;

                var customerFromJson = JsonConvert.DeserializeObject<Resume>(jsonFromFile);
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
                var customer = GetCustomer();

                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                using (var writer = new StreamWriter(jsonfile))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

		private Resume GetCustomer()
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


        }

		

		

		

		
	}
}
