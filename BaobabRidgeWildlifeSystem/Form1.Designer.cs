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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = SystemColors.Control;
            lblSubtitle.Location = new Point(506, 45);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(377, 46);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Update Animal Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(25, 142);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "AnimalID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(150, 139);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(155, 31);
            txtID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 304);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 4;
            label2.Text = "Animal Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 300);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 31);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(15, 382);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Species:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(25, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 25);
            label4.TabIndex = 9;
            label4.Text = "Age: ";
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
            btnUpdate.Location = new Point(1157, 292);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(158, 48);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Animal";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Enabled = false;
            btnSaveChanges.Font = new Font("Microsoft Sans Serif", 12F);
            btnSaveChanges.Location = new Point(1157, 370);
            btnSaveChanges.Margin = new Padding(4);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(158, 48);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonbtnClear3
            // 
            buttonbtnClear3.Font = new Font("Microsoft Sans Serif", 12F);
            buttonbtnClear3.Location = new Point(1157, 440);
            buttonbtnClear3.Margin = new Padding(4);
            buttonbtnClear3.Name = "buttonbtnClear3";
            buttonbtnClear3.Size = new Size(145, 45);
            buttonbtnClear3.TabIndex = 14;
            buttonbtnClear3.Text = "Clear";
            buttonbtnClear3.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 139);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(708, 525);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1409, 744);
            Controls.Add(dataGridView1);
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
            Font = new Font("Segoe UI", 10.8F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private DataGridView dataGridView1;
    }
}
