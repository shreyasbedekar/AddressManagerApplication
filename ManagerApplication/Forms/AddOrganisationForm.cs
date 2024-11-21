using System;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace ManagerApplication
{
    public partial class AddOrganisationForm : Wisej.Web.Form
    {
        public string OrganisationName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public AddOrganisationForm()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                OrganisationName = OrganisationNametextBox.Text;
                Street = StreettextBox.Text;
                Zip = ZiptextBox.Text;
                City = CitytextBox.Text;
                Country = CountrytextBox.Text;

                if (string.IsNullOrWhiteSpace(OrganisationName) || string.IsNullOrWhiteSpace(Street))
                {
                    AlertBox.Show("Organisation Name and Street are required!", MessageBoxIcon.Error);
                    return;
                }
                if (!string.IsNullOrEmpty(Zip) && !Regex.IsMatch(Zip, @"^\d+$"))
                {
                    AlertBox.Show("Zip code must contain only digits!", MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(City, @"^[a-zA-Z\s]+$"))
                {
                    AlertBox.Show("City must contain only letters and spaces!", MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(Country, @"^[a-zA-Z\s]+$"))
                {
                    AlertBox.Show("Country must contain only letters and spaces!", MessageBoxIcon.Error);
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error saving organisation details: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }
}
