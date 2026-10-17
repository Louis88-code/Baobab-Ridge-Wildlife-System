namespace BaobabRidgeWildlifeSystem
{
    partial class Form1
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            label4 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(454, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Baobab Ridge Wildlife System";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Location = new Point(15, 52);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(159, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Update Animal Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 114);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "AnimalID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(120, 111);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 243);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 4;
            label2.Text = "Animal Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(129, 243);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 27);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 306);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 6;
            label3.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(88, 306);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(125, 27);
            txtSpecies.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(78, 172);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 172);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 9;
            label4.Text = "Age: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 396);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 10;
            label5.Text = "Recovery Score (0-100):";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(183, 393);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(125, 27);
            txtRecoveryScore.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(873, 199);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(126, 38);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Animal";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Enabled = false;
            btnSaveChanges.Location = new Point(873, 264);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(126, 38);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonbtnClear3
            // 
            buttonbtnClear3.Location = new Point(873, 326);
            buttonbtnClear3.Name = "buttonbtnClear3";
            buttonbtnClear3.Size = new Size(116, 36);
            buttonbtnClear3.TabIndex = 14;
            buttonbtnClear3.Text = "Clear";
            buttonbtnClear3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 452);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 15;
            label6.Text = "Status:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 511);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 16;
            label7.Text = "Housing:";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(88, 452);
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Size = new Size(147, 27);
            txtStatus.TabIndex = 17;
            // 
            // txtHousing
            // 
            txtHousing.Location = new Point(88, 511);
            txtHousing.Name = "txtHousing";
            txtHousing.ReadOnly = true;
            txtHousing.Size = new Size(135, 27);
            txtHousing.TabIndex = 18;
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToAddRows = false;
            dgvAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(334, 86);
            dgvAnimals.MultiSelect = false;
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.ReadOnly = true;
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(494, 420);
            dgvAnimals.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 554);
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
            Controls.Add(label4);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private Label label4;
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
    }
}
