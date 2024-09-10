using MunicipalityApp;
using System;
using System.Windows.Forms;


namespace EventManagementApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Code to run when the form loads, if needed
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            // Open the Local Events form
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Open the Report Issues form
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
        }

        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            // Open the Service Request Status form
        }

        private void btnProvideFeedback_Click(object sender, EventArgs e)
        {
            // Open the Provide Feedback form
            ProvideFeedbackForm provideFeedbackForm = new ProvideFeedbackForm();
            provideFeedbackForm.Show();
        }
    }
}
