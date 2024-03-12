namespace SecureSoftware
{
    partial class PasswordVault
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordVault));
            TopBarPanel = new Panel();
            TopBarTableLayout = new TableLayoutPanel();
            panel3 = new Panel();
            GlobalEmail = new Label();
            GlobalUsername = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            HeaderLabel = new Label();
            ContextMenuButtonsTable = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            sideBarMenuItem1 = new Components.SideBarMenuItem();
            sideBarMenuItem2 = new Components.SideBarMenuItem();
            sideBarMenuItem3 = new Components.SideBarMenuItem();
            MainPanel = new FlowLayoutPanel();
            ProgressPanel = new Components.ProgressPanel();
            sideBarMenuItem4 = new Components.SideBarMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            ActionRowLayoutPanel = new TableLayoutPanel();
            RefreshPasswordsButton = new Button();
            DeletePasswordsButton = new Button();
            CreatePasswordButton = new Button();
            TopBarPanel.SuspendLayout();
            TopBarTableLayout.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ContextMenuButtonsTable.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ActionRowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopBarPanel
            // 
            TopBarPanel.BackColor = Color.DarkOrchid;
            TopBarPanel.Controls.Add(TopBarTableLayout);
            TopBarPanel.Dock = DockStyle.Top;
            TopBarPanel.Location = new Point(0, 0);
            TopBarPanel.Margin = new Padding(0);
            TopBarPanel.Name = "TopBarPanel";
            TopBarPanel.Size = new Size(1384, 130);
            TopBarPanel.TabIndex = 0;
            // 
            // TopBarTableLayout
            // 
            TopBarTableLayout.BackColor = Color.FromArgb(100, 48, 122);
            TopBarTableLayout.ColumnCount = 1;
            TopBarTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TopBarTableLayout.Controls.Add(panel3, 0, 1);
            TopBarTableLayout.Controls.Add(tableLayoutPanel3, 0, 0);
            TopBarTableLayout.Dock = DockStyle.Fill;
            TopBarTableLayout.Location = new Point(0, 0);
            TopBarTableLayout.Margin = new Padding(0);
            TopBarTableLayout.Name = "TopBarTableLayout";
            TopBarTableLayout.RowCount = 2;
            TopBarTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40.6896553F));
            TopBarTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 59.3103447F));
            TopBarTableLayout.Size = new Size(1384, 130);
            TopBarTableLayout.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOrchid;
            panel3.Controls.Add(GlobalEmail);
            panel3.Controls.Add(GlobalUsername);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 52);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1384, 78);
            panel3.TabIndex = 1;
            // 
            // GlobalEmail
            // 
            GlobalEmail.AutoSize = true;
            GlobalEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalEmail.ForeColor = SystemColors.Control;
            GlobalEmail.Location = new Point(86, 39);
            GlobalEmail.Name = "GlobalEmail";
            GlobalEmail.Size = new Size(190, 30);
            GlobalEmail.TabIndex = 6;
            GlobalEmail.Text = "example@test.com";
            // 
            // GlobalUsername
            // 
            GlobalUsername.AutoSize = true;
            GlobalUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalUsername.ForeColor = SystemColors.Control;
            GlobalUsername.Location = new Point(86, 9);
            GlobalUsername.Name = "GlobalUsername";
            GlobalUsername.Size = new Size(96, 30);
            GlobalUsername.TabIndex = 5;
            GlobalUsername.Text = "Test User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel3.Controls.Add(HeaderLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(ContextMenuButtonsTable, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1378, 46);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.BackColor = Color.FromArgb(100, 48, 122);
            HeaderLabel.Dock = DockStyle.Fill;
            HeaderLabel.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            HeaderLabel.ForeColor = Color.White;
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Margin = new Padding(0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(1278, 46);
            HeaderLabel.TabIndex = 3;
            HeaderLabel.Text = "PASSMAN";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            HeaderLabel.MouseDown += HeaderLabel_MouseDown;
            HeaderLabel.MouseMove += HeaderLabel_MouseMove;
            // 
            // ContextMenuButtonsTable
            // 
            ContextMenuButtonsTable.ColumnCount = 2;
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ContextMenuButtonsTable.Controls.Add(iconButton1, 1, 0);
            ContextMenuButtonsTable.Location = new Point(1278, 0);
            ContextMenuButtonsTable.Margin = new Padding(0);
            ContextMenuButtonsTable.Name = "ContextMenuButtonsTable";
            ContextMenuButtonsTable.RowCount = 1;
            ContextMenuButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ContextMenuButtonsTable.Size = new Size(100, 46);
            ContextMenuButtonsTable.TabIndex = 4;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(192, 57, 43);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(50, 0);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(50, 46);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrchid;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 731);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(sideBarMenuItem1);
            flowLayoutPanel2.Controls.Add(sideBarMenuItem2);
            flowLayoutPanel2.Controls.Add(sideBarMenuItem3);
            flowLayoutPanel2.Dock = DockStyle.Left;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(297, 731);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // sideBarMenuItem1
            // 
            sideBarMenuItem1.BackColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem1.BackgroundColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem1.BackgroundColorHover = Color.FromArgb(155, 89, 182);
            sideBarMenuItem1.BackgroundImageLayout = ImageLayout.None;
            sideBarMenuItem1.Cursor = Cursors.Hand;
            sideBarMenuItem1.Icon = FontAwesome.Sharp.IconChar.Vault;
            sideBarMenuItem1.Label = "Password Vault";
            sideBarMenuItem1.Location = new Point(0, 0);
            sideBarMenuItem1.Margin = new Padding(0);
            sideBarMenuItem1.Name = "sideBarMenuItem1";
            sideBarMenuItem1.Size = new Size(297, 58);
            sideBarMenuItem1.TabIndex = 0;
            // 
            // sideBarMenuItem2
            // 
            sideBarMenuItem2.BackColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem2.BackgroundColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem2.BackgroundColorHover = Color.FromArgb(155, 89, 182);
            sideBarMenuItem2.Cursor = Cursors.Hand;
            sideBarMenuItem2.Icon = FontAwesome.Sharp.IconChar.Newspaper;
            sideBarMenuItem2.Label = "Secure Notes";
            sideBarMenuItem2.Location = new Point(0, 58);
            sideBarMenuItem2.Margin = new Padding(0);
            sideBarMenuItem2.Name = "sideBarMenuItem2";
            sideBarMenuItem2.Size = new Size(297, 58);
            sideBarMenuItem2.TabIndex = 1;
            // 
            // sideBarMenuItem3
            // 
            sideBarMenuItem3.BackColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem3.BackgroundColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem3.BackgroundColorHover = Color.FromArgb(155, 89, 182);
            sideBarMenuItem3.Cursor = Cursors.Hand;
            sideBarMenuItem3.Icon = FontAwesome.Sharp.IconChar.Gear;
            sideBarMenuItem3.Label = "Generate Password";
            sideBarMenuItem3.Location = new Point(0, 116);
            sideBarMenuItem3.Margin = new Padding(0);
            sideBarMenuItem3.Name = "sideBarMenuItem3";
            sideBarMenuItem3.Size = new Size(297, 58);
            sideBarMenuItem3.TabIndex = 2;
            sideBarMenuItem3.Load += sideBarMenuItem3_Load;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Controls.Add(ProgressPanel);
            MainPanel.Controls.Add(sideBarMenuItem4);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.FlowDirection = FlowDirection.TopDown;
            MainPanel.Location = new Point(0, 50);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1087, 681);
            MainPanel.TabIndex = 3;
            MainPanel.WrapContents = false;
            // 
            // ProgressPanel
            // 
            ProgressPanel.Location = new Point(3, 3);
            ProgressPanel.Name = "ProgressPanel";
            ProgressPanel.Size = new Size(571, 69);
            ProgressPanel.TabIndex = 0;
            // 
            // sideBarMenuItem4
            // 
            sideBarMenuItem4.BackgroundColor = Color.Empty;
            sideBarMenuItem4.BackgroundColorHover = Color.Empty;
            sideBarMenuItem4.Icon = FontAwesome.Sharp.IconChar.None;
            sideBarMenuItem4.Label = null;
            sideBarMenuItem4.Location = new Point(0, 75);
            sideBarMenuItem4.Margin = new Padding(0);
            sideBarMenuItem4.Name = "sideBarMenuItem4";
            sideBarMenuItem4.Size = new Size(297, 58);
            sideBarMenuItem4.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(MainPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(ActionRowLayoutPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(297, 130);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1087, 731);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // ActionRowLayoutPanel
            // 
            ActionRowLayoutPanel.BackColor = Color.FromArgb(100, 48, 122);
            ActionRowLayoutPanel.ColumnCount = 3;
            ActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ActionRowLayoutPanel.Controls.Add(RefreshPasswordsButton, 0, 0);
            ActionRowLayoutPanel.Controls.Add(DeletePasswordsButton, 1, 0);
            ActionRowLayoutPanel.Controls.Add(CreatePasswordButton, 0, 0);
            ActionRowLayoutPanel.Dock = DockStyle.Fill;
            ActionRowLayoutPanel.ForeColor = Color.Transparent;
            ActionRowLayoutPanel.Location = new Point(0, 0);
            ActionRowLayoutPanel.Margin = new Padding(0);
            ActionRowLayoutPanel.Name = "ActionRowLayoutPanel";
            ActionRowLayoutPanel.RowCount = 1;
            ActionRowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ActionRowLayoutPanel.Size = new Size(1087, 50);
            ActionRowLayoutPanel.TabIndex = 4;
            // 
            // RefreshPasswordsButton
            // 
            RefreshPasswordsButton.BackColor = Color.FromArgb(41, 128, 185);
            RefreshPasswordsButton.Cursor = Cursors.Hand;
            RefreshPasswordsButton.Dock = DockStyle.Fill;
            RefreshPasswordsButton.FlatAppearance.BorderSize = 0;
            RefreshPasswordsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            RefreshPasswordsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            RefreshPasswordsButton.FlatStyle = FlatStyle.Flat;
            RefreshPasswordsButton.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshPasswordsButton.ForeColor = Color.White;
            RefreshPasswordsButton.Location = new Point(362, 0);
            RefreshPasswordsButton.Margin = new Padding(0);
            RefreshPasswordsButton.Name = "RefreshPasswordsButton";
            RefreshPasswordsButton.Size = new Size(362, 50);
            RefreshPasswordsButton.TabIndex = 3;
            RefreshPasswordsButton.Text = "Refresh Passwords";
            RefreshPasswordsButton.UseVisualStyleBackColor = false;
            RefreshPasswordsButton.Click += RefreshPasswordsButton_Click;
            // 
            // DeletePasswordsButton
            // 
            DeletePasswordsButton.BackColor = Color.FromArgb(192, 57, 43);
            DeletePasswordsButton.Cursor = Cursors.Hand;
            DeletePasswordsButton.Dock = DockStyle.Fill;
            DeletePasswordsButton.Enabled = false;
            DeletePasswordsButton.FlatAppearance.BorderSize = 0;
            DeletePasswordsButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            DeletePasswordsButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            DeletePasswordsButton.FlatStyle = FlatStyle.Flat;
            DeletePasswordsButton.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeletePasswordsButton.ForeColor = Color.White;
            DeletePasswordsButton.Location = new Point(724, 0);
            DeletePasswordsButton.Margin = new Padding(0);
            DeletePasswordsButton.Name = "DeletePasswordsButton";
            DeletePasswordsButton.Size = new Size(363, 50);
            DeletePasswordsButton.TabIndex = 2;
            DeletePasswordsButton.Text = "Delete Passwords";
            DeletePasswordsButton.UseVisualStyleBackColor = false;
            DeletePasswordsButton.Click += DeletePasswordsButton_Click;
            // 
            // CreatePasswordButton
            // 
            CreatePasswordButton.BackColor = Color.FromArgb(39, 174, 96);
            CreatePasswordButton.Cursor = Cursors.Hand;
            CreatePasswordButton.Dock = DockStyle.Fill;
            CreatePasswordButton.Enabled = false;
            CreatePasswordButton.FlatAppearance.BorderSize = 0;
            CreatePasswordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            CreatePasswordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            CreatePasswordButton.FlatStyle = FlatStyle.Flat;
            CreatePasswordButton.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            CreatePasswordButton.ForeColor = Color.White;
            CreatePasswordButton.Location = new Point(0, 0);
            CreatePasswordButton.Margin = new Padding(0);
            CreatePasswordButton.Name = "CreatePasswordButton";
            CreatePasswordButton.Size = new Size(362, 50);
            CreatePasswordButton.TabIndex = 1;
            CreatePasswordButton.Text = "Create Password";
            CreatePasswordButton.UseVisualStyleBackColor = false;
            CreatePasswordButton.Click += CreatePasswordButton_Click;
            // 
            // PasswordVault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 861);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(TopBarPanel);
            MinimumSize = new Size(750, 400);
            Name = "PasswordVault";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Vault";
            Load += PasswordVault_Load;
            Resize += PasswordVault_Resize;
            TopBarPanel.ResumeLayout(false);
            TopBarTableLayout.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ContextMenuButtonsTable.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ActionRowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel TopBarPanel;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Components.SideBarMenuItem sideBarMenuItem1;
        private Components.SideBarMenuItem sideBarMenuItem2;
        private Components.SideBarMenuItem sideBarMenuItem3;
        private FlowLayoutPanel MainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel ActionRowLayoutPanel;
        private Button CreatePasswordButton;
        private Button DeletePasswordsButton;
        private Components.ProgressPanel ProgressPanel;
        private TableLayoutPanel TopBarTableLayout;
        private Panel panel3;
        private Label GlobalUsername;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label HeaderLabel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label GlobalEmail;
        private TableLayoutPanel ContextMenuButtonsTable;
        private Button RefreshPasswordsButton;
        private Components.SideBarMenuItem sideBarMenuItem4;
    }
}
