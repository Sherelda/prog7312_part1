namespace EventManagementApp
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLocalEvents;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Button btnProvideFeedback; // New button
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            btnLocalEvents = new Button();
            btnReportIssues = new Button();
            btnServiceRequestStatus = new Button();
            btnProvideFeedback = new Button(); // New button
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLocalEvents
            // 
            btnLocalEvents.BackColor = Color.FromArgb(0, 122, 204);
            btnLocalEvents.FlatAppearance.BorderSize = 0;
            btnLocalEvents.FlatStyle = FlatStyle.Flat;
            btnLocalEvents.Font = new Font("Segoe UI", 10F);
            btnLocalEvents.ForeColor = Color.White;
            btnLocalEvents.Location = new Point(126, 116);
            btnLocalEvents.Name = "btnLocalEvents";
            btnLocalEvents.Size = new Size(244, 61);
            btnLocalEvents.TabIndex = 0;
            btnLocalEvents.Text = "Local Events and Announcements";
            btnLocalEvents.UseVisualStyleBackColor = false;
            btnLocalEvents.Click += btnLocalEvents_Click;
            // 
            // btnReportIssues
            // 
            btnReportIssues.BackColor = Color.FromArgb(255, 159, 67);
            btnReportIssues.FlatAppearance.BorderSize = 0;
            btnReportIssues.FlatStyle = FlatStyle.Flat;
            btnReportIssues.Font = new Font("Segoe UI", 10F);
            btnReportIssues.ForeColor = Color.White;
            btnReportIssues.Location = new Point(126, 222);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(244, 55);
            btnReportIssues.TabIndex = 1;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = false;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // btnServiceRequestStatus
            // 
            btnServiceRequestStatus.BackColor = Color.FromArgb(76, 175, 80);
            btnServiceRequestStatus.FlatAppearance.BorderSize = 0;
            btnServiceRequestStatus.FlatStyle = FlatStyle.Flat;
            btnServiceRequestStatus.Font = new Font("Segoe UI", 10F);
            btnServiceRequestStatus.ForeColor = Color.White;
            btnServiceRequestStatus.Location = new Point(126, 316);
            btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            btnServiceRequestStatus.Size = new Size(244, 57);
            btnServiceRequestStatus.TabIndex = 2;
            btnServiceRequestStatus.Text = "Service Request Status";
            btnServiceRequestStatus.UseVisualStyleBackColor = false;
            btnServiceRequestStatus.Click += btnServiceRequestStatus_Click;
            // 
            // btnProvideFeedback
            // 
            btnProvideFeedback.BackColor = Color.FromArgb(233, 30, 99); // Example color
            btnProvideFeedback.FlatAppearance.BorderSize = 0;
            btnProvideFeedback.FlatStyle = FlatStyle.Flat;
            btnProvideFeedback.Font = new Font("Segoe UI", 10F);
            btnProvideFeedback.ForeColor = Color.White;
            btnProvideFeedback.Location = new Point(126, 402);
            btnProvideFeedback.Name = "btnProvideFeedback";
            btnProvideFeedback.Size = new Size(244, 55);
            btnProvideFeedback.TabIndex = 3;
            btnProvideFeedback.Text = "Provide Feedback";
            btnProvideFeedback.UseVisualStyleBackColor = false;
            btnProvideFeedback.Click += btnProvideFeedback_Click; // Event handler
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 40);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 4;
            label1.Text = "Welcome Users";
            // 
            // MainMenu
            // 
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(499, 470); // Increased size to fit new button
            Controls.Add(label1);
            Controls.Add(btnProvideFeedback); // Add new button to controls
            Controls.Add(btnServiceRequestStatus);
            Controls.Add(btnReportIssues);
            Controls.Add(btnLocalEvents);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Main Menu";
            Load += MainMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
