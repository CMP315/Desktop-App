namespace SecureSoftware.Components
{
    partial class UserAccountListItem
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
            DeleteButton = new Button();
            ViewButton = new Button();
            EditButton = new Button();
            Username = new Label();
            SiteName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            NumberLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(192, 57, 43);
            DeleteButton.Cursor = Cursors.Hand;
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.FlatAppearance.BorderColor = Color.Black;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            DeleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.ImageAlign = ContentAlignment.BottomCenter;
            DeleteButton.Location = new Point(0, 96);
            DeleteButton.Margin = new Padding(0);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(160, 48);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete Password";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ViewButton
            // 
            ViewButton.BackColor = Color.FromArgb(41, 128, 185);
            ViewButton.Cursor = Cursors.Hand;
            ViewButton.Dock = DockStyle.Fill;
            ViewButton.FlatAppearance.BorderColor = Color.Black;
            ViewButton.FlatAppearance.BorderSize = 0;
            ViewButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            ViewButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            ViewButton.FlatStyle = FlatStyle.Flat;
            ViewButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ViewButton.ForeColor = Color.White;
            ViewButton.Location = new Point(0, 0);
            ViewButton.Margin = new Padding(0);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(160, 48);
            ViewButton.TabIndex = 0;
            ViewButton.Text = "View Password";
            ViewButton.UseVisualStyleBackColor = false;
            ViewButton.Click += ViewButton_Click;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(39, 174, 96);
            EditButton.Cursor = Cursors.Hand;
            EditButton.Dock = DockStyle.Fill;
            EditButton.FlatAppearance.BorderColor = Color.Black;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            EditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(0, 48);
            EditButton.Margin = new Padding(0);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(160, 48);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit Password";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Dock = DockStyle.Fill;
            Username.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(0, 72);
            Username.Margin = new Padding(0);
            Username.Name = "Username";
            Username.Size = new Size(405, 72);
            Username.TabIndex = 2;
            Username.Text = "Username";
            Username.TextAlign = ContentAlignment.TopCenter;
            // 
            // SiteName
            // 
            SiteName.AutoSize = true;
            SiteName.Dock = DockStyle.Fill;
            SiteName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            SiteName.Location = new Point(0, 0);
            SiteName.Margin = new Padding(0);
            SiteName.Name = "SiteName";
            SiteName.Size = new Size(405, 72);
            SiteName.TabIndex = 3;
            SiteName.Text = "Site Name";
            SiteName.TextAlign = ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.22222F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.916666F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(NumberLabel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(720, 150);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(ViewButton, 0, 0);
            tableLayoutPanel2.Controls.Add(DeleteButton, 0, 2);
            tableLayoutPanel2.Controls.Add(EditButton, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(557, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(160, 144);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(SiteName, 0, 0);
            tableLayoutPanel3.Controls.Add(Username, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(146, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(405, 144);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Dock = DockStyle.Fill;
            NumberLabel.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point);
            NumberLabel.Location = new Point(3, 0);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(137, 150);
            NumberLabel.TabIndex = 2;
            NumberLabel.Text = "1";
            NumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserAccountListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UserAccountListItem";
            Size = new Size(720, 150);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button ViewButton;
        private Button EditButton;
        private Label Username;
        private Label SiteName;
        private Button DeleteButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label NumberLabel;
    }
}
