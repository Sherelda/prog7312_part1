using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ReportIssuesForm : Form
    {
        private List<Issue> issuesList = new List<Issue>();
        private DataGridView dgvIssues;

        public ReportIssuesForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvIssues = new DataGridView
            {
                Location = new Point(13, 460),
                Size = new Size(950, 180),
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true
            };

            dgvIssues.Columns.Add("Location", "Location");
            dgvIssues.Columns.Add("Category", "Category");
            dgvIssues.Columns.Add("Description", "Description");
            dgvIssues.Columns.Add("Attachment", "Attachment");

            Controls.Add(dgvIssues);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtbDescription.Text;
            string attachment = ofdAttachment.FileName;

            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            Issue newIssue = new Issue
            {
                Location = location,
                Category = category,
                Description = description,
                Attachment = attachment
            };

            issuesList.Add(newIssue);
            dgvIssues.Rows.Add(newIssue.Location, newIssue.Category, newIssue.Description, newIssue.Attachment);

            MessageBox.Show("Issue reported successfully.");

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (ofdAttachment.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File attached: " + ofdAttachment.FileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed when the form loads
        }
    }

    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
    }
}
