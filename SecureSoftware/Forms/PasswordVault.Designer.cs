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
            TopBarPanel = new Panel();
            TopBarTableLayout = new TableLayoutPanel();
            EmptyBar = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            ContextMenuButtonsTable = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            MinimizeButton = new FontAwesome.Sharp.IconButton();
            LogoutButton = new Button();
            HeaderLabel = new Label();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            NavbarPanel = new FlowLayoutPanel();
            PagePanel = new Panel();
            TopBarPanel.SuspendLayout();
            TopBarTableLayout.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ContextMenuButtonsTable.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            TopBarTableLayout.Controls.Add(EmptyBar, 0, 1);
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
            // EmptyBar
            // 
            EmptyBar.BackColor = Color.DarkOrchid;
            EmptyBar.Dock = DockStyle.Top;
            EmptyBar.Location = new Point(0, 52);
            EmptyBar.Margin = new Padding(0);
            EmptyBar.Name = "EmptyBar";
            EmptyBar.Size = new Size(1384, 78);
            EmptyBar.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(ContextMenuButtonsTable, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1378, 46);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(100, 48, 122);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(1228, 46);
            label4.TabIndex = 5;
            label4.Text = "PASSMAN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContextMenuButtonsTable
            // 
            ContextMenuButtonsTable.ColumnCount = 3;
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ContextMenuButtonsTable.Controls.Add(iconButton1, 2, 0);
            ContextMenuButtonsTable.Controls.Add(MinimizeButton, 0, 0);
            ContextMenuButtonsTable.Location = new Point(1228, 0);
            ContextMenuButtonsTable.Margin = new Padding(0);
            ContextMenuButtonsTable.Name = "ContextMenuButtonsTable";
            ContextMenuButtonsTable.RowCount = 1;
            ContextMenuButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ContextMenuButtonsTable.Size = new Size(150, 46);
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
            iconButton1.Location = new Point(103, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(44, 40);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += CloseButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(243, 156, 18);
            MinimizeButton.Dock = DockStyle.Fill;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 156, 18);
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 196, 15);
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.ForeColor = SystemColors.ControlText;
            MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            MinimizeButton.IconColor = Color.Black;
            MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MinimizeButton.Location = new Point(3, 3);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(44, 40);
            MinimizeButton.TabIndex = 5;
            MinimizeButton.UseVisualStyleBackColor = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.FromArgb(192, 57, 43);
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            LogoutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.Location = new Point(0, 666);
            LogoutButton.Margin = new Padding(0);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(297, 65);
            LogoutButton.TabIndex = 7;
            LogoutButton.Text = "LOGOUT";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Location = new Point(0, 0);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(100, 23);
            HeaderLabel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrchid;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 731);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(LogoutButton, 0, 1);
            tableLayoutPanel2.Controls.Add(NavbarPanel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Size = new Size(297, 731);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // NavbarPanel
            // 
            NavbarPanel.AutoScroll = true;
            NavbarPanel.Dock = DockStyle.Fill;
            NavbarPanel.Location = new Point(0, 0);
            NavbarPanel.Margin = new Padding(0);
            NavbarPanel.Name = "NavbarPanel";
            NavbarPanel.Size = new Size(297, 666);
            NavbarPanel.TabIndex = 0;
            // 
            // PagePanel
            // 
            PagePanel.BackColor = Color.WhiteSmoke;
            PagePanel.Dock = DockStyle.Fill;
            PagePanel.Location = new Point(297, 130);
            PagePanel.Margin = new Padding(0);
            PagePanel.Name = "PagePanel";
            PagePanel.Size = new Size(1087, 731);
            PagePanel.TabIndex = 2;
            // 
            // PasswordVault
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 861);
            Controls.Add(PagePanel);
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
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ContextMenuButtonsTable.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel TopBarPanel;
        private Panel panel2;
        private FlowLayoutPanel NavbarPanel;
        private TableLayoutPanel TopBarTableLayout;
        private Panel EmptyBar;
        private TableLayoutPanel tableLayoutPanel3;
        private Label HeaderLabel;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TableLayoutPanel ContextMenuButtonsTable;
        private Button LogoutButton;
        private TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private Panel PagePanel;
        private Label label4;
    }
}
