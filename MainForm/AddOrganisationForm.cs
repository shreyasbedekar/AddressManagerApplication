using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class AddOrgainsationForm : Form
    {
        public string OrganisationName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public AddOrgainsationForm()
        {
            InitializeComponent();
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
