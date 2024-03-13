namespace SecureSoftware.Forms.Password_Generator
{
    partial class PassphraseGenerator
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
            label4 = new Label();
            label3 = new Label();
            PassphraseLengthTrackBar = new TrackBar();
            RefreshButton = new Button();
            CopyButton = new Button();
            label2 = new Label();
            GeneratedPasswordTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)PassphraseLengthTrackBar).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(208, 185);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 28;
            label4.Text = "Passphrase Length";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(233, 233);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 27;
            label3.Text = "25 words";
            // 
            // PassphraseLengthTrackBar
            // 
            PassphraseLengthTrackBar.LargeChange = 10;
            PassphraseLengthTrackBar.Location = new Point(142, 203);
            PassphraseLengthTrackBar.Maximum = 100;
            PassphraseLengthTrackBar.Minimum = 1;
            PassphraseLengthTrackBar.Name = "PassphraseLengthTrackBar";
            PassphraseLengthTrackBar.Size = new Size(245, 45);
            PassphraseLengthTrackBar.TabIndex = 26;
            PassphraseLengthTrackBar.Value = 25;
            PassphraseLengthTrackBar.Scroll += PassphraseLengthTrackBar_Scroll;
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
            RefreshButton.Location = new Point(95, 150);
            RefreshButton.Margin = new Padding(0);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(78, 23);
            RefreshButton.TabIndex = 25;
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
            CopyButton.Location = new Point(15, 150);
            CopyButton.Margin = new Padding(0);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new Size(78, 23);
            CopyButton.TabIndex = 24;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = false;
            CopyButton.Click += CopyButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(9, 4);
            label2.Name = "label2";
            label2.Size = new Size(216, 21);
            label2.TabIndex = 23;
            label2.Text = "Your Generated Passphrase";
            // 
            // GeneratedPasswordTextBox
            // 
            GeneratedPasswordTextBox.BackColor = Color.FromArgb(155, 89, 182);
            GeneratedPasswordTextBox.BorderStyle = BorderStyle.None;
            GeneratedPasswordTextBox.ForeColor = Color.White;
            GeneratedPasswordTextBox.Location = new Point(15, 28);
            GeneratedPasswordTextBox.Name = "GeneratedPasswordTextBox";
            GeneratedPasswordTextBox.Size = new Size(495, 119);
            GeneratedPasswordTextBox.TabIndex = 30;
            GeneratedPasswordTextBox.Text = "";
            // 
            // PassphraseGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            Controls.Add(GeneratedPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PassphraseLengthTrackBar);
            Controls.Add(RefreshButton);
            Controls.Add(CopyButton);
            Controls.Add(label2);
            Name = "PassphraseGenerator";
            Size = new Size(525, 287);
            ((System.ComponentModel.ISupportInitialize)PassphraseLengthTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private TrackBar PassphraseLengthTrackBar;
        private Button RefreshButton;
        private Button CopyButton;
        private Label label2;
        private RichTextBox GeneratedPasswordTextBox;
    }
}
