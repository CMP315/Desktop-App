namespace SecureSoftware.Components
{
    partial class SideBarMenuItem
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
            SideBarIcon = new FontAwesome.Sharp.IconPictureBox();
            SideBarLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)SideBarIcon).BeginInit();
            SuspendLayout();
            // 
            // SideBarIcon
            // 
            SideBarIcon.BackColor = Color.Transparent;
            SideBarIcon.Dock = DockStyle.Left;
            SideBarIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            SideBarIcon.IconColor = Color.White;
            SideBarIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SideBarIcon.IconSize = 58;
            SideBarIcon.Location = new Point(0, 0);
            SideBarIcon.Name = "SideBarIcon";
            SideBarIcon.Size = new Size(60, 58);
            SideBarIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            SideBarIcon.TabIndex = 0;
            SideBarIcon.TabStop = false;
            // 
            // SideBarLabel
            // 
            SideBarLabel.AutoSize = true;
            SideBarLabel.Dock = DockStyle.Fill;
            SideBarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SideBarLabel.ForeColor = Color.White;
            SideBarLabel.Location = new Point(60, 0);
            SideBarLabel.Name = "SideBarLabel";
            SideBarLabel.Padding = new Padding(0, 10, 0, 0);
            SideBarLabel.Size = new Size(171, 42);
            SideBarLabel.TabIndex = 1;
            SideBarLabel.Text = "Password Vault";
            SideBarLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SideBarMenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SideBarLabel);
            Controls.Add(SideBarIcon);
            Cursor = Cursors.Hand;
            Margin = new Padding(0);
            Name = "SideBarMenuItem";
            Size = new Size(297, 58);
            ((System.ComponentModel.ISupportInitialize)SideBarIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox SideBarIcon;
        private Label SideBarLabel;
    }
}
