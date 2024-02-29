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
            tableLayoutPanel1 = new TableLayoutPanel();
            ViewButton = new Button();
            EditButton = new Button();
            Icon = new FontAwesome.Sharp.IconPictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            Username = new Label();
            SiteName = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icon).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ViewButton, 0, 0);
            tableLayoutPanel1.Controls.Add(EditButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(520, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(200, 150);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ViewButton
            // 
            ViewButton.BackColor = Color.FromArgb(41, 128, 185);
            ViewButton.Cursor = Cursors.Hand;
            ViewButton.Dock = DockStyle.Fill;
            ViewButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ViewButton.ForeColor = Color.White;
            ViewButton.Location = new Point(3, 3);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(194, 68);
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
            EditButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(3, 77);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(194, 70);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit Password";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // Icon
            // 
            Icon.BackColor = SystemColors.Control;
            Icon.Dock = DockStyle.Left;
            Icon.ForeColor = SystemColors.ControlText;
            Icon.IconChar = FontAwesome.Sharp.IconChar.ShopLock;
            Icon.IconColor = SystemColors.ControlText;
            Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Icon.IconSize = 127;
            Icon.Location = new Point(0, 0);
            Icon.Name = "Icon";
            Icon.Size = new Size(127, 150);
            Icon.SizeMode = PictureBoxSizeMode.CenterImage;
            Icon.TabIndex = 1;
            Icon.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Username, 0, 2);
            tableLayoutPanel2.Controls.Add(SiteName, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(127, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(393, 150);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Dock = DockStyle.Fill;
            Username.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(3, 73);
            Username.Name = "Username";
            Username.Size = new Size(387, 77);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // SiteName
            // 
            SiteName.AutoSize = true;
            SiteName.Dock = DockStyle.Fill;
            SiteName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            SiteName.Location = new Point(3, 17);
            SiteName.Name = "SiteName";
            SiteName.Size = new Size(387, 56);
            SiteName.TabIndex = 3;
            SiteName.Text = "Site Name";
            // 
            // UserAccountListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(Icon);
            Controls.Add(tableLayoutPanel1);
            Name = "UserAccountListItem";
            Size = new Size(720, 150);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icon).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button ViewButton;
        private Button EditButton;
        private FontAwesome.Sharp.IconPictureBox Icon;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Username;
        private Label SiteName;
    }
}
