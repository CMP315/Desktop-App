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
            panel1 = new Panel();
            LoginDetail = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            sideBarMenuItem1 = new Components.SideBarMenuItem();
            sideBarMenuItem2 = new Components.SideBarMenuItem();
            sideBarMenuItem3 = new Components.SideBarMenuItem();
            MainPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(LoginDetail);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 90);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // LoginDetail
            // 
            LoginDetail.AutoSize = true;
            LoginDetail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginDetail.ForeColor = SystemColors.Control;
            LoginDetail.Location = new Point(86, 19);
            LoginDetail.Name = "LoginDetail";
            LoginDetail.Size = new Size(167, 30);
            LoginDetail.TabIndex = 5;
            LoginDetail.Text = "Logged in as ......";
            LoginDetail.Click += label1_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.DarkOrchid;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 771);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
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
            flowLayoutPanel2.Size = new Size(297, 771);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // sideBarMenuItem1
            // 
            sideBarMenuItem1.BackColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem1.BackgroundColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem1.BackgroundImageLayout = ImageLayout.None;
            sideBarMenuItem1.Icon = FontAwesome.Sharp.IconChar.Mosque;
            sideBarMenuItem1.Label = "Password Vault";
            sideBarMenuItem1.Location = new Point(0, 0);
            sideBarMenuItem1.Margin = new Padding(0);
            sideBarMenuItem1.Name = "sideBarMenuItem1";
            sideBarMenuItem1.Size = new Size(297, 58);
            sideBarMenuItem1.TabIndex = 0;
            sideBarMenuItem1.Load += sideBarMenuItem1_Load;
            // 
            // sideBarMenuItem2
            // 
            sideBarMenuItem2.BackColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem2.BackgroundColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem2.Icon = FontAwesome.Sharp.IconChar.Fedora;
            sideBarMenuItem2.Label = "Secure Notes";
            sideBarMenuItem2.Location = new Point(0, 58);
            sideBarMenuItem2.Margin = new Padding(0);
            sideBarMenuItem2.Name = "sideBarMenuItem2";
            sideBarMenuItem2.Size = new Size(297, 58);
            sideBarMenuItem2.TabIndex = 1;
            sideBarMenuItem2.Load += sideBarMenuItem2_Load;
            // 
            // sideBarMenuItem3
            // 
            sideBarMenuItem3.BackColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem3.BackgroundColor = Color.FromArgb(100, 48, 122);
            sideBarMenuItem3.Icon = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            sideBarMenuItem3.Label = "Generate Password";
            sideBarMenuItem3.Location = new Point(0, 116);
            sideBarMenuItem3.Margin = new Padding(0);
            sideBarMenuItem3.Name = "sideBarMenuItem3";
            sideBarMenuItem3.Size = new Size(297, 58);
            sideBarMenuItem3.TabIndex = 2;
            // 
            // MainPanel
            // 
            MainPanel.AutoScroll = true;
            MainPanel.AutoSize = true;
            MainPanel.BackColor = Color.Transparent;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(297, 90);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1087, 771);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += flowLayoutPanel1_Paint;
            // 
            // Email1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 861);
            Controls.Add(MainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Email1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label LoginDetail;
        private FlowLayoutPanel MainPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Components.SideBarMenuItem sideBarMenuItem1;
        private Components.SideBarMenuItem sideBarMenuItem2;
        private Components.SideBarMenuItem sideBarMenuItem3;
    }
}
