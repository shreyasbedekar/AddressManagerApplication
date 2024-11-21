namespace ManagerApplication
{
    partial class AddOrganisationForm
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Savebutton = new Wisej.Web.Button();
            this.OrganisationNamelabel = new Wisej.Web.Label();
            this.Streetlabel = new Wisej.Web.Label();
            this.Ziplabel = new Wisej.Web.Label();
            this.Citylabel = new Wisej.Web.Label();
            this.Countrylabel = new Wisej.Web.Label();
            this.OrganisationNametextBox = new Wisej.Web.TextBox();
            this.StreettextBox = new Wisej.Web.TextBox();
            this.ZiptextBox = new Wisej.Web.TextBox();
            this.CitytextBox = new Wisej.Web.TextBox();
            this.CountrytextBox = new Wisej.Web.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(163, 307);
            this.Savebutton.Movable = true;
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(100, 37);
            this.Savebutton.TabIndex = 0;
            this.Savebutton.Text = "Save";
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // OrganisationNamelabel
            // 
            this.OrganisationNamelabel.Location = new System.Drawing.Point(23, 64);
            this.OrganisationNamelabel.Movable = true;
            this.OrganisationNamelabel.Name = "OrganisationNamelabel";
            this.OrganisationNamelabel.Size = new System.Drawing.Size(135, 26);
            this.OrganisationNamelabel.TabIndex = 1;
            this.OrganisationNamelabel.Text = "Organisation Name :";
            // 
            // Streetlabel
            // 
            this.Streetlabel.Location = new System.Drawing.Point(23, 107);
            this.Streetlabel.Movable = true;
            this.Streetlabel.Name = "Streetlabel";
            this.Streetlabel.Size = new System.Drawing.Size(135, 26);
            this.Streetlabel.TabIndex = 2;
            this.Streetlabel.Text = "Street : ";
            // 
            // Ziplabel
            // 
            this.Ziplabel.Location = new System.Drawing.Point(23, 150);
            this.Ziplabel.Movable = true;
            this.Ziplabel.Name = "Ziplabel";
            this.Ziplabel.Size = new System.Drawing.Size(135, 26);
            this.Ziplabel.TabIndex = 3;
            this.Ziplabel.Text = "Zip :";
            // 
            // Citylabel
            // 
            this.Citylabel.Location = new System.Drawing.Point(23, 199);
            this.Citylabel.Movable = true;
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(135, 26);
            this.Citylabel.TabIndex = 4;
            this.Citylabel.Text = "City :";
            // 
            // Countrylabel
            // 
            this.Countrylabel.Location = new System.Drawing.Point(23, 254);
            this.Countrylabel.Movable = true;
            this.Countrylabel.Name = "Countrylabel";
            this.Countrylabel.Size = new System.Drawing.Size(135, 26);
            this.Countrylabel.TabIndex = 5;
            this.Countrylabel.Text = "Country :";
            // 
            // OrganisationNametextBox
            // 
            this.OrganisationNametextBox.Location = new System.Drawing.Point(204, 60);
            this.OrganisationNametextBox.Movable = true;
            this.OrganisationNametextBox.Name = "OrganisationNametextBox";
            this.OrganisationNametextBox.Size = new System.Drawing.Size(152, 30);
            this.OrganisationNametextBox.TabIndex = 6;
            // 
            // StreettextBox
            // 
            this.StreettextBox.Location = new System.Drawing.Point(204, 103);
            this.StreettextBox.Movable = true;
            this.StreettextBox.Name = "StreettextBox";
            this.StreettextBox.Size = new System.Drawing.Size(152, 30);
            this.StreettextBox.TabIndex = 7;
            // 
            // ZiptextBox
            // 
            this.ZiptextBox.Location = new System.Drawing.Point(204, 146);
            this.ZiptextBox.Movable = true;
            this.ZiptextBox.Name = "ZiptextBox";
            this.ZiptextBox.Size = new System.Drawing.Size(152, 30);
            this.ZiptextBox.TabIndex = 8;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(204, 195);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(152, 30);
            this.CitytextBox.TabIndex = 9;
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(204, 250);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(152, 30);
            this.CountrytextBox.TabIndex = 10;
            // 
            // AddOrganisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 432);
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
            this.Name = "AddOrganisationForm";
            this.Text = "Add Organisation";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private Wisej.Web.Label Countrylabel;
        private Wisej.Web.Label Citylabel;
        private Wisej.Web.Label Ziplabel;
        private Wisej.Web.Label Streetlabel;
        private Wisej.Web.Button Savebutton;
        private Wisej.Web.Label OrganisationNamelabel;
        private Wisej.Web.TextBox ZiptextBox;
        private Wisej.Web.TextBox StreettextBox;
        private Wisej.Web.TextBox OrganisationNametextBox;
        private Wisej.Web.TextBox CitytextBox;
        private Wisej.Web.TextBox CountrytextBox;
    }
}