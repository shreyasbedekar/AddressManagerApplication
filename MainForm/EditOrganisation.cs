using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wisej.Web;

namespace MainForm
{
    public partial class EditOrganisation : Wisej.Web.Form
    {
        public int OrganisationId { get; set; }
        public string OrganisationName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public EditOrganisation(int organisationId)
        {
            InitializeComponent();
            OrganisationId = organisationId;
        }

        private void LoadOrganisationData()
        {
            var dbManager = new DatabaseManager();
            var organisation = dbManager.GetOrganisationById(OrganisationId);
            OrganisationtextBox.Text = organisation.Name;
            StreettextBox.Text = organisation.Street;
            ZiptextBox.Text = organisation.Zip;
            CitytextBox.Text = organisation.City;
            CountrytextBox.Text = organisation.Country;
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            OrganisationName = OrganisationtextBox.Text;
            Street = StreettextBox.Text;
            Zip = ZiptextBox.Text;
            City = CitytextBox.Text;
            Country = CountrytextBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
