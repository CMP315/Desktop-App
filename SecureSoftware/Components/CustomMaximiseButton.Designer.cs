namespace SecureSoftware.Components
{
    partial class CustomMaximiseButton
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
            IconButton = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // IconButton
            // 
            IconButton.BackColor = Color.FromArgb(26, 188, 156);
            IconButton.Dock = DockStyle.Fill;
            IconButton.FlatAppearance.BorderSize = 0;
            IconButton.FlatStyle = FlatStyle.Flat;
            IconButton.ForeColor = Color.White;
            IconButton.IconChar = FontAwesome.Sharp.IconChar.None;
            IconButton.IconColor = Color.FromArgb(44, 62, 80);
            IconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButton.Location = new Point(0, 0);
            IconButton.Name = "IconButton";
            IconButton.Size = new Size(50, 50);
            IconButton.TabIndex = 0;
            IconButton.UseVisualStyleBackColor = false;
            IconButton.Click += IconButton_Click;
            // 
            // CustomMaximiseButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(IconButton);
            Name = "CustomMaximiseButton";
            Size = new Size(50, 50);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconButton IconButton;
    }
}
