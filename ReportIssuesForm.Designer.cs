namespace MunicipalityApp
{
    partial class ReportIssuesForm
    {
        //components of the form 
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.OpenFileDialog ofdAttachment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;

        //method to clean up resources
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            //calling the base class 
            base.Dispose(disposing);
        }

        //method which initialize and arrange the components of the form
        private void InitializeComponent()
        {
            //form controls 
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            btnAttach = new Button();
            ofdAttachment = new OpenFileDialog();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();

            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(20, 37);
            lblLocation.Margin = new Padding(4, 0, 4, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(56, 15);
            lblLocation.TabIndex = 0;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(86, 34);
            txtLocation.Margin = new Padding(4, 3, 4, 3);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(322, 23);
            txtLocation.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 91);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "Roads", "Utilities", "Others" });
            cmbCategory.Location = new Point(86, 91);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(322, 23);
            cmbCategory.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(13, 144);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description:";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(13, 179);
            rtbDescription.Margin = new Padding(4, 3, 4, 3);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(950, 172);
            rtbDescription.TabIndex = 5;
            rtbDescription.Text = "";
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(13, 377);
            btnAttach.Margin = new Padding(4, 3, 4, 3);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(155, 60);
            btnAttach.TabIndex = 6;
            btnAttach.Text = "Attach File";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(684, 377);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(157, 60);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(329, 377);
            btnBack.Margin = new Padding(4, 3, 4, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(173, 60);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReportIssuesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(982, 650);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(btnAttach);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReportIssuesForm";
            Text = "Report Issues";
            Load += ReportIssuesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
