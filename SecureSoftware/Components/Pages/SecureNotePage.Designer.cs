namespace SecureSoftware.Components
{
    partial class SecureNotePage
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
            ActionRowLayoutPanel = new TableLayoutPanel();
            RefreshPasswordsButton = new Button();
            DeletePasswordsButton = new Button();
            panel1 = new Panel();
            SecureActionRowLayoutPanel = new TableLayoutPanel();
            RefreshNotesButton = new Button();
            DeleteNotesButton = new Button();
            CreatePasswordButton = new Button();
            MainPanel = new FlowLayoutPanel();
            ProgressPanel = new ProgressPanel();
            ActionRowLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            SecureActionRowLayoutPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ActionRowLayoutPanel
            // 
            ActionRowLayoutPanel.BackColor = Color.FromArgb(100, 48, 122);
            ActionRowLayoutPanel.ColumnCount = 3;
            ActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ActionRowLayoutPanel.Controls.Add(RefreshPasswordsButton, 0, 0);
            ActionRowLayoutPanel.Location = new Point(0, 0);
            ActionRowLayoutPanel.Name = "ActionRowLayoutPanel";
            ActionRowLayoutPanel.RowCount = 1;
            ActionRowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ActionRowLayoutPanel.Size = new Size(200, 100);
            ActionRowLayoutPanel.TabIndex = 0;
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
            RefreshPasswordsButton.Location = new Point(0, 0);
            RefreshPasswordsButton.Margin = new Padding(0);
            RefreshPasswordsButton.Name = "RefreshPasswordsButton";
            RefreshPasswordsButton.Size = new Size(66, 100);
            RefreshPasswordsButton.TabIndex = 3;
            RefreshPasswordsButton.Text = "Refresh Passwords";
            RefreshPasswordsButton.UseVisualStyleBackColor = false;
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
            DeletePasswordsButton.Location = new Point(66, 0);
            DeletePasswordsButton.Margin = new Padding(0);
            DeletePasswordsButton.Name = "DeletePasswordsButton";
            DeletePasswordsButton.Size = new Size(66, 100);
            DeletePasswordsButton.TabIndex = 2;
            DeletePasswordsButton.Text = "Delete Passwords";
            DeletePasswordsButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(SecureActionRowLayoutPanel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 50);
            panel1.TabIndex = 0;
            // 
            // SecureActionRowLayoutPanel
            // 
            SecureActionRowLayoutPanel.BackColor = Color.FromArgb(100, 48, 122);
            SecureActionRowLayoutPanel.ColumnCount = 3;
            SecureActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            SecureActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            SecureActionRowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            SecureActionRowLayoutPanel.Controls.Add(RefreshNotesButton, 0, 0);
            SecureActionRowLayoutPanel.Controls.Add(DeleteNotesButton, 1, 0);
            SecureActionRowLayoutPanel.Controls.Add(CreatePasswordButton, 0, 0);
            SecureActionRowLayoutPanel.Dock = DockStyle.Fill;
            SecureActionRowLayoutPanel.ForeColor = Color.Transparent;
            SecureActionRowLayoutPanel.Location = new Point(0, 0);
            SecureActionRowLayoutPanel.Margin = new Padding(0);
            SecureActionRowLayoutPanel.Name = "SecureActionRowLayoutPanel";
            SecureActionRowLayoutPanel.RowCount = 1;
            SecureActionRowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            SecureActionRowLayoutPanel.Size = new Size(1088, 50);
            SecureActionRowLayoutPanel.TabIndex = 5;
            // 
            // RefreshNotesButton
            // 
            RefreshNotesButton.BackColor = Color.FromArgb(41, 128, 185);
            RefreshNotesButton.Cursor = Cursors.Hand;
            RefreshNotesButton.Dock = DockStyle.Fill;
            RefreshNotesButton.Enabled = false;
            RefreshNotesButton.FlatAppearance.BorderSize = 0;
            RefreshNotesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            RefreshNotesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            RefreshNotesButton.FlatStyle = FlatStyle.Flat;
            RefreshNotesButton.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshNotesButton.ForeColor = Color.White;
            RefreshNotesButton.Location = new Point(362, 0);
            RefreshNotesButton.Margin = new Padding(0);
            RefreshNotesButton.Name = "RefreshNotesButton";
            RefreshNotesButton.Size = new Size(362, 50);
            RefreshNotesButton.TabIndex = 3;
            RefreshNotesButton.Text = "Refresh Notes";
            RefreshNotesButton.UseVisualStyleBackColor = false;
            RefreshNotesButton.Click += RefreshNotesButton_Click;
            // 
            // DeleteNotesButton
            // 
            DeleteNotesButton.BackColor = Color.FromArgb(192, 57, 43);
            DeleteNotesButton.Cursor = Cursors.Hand;
            DeleteNotesButton.Dock = DockStyle.Fill;
            DeleteNotesButton.Enabled = false;
            DeleteNotesButton.FlatAppearance.BorderSize = 0;
            DeleteNotesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            DeleteNotesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            DeleteNotesButton.FlatStyle = FlatStyle.Flat;
            DeleteNotesButton.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteNotesButton.ForeColor = Color.White;
            DeleteNotesButton.Location = new Point(724, 0);
            DeleteNotesButton.Margin = new Padding(0);
            DeleteNotesButton.Name = "DeleteNotesButton";
            DeleteNotesButton.Size = new Size(364, 50);
            DeleteNotesButton.TabIndex = 2;
            DeleteNotesButton.Text = "Delete Notes";
            DeleteNotesButton.UseVisualStyleBackColor = false;
            DeleteNotesButton.Click += DeleteNotesButton_Click;
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
            CreatePasswordButton.Text = "Create Note";
            CreatePasswordButton.UseVisualStyleBackColor = false;
            CreatePasswordButton.Click += CreateNoteButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(ProgressPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.FlowDirection = FlowDirection.TopDown;
            MainPanel.Location = new Point(0, 50);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1088, 682);
            MainPanel.TabIndex = 4;
            MainPanel.WrapContents = false;
            // 
            // ProgressPanel
            // 
            ProgressPanel.LabelProp = "Loading Secure Notes...";
            ProgressPanel.Location = new Point(3, 3);
            ProgressPanel.Name = "ProgressPanel";
            ProgressPanel.Size = new Size(571, 69);
            ProgressPanel.TabIndex = 0;
            // 
            // SecureNotePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainPanel);
            Controls.Add(panel1);
            Name = "SecureNotePage";
            Size = new Size(1088, 732);
            Resize += SecureNotePage_Resize;
            ActionRowLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            SecureActionRowLayoutPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ActionRowLayoutPanel;
        private Button RefreshPasswordsButton;
        private Button DeletePasswordsButton;
        private Panel panel1;
        private TableLayoutPanel SecureActionRowLayoutPanel;
        private Button RefreshNotesButton;
        private Button DeleteNotesButton;
        private Button CreatePasswordButton;
        private FlowLayoutPanel MainPanel;
        private ProgressPanel ProgressPanel;
    }
}
