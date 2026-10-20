namespace BaobabRidgeWildlifeSystem
{
    partial class SummaryForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblHeaderSub = new Label();
            btnGenerate = new Button();
            btnClose = new Button();
            txtSummary = new TextBox();
            lblStatus = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(27, 67, 50);
            pnlHeader.Controls.Add(lblHeaderSub);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(560, 84);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Summary Report";
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 9F);
            lblHeaderSub.ForeColor = Color.FromArgb(200, 224, 206);
            lblHeaderSub.Location = new Point(29, 50);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(238, 15);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Baobab Ridge Wildlife System  /  Statistics";
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(46, 125, 50);
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.FlatAppearance.BorderSize = 0;
            btnGenerate.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnGenerate.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(24, 104);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(180, 40);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate Summary";
            btnGenerate.UseVisualStyleBackColor = false;
            btnGenerate.Click += GenerateButton_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 241, 234);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.ForeColor = Color.FromArgb(45, 65, 50);
            btnClose.Location = new Point(216, 104);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += CloseButton_Click;
            // 
            // txtSummary
            // 
            txtSummary.BackColor = Color.White;
            txtSummary.BorderStyle = BorderStyle.FixedSingle;
            txtSummary.Font = new Font("Consolas", 10F);
            txtSummary.Location = new Point(24, 160);
            txtSummary.Multiline = true;
            txtSummary.Name = "txtSummary";
            txtSummary.ReadOnly = true;
            txtSummary.ScrollBars = ScrollBars.Vertical;
            txtSummary.Size = new Size(496, 280);
            txtSummary.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(75, 88, 76);
            lblStatus.Location = new Point(24, 454);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(250, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Click Generate Summary to create the report.";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 241);
            ClientSize = new Size(560, 490);
            Controls.Add(lblStatus);
            Controls.Add(txtSummary);
            Controls.Add(btnClose);
            Controls.Add(btnGenerate);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SummaryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Baobab Ridge Wildlife System - Summary Report";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblHeaderSub;
        private Button btnGenerate;
        private Button btnClose;
        private TextBox txtSummary;
        private Label lblStatus;
    }
}
