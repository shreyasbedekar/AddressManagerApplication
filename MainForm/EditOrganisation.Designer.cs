namespace MainForm
{
    partial class EditOrganisation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrganisationIdlabel = new System.Windows.Forms.Label();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.ZiptextBox = new System.Windows.Forms.TextBox();
            this.StreettextBox = new System.Windows.Forms.TextBox();
            this.Countrylabel = new System.Windows.Forms.Label();
            this.Citylabel = new System.Windows.Forms.Label();
            this.Ziplabel = new System.Windows.Forms.Label();
            this.Streetlabel = new System.Windows.Forms.Label();
            this.OrganisationNamelabel = new System.Windows.Forms.Label();
            this.OrganisationtextBox = new System.Windows.Forms.TextBox();
            this.OrganisationIdtextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrganisationIdlabel
            // 
            this.OrganisationIdlabel.AutoSize = true;
            this.OrganisationIdlabel.Location = new System.Drawing.Point(74, 41);
            this.OrganisationIdlabel.Name = "OrganisationIdlabel";
            this.OrganisationIdlabel.Size = new System.Drawing.Size(106, 16);
            this.OrganisationIdlabel.TabIndex = 0;
            this.OrganisationIdlabel.Text = "Organisation Id : ";
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(252, 262);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(202, 22);
            this.CountrytextBox.TabIndex = 19;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(252, 222);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(202, 22);
            this.CitytextBox.TabIndex = 18;
            // 
            // ZiptextBox
            // 
            this.ZiptextBox.Location = new System.Drawing.Point(252, 176);
            this.ZiptextBox.Name = "ZiptextBox";
            this.ZiptextBox.Size = new System.Drawing.Size(202, 22);
            this.ZiptextBox.TabIndex = 17;
            // 
            // StreettextBox
            // 
            this.StreettextBox.Location = new System.Drawing.Point(252, 131);
            this.StreettextBox.Name = "StreettextBox";
            this.StreettextBox.Size = new System.Drawing.Size(202, 22);
            this.StreettextBox.TabIndex = 16;
            // 
            // Countrylabel
            // 
            this.Countrylabel.AutoSize = true;
            this.Countrylabel.Location = new System.Drawing.Point(74, 262);
            this.Countrylabel.Name = "Countrylabel";
            this.Countrylabel.Size = new System.Drawing.Size(61, 16);
            this.Countrylabel.TabIndex = 15;
            this.Countrylabel.Text = "Country : ";
            // 
            // Citylabel
            // 
            this.Citylabel.AutoSize = true;
            this.Citylabel.Location = new System.Drawing.Point(74, 222);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(38, 16);
            this.Citylabel.TabIndex = 14;
            this.Citylabel.Text = "City : ";
            // 
            // Ziplabel
            // 
            this.Ziplabel.AutoSize = true;
            this.Ziplabel.Location = new System.Drawing.Point(74, 176);
            this.Ziplabel.Name = "Ziplabel";
            this.Ziplabel.Size = new System.Drawing.Size(38, 16);
            this.Ziplabel.TabIndex = 13;
            this.Ziplabel.Text = "Zip  : ";
            // 
            // Streetlabel
            // 
            this.Streetlabel.AutoSize = true;
            this.Streetlabel.Location = new System.Drawing.Point(74, 131);
            this.Streetlabel.Name = "Streetlabel";
            this.Streetlabel.Size = new System.Drawing.Size(54, 16);
            this.Streetlabel.TabIndex = 12;
            this.Streetlabel.Text = "Street  : ";
            // 
            // OrganisationNamelabel
            // 
            this.OrganisationNamelabel.AutoSize = true;
            this.OrganisationNamelabel.Location = new System.Drawing.Point(74, 87);
            this.OrganisationNamelabel.Name = "OrganisationNamelabel";
            this.OrganisationNamelabel.Size = new System.Drawing.Size(132, 16);
            this.OrganisationNamelabel.TabIndex = 11;
            this.OrganisationNamelabel.Text = "Organisation Name : ";
            // 
            // OrganisationtextBox
            // 
            this.OrganisationtextBox.Location = new System.Drawing.Point(252, 81);
            this.OrganisationtextBox.Name = "OrganisationtextBox";
            this.OrganisationtextBox.Size = new System.Drawing.Size(202, 22);
            this.OrganisationtextBox.TabIndex = 10;
            // 
            // OrganisationIdtextBox
            // 
            this.OrganisationIdtextBox.Location = new System.Drawing.Point(252, 41);
            this.OrganisationIdtextBox.Name = "OrganisationIdtextBox";
            this.OrganisationIdtextBox.Size = new System.Drawing.Size(202, 22);
            this.OrganisationIdtextBox.TabIndex = 20;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(144, 340);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(151, 47);
            this.Savebutton.TabIndex = 22;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // EditOrganisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.OrganisationIdtextBox);
            this.Controls.Add(this.CountrytextBox);
            this.Controls.Add(this.CitytextBox);
            this.Controls.Add(this.ZiptextBox);
            this.Controls.Add(this.StreettextBox);
            this.Controls.Add(this.Countrylabel);
            this.Controls.Add(this.Citylabel);
            this.Controls.Add(this.Ziplabel);
            this.Controls.Add(this.Streetlabel);
            this.Controls.Add(this.OrganisationNamelabel);
            this.Controls.Add(this.OrganisationtextBox);
            this.Controls.Add(this.OrganisationIdlabel);
            this.Name = "EditOrganisation";
            this.Text = "EditOrganisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrganisationIdlabel;
        private System.Windows.Forms.TextBox CountrytextBox;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.TextBox ZiptextBox;
        private System.Windows.Forms.TextBox StreettextBox;
        private System.Windows.Forms.Label Countrylabel;
        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label Ziplabel;
        private System.Windows.Forms.Label Streetlabel;
        private System.Windows.Forms.Label OrganisationNamelabel;
        private System.Windows.Forms.TextBox OrganisationtextBox;
        private System.Windows.Forms.TextBox OrganisationIdtextBox;
        private System.Windows.Forms.Button Savebutton;
    }
}