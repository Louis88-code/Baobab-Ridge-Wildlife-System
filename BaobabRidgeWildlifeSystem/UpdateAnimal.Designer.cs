namespace BaobabRidgeWildlifeSystem
{
    partial class UpdateAnimal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSubtitle = new Label();
            lblAnimalID = new Label();
            txtID = new TextBox();
            lblAnimalName = new Label();
            txtName = new TextBox();
            lblspecies = new Label();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            lblAge = new Label();
            label5 = new Label();
            txtRecoveryScore = new TextBox();
            btnUpdate = new Button();
            btnSaveChanges = new Button();
            buttonbtnClear3 = new Button();
            label6 = new Label();
            label7 = new Label();
            txtStatus = new TextBox();
            txtHousing = new TextBox();
            dgvAnimals = new DataGridView();
            DGV1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV1).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.Control;
            lblSubtitle.Location = new Point(555, 41);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(377, 46);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Update Animal Details";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblAnimalID.ForeColor = SystemColors.Control;
            lblAnimalID.Location = new Point(25, 142);
            lblAnimalID.Margin = new Padding(4, 0, 4, 0);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(96, 25);
            lblAnimalID.TabIndex = 2;
            lblAnimalID.Text = "AnimalID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 139);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(155, 31);
            txtID.TabIndex = 3;
            // 
            // lblAnimalName
            // 
            lblAnimalName.AutoSize = true;
            lblAnimalName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblAnimalName.ForeColor = SystemColors.Control;
            lblAnimalName.Location = new Point(15, 304);
            lblAnimalName.Margin = new Padding(4, 0, 4, 0);
            lblAnimalName.Name = "lblAnimalName";
            lblAnimalName.Size = new Size(132, 25);
            lblAnimalName.TabIndex = 4;
            lblAnimalName.Text = "Animal Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 300);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 31);
            txtName.TabIndex = 5;
            // 
            // lblspecies
            // 
            lblspecies.AutoSize = true;
            lblspecies.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblspecies.ForeColor = SystemColors.Control;
            lblspecies.Location = new Point(15, 382);
            lblspecies.Margin = new Padding(4, 0, 4, 0);
            lblspecies.Name = "lblspecies";
            lblspecies.Size = new Size(80, 25);
            lblspecies.TabIndex = 6;
            lblspecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(150, 382);
            txtSpecies.Margin = new Padding(4);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(178, 31);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(150, 215);
            txtAge.Margin = new Padding(4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(155, 31);
            txtAge.TabIndex = 8;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblAge.ForeColor = SystemColors.Control;
            lblAge.Location = new Point(25, 215);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(56, 25);
            lblAge.TabIndex = 9;
            lblAge.Text = "Age: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 495);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(215, 25);
            label5.TabIndex = 10;
            label5.Text = "Recovery Score (0-100):";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(229, 491);
            txtRecoveryScore.Margin = new Padding(4);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(155, 31);
            txtRecoveryScore.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F);
            btnUpdate.Location = new Point(1213, 292);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 48);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Animal";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += UpdateButton_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Enabled = false;
            btnSaveChanges.Font = new Font("Microsoft Sans Serif", 12F);
            btnSaveChanges.Location = new Point(1213, 370);
            btnSaveChanges.Margin = new Padding(4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(158, 48);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += SaveChangesButton_Click;
            // 
            // buttonbtnClear3
            // 
            buttonbtnClear3.Font = new Font("Microsoft Sans Serif", 12F);
            buttonbtnClear3.Location = new Point(1213, 451);
            buttonbtnClear3.Margin = new Padding(4);
            buttonbtnClear3.Name = "buttonbtnClear3";
            buttonbtnClear3.Size = new Size(145, 45);
            buttonbtnClear3.TabIndex = 14;
            buttonbtnClear3.Text = "Clear";
            buttonbtnClear3.UseVisualStyleBackColor = true;
            buttonbtnClear3.Click += ClearButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(15, 565);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 15;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(19, 639);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 25);
            label7.TabIndex = 16;
            label7.Text = "Housing:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(110, 565);
            txtStatus.Margin = new Padding(4);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(183, 31);
            txtStatus.TabIndex = 17;
            // 
            // txtHousing
            // 
            txtHousing.Location = new Point(110, 639);
            txtHousing.Margin = new Padding(4);
            txtHousing.Name = "txtHousing";
            txtHousing.ReadOnly = true;
            txtHousing.Size = new Size(168, 31);
            txtHousing.TabIndex = 18;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(-2812, -352);
            dgvAnimals.Margin = new Padding(4);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(618, 525);
            dgvAnimals.TabIndex = 19;
            // 
            // DGV1
            // 
            DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV1.Location = new Point(392, 142);
            DGV1.Margin = new Padding(4);
            DGV1.MultiSelect = false;
            DGV1.Name = "DGV1";
            DGV1.RowHeadersWidth = 51;
            DGV1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV1.Size = new Size(796, 525);
            DGV1.TabIndex = 20;
            DGV1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1409, 744);
            Controls.Add(DGV1);
            Controls.Add(dgvAnimals);
            Controls.Add(txtHousing);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonbtnClear3);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnUpdate);
            Controls.Add(txtRecoveryScore);
            Controls.Add(label5);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(lblspecies);
            Controls.Add(txtName);
            Controls.Add(lblAnimalName);
            Controls.Add(txtID);
            Controls.Add(lblAnimalID);
            Controls.Add(lblSubtitle);
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
