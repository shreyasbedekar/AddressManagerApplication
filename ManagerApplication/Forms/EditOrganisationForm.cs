using System;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace ManagerApplication
{
    public partial class EditOrganisationForm : Form
    {
        public int OrgansationId { get; set; }
        public string OrganisationName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public EditOrganisationForm(int organsationId, string organisationName, string street, string zip, string city, string country)
        {
            InitializeComponent();
            OrgansationId = organsationId;
            OrganisationNametextBox.Text = organisationName;
            StreettextBox.Text = street;
            ZiptextBox.Text = zip;
            CitytextBox.Text = city;
            CountrytextBox.Text = country;
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

                if (string.IsNullOrEmpty(OrganisationName) || string.IsNullOrWhiteSpace(Street))
                {
                    AlertBox.Show("Organisation Name and Street are required!", MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(Zip, @"^\d+$"))
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

                var dbManager = new DatabaseManager();
                dbManager.UpdateOrganisation(OrgansationId, OrganisationName, Street, Zip, City, Country);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error saving organisation details: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }
}
