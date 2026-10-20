namespace BaobabRidgeWildlifeSystem
{
    partial class UpdateAnimal
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblHeaderSub = new Label();
            lblSubtitle = new Label();
            pnlLeft = new Panel();
            txtHousing = new TextBox();
            label7 = new Label();
            txtStatus = new TextBox();
            label6 = new Label();
            txtRecoveryScore = new TextBox();
            label5 = new Label();
            txtSpecies = new TextBox();
            lblspecies = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtName = new TextBox();
            lblAnimalName = new Label();
            txtID = new TextBox();
            lblAnimalID = new Label();
            pnlRight = new Panel();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            DGV1 = new DataGridView();
            pnlButtons = new Panel();
            buttonbtnClear3 = new Button();
            btnSaveChanges = new Button();
            btnUpdate = new Button();
            dgvAnimals = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV1).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(27, 67, 50);
            pnlHeader.Controls.Add(lblHeaderSub);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1120, 84);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSub
            // 
            lblHeaderSub.AutoSize = true;
            lblHeaderSub.Font = new Font("Segoe UI", 9.5F);
            lblHeaderSub.ForeColor = Color.FromArgb(200, 224, 206);
            lblHeaderSub.Location = new Point(27, 50);
            lblHeaderSub.Name = "lblHeaderSub";
            lblHeaderSub.Size = new Size(415, 17);
            lblHeaderSub.TabIndex = 1;
            lblHeaderSub.Text = "Baobab Ridge Wildlife System  /  Select an animal, then edit its details";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSubtitle.ForeColor = Color.White;
            lblSubtitle.Location = new Point(24, 10);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(269, 32);
            lblSubtitle.TabIndex = 0;
            lblSubtitle.Text = "Update Animal Details";
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.White;
            pnlLeft.Controls.Add(txtHousing);
            pnlLeft.Controls.Add(label7);
            pnlLeft.Controls.Add(txtStatus);
            pnlLeft.Controls.Add(label6);
            pnlLeft.Controls.Add(txtRecoveryScore);
            pnlLeft.Controls.Add(label5);
            pnlLeft.Controls.Add(txtSpecies);
            pnlLeft.Controls.Add(lblspecies);
            pnlLeft.Controls.Add(txtAge);
            pnlLeft.Controls.Add(lblAge);
            pnlLeft.Controls.Add(txtName);
            pnlLeft.Controls.Add(lblAnimalName);
            pnlLeft.Controls.Add(txtID);
            pnlLeft.Controls.Add(lblAnimalID);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 84);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(340, 576);
            pnlLeft.TabIndex = 1;
            // 
            // txtHousing
            // 
            txtHousing.BackColor = Color.FromArgb(238, 242, 236);
            txtHousing.BorderStyle = BorderStyle.FixedSingle;
            txtHousing.Font = new Font("Segoe UI", 10F);
            txtHousing.Location = new Point(24, 430);
            txtHousing.Name = "txtHousing";
            txtHousing.ReadOnly = true;
            txtHousing.Size = new Size(292, 25);
            txtHousing.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(45, 65, 50);
            label7.Location = new Point(24, 408);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 12;
            label7.Text = "Housing";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(238, 242, 236);
            txtStatus.BorderStyle = BorderStyle.FixedSingle;
            txtStatus.Font = new Font("Segoe UI", 10F);
            txtStatus.Location = new Point(24, 366);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(292, 25);
            txtStatus.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(45, 65, 50);
            label6.Location = new Point(24, 344);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 10;
            label6.Text = "Status";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.BorderStyle = BorderStyle.FixedSingle;
            txtRecoveryScore.Font = new Font("Segoe UI", 10F);
            txtRecoveryScore.Location = new Point(24, 302);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(292, 25);
            txtRecoveryScore.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(45, 65, 50);
            label5.Location = new Point(24, 280);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 8;
            label5.Text = "Recovery Score (0-100)";
            // 
            // txtSpecies
            // 
            txtSpecies.BorderStyle = BorderStyle.FixedSingle;
            txtSpecies.Font = new Font("Segoe UI", 10F);
            txtSpecies.Location = new Point(24, 174);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(292, 25);
            txtSpecies.TabIndex = 5;
            // 
            // lblspecies
            // 
            lblspecies.AutoSize = true;
            lblspecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblspecies.ForeColor = Color.FromArgb(45, 65, 50);
            lblspecies.Location = new Point(24, 152);
            lblspecies.Name = "lblspecies";
            lblspecies.Size = new Size(49, 15);
            lblspecies.TabIndex = 4;
            lblspecies.Text = "Species";
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Segoe UI", 10F);
            txtAge.Location = new Point(24, 238);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(292, 25);
            txtAge.TabIndex = 7;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAge.ForeColor = Color.FromArgb(45, 65, 50);
            lblAge.Location = new Point(24, 216);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(29, 15);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(24, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 25);
            txtName.TabIndex = 3;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnimalName.ForeColor = Color.FromArgb(45, 65, 50);
            lblAnimalName.Location = new Point(24, 88);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(81, 15);
            lblAnimalName.TabIndex = 2;
            lblAnimalName.Text = "Name";
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Segoe UI", 10F);
            txtID.Location = new Point(24, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(292, 25);
            txtID.TabIndex = 1;
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnimalID.ForeColor = Color.FromArgb(45, 65, 50);
            lblAnimalID.Location = new Point(24, 24);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(61, 15);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.FromArgb(244, 246, 241);
            pnlRight.Controls.Add(DGV1);
            pnlRight.Controls.Add(pnlButtons);
            pnlRight.Controls.Add(pnlSearch);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(340, 84);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new Padding(20, 20, 20, 12);
            pnlRight.Size = new Size(780, 576);
            pnlRight.TabIndex = 2;
            // 
            // DGV1
            // 
            DGV1.AllowUserToAddRows = false;
            DGV1.AllowUserToDeleteRows = false;
            DGV1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(246, 249, 245);
            DGV1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGV1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV1.BackgroundColor = Color.White;
            DGV1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(39, 78, 59);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(39, 78, 59);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV1.ColumnHeadersHeight = 38;
            DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(40, 50, 42);
            dataGridViewCellStyle3.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 201);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(27, 67, 50);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV1.DefaultCellStyle = dataGridViewCellStyle3;
            DGV1.Dock = DockStyle.Fill;
            DGV1.EnableHeadersVisualStyles = false;
            DGV1.GridColor = Color.FromArgb(228, 233, 226);
            DGV1.Location = new Point(20, 20);
            DGV1.MultiSelect = false;
            DGV1.Name = "DGV1";
            DGV1.ReadOnly = true;
            DGV1.RowHeadersVisible = false;
            DGV1.RowHeadersWidth = 51;
            DGV1.RowTemplate.Height = 30;
            DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV1.Size = new Size(740, 484);
            DGV1.TabIndex = 0;
            DGV1.CellClick += DGV1_CellClick;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(244, 246, 241);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(20, 20);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(740, 50);
            pnlSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(45, 65, 50);
            lblSearch.Location = new Point(0, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(76, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search by ID";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(92, 11);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 25);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 241, 234);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.ForeColor = Color.FromArgb(45, 65, 50);
            btnSearch.Location = new Point(304, 8);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += SearchButton_Click;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.FromArgb(244, 246, 241);
            pnlButtons.Controls.Add(buttonbtnClear3);
            pnlButtons.Controls.Add(btnSaveChanges);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(20, 504);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(740, 60);
            pnlButtons.TabIndex = 1;
            // 
            // buttonbtnClear3
            // 
            buttonbtnClear3.BackColor = Color.White;
            buttonbtnClear3.Cursor = Cursors.Hand;
            buttonbtnClear3.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            buttonbtnClear3.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 241, 234);
            buttonbtnClear3.FlatStyle = FlatStyle.Flat;
            buttonbtnClear3.Font = new Font("Segoe UI", 10F);
            buttonbtnClear3.ForeColor = Color.FromArgb(45, 65, 50);
            buttonbtnClear3.Location = new Point(344, 14);
            buttonbtnClear3.Name = "buttonbtnClear3";
            buttonbtnClear3.Size = new Size(110, 40);
            buttonbtnClear3.TabIndex = 2;
            buttonbtnClear3.Text = "Clear";
            buttonbtnClear3.UseVisualStyleBackColor = false;
            buttonbtnClear3.Click += ClearButton_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(27, 67, 50);
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.Enabled = false;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatAppearance.MouseDownBackColor = Color.FromArgb(15, 45, 33);
            btnSaveChanges.FlatAppearance.MouseOverBackColor = Color.FromArgb(39, 90, 66);
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(172, 14);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(160, 40);
            btnSaveChanges.TabIndex = 1;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += SaveChangesButton_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(46, 125, 50);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(0, 14);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 40);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Update Animal";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += UpdateButton_Click;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvAnimals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvAnimals.DefaultCellStyle = dataGridViewCellStyle5;
            dgvAnimals.Location = new Point(0, 0);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(240, 120);
            dgvAnimals.TabIndex = 19;
            dgvAnimals.Visible = false;
            // 
            // UpdateAnimal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 241);
            ClientSize = new Size(1120, 660);
            Controls.Add(dgvAnimals);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(960, 600);
            Name = "UpdateAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife System - Update Animal";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV1).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Panel pnlLeft;
        private Panel pnlRight;
        private Panel pnlButtons;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblHeaderSub;
        private Label lblSubtitle;
        private Label lblAnimalID;
        private TextBox txtID;
        private Label lblAnimalName;
        private TextBox txtName;
        private Label lblspecies;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private Label lblAge;
        private Label label5;
        private TextBox txtRecoveryScore;
        private Button btnUpdate;
        private Button btnSaveChanges;
        private Button buttonbtnClear3;
        private Label label6;
        private Label label7;
        private TextBox txtStatus;
        private TextBox txtHousing;
        private DataGridView dgvAnimals;
        private DataGridView DGV1;
    }
}