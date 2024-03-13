namespace SecureSoftware.Forms.Password_Generator
{
    partial class SelectType
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HeaderTable = new TableLayoutPanel();
            label1 = new Label();
            ButtonListTable = new TableLayoutPanel();
            PassphraseGeneratorButton = new Button();
            StandardGeneratorButton = new Button();
            CancelButton = new Button();
            MainPanel = new Panel();
            DefaultGenerator = new StandardGenerator();
            HeaderTable.SuspendLayout();
            ButtonListTable.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderTable
            // 
            HeaderTable.ColumnCount = 1;
            HeaderTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            HeaderTable.Controls.Add(label1, 0, 0);
            HeaderTable.Controls.Add(ButtonListTable, 0, 1);
            HeaderTable.Dock = DockStyle.Top;
            HeaderTable.Location = new Point(0, 0);
            HeaderTable.Name = "HeaderTable";
            HeaderTable.RowCount = 2;
            HeaderTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            HeaderTable.Size = new Size(514, 106);
            HeaderTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 48, 122);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(514, 46);
            label1.TabIndex = 2;
            label1.Text = "PASSMAN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButtonListTable
            // 
            ButtonListTable.ColumnCount = 2;
            ButtonListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButtonListTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ButtonListTable.Controls.Add(PassphraseGeneratorButton, 1, 0);
            ButtonListTable.Controls.Add(StandardGeneratorButton, 0, 0);
            ButtonListTable.Dock = DockStyle.Fill;
            ButtonListTable.Location = new Point(0, 46);
            ButtonListTable.Margin = new Padding(0);
            ButtonListTable.Name = "ButtonListTable";
            ButtonListTable.RowCount = 1;
            ButtonListTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonListTable.Size = new Size(514, 60);
            ButtonListTable.TabIndex = 3;
            // 
            // PassphraseGeneratorButton
            // 
            PassphraseGeneratorButton.BackColor = Color.FromArgb(39, 174, 96);
            PassphraseGeneratorButton.Dock = DockStyle.Fill;
            PassphraseGeneratorButton.FlatAppearance.BorderSize = 0;
            PassphraseGeneratorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            PassphraseGeneratorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            PassphraseGeneratorButton.FlatStyle = FlatStyle.Flat;
            PassphraseGeneratorButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PassphraseGeneratorButton.ForeColor = Color.White;
            PassphraseGeneratorButton.Location = new Point(257, 0);
            PassphraseGeneratorButton.Margin = new Padding(0);
            PassphraseGeneratorButton.Name = "PassphraseGeneratorButton";
            PassphraseGeneratorButton.Size = new Size(257, 60);
            PassphraseGeneratorButton.TabIndex = 1;
            PassphraseGeneratorButton.Text = "Generate Passphrase";
            PassphraseGeneratorButton.UseVisualStyleBackColor = false;
            PassphraseGeneratorButton.Click += PassphraseGeneratorButton_Click;
            // 
            // StandardGeneratorButton
            // 
            StandardGeneratorButton.BackColor = Color.FromArgb(22, 160, 133);
            StandardGeneratorButton.Dock = DockStyle.Fill;
            StandardGeneratorButton.FlatAppearance.BorderSize = 0;
            StandardGeneratorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 160, 133);
            StandardGeneratorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            StandardGeneratorButton.FlatStyle = FlatStyle.Flat;
            StandardGeneratorButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            StandardGeneratorButton.ForeColor = Color.White;
            StandardGeneratorButton.Location = new Point(0, 0);
            StandardGeneratorButton.Margin = new Padding(0);
            StandardGeneratorButton.Name = "StandardGeneratorButton";
            StandardGeneratorButton.Size = new Size(257, 60);
            StandardGeneratorButton.TabIndex = 0;
            StandardGeneratorButton.Text = "Generate Password (Default)";
            StandardGeneratorButton.UseVisualStyleBackColor = false;
            StandardGeneratorButton.Click += StandardGeneratorButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 57, 43);
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Dock = DockStyle.Bottom;
            CancelButton.FlatAppearance.BorderColor = Color.Black;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(0, 375);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(514, 62);
            CancelButton.TabIndex = 13;
            CancelButton.Text = "Close";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(DefaultGenerator);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 106);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(514, 269);
            MainPanel.TabIndex = 14;
            // 
            // DefaultGenerator
            // 
            DefaultGenerator.BackColor = Color.FromArgb(155, 89, 182);
            DefaultGenerator.Location = new Point(0, 0);
            DefaultGenerator.Name = "DefaultGenerator";
            DefaultGenerator.Size = new Size(525, 287);
            DefaultGenerator.TabIndex = 0;
            // 
            // SelectType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            ClientSize = new Size(514, 437);
            Controls.Add(MainPanel);
            Controls.Add(CancelButton);
            Controls.Add(HeaderTable);
            Name = "SelectType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SelectType";
            HeaderTable.ResumeLayout(false);
            HeaderTable.PerformLayout();
            ButtonListTable.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel HeaderTable;
        private Label label1;
        private Button CancelButton;
        private Button StandardGeneratorButton;
        private Button PassphraseGeneratorButton;
        private Panel MainPanel;
        private TableLayoutPanel ButtonListTable;
        private StandardGenerator DefaultGenerator;
    }
}