namespace MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.organizationGridView = new System.Windows.Forms.DataGridView();
            this.addOrganisationbutton = new System.Windows.Forms.Button();
            this.editOrganisationbutton = new System.Windows.Forms.Button();
            this.deleteOrgainsationbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.organizationGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // organizationGridView
            // 
            this.organizationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organizationGridView.Location = new System.Drawing.Point(-1, 2);
            this.organizationGridView.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.organizationGridView.Name = "organizationGridView";
            this.organizationGridView.RowHeadersWidth = 51;
            this.organizationGridView.RowTemplate.Height = 24;
            this.organizationGridView.Size = new System.Drawing.Size(789, 306);
            this.organizationGridView.TabIndex = 0;
            // 
            // addOrganisationbutton
            // 
            this.addOrganisationbutton.Location = new System.Drawing.Point(111, 347);
            this.addOrganisationbutton.Name = "addOrganisationbutton";
            this.addOrganisationbutton.Size = new System.Drawing.Size(150, 29);
            this.addOrganisationbutton.TabIndex = 1;
            this.addOrganisationbutton.Text = "Add Organisation";
            this.addOrganisationbutton.UseVisualStyleBackColor = true;
            this.addOrganisationbutton.Click += new System.EventHandler(this.addOrganisationbutton_Click);
            // 
            // editOrganisationbutton
            // 
            this.editOrganisationbutton.Location = new System.Drawing.Point(313, 347);
            this.editOrganisationbutton.Name = "editOrganisationbutton";
            this.editOrganisationbutton.Size = new System.Drawing.Size(150, 29);
            this.editOrganisationbutton.TabIndex = 2;
            this.editOrganisationbutton.Text = "Edit Organisation";
            this.editOrganisationbutton.UseVisualStyleBackColor = true;
            // 
            // deleteOrgainsationbutton
            // 
            this.deleteOrgainsationbutton.Location = new System.Drawing.Point(501, 347);
            this.deleteOrgainsationbutton.Name = "deleteOrgainsationbutton";
            this.deleteOrgainsationbutton.Size = new System.Drawing.Size(150, 29);
            this.deleteOrgainsationbutton.TabIndex = 3;
            this.deleteOrgainsationbutton.Text = "Delete Organisation";
            this.deleteOrgainsationbutton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteOrgainsationbutton);
            this.Controls.Add(this.editOrganisationbutton);
            this.Controls.Add(this.addOrganisationbutton);
            this.Controls.Add(this.organizationGridView);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.organizationGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView organizationGridView;
        private System.Windows.Forms.Button addOrganisationbutton;
        private System.Windows.Forms.Button editOrganisationbutton;
        private System.Windows.Forms.Button deleteOrgainsationbutton;
    }
}

