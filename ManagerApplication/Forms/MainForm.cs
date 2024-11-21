using System;
using Wisej.Web;

namespace ManagerApplication
{
    public partial class MainForm : Form
    {
        private DatabaseManager dbManager;
        public MainForm()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            LoadData();
        }


        private void LoadData()
        {
            organisationdataGridView.DataSource = dbManager.GetAllOrganisations();
            staffdataGridView.DataSource = dbManager.GetAllStaff();
        }

        private void addOrganisationbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var addOrgForm = new AddOrganisationForm();
                if (addOrgForm.ShowDialog() == DialogResult.OK)
                {
                    dbManager.AddOrganisation(addOrgForm.OrganisationName, addOrgForm.Street, addOrgForm.Zip, addOrgForm.City, addOrgForm.Country);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error adding organisation: " + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void editOrgansitonbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (organisationdataGridView.SelectedRows.Count == 0)
                {
                    AlertBox.Show("Please select a row to edit!", MessageBoxIcon.Error);
                    return;
                }

                if (organisationdataGridView.SelectedRows.Count == 1)
                {
                    var selectedRow = organisationdataGridView.SelectedRows[0];
                    if (int.TryParse(selectedRow.Cells["Id"].Value?.ToString(), out int id))
                    {
                        var editOrgForm = new EditOrganisationForm(
                            id,
                            selectedRow.Cells["Name"].Value.ToString(),
                            selectedRow.Cells["Street"].Value.ToString(),
                            selectedRow.Cells["Zip"].Value.ToString(),
                            selectedRow.Cells["City"].Value.ToString(),
                            selectedRow.Cells["Country"].Value.ToString()
                        );

                        if (editOrgForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadData();
                        }
                    }
                    else
                    {
                        AlertBox.Show("Invalid Id value!", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    AlertBox.Show("Please select a row to edit!", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error editing organisation: " + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void addStaffbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var addStaffForm = new AddStaffForm();
                if (addStaffForm.ShowDialog() == DialogResult.OK)
                {
                    dbManager.AddStaff(addStaffForm.Title, addStaffForm.FirstName, addStaffForm.LastName, addStaffForm.PhoneNumber, addStaffForm.Email, addStaffForm.OrgainsationId);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error adding staff: " + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void editStaffbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRow = staffdataGridView.SelectedRows[0];
                int staffId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string title = selectedRow.Cells["Title"].Value.ToString();
                string firstName = selectedRow.Cells["FirstName"].Value.ToString();
                string lastName = selectedRow.Cells["LastName"].Value.ToString();
                string phoneNumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                int organisationId = 0;
                if (selectedRow.Cells["OrganisationId"].Value != null)
                {
                    string organisationIdValue = selectedRow.Cells["OrganisationId"].Value.ToString();
                    if (int.TryParse(organisationIdValue, out int orgId))
                    {
                        organisationId = orgId;
                    }
                    else
                    {
                        AlertBox.Show("Invalid Organisation ID format!", MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    AlertBox.Show("Organisation ID is missing!", MessageBoxIcon.Error);
                    return;
                }

                var editStaffForm = new EdittStaffForm(dbManager, staffId, title, firstName, lastName, phoneNumber, email, organisationId);

                if (editStaffForm.ShowDialog() == DialogResult.OK)
                {
                    dbManager.UpdateStaff(
                        staffId,
                        editStaffForm.Title,
                        editStaffForm.FirstName,
                        editStaffForm.LastName,
                        editStaffForm.PhoneNumber,
                        editStaffForm.Email,
                        editStaffForm.OrganisationId);
                    LoadData();
                }
            }
            catch (InvalidCastException ex)
            {
                AlertBox.Show("Invalid data format: " + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void deleteOrganisaitonbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (organisationdataGridView.SelectedRows.Count == 1)
                {
                    var selectedRow = organisationdataGridView.SelectedRows[0];
                    var idValue = selectedRow.Cells["Id"].Value;
                    if (idValue == null)
                    {
                        AlertBox.Show("The selected row does not have a valid Id!", MessageBoxIcon.Error);
                        return;
                    }
                    dbManager.DeleteOrganisation(Convert.ToInt32(idValue));
                    LoadData();
                }
                else
                {
                    AlertBox.Show("Please select a row to delete!", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error deleting organisation: " + ex.Message, MessageBoxIcon.Error);
            }
        }

        private void deleteStaffbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffdataGridView.SelectedRows.Count == 1)
                {
                    var selectedRow = staffdataGridView.SelectedRows[0];
                    var cellValue = selectedRow.Cells["Id"].Value;

                    if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                    {
                        dbManager.DeleteStaff(id);
                        LoadData();
                    }
                    else
                    {
                        AlertBox.Show("Invalid Id value!", MessageBoxIcon.Error);
                    }
                }
                else
                {
                    AlertBox.Show("Please select a row to delete!", MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AlertBox.Show("Error deleting staff: " + ex.Message, MessageBoxIcon.Error);
            }
        }
    }
}
