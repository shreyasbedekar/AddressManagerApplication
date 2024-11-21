using System;
using System.Text.RegularExpressions;
using Wisej.Web;

namespace ManagerApplication
{
    public partial class EdittStaffForm : Form
    {
        private DatabaseManager dbManager;
        public int StaffId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int OrganisationId { get; set; }
        public EdittStaffForm(DatabaseManager dbManager, int staffId, string title, string firstName, string lastName, string phoneNumber, string email, int organisationId)
        {
            InitializeComponent();
            this.dbManager = dbManager;
            StaffId = staffId;
            TitletextBox.Text = title;
            FirstNametextBox.Text = firstName;
            LastNametextBox.Text = lastName;
            PhoneNumbetextBox.Text = phoneNumber;
            EmailtextBox.Text = email;
            try
            {
                var organisations = dbManager.GetAllOrganisations();
                OrganisationIdcomboBox.DataSource = organisations;
                OrganisationIdcomboBox.DisplayMember = "Name";
                OrganisationIdcomboBox.ValueMember = "Id";

                if (organisationId > 0)
                {
                    OrganisationIdcomboBox.SelectedValue = organisationId;
                }
                else
                {
                    OrganisationIdcomboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error loading organisations: " + ex.Message, MessageBoxIcon.Error);
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

                if (OrganisationIdcomboBox.SelectedValue != null)
                {
                    OrganisationId = Convert.ToInt32(OrganisationIdcomboBox.SelectedValue);
                }
                if (string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName))
                {
                    AlertBox.Show("First Name and Last Name are required!", MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(FirstName, @"^[a-zA-Z]+$"))
                {
                    AlertBox.Show("First Name must contain only letters!", MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(LastName, @"^[a-zA-Z]+$"))
                {
                    AlertBox.Show("Last Name must contain only letters!", MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(PhoneNumber) && !Regex.IsMatch(PhoneNumber, @"^\d+$"))
                {
                    AlertBox.Show("Phone Number must contain only digits!", MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(Email) && !Regex.IsMatch(Email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                {
                    AlertBox.Show("Invalid Email format!", MessageBoxIcon.Error);
                    return;
                }

                dbManager.UpdateStaff(StaffId, Title, FirstName, LastName, PhoneNumber, Email, OrganisationId);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (InvalidCastException ex)
            {
                AlertBox.Show("Invalid data format: " + ex.Message, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error saving staff details: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }
}
