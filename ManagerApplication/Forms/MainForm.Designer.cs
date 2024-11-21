namespace ManagerApplication
{
    partial class MainForm
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
            this.addOrganisationbutton = new Wisej.Web.Button();
            this.editOrgansitonbutton = new Wisej.Web.Button();
            this.addStaffbutton = new Wisej.Web.Button();
            this.editStaffbutton = new Wisej.Web.Button();
            this.organisationdataGridView = new Wisej.Web.DataGridView();
            this.staffdataGridView = new Wisej.Web.DataGridView();
            this.deleteOrganisaitonbutton = new Wisej.Web.Button();
            this.deleteStaffbutton = new Wisej.Web.Button();
            ((System.ComponentModel.ISupportInitialize)(this.organisationdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrganisationbutton
            // 
            this.addOrganisationbutton.Location = new System.Drawing.Point(319, 212);
            this.addOrganisationbutton.Name = "addOrganisationbutton";
            this.addOrganisationbutton.Size = new System.Drawing.Size(100, 37);
            this.addOrganisationbutton.TabIndex = 0;
            this.addOrganisationbutton.Text = "Add Organisation";
            this.addOrganisationbutton.Click += new System.EventHandler(this.addOrganisationbutton_Click);
            // 
            // editOrgansitonbutton
            // 
            this.editOrgansitonbutton.Location = new System.Drawing.Point(507, 213);
            this.editOrgansitonbutton.Name = "editOrgansitonbutton";
            this.editOrgansitonbutton.Size = new System.Drawing.Size(100, 36);
            this.editOrgansitonbutton.TabIndex = 1;
            this.editOrgansitonbutton.Text = "Edit Organisation";
            this.editOrgansitonbutton.Click += new System.EventHandler(this.editOrgansitonbutton_Click);
            // 
            // addStaffbutton
            // 
            this.addStaffbutton.Location = new System.Drawing.Point(319, 472);
            this.addStaffbutton.Name = "addStaffbutton";
            this.addStaffbutton.Size = new System.Drawing.Size(100, 37);
            this.addStaffbutton.TabIndex = 2;
            this.addStaffbutton.Text = "Add Staff";
            this.addStaffbutton.Click += new System.EventHandler(this.addStaffbutton_Click);
            // 
            // editStaffbutton
            // 
            this.editStaffbutton.Location = new System.Drawing.Point(507, 472);
            this.editStaffbutton.Name = "editStaffbutton";
            this.editStaffbutton.Size = new System.Drawing.Size(100, 37);
            this.editStaffbutton.TabIndex = 3;
            this.editStaffbutton.Text = "Edit Staff";
            this.editStaffbutton.Click += new System.EventHandler(this.editStaffbutton_Click);
            // 
            // organisationdataGridView
            // 
            this.organisationdataGridView.Location = new System.Drawing.Point(256, 18);
            this.organisationdataGridView.Name = "organisationdataGridView";
            this.organisationdataGridView.Size = new System.Drawing.Size(644, 162);
            this.organisationdataGridView.TabIndex = 4;
            // 
            // staffdataGridView
            // 
            this.staffdataGridView.Location = new System.Drawing.Point(256, 279);
            this.staffdataGridView.Name = "staffdataGridView";
            this.staffdataGridView.Size = new System.Drawing.Size(644, 162);
            this.staffdataGridView.TabIndex = 5;
            // 
            // deleteOrganisaitonbutton
            // 
            this.deleteOrganisaitonbutton.Location = new System.Drawing.Point(697, 212);
            this.deleteOrganisaitonbutton.Name = "deleteOrganisaitonbutton";
            this.deleteOrganisaitonbutton.Size = new System.Drawing.Size(100, 37);
            this.deleteOrganisaitonbutton.TabIndex = 6;
            this.deleteOrganisaitonbutton.Text = "Delete Organisation";
            this.deleteOrganisaitonbutton.Click += new System.EventHandler(this.deleteOrganisaitonbutton_Click);
            // 
            // deleteStaffbutton
            // 
            this.deleteStaffbutton.Location = new System.Drawing.Point(697, 472);
            this.deleteStaffbutton.Name = "deleteStaffbutton";
            this.deleteStaffbutton.Size = new System.Drawing.Size(100, 37);
            this.deleteStaffbutton.TabIndex = 7;
            this.deleteStaffbutton.Text = "Delete Staff";
            this.deleteStaffbutton.Click += new System.EventHandler(this.deleteStaffbutton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 599);
            this.Controls.Add(this.deleteStaffbutton);
            this.Controls.Add(this.staffdataGridView);
            this.Controls.Add(this.editStaffbutton);
            this.Controls.Add(this.addStaffbutton);
            this.Controls.Add(this.editOrgansitonbutton);
            this.Controls.Add(this.addOrganisationbutton);
            this.Controls.Add(this.organisationdataGridView);
            this.Controls.Add(this.deleteOrganisaitonbutton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.organisationdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button addOrganisationbutton;
        private Wisej.Web.Button editOrgansitonbutton;
        private Wisej.Web.Button addStaffbutton;
        private Wisej.Web.Button editStaffbutton;
        private Wisej.Web.DataGridView organisationdataGridView;
        private Wisej.Web.DataGridView staffdataGridView;
        private Wisej.Web.Button deleteOrganisaitonbutton;
        private Wisej.Web.Button deleteStaffbutton;
    }
}