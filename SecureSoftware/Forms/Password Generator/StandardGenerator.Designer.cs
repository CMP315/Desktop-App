namespace SecureSoftware.Forms.Password_Generator
{
    partial class StandardGenerator
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            UppercaseCheckbox = new CheckBox();
            LowercaseCheckbox = new CheckBox();
            DigitsCheckbox = new CheckBox();
            SymbolsCheckbox = new CheckBox();
            EmojisCheckbox = new CheckBox();
            AvoidSimilarCheckbox = new CheckBox();
            AvoidAmbigiousCheckbox = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            PasswordLengthTrackBar = new TrackBar();
            RefreshButton = new Button();
            CopyButton = new Button();
            label2 = new Label();
            GeneratedPasswordTextBox = new TextBox();
            PasswordVisibilityButton = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthTrackBar).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(UppercaseCheckbox);
            flowLayoutPanel1.Controls.Add(LowercaseCheckbox);
            flowLayoutPanel1.Controls.Add(DigitsCheckbox);
            flowLayoutPanel1.Controls.Add(SymbolsCheckbox);
            flowLayoutPanel1.Controls.Add(EmojisCheckbox);
            flowLayoutPanel1.Controls.Add(AvoidSimilarCheckbox);
            flowLayoutPanel1.Controls.Add(AvoidAmbigiousCheckbox);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(16, 93);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(206, 183);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // UppercaseCheckbox
            // 
            UppercaseCheckbox.AutoSize = true;
            UppercaseCheckbox.Checked = true;
            UppercaseCheckbox.CheckState = CheckState.Checked;
            UppercaseCheckbox.ForeColor = Color.White;
            UppercaseCheckbox.Location = new Point(3, 3);
            UppercaseCheckbox.Name = "UppercaseCheckbox";
            UppercaseCheckbox.Size = new Size(103, 19);
            UppercaseCheckbox.TabIndex = 0;
            UppercaseCheckbox.Text = "Use Uppercase";
            UppercaseCheckbox.UseVisualStyleBackColor = true;
            UppercaseCheckbox.CheckedChanged += UppercaseCheckbox_Click;
            // 
            // LowercaseCheckbox
            // 
            LowercaseCheckbox.AutoSize = true;
            LowercaseCheckbox.Checked = true;
            LowercaseCheckbox.CheckState = CheckState.Checked;
            LowercaseCheckbox.ForeColor = Color.White;
            LowercaseCheckbox.Location = new Point(3, 28);
            LowercaseCheckbox.Name = "LowercaseCheckbox";
            LowercaseCheckbox.Size = new Size(103, 19);
            LowercaseCheckbox.TabIndex = 1;
            LowercaseCheckbox.Text = "Use Lowercase";
            LowercaseCheckbox.UseVisualStyleBackColor = true;
            LowercaseCheckbox.CheckedChanged += LowercaseCheckbox_CheckedChanged;
            // 
            // DigitsCheckbox
            // 
            DigitsCheckbox.AutoSize = true;
            DigitsCheckbox.Checked = true;
            DigitsCheckbox.CheckState = CheckState.Checked;
            DigitsCheckbox.ForeColor = Color.White;
            DigitsCheckbox.Location = new Point(3, 53);
            DigitsCheckbox.Name = "DigitsCheckbox";
            DigitsCheckbox.Size = new Size(78, 19);
            DigitsCheckbox.TabIndex = 2;
            DigitsCheckbox.Text = "Use Digits";
            DigitsCheckbox.UseVisualStyleBackColor = true;
            DigitsCheckbox.CheckedChanged += DigitsCheckbox_CheckedChanged;
            // 
            // SymbolsCheckbox
            // 
            SymbolsCheckbox.AutoSize = true;
            SymbolsCheckbox.Checked = true;
            SymbolsCheckbox.CheckState = CheckState.Checked;
            SymbolsCheckbox.ForeColor = Color.White;
            SymbolsCheckbox.Location = new Point(3, 78);
            SymbolsCheckbox.Name = "SymbolsCheckbox";
            SymbolsCheckbox.Size = new Size(93, 19);
            SymbolsCheckbox.TabIndex = 3;
            SymbolsCheckbox.Text = "Use Symbols";
            SymbolsCheckbox.UseVisualStyleBackColor = true;
            SymbolsCheckbox.CheckedChanged += SymbolsCheckbox_CheckedChanged;
            // 
            // EmojisCheckbox
            // 
            EmojisCheckbox.AutoSize = true;
            EmojisCheckbox.ForeColor = Color.White;
            EmojisCheckbox.Location = new Point(3, 103);
            EmojisCheckbox.Name = "EmojisCheckbox";
            EmojisCheckbox.Size = new Size(83, 19);
            EmojisCheckbox.TabIndex = 6;
            EmojisCheckbox.Text = "Use Emojis";
            EmojisCheckbox.UseVisualStyleBackColor = true;
            EmojisCheckbox.CheckedChanged += EmojisCheckbox_CheckedChanged;
            // 
            // AvoidSimilarCheckbox
            // 
            AvoidSimilarCheckbox.AutoSize = true;
            AvoidSimilarCheckbox.ForeColor = Color.White;
            AvoidSimilarCheckbox.Location = new Point(3, 128);
            AvoidSimilarCheckbox.Name = "AvoidSimilarCheckbox";
            AvoidSimilarCheckbox.Size = new Size(155, 19);
            AvoidSimilarCheckbox.TabIndex = 4;
            AvoidSimilarCheckbox.Text = "Avoid Similar Characters";
            AvoidSimilarCheckbox.UseVisualStyleBackColor = true;
            AvoidSimilarCheckbox.CheckedChanged += AvoidSimilarCheckbox_CheckedChanged;
            // 
            // AvoidAmbigiousCheckbox
            // 
            AvoidAmbigiousCheckbox.AutoSize = true;
            AvoidAmbigiousCheckbox.ForeColor = Color.White;
            AvoidAmbigiousCheckbox.Location = new Point(3, 153);
            AvoidAmbigiousCheckbox.Name = "AvoidAmbigiousCheckbox";
            AvoidAmbigiousCheckbox.Size = new Size(166, 19);
            AvoidAmbigiousCheckbox.TabIndex = 5;
            AvoidAmbigiousCheckbox.Tag = "";
            AvoidAmbigiousCheckbox.Text = "Avoid Ambigious Symbols";
            AvoidAmbigiousCheckbox.UseVisualStyleBackColor = true;
            AvoidAmbigiousCheckbox.CheckedChanged += AvoidAmbigiousCheckbox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(304, 93);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 19;
            label4.Text = "Password Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 141);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 18;
            label3.Text = "25 characters";
            // 
            // PasswordLengthTrackBar
            // 
            PasswordLengthTrackBar.LargeChange = 10;
            PasswordLengthTrackBar.Location = new Point(238, 111);
            PasswordLengthTrackBar.Maximum = 100;
            PasswordLengthTrackBar.Minimum = 1;
            PasswordLengthTrackBar.Name = "PasswordLengthTrackBar";
            PasswordLengthTrackBar.Size = new Size(245, 45);
            PasswordLengthTrackBar.TabIndex = 17;
            PasswordLengthTrackBar.Value = 25;
            PasswordLengthTrackBar.Scroll += PasswordLengthTrackBar_Scroll;
            // 
            // RefreshButton
            // 
            RefreshButton.BackColor = Color.FromArgb(41, 128, 185);
            RefreshButton.Cursor = Cursors.Hand;
            RefreshButton.FlatAppearance.BorderColor = Color.Black;
            RefreshButton.FlatAppearance.BorderSize = 0;
            RefreshButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            RefreshButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            RefreshButton.FlatStyle = FlatStyle.Flat;
            RefreshButton.ForeColor = Color.White;
            RefreshButton.Location = new Point(96, 56);
            RefreshButton.Margin = new Padding(0);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(78, 23);
            RefreshButton.TabIndex = 16;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = false;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // CopyButton
            // 
            CopyButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyButton.Cursor = Cursors.Hand;
            CopyButton.FlatAppearance.BorderColor = Color.Black;
            CopyButton.FlatAppearance.BorderSize = 0;
            CopyButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyButton.FlatStyle = FlatStyle.Flat;
            CopyButton.ForeColor = Color.White;
            CopyButton.Location = new Point(16, 56);
            CopyButton.Margin = new Padding(0);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(78, 23);
            CopyButton.TabIndex = 15;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += CopyButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 6);
            label2.Name = "label2";
            label2.Size = new Size(204, 21);
            label2.TabIndex = 14;
            label2.Text = "Your Generated Password";
            // 
            // GeneratedPasswordTextBox
            // 
            GeneratedPasswordTextBox.BackColor = Color.FromArgb(155, 89, 182);
            GeneratedPasswordTextBox.BorderStyle = BorderStyle.None;
            GeneratedPasswordTextBox.ForeColor = Color.White;
            GeneratedPasswordTextBox.Location = new Point(16, 30);
            GeneratedPasswordTextBox.Name = "GeneratedPasswordTextBox";
            GeneratedPasswordTextBox.ReadOnly = true;
            GeneratedPasswordTextBox.Size = new Size(468, 16);
            GeneratedPasswordTextBox.TabIndex = 21;
            GeneratedPasswordTextBox.Text = "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@";
            // 
            // PasswordVisibilityButton
            // 
            PasswordVisibilityButton.Cursor = Cursors.Hand;
            PasswordVisibilityButton.FlatAppearance.BorderSize = 0;
            PasswordVisibilityButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            PasswordVisibilityButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            PasswordVisibilityButton.FlatStyle = FlatStyle.Flat;
            PasswordVisibilityButton.ForeColor = Color.White;
            PasswordVisibilityButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            PasswordVisibilityButton.IconColor = Color.White;
            PasswordVisibilityButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PasswordVisibilityButton.IconSize = 25;
            PasswordVisibilityButton.Location = new Point(484, 30);
            PasswordVisibilityButton.Name = "PasswordVisibilityButton";
            PasswordVisibilityButton.Size = new Size(32, 19);
            PasswordVisibilityButton.TabIndex = 22;
            PasswordVisibilityButton.UseVisualStyleBackColor = true;
            PasswordVisibilityButton.Click += PasswordVisibilityButton_Click;
            // 
            // StandardGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            Controls.Add(PasswordVisibilityButton);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PasswordLengthTrackBar);
            Controls.Add(RefreshButton);
            Controls.Add(CopyButton);
            Controls.Add(label2);
            Controls.Add(GeneratedPasswordTextBox);
            Name = "StandardGenerator";
            Size = new Size(525, 287);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordLengthTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox UppercaseCheckbox;
        private CheckBox LowercaseCheckbox;
        private CheckBox DigitsCheckbox;
        private CheckBox SymbolsCheckbox;
        private CheckBox EmojisCheckbox;
        private CheckBox AvoidSimilarCheckbox;
        private CheckBox AvoidAmbigiousCheckbox;
        private Label label4;
        private Label label3;
        private TrackBar PasswordLengthTrackBar;
        private Button RefreshButton;
        private Button CopyButton;
        private Label label2;
        private TextBox GeneratedPasswordTextBox;
        private FontAwesome.Sharp.IconButton PasswordVisibilityButton;
    }
}
