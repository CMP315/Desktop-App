namespace SecureSoftware.Forms
{
    partial class LoginOrRegister
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
            tableLayoutPanel2 = new TableLayoutPanel();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            LoginButton = new Button();
            RegisterButton = new Button();
            CloseButton = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(142, 68, 173);
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(516, 77);
            tableLayoutPanel2.TabIndex = 8;
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
            label4.Size = new Size(516, 50);
            label4.TabIndex = 0;
            label4.Text = "PASSMAN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 50);
            label5.Name = "label5";
            label5.Size = new Size(510, 27);
            label5.TabIndex = 1;
            label5.Text = "\"A simple and secure Password Manager!\"";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(LoginButton, 0, 0);
            tableLayoutPanel1.Controls.Add(RegisterButton, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 77);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(516, 62);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(22, 160, 133);
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Dock = DockStyle.Fill;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 160, 133);
            LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(0, 0);
            LoginButton.Margin = new Padding(0);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(258, 62);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(22, 160, 133);
            RegisterButton.Cursor = Cursors.Hand;
            RegisterButton.Dock = DockStyle.Fill;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 160, 133);
            RegisterButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegisterButton.ForeColor = Color.White;
            RegisterButton.Location = new Point(258, 0);
            RegisterButton.Margin = new Padding(0);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(258, 62);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "REGISTER";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.FromArgb(192, 57, 43);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Dock = DockStyle.Bottom;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            CloseButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(0, 137);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(516, 35);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "Close the Application";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginOrRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CloseButton;
            ClientSize = new Size(516, 172);
            Controls.Add(CloseButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel2);
            Name = "LoginOrRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginOrRegister";
            FormClosing += LoginOrRegister_FormClosing;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button RegisterButton;
        private Button CloseButton;
        private Button LoginButton;
    }
}