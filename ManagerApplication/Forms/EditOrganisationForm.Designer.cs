namespace ManagerApplication
{
    partial class EditOrganisationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej.NET Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ZiptextBox = new Wisej.Web.TextBox();
            this.StreettextBox = new Wisej.Web.TextBox();
            this.Countrylabel = new Wisej.Web.Label();
            this.Citylabel = new Wisej.Web.Label();
            this.Ziplabel = new Wisej.Web.Label();
            this.Streetlabel = new Wisej.Web.Label();
            this.Savebutton = new Wisej.Web.Button();
            this.OrganisationNamelabel = new Wisej.Web.Label();
            this.OrganisationNametextBox = new Wisej.Web.TextBox();
            this.CitytextBox = new Wisej.Web.TextBox();
            this.CountrytextBox = new Wisej.Web.TextBox();
            this.SuspendLayout();
            // 
            // ZiptextBox
            // 
            this.ZiptextBox.Location = new System.Drawing.Point(216, 136);
            this.ZiptextBox.Movable = true;
            this.ZiptextBox.Name = "ZiptextBox";
            this.ZiptextBox.Size = new System.Drawing.Size(164, 30);
            this.ZiptextBox.TabIndex = 19;
            // 
            // StreettextBox
            // 
            this.StreettextBox.Location = new System.Drawing.Point(216, 93);
            this.StreettextBox.Movable = true;
            this.StreettextBox.Name = "StreettextBox";
            this.StreettextBox.Size = new System.Drawing.Size(164, 30);
            this.StreettextBox.TabIndex = 18;
            // 
            // Countrylabel
            // 
            this.Countrylabel.Location = new System.Drawing.Point(35, 237);
            this.Countrylabel.Movable = true;
            this.Countrylabel.Name = "Countrylabel";
            this.Countrylabel.Size = new System.Drawing.Size(147, 33);
            this.Countrylabel.TabIndex = 16;
            this.Countrylabel.Text = "Country :";
            // 
            // Citylabel
            // 
            this.Citylabel.Location = new System.Drawing.Point(35, 182);
            this.Citylabel.Movable = true;
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(147, 33);
            this.Citylabel.TabIndex = 15;
            this.Citylabel.Text = "City :";
            // 
            // Ziplabel
            // 
            this.Ziplabel.Location = new System.Drawing.Point(35, 133);
            this.Ziplabel.Movable = true;
            this.Ziplabel.Name = "Ziplabel";
            this.Ziplabel.Size = new System.Drawing.Size(147, 33);
            this.Ziplabel.TabIndex = 14;
            this.Ziplabel.Text = "Zip :";
            // 
            // Streetlabel
            // 
            this.Streetlabel.Location = new System.Drawing.Point(35, 90);
            this.Streetlabel.Movable = true;
            this.Streetlabel.Name = "Streetlabel";
            this.Streetlabel.Size = new System.Drawing.Size(147, 33);
            this.Streetlabel.TabIndex = 13;
            this.Streetlabel.Text = "Street : ";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(175, 290);
            this.Savebutton.Movable = true;
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(112, 44);
            this.Savebutton.TabIndex = 11;
            this.Savebutton.Text = "Save";
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // OrganisationNamelabel
            // 
            this.OrganisationNamelabel.Location = new System.Drawing.Point(35, 47);
            this.OrganisationNamelabel.Movable = true;
            this.OrganisationNamelabel.Name = "OrganisationNamelabel";
            this.OrganisationNamelabel.Size = new System.Drawing.Size(147, 33);
            this.OrganisationNamelabel.TabIndex = 12;
            this.OrganisationNamelabel.Text = "Organisation Name :";
            // 
            // OrganisationNametextBox
            // 
            this.OrganisationNametextBox.Location = new System.Drawing.Point(216, 50);
            this.OrganisationNametextBox.Movable = true;
            this.OrganisationNametextBox.Name = "OrganisationNametextBox";
            this.OrganisationNametextBox.Size = new System.Drawing.Size(164, 30);
            this.OrganisationNametextBox.TabIndex = 17;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(216, 185);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(164, 30);
            this.CitytextBox.TabIndex = 20;
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(216, 240);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(164, 30);
            this.CountrytextBox.TabIndex = 21;
            // 
            // EditOrganisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.ZiptextBox);
            this.Controls.Add(this.StreettextBox);
            this.Controls.Add(this.Countrylabel);
            this.Controls.Add(this.Citylabel);
            this.Controls.Add(this.Ziplabel);
            this.Controls.Add(this.Streetlabel);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.OrganisationNamelabel);
            this.Controls.Add(this.OrganisationNametextBox);
            this.Controls.Add(this.CitytextBox);
            this.Controls.Add(this.CountrytextBox);
            this.Name = "EditOrganisationForm";
            this.Text = "EditOrganisationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox ZiptextBox;
        private Wisej.Web.TextBox StreettextBox;
        private Wisej.Web.Label Countrylabel;
        private Wisej.Web.Label Citylabel;
        private Wisej.Web.Label Ziplabel;
        private Wisej.Web.Label Streetlabel;
        private Wisej.Web.Button Savebutton;
        private Wisej.Web.Label OrganisationNamelabel;
        private Wisej.Web.TextBox OrganisationNametextBox;
        private Wisej.Web.TextBox CitytextBox;
        private Wisej.Web.TextBox CountrytextBox;
    }
}