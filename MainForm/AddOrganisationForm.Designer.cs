namespace MainForm
{
    partial class AddOrgainsationForm
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
            this.OrganisationtextBox = new System.Windows.Forms.TextBox();
            this.OrganisationNamelabel = new System.Windows.Forms.Label();
            this.Streetlabel = new System.Windows.Forms.Label();
            this.Ziplabel = new System.Windows.Forms.Label();
            this.Citylabel = new System.Windows.Forms.Label();
            this.Countrylabel = new System.Windows.Forms.Label();
            this.StreettextBox = new System.Windows.Forms.TextBox();
            this.ZiptextBox = new System.Windows.Forms.TextBox();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrganisationtextBox
            // 
            this.OrganisationtextBox.Location = new System.Drawing.Point(217, 52);
            this.OrganisationtextBox.Name = "OrganisationtextBox";
            this.OrganisationtextBox.Size = new System.Drawing.Size(202, 22);
            this.OrganisationtextBox.TabIndex = 0;
            // 
            // OrganisationNamelabel
            // 
            this.OrganisationNamelabel.AutoSize = true;
            this.OrganisationNamelabel.Location = new System.Drawing.Point(39, 58);
            this.OrganisationNamelabel.Name = "OrganisationNamelabel";
            this.OrganisationNamelabel.Size = new System.Drawing.Size(165, 20);
            this.OrganisationNamelabel.TabIndex = 1;
            this.OrganisationNamelabel.Text = "Organisation Name : ";
            // 
            // Streetlabel
            // 
            this.Streetlabel.AutoSize = true;
            this.Streetlabel.Location = new System.Drawing.Point(39, 102);
            this.Streetlabel.Name = "Streetlabel";
            this.Streetlabel.Size = new System.Drawing.Size(68, 20);
            this.Streetlabel.TabIndex = 2;
            this.Streetlabel.Text = "Street  : ";
            // 
            // Ziplabel
            // 
            this.Ziplabel.AutoSize = true;
            this.Ziplabel.Location = new System.Drawing.Point(39, 147);
            this.Ziplabel.Name = "Ziplabel";
            this.Ziplabel.Size = new System.Drawing.Size(48, 20);
            this.Ziplabel.TabIndex = 3;
            this.Ziplabel.Text = "Zip  : ";
            // 
            // Citylabel
            // 
            this.Citylabel.AutoSize = true;
            this.Citylabel.Location = new System.Drawing.Point(39, 193);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(48, 20);
            this.Citylabel.TabIndex = 4;
            this.Citylabel.Text = "City : ";
            // 
            // Countrylabel
            // 
            this.Countrylabel.AutoSize = true;
            this.Countrylabel.Location = new System.Drawing.Point(39, 233);
            this.Countrylabel.Name = "Countrylabel";
            this.Countrylabel.Size = new System.Drawing.Size(76, 20);
            this.Countrylabel.TabIndex = 5;
            this.Countrylabel.Text = "Country : ";
            // 
            // StreettextBox
            // 
            this.StreettextBox.Location = new System.Drawing.Point(217, 102);
            this.StreettextBox.Name = "StreettextBox";
            this.StreettextBox.Size = new System.Drawing.Size(202, 22);
            this.StreettextBox.TabIndex = 6;
            // 
            // ZiptextBox
            // 
            this.ZiptextBox.Location = new System.Drawing.Point(217, 147);
            this.ZiptextBox.Name = "ZiptextBox";
            this.ZiptextBox.Size = new System.Drawing.Size(202, 22);
            this.ZiptextBox.TabIndex = 7;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(217, 193);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(202, 22);
            this.CitytextBox.TabIndex = 8;
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(217, 233);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(202, 22);
            this.CountrytextBox.TabIndex = 9;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(129, 286);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 10;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // AddOrgainsationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Savebutton);
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
            this.Name = "AddOrgainsationForm";
            this.Text = "Add Organisation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrganisationtextBox;
        private System.Windows.Forms.Label OrganisationNamelabel;
        private System.Windows.Forms.Label Streetlabel;
        private System.Windows.Forms.Label Ziplabel;
        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label Countrylabel;
        private System.Windows.Forms.TextBox StreettextBox;
        private System.Windows.Forms.TextBox ZiptextBox;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.TextBox CountrytextBox;
        private System.Windows.Forms.Button Savebutton;
    }
}