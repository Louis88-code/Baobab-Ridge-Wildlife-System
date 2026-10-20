namespace BaobabRidgeWildlifeSystem
{
    partial class AddAnimal
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
            SuspendLayout();
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(28, 20);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(59, 15);
            lblAnimalId.TabIndex = 0;
            lblAnimalId.Text = "Animal ID";
            lblAnimalId.Click += lblAnimalId_Click;
            // 
            // txtAnimalId
            // 
            txtAnimalId.Location = new Point(142, 17);
            txtAnimalId.Name = "txtAnimalId";
            txtAnimalId.Size = new Size(143, 23);
            txtAnimalId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(28, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 46);
            txtName.Name = "txtName";
            txtName.Size = new Size(143, 23);
            txtName.TabIndex = 3;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(28, 80);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(46, 15);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(142, 77);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(143, 23);
            txtSpecies.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(28, 109);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(66, 15);
            lblAge.TabIndex = 6;
            lblAge.Text = "Age (years)";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(142, 106);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(143, 23);
            txtAge.TabIndex = 7;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(28, 135);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(87, 15);
            lblRecoveryScore.TabIndex = 8;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(142, 135);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(143, 23);
            txtRecoveryScore.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(151, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 573);
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
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
