namespace SecureSoftware.Components
{
    partial class PasswordVaultPage
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
            MainPanel = new FlowLayoutPanel();
            ProgressPanel = new ProgressPanel();
            ActionRowLayoutPanel = new TableLayoutPanel();
            RefreshPasswordsButton = new Button();
            DeletePasswordsButton = new Button();
            CreatePasswordButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            MainPanel.SuspendLayout();
            ActionRowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(MainPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(ActionRowLayoutPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1088, 732);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Controls.Add(ProgressPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.FlowDirection = FlowDirection.TopDown;
            MainPanel.Location = new Point(0, 50);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1088, 682);
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
            ActionRowLayoutPanel.Size = new Size(1088, 50);
            ActionRowLayoutPanel.TabIndex = 4;
            // 
            // RefreshPasswordsButton
            // 
            RefreshPasswordsButton.BackColor = Color.FromArgb(41, 128, 185);
            RefreshPasswordsButton.Cursor = Cursors.Hand;
            RefreshPasswordsButton.Dock = DockStyle.Fill;
            RefreshPasswordsButton.Enabled = false;
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
            DeletePasswordsButton.Size = new Size(364, 50);
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
            // PasswordVaultPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "PasswordVaultPage";
            Size = new Size(1088, 732);
            Resize += PasswordVaultPage_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ActionRowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel MainPanel;
        private ProgressPanel ProgressPanel;
        private TableLayoutPanel ActionRowLayoutPanel;
        private Button RefreshPasswordsButton;
        private Button DeletePasswordsButton;
        private Button CreatePasswordButton;
    }
}
