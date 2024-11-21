namespace ManagerApplication
{
    partial class AddStaffForm
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
            this.Titlelabel = new Wisej.Web.Label();
            this.FirstNamelabel = new Wisej.Web.Label();
            this.LastNamelabel = new Wisej.Web.Label();
            this.PhoneNumberlabel = new Wisej.Web.Label();
            this.Emaillabel = new Wisej.Web.Label();
            this.Organsiationlabel = new Wisej.Web.Label();
            this.TitletextBox = new Wisej.Web.TextBox();
            this.FirstNametextBox = new Wisej.Web.TextBox();
            this.LastNametextBox = new Wisej.Web.TextBox();
            this.PhoneNumbetextBox = new Wisej.Web.TextBox();
            this.EmailtextBox = new Wisej.Web.TextBox();
            this.OrganisationIdcomboBox = new Wisej.Web.ComboBox();
            this.Savebutton = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.Location = new System.Drawing.Point(53, 68);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(100, 18);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Title :";
            // 
            // FirstNamelabel
            // 
            this.FirstNamelabel.Location = new System.Drawing.Point(53, 114);
            this.FirstNamelabel.Name = "FirstNamelabel";
            this.FirstNamelabel.Size = new System.Drawing.Size(100, 18);
            this.FirstNamelabel.TabIndex = 1;
            this.FirstNamelabel.Text = "First Name :";
            // 
            // LastNamelabel
            // 
            this.LastNamelabel.Location = new System.Drawing.Point(53, 164);
            this.LastNamelabel.Name = "LastNamelabel";
            this.LastNamelabel.Size = new System.Drawing.Size(100, 18);
            this.LastNamelabel.TabIndex = 2;
            this.LastNamelabel.Text = "Last Name :";
            // 
            // PhoneNumberlabel
            // 
            this.PhoneNumberlabel.Location = new System.Drawing.Point(53, 205);
            this.PhoneNumberlabel.Name = "PhoneNumberlabel";
            this.PhoneNumberlabel.Size = new System.Drawing.Size(100, 18);
            this.PhoneNumberlabel.TabIndex = 3;
            this.PhoneNumberlabel.Text = "Phone Number :";
            // 
            // Emaillabel
            // 
            this.Emaillabel.Location = new System.Drawing.Point(53, 257);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(100, 18);
            this.Emaillabel.TabIndex = 4;
            this.Emaillabel.Text = "Email :";
            // 
            // Organsiationlabel
            // 
            this.Organsiationlabel.Location = new System.Drawing.Point(53, 303);
            this.Organsiationlabel.Name = "Organsiationlabel";
            this.Organsiationlabel.Size = new System.Drawing.Size(100, 18);
            this.Organsiationlabel.TabIndex = 5;
            this.Organsiationlabel.Text = "Organisation :";
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(248, 68);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(100, 30);
            this.TitletextBox.TabIndex = 6;
            // 
            // FirstNametextBox
            // 
            this.FirstNametextBox.Location = new System.Drawing.Point(248, 114);
            this.FirstNametextBox.Name = "FirstNametextBox";
            this.FirstNametextBox.Size = new System.Drawing.Size(173, 30);
            this.FirstNametextBox.TabIndex = 7;
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Location = new System.Drawing.Point(248, 164);
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(173, 30);
            this.LastNametextBox.TabIndex = 8;
            // 
            // PhoneNumbetextBox
            // 
            this.PhoneNumbetextBox.Location = new System.Drawing.Point(248, 205);
            this.PhoneNumbetextBox.Name = "PhoneNumbetextBox";
            this.PhoneNumbetextBox.Size = new System.Drawing.Size(173, 30);
            this.PhoneNumbetextBox.TabIndex = 9;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(248, 257);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(173, 30);
            this.EmailtextBox.TabIndex = 10;
            // 
            // OrganisationIdcomboBox
            // 
            this.OrganisationIdcomboBox.Location = new System.Drawing.Point(248, 303);
            this.OrganisationIdcomboBox.Name = "OrganisationIdcomboBox";
            this.OrganisationIdcomboBox.Size = new System.Drawing.Size(173, 30);
            this.OrganisationIdcomboBox.TabIndex = 11;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(174, 367);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(100, 37);
            this.Savebutton.TabIndex = 12;
            this.Savebutton.Text = "Save";
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 459);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.PhoneNumbetextBox);
            this.Controls.Add(this.LastNametextBox);
            this.Controls.Add(this.FirstNametextBox);
            this.Controls.Add(this.Organsiationlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.PhoneNumberlabel);
            this.Controls.Add(this.LastNamelabel);
            this.Controls.Add(this.FirstNamelabel);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.TitletextBox);
            this.Controls.Add(this.OrganisationIdcomboBox);
            this.Controls.Add(this.Savebutton);
            this.Name = "AddStaffForm";
            this.Text = "AddStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.Label Titlelabel;
        private Wisej.Web.Label FirstNamelabel;
        private Wisej.Web.Label LastNamelabel;
        private Wisej.Web.Label PhoneNumberlabel;
        private Wisej.Web.Label Emaillabel;
        private Wisej.Web.Label Organsiationlabel;
        private Wisej.Web.TextBox TitletextBox;
        private Wisej.Web.TextBox FirstNametextBox;
        private Wisej.Web.TextBox LastNametextBox;
        private Wisej.Web.TextBox PhoneNumbetextBox;
        private Wisej.Web.TextBox EmailtextBox;
        private Wisej.Web.ComboBox OrganisationIdcomboBox;
        private Wisej.Web.Button Savebutton;
    }
}