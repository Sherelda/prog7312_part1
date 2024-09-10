using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EventManagementApp
{
    public partial class ProvideFeedbackForm : Form
    {
        private List<Feedback> feedbackList = new List<Feedback>();

        public ProvideFeedbackForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Retrieve data from the form
            string name = txtName.Text;
            string email = txtEmailID.Text;
            string comments = rtbComments.Text;
            string suggestions = rtbSuggestions.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(comments))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Store data in the list
            feedbackList.Add(new Feedback
            {
                Name = name,
                Email = email,
                Comments = comments,
                Suggestions = suggestions
            });

            // Clear fields after sending
            txtName.Clear();
            txtEmailID.Clear();
            rtbComments.Clear();
            rtbSuggestions.Clear();

            MessageBox.Show("Feedback sent successfully.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtName.Clear();
            txtEmailID.Clear();
            rtbComments.Clear();
            rtbSuggestions.Clear();
        }

        private class Feedback
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Comments { get; set; }
            public string Suggestions { get; set; }
        }
    }
}
