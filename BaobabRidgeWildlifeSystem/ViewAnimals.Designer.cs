namespace BaobabRidgeWildlifeSystem
{
    partial class ViewAnimals
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
        private Button summaryButton;
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altStyle = new DataGridViewCellStyle();
            headerPanel = new Panel();
            subtitleLabel = new Label();
            titleLabel = new Label();
            actionPanel = new Panel();
            loadButton = new Button();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            summaryButton = new Button();
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
            headerPanel.BackColor = Color.FromArgb(27, 67, 50);
            headerPanel.Controls.Add(subtitleLabel);
            headerPanel.Controls.Add(titleLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1003, 90);
            headerPanel.TabIndex = 0;
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 9.5F);
            subtitleLabel.ForeColor = Color.FromArgb(200, 224, 206);
            subtitleLabel.Location = new Point(26, 56);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(248, 17);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Animal Records  /  View and Load Records";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(22, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(376, 37);
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
            actionPanel.Controls.Add(summaryButton);
            actionPanel.Controls.Add(closeButton);
            actionPanel.Dock = DockStyle.Top;
            actionPanel.Location = new Point(0, 90);
            actionPanel.Name = "actionPanel";
            actionPanel.Padding = new Padding(16, 12, 16, 12);
            actionPanel.Size = new Size(1003, 64);
            actionPanel.TabIndex = 1;
            // 
            // loadButton
            // 
            loadButton.BackColor = Color.FromArgb(46, 125, 50);
            loadButton.Cursor = Cursors.Hand;
            loadButton.FlatAppearance.BorderSize = 0;
            loadButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 94, 32);
            loadButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 142, 60);
            loadButton.FlatStyle = FlatStyle.Flat;
            loadButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            loadButton.ForeColor = Color.White;
            loadButton.Location = new Point(16, 12);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(145, 40);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load / Refresh";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += LoadButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Cursor = Cursors.Hand;
            addButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 241, 232);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 9.5F);
            addButton.ForeColor = Color.FromArgb(45, 65, 50);
            addButton.Location = new Point(172, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(110, 40);
            addButton.TabIndex = 1;
            addButton.Text = "Add Animal";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.White;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            updateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 241, 232);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 9.5F);
            updateButton.ForeColor = Color.FromArgb(45, 65, 50);
            updateButton.Location = new Point(292, 12);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(110, 40);
            updateButton.TabIndex = 2;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += UpdateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatAppearance.BorderColor = Color.FromArgb(214, 160, 154);
            deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 233);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 9.5F);
            deleteButton.ForeColor = Color.FromArgb(170, 50, 40);
            deleteButton.Location = new Point(412, 12);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(110, 40);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.BackColor = Color.White;
            summaryButton.Cursor = Cursors.Hand;
            summaryButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            summaryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 241, 232);
            summaryButton.FlatStyle = FlatStyle.Flat;
            summaryButton.Font = new Font("Segoe UI", 9.5F);
            summaryButton.ForeColor = Color.FromArgb(45, 65, 50);
            summaryButton.Location = new Point(532, 12);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(130, 40);
            summaryButton.TabIndex = 4;
            summaryButton.Text = "Summary Report";
            summaryButton.UseVisualStyleBackColor = false;
            summaryButton.Click += SummaryButton_Click;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButton.BackColor = Color.White;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderColor = Color.FromArgb(190, 200, 190);
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 241, 234);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 9.5F);
            closeButton.ForeColor = Color.FromArgb(45, 65, 50);
            closeButton.Location = new Point(887, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(100, 40);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // animalsGrid
            // 
            animalsGrid.AllowUserToAddRows = false;
            animalsGrid.AllowUserToDeleteRows = false;
            animalsGrid.AllowUserToResizeRows = false;
            altStyle.BackColor = Color.FromArgb(246, 249, 245);
            animalsGrid.AlternatingRowsDefaultCellStyle = altStyle;
            animalsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            animalsGrid.BackgroundColor = Color.White;
            animalsGrid.BorderStyle = BorderStyle.None;
            animalsGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            animalsGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(39, 78, 59);
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.Padding = new Padding(8, 0, 0, 0);
            headerStyle.SelectionBackColor = Color.FromArgb(39, 78, 59);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;
            animalsGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            animalsGrid.ColumnHeadersHeight = 38;
            animalsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(40, 50, 42);
            cellStyle.Padding = new Padding(8, 0, 0, 0);
            cellStyle.SelectionBackColor = Color.FromArgb(200, 230, 201);
            cellStyle.SelectionForeColor = Color.FromArgb(27, 67, 50);
            cellStyle.WrapMode = DataGridViewTriState.False;
            animalsGrid.DefaultCellStyle = cellStyle;
            animalsGrid.Dock = DockStyle.Fill;
            animalsGrid.EnableHeadersVisualStyles = false;
            animalsGrid.GridColor = Color.FromArgb(228, 233, 226);
            animalsGrid.Location = new Point(0, 154);
            animalsGrid.MultiSelect = false;
            animalsGrid.Name = "animalsGrid";
            animalsGrid.ReadOnly = true;
            animalsGrid.RowHeadersVisible = false;
            animalsGrid.RowHeadersWidth = 41;
            animalsGrid.RowTemplate.Height = 32;
            animalsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            animalsGrid.Size = new Size(1003, 438);
            animalsGrid.TabIndex = 2;
            // 
            // footerPanel
            // 
            footerPanel.BackColor = Color.FromArgb(244, 246, 241);
            footerPanel.Controls.Add(countLabel);
            footerPanel.Controls.Add(statusLabel);
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 592);
            footerPanel.Name = "footerPanel";
            footerPanel.Padding = new Padding(16, 6, 16, 6);
            footerPanel.Size = new Size(1003, 40);
            footerPanel.TabIndex = 3;
            // 
            // countLabel
            // 
            countLabel.Dock = DockStyle.Right;
            countLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            countLabel.ForeColor = Color.FromArgb(39, 78, 59);
            countLabel.Location = new Point(757, 6);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(230, 28);
            countLabel.TabIndex = 1;
            countLabel.Text = "0 animal records";
            countLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusLabel
            // 
            statusLabel.AutoEllipsis = true;
            statusLabel.Dock = DockStyle.Fill;
            statusLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = Color.FromArgb(75, 88, 76);
            statusLabel.Location = new Point(16, 6);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(971, 28);
            statusLabel.TabIndex = 0;
            statusLabel.Text = "Select Load / Refresh to read animals.txt.";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ViewTheAnimals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 632);
            Controls.Add(animalsGrid);
            Controls.Add(footerPanel);
            Controls.Add(actionPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(824, 514);
            Name = "ViewTheAnimals";
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