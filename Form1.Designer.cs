namespace BaobabRidgeWildlifeSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Panel headerPanel;
        private Label titleLabel;
        private Label subtitleLabel;
        private Panel actionPanel;
        private Button loadButton;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button closeButton;
        private DataGridView animalsGrid;
        private Panel footerPanel;
        private Label statusLabel;
        private Label countLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            subtitleLabel = new Label();
            titleLabel = new Label();
            actionPanel = new Panel();
            loadButton = new Button();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            closeButton = new Button();
            animalsGrid = new DataGridView();
            footerPanel = new Panel();
            countLabel = new Label();
            statusLabel = new Label();
            headerPanel.SuspendLayout();
            actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)animalsGrid).BeginInit();
            footerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.ForestGreen;
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(6);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(37, 26, 37, 21);
            headerPanel.Size = new Size(2006, 201);
            headerPanel.TabIndex = 0;
            headerPanel.Paint += headerPanel_Paint;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 9.5F);
            subtitleLabel.ForeColor = Color.FromArgb(225, 235, 226);
            subtitleLabel.Location = new Point(43, 115);
            subtitleLabel.Margin = new Padding(6, 0, 6, 0);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(495, 36);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Animal Records  /  View and Load Records";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(37, 21);
            titleLabel.Margin = new Padding(6, 0, 6, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(751, 68);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Baobab Ridge Wildlife System";
            // 
            // actionPanel
            // 
            actionPanel.BackColor = Color.FromArgb(244, 246, 241);
            actionPanel.Controls.Add(loadButton);
            actionPanel.Controls.Add(addButton);
            actionPanel.Controls.Add(updateButton);
            actionPanel.Controls.Add(deleteButton);
            actionPanel.Controls.Add(closeButton);
            actionPanel.Dock = DockStyle.Top;
            actionPanel.Location = new Point(0, 201);
            actionPanel.Margin = new Padding(6);
            actionPanel.Name = "actionPanel";
            actionPanel.Padding = new Padding(30, 26, 30, 26);
            actionPanel.Size = new Size(2006, 132);
            actionPanel.TabIndex = 1;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.ForestGreen;
            loadButton.FlatAppearance.BorderSize = 0;
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            loadButton.ForeColor = Color.White;
            loadButton.Location = new Point(33, 26);
            loadButton.Margin = new Padding(6);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(290, 77);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load / Refresh";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += LoadButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 9F);
            addButton.ForeColor = Color.FromArgb(45, 65, 50);
            addButton.Location = new Point(345, 26);
            addButton.Margin = new Padding(6);
            addButton.Name = "addButton";
            addButton.Size = new Size(208, 77);
            addButton.TabIndex = 1;
            addButton.Text = "Add Animal";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.White;
            updateButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 9F);
            updateButton.ForeColor = Color.FromArgb(45, 65, 50);
            updateButton.Location = new Point(572, 26);
            updateButton.Margin = new Padding(6);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(208, 77);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 9F);
            deleteButton.ForeColor = Color.FromArgb(145, 55, 45);
            deleteButton.Location = new Point(799, 26);
            deleteButton.Margin = new Padding(6);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(208, 77);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.White;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9F);
            closeButton.ForeColor = Color.FromArgb(45, 65, 50);
            closeButton.Location = new Point(1790, 26);
            closeButton.Margin = new Padding(6);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(182, 77);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // animalsGrid
            // 
            animalsGrid.AllowUserToAddRows = false;
            animalsGrid.AllowUserToDeleteRows = false;
            animalsGrid.AllowUserToResizeRows = false;
            animalsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            animalsGrid.BackgroundColor = Color.White;
            animalsGrid.BorderStyle = BorderStyle.None;
            animalsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            animalsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            animalsGrid.ColumnHeadersHeight = 42;
            animalsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            animalsGrid.Dock = DockStyle.Fill;
            animalsGrid.EnableHeadersVisualStyles = false;
            animalsGrid.GridColor = Color.FromArgb(228, 233, 226);
            animalsGrid.Location = new Point(0, 333);
            animalsGrid.Margin = new Padding(6);
            animalsGrid.MultiSelect = false;
            animalsGrid.Name = "animalsGrid";
            animalsGrid.ReadOnly = true;
            animalsGrid.RowHeadersVisible = false;
            animalsGrid.RowHeadersWidth = 82;
            animalsGrid.RowTemplate.Height = 34;
            animalsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            animalsGrid.Size = new Size(2006, 849);
            animalsGrid.TabIndex = 2;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(244, 246, 241);
            footerPanel.Controls.Add(countLabel);
            footerPanel.Controls.Add(statusLabel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 1182);
            footerPanel.Margin = new Padding(6);
            footerPanel.Name = "footerPanel";
            footerPanel.Padding = new Padding(30, 13, 30, 13);
            footerPanel.Size = new Size(2006, 81);
            footerPanel.TabIndex = 3;
            // 
            // countLabel
            // 
            countLabel.Dock = DockStyle.Right;
            countLabel.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            countLabel.ForeColor = Color.FromArgb(39, 78, 59);
            countLabel.Location = new Point(1515, 13);
            countLabel.Margin = new Padding(6, 0, 6, 0);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(461, 55);
            countLabel.TabIndex = 1;
            countLabel.Text = "0 animal records";
            countLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            statusLabel.AutoEllipsis = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Segoe UI", 8.5F);
            statusLabel.ForeColor = Color.FromArgb(75, 88, 76);
            statusLabel.Location = new Point(30, 13);
            statusLabel.Margin = new Padding(6, 0, 6, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(1946, 55);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Select Load / Refresh to read animals.txt.";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2006, 1263);
            Controls.Add(animalsGrid);
            Controls.Add(footerPanel);
            Controls.Add(actionPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(6);
            MinimumSize = new Size(1649, 1029);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baobab Ridge Wildlife System - View Animals";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)animalsGrid).EndInit();
            footerPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
