namespace EventManagementApp
{
    partial class ProvideFeedbackForm
    {
        //componets for theform
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFeedbackForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Label lblSuggestions;
        private System.Windows.Forms.RichTextBox rtbSuggestions;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClear;

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
            lblFeedbackForm = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblEmailID = new Label();
            txtEmailID = new TextBox();
            lblComments = new Label();
            rtbComments = new RichTextBox();
            lblSuggestions = new Label();
            rtbSuggestions = new RichTextBox();
            btnSend = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblFeedbackForm
            // 
            lblFeedbackForm.AutoSize = true;
            lblFeedbackForm.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFeedbackForm.Location = new Point(12, 9);
            lblFeedbackForm.Name = "lblFeedbackForm";
            lblFeedbackForm.Size = new Size(148, 25);
            lblFeedbackForm.TabIndex = 0;
            lblFeedbackForm.Text = "Feedback Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(357, 23);
            txtName.TabIndex = 2;
            // 
            // lblEmailID
            // 
            lblEmailID.AutoSize = true;
            lblEmailID.Location = new Point(12, 85);
            lblEmailID.Name = "lblEmailID";
            lblEmailID.Size = new Size(53, 15);
            lblEmailID.TabIndex = 3;
            lblEmailID.Text = "Email ID:";
            // 
            // txtEmailID
            // 
            txtEmailID.Location = new Point(80, 95);
            txtEmailID.Name = "txtEmailID";
            txtEmailID.Size = new Size(357, 23);
            txtEmailID.TabIndex = 4;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Location = new Point(12, 133);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(69, 15);
            lblComments.TabIndex = 5;
            lblComments.Text = "Comments:";
            // 
            // rtbComments
            // 
            rtbComments.Location = new Point(12, 151);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(659, 99);
            rtbComments.TabIndex = 6;
            rtbComments.Text = "";
            // 
            // lblSuggestions
            // 
            lblSuggestions.AutoSize = true;
            lblSuggestions.Location = new Point(12, 267);
            lblSuggestions.Name = "lblSuggestions";
            lblSuggestions.Size = new Size(74, 15);
            lblSuggestions.TabIndex = 7;
            lblSuggestions.Text = "Suggestions:";
            // 
            // rtbSuggestions
            // 
            rtbSuggestions.Location = new Point(12, 285);
            rtbSuggestions.Name = "rtbSuggestions";
            rtbSuggestions.Size = new Size(659, 96);
            rtbSuggestions.TabIndex = 8;
            rtbSuggestions.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 400);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(154, 56);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(505, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(166, 56);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProvideFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(714, 477);
            Controls.Add(btnClear);
            Controls.Add(btnSend);
            Controls.Add(rtbSuggestions);
            Controls.Add(lblSuggestions);
            Controls.Add(rtbComments);
            Controls.Add(lblComments);
            Controls.Add(txtEmailID);
            Controls.Add(lblEmailID);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblFeedbackForm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "ProvideFeedbackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Provide Feedback";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
