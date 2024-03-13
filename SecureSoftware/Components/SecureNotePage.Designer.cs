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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            CreatePasswordButton = new Button();
            MainPanel = new FlowLayoutPanel();
            ProgressPanel = new ProgressPanel();
            ActionRowLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 54);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(100, 48, 122);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(CreatePasswordButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = Color.Transparent;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1088, 54);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 128, 185);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(362, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(362, 54);
            button1.TabIndex = 3;
            button1.Text = "Refresh Notes";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 57, 43);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(724, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(364, 54);
            button2.TabIndex = 2;
            button2.Text = "Delete Note";
            button2.UseVisualStyleBackColor = false;
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
            CreatePasswordButton.Size = new Size(362, 54);
            CreatePasswordButton.TabIndex = 1;
            CreatePasswordButton.Text = "Create Note";
            CreatePasswordButton.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Controls.Add(ProgressPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.FlowDirection = FlowDirection.TopDown;
            MainPanel.Location = new Point(0, 54);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1088, 678);
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
            ActionRowLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ActionRowLayoutPanel;
        private Button RefreshPasswordsButton;
        private Button DeletePasswordsButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button CreatePasswordButton;
        private FlowLayoutPanel MainPanel;
        private ProgressPanel ProgressPanel;
    }
}
