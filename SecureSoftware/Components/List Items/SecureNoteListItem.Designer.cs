namespace SecureSoftware.Components
{
    partial class SecureNoteListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            NumberLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            NameLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            CreatedAtTitleLabel = new Label();
            CreatedAtLabel = new Label();
            LastEditedLabel = new Label();
            LastEditedTitleLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            ViewNoteButton = new Button();
            EditNoteButton = new Button();
            DeleteNoteButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(NumberLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(720, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Dock = DockStyle.Fill;
            NumberLabel.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLabel.Location = new Point(3, 0);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(138, 150);
            NumberLabel.TabIndex = 0;
            NumberLabel.Text = "1";
            NumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(NameLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(147, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 61.8055573F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 38.1944427F));
            tableLayoutPanel2.Size = new Size(426, 144);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(413, 89);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "This is a test note!";
            NameLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.50834F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.49165F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(CreatedAtTitleLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(CreatedAtLabel, 1, 0);
            tableLayoutPanel4.Controls.Add(LastEditedLabel, 1, 1);
            tableLayoutPanel4.Controls.Add(LastEditedTitleLabel, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 92);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(413, 49);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // CreatedAtTitleLabel
            // 
            CreatedAtTitleLabel.AutoSize = true;
            CreatedAtTitleLabel.Dock = DockStyle.Fill;
            CreatedAtTitleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreatedAtTitleLabel.Location = new Point(0, 0);
            CreatedAtTitleLabel.Margin = new Padding(0);
            CreatedAtTitleLabel.Name = "CreatedAtTitleLabel";
            CreatedAtTitleLabel.Size = new Size(146, 24);
            CreatedAtTitleLabel.TabIndex = 0;
            CreatedAtTitleLabel.Text = "Created At";
            CreatedAtTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CreatedAtLabel
            // 
            CreatedAtLabel.AutoSize = true;
            CreatedAtLabel.Dock = DockStyle.Fill;
            CreatedAtLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedAtLabel.ImageAlign = ContentAlignment.MiddleLeft;
            CreatedAtLabel.Location = new Point(149, 0);
            CreatedAtLabel.Name = "CreatedAtLabel";
            CreatedAtLabel.Size = new Size(261, 24);
            CreatedAtLabel.TabIndex = 2;
            CreatedAtLabel.Text = "Wed 13, Mar, 2023";
            CreatedAtLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LastEditedLabel
            // 
            LastEditedLabel.AutoSize = true;
            LastEditedLabel.Dock = DockStyle.Fill;
            LastEditedLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LastEditedLabel.ImageAlign = ContentAlignment.MiddleLeft;
            LastEditedLabel.Location = new Point(149, 24);
            LastEditedLabel.Name = "LastEditedLabel";
            LastEditedLabel.Size = new Size(261, 25);
            LastEditedLabel.TabIndex = 3;
            LastEditedLabel.Text = "label4";
            LastEditedLabel.TextAlign = ContentAlignment.MiddleLeft;
            LastEditedLabel.Visible = false;
            // 
            // LastEditedTitleLabel
            // 
            LastEditedTitleLabel.AutoSize = true;
            LastEditedTitleLabel.Dock = DockStyle.Fill;
            LastEditedTitleLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LastEditedTitleLabel.Location = new Point(0, 24);
            LastEditedTitleLabel.Margin = new Padding(0);
            LastEditedTitleLabel.Name = "LastEditedTitleLabel";
            LastEditedTitleLabel.Size = new Size(146, 25);
            LastEditedTitleLabel.TabIndex = 1;
            LastEditedTitleLabel.Text = "Last Edited At";
            LastEditedTitleLabel.TextAlign = ContentAlignment.MiddleRight;
            LastEditedTitleLabel.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(ViewNoteButton, 0, 0);
            tableLayoutPanel3.Controls.Add(EditNoteButton, 0, 1);
            tableLayoutPanel3.Controls.Add(DeleteNoteButton, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(579, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Size = new Size(138, 144);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // ViewNoteButton
            // 
            ViewNoteButton.BackColor = Color.FromArgb(41, 128, 185);
            ViewNoteButton.Dock = DockStyle.Fill;
            ViewNoteButton.FlatAppearance.BorderSize = 0;
            ViewNoteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            ViewNoteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            ViewNoteButton.FlatStyle = FlatStyle.Flat;
            ViewNoteButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ViewNoteButton.ForeColor = Color.White;
            ViewNoteButton.Location = new Point(0, 0);
            ViewNoteButton.Margin = new Padding(0);
            ViewNoteButton.Name = "ViewNoteButton";
            ViewNoteButton.Size = new Size(138, 48);
            ViewNoteButton.TabIndex = 0;
            ViewNoteButton.Text = "View Note";
            ViewNoteButton.UseVisualStyleBackColor = false;
            ViewNoteButton.Click += ViewNoteButton_Click;
            // 
            // EditNoteButton
            // 
            EditNoteButton.BackColor = Color.FromArgb(39, 174, 96);
            EditNoteButton.Dock = DockStyle.Fill;
            EditNoteButton.FlatAppearance.BorderSize = 0;
            EditNoteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            EditNoteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            EditNoteButton.FlatStyle = FlatStyle.Flat;
            EditNoteButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditNoteButton.ForeColor = Color.White;
            EditNoteButton.Location = new Point(0, 48);
            EditNoteButton.Margin = new Padding(0);
            EditNoteButton.Name = "EditNoteButton";
            EditNoteButton.Size = new Size(138, 48);
            EditNoteButton.TabIndex = 1;
            EditNoteButton.Text = "Edit Note";
            EditNoteButton.UseVisualStyleBackColor = false;
            EditNoteButton.Click += EditNoteButton_Click;
            // 
            // DeleteNoteButton
            // 
            DeleteNoteButton.BackColor = Color.FromArgb(192, 57, 43);
            DeleteNoteButton.Dock = DockStyle.Fill;
            DeleteNoteButton.FlatAppearance.BorderSize = 0;
            DeleteNoteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            DeleteNoteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            DeleteNoteButton.FlatStyle = FlatStyle.Flat;
            DeleteNoteButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteNoteButton.ForeColor = Color.White;
            DeleteNoteButton.Location = new Point(0, 96);
            DeleteNoteButton.Margin = new Padding(0);
            DeleteNoteButton.Name = "DeleteNoteButton";
            DeleteNoteButton.Size = new Size(138, 48);
            DeleteNoteButton.TabIndex = 2;
            DeleteNoteButton.Text = "Delete Note";
            DeleteNoteButton.UseVisualStyleBackColor = false;
            DeleteNoteButton.Click += DeleteNoteButton_Click;
            // 
            // SecureNoteListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "SecureNoteListItem";
            Size = new Size(720, 150);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label NumberLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button ViewNoteButton;
        private Button EditNoteButton;
        private Button DeleteNoteButton;
        private Label NameLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private Label CreatedAtTitleLabel;
        private Label CreatedAtLabel;
        private Label LastEditedLabel;
        private Label LastEditedTitleLabel;
    }
}
