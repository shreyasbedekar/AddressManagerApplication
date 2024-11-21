using System;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace ManagerApplication
{
    public partial class AddStaffForm : Form
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrgainsationId { get; set; }
        public AddStaffForm()
        {
            InitializeComponent();
            LoadOrganisation();
        }

        private void LoadOrganisation()
        {
            try
            {
                var dbManager = new DatabaseManager();
                var organisations = dbManager.GetAllOrganisations();
                OrganisationIdcomboBox.DataSource = organisations;
                OrganisationIdcomboBox.DisplayMember = "Name";
                OrganisationIdcomboBox.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error retrieving organisations: " + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                Title = TitletextBox.Text;
                FirstName = FirstNametextBox.Text;
                LastName = LastNametextBox.Text;
                PhoneNumber = PhoneNumbetextBox.Text;
                Email = EmailtextBox.Text;

                if (!Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || !Regex.IsMatch(LastName, @"^[a-zA-Z]+$"))
                {
                    AlertBox.Show("First Name and Last Name must contain only letters!", MessageBoxIcon.Error);
                    return;
                }
                if (!Regex.IsMatch(PhoneNumber, @"^\d+$"))
                {
                    AlertBox.Show("Phone Number must contain only numbers!", MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    AlertBox.Show("Please enter a valid email address!", MessageBoxIcon.Error);
                    return;
                }

                if (OrganisationIdcomboBox.SelectedValue != null && int.TryParse(OrganisationIdcomboBox.SelectedValue.ToString(), out int orgId))
                {
                    OrgainsationId = orgId;
                }
                else
                {
                    AlertBox.Show("Invalid Organisation ID selected!", MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                {
                    AlertBox.Show("Please fill in required fields!", MessageBoxIcon.Error);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error saving staff details: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }
}
