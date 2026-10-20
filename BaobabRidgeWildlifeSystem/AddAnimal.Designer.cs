namespace BaobabRidgeWildlifeSystem
{
    partial class AddAnimal
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
            lblAnimalId = new Label();
            txtAnimalId = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblRecoveryScore = new Label();
            txtRecoveryScore = new TextBox();
            btnAdd = new Button();
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
            pnlHeader.Size = new Size(380, 84);
            pnlHeader.TabIndex = 11;
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
            lblTitle.Text = "Add New Animal";
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
            lblHeaderSub.Text = "Baobab Ridge Wildlife System  /  New Record";
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnimalId.ForeColor = Color.FromArgb(45, 65, 50);
            lblAnimalId.Location = new Point(32, 106);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(61, 15);
            lblAnimalId.TabIndex = 0;
            lblAnimalId.Text = "Animal ID";
            // 
            // txtAnimalId
            // 
            txtAnimalId.BorderStyle = BorderStyle.FixedSingle;
            txtAnimalId.Font = new Font("Segoe UI", 10F);
            txtAnimalId.Location = new Point(32, 128);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(316, 25);
            txtAnimalId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 65, 50);
            lblName.Location = new Point(32, 170);
            lblName.Name = "lblName";
            lblName.Size = new Size(40, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(32, 192);
            txtName.Name = "txtName";
            txtName.Size = new Size(316, 25);
            txtName.TabIndex = 3;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSpecies.ForeColor = Color.FromArgb(45, 65, 50);
            lblSpecies.Location = new Point(32, 234);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(48, 15);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // txtSpecies
            // 
            txtSpecies.BorderStyle = BorderStyle.FixedSingle;
            txtSpecies.Font = new Font("Segoe UI", 10F);
            txtSpecies.Location = new Point(32, 256);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(316, 25);
            txtSpecies.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(45, 65, 50);
            lblAge.Location = new Point(32, 298);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(68, 15);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age (years)";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.Location = new Point(32, 320);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(316, 25);
            txtAge.TabIndex = 7;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecoveryScore.ForeColor = Color.FromArgb(45, 65, 50);
            lblRecoveryScore.Location = new Point(32, 362);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(131, 15);
            lblRecoveryScore.TabIndex = 8;
            lblRecoveryScore.Text = "Recovery Score (0-100)";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.BorderStyle = BorderStyle.FixedSingle;
            txtRecoveryScore.Font = new Font("Segoe UI", 10F);
            txtRecoveryScore.Location = new Point(32, 384);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(316, 25);
            txtRecoveryScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 125, 50);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(32, 436);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(316, 44);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddAnimal
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 241);
            ClientSize = new Size(380, 510);
            Controls.Add(btnAdd);
            Controls.Add(txtRecoveryScore);
            Controls.Add(lblRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtSpecies);
            Controls.Add(lblSpecies);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(txtAnimalId);
            Controls.Add(lblAnimalId);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife System - Add Animal";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblHeaderSub;
        private Label lblAnimalId;
        private TextBox txtAnimalId;
        private Label lblName;
        private TextBox txtName;
        private Label lblSpecies;
        private TextBox txtSpecies;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblRecoveryScore;
        private TextBox txtRecoveryScore;
        private Button btnAdd;
    }
}