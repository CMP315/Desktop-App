namespace SecureSoftware.Components
{
    partial class UserSettings
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            UsernameInput = new TextBox();
            EmailInput = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ChangePassword = new Button();
            DeleteAccount = new Button();
            Save = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1088, 732);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel3);
            flowLayoutPanel1.Controls.Add(UsernameInput);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel4);
            flowLayoutPanel1.Controls.Add(EmailInput);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(Save);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(220, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 200, 0, 0);
            flowLayoutPanel1.Size = new Size(646, 726);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Controls.Add(iconPictureBox1, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 203);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(337, 30);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(33, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 30);
            label1.TabIndex = 0;
            label1.Text = "Your Account Username";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 30;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Margin = new Padding(0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(30, 30);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // UsernameInput
            // 
            UsernameInput.Enabled = false;
            UsernameInput.Location = new Point(3, 239);
            UsernameInput.Margin = new Padding(3, 3, 3, 20);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(643, 23);
            UsernameInput.TabIndex = 2;
            // 
            // EmailInput
            // 
            EmailInput.Enabled = false;
            EmailInput.Location = new Point(3, 321);
            EmailInput.Margin = new Padding(3, 3, 3, 20);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(643, 23);
            EmailInput.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ChangePassword, 0, 0);
            tableLayoutPanel2.Controls.Add(DeleteAccount, 1, 0);
            tableLayoutPanel2.Location = new Point(0, 364);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(643, 100);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = Color.FromArgb(9, 132, 227);
            ChangePassword.Dock = DockStyle.Fill;
            ChangePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(9, 132, 227);
            ChangePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(116, 185, 255);
            ChangePassword.FlatStyle = FlatStyle.Flat;
            ChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChangePassword.ForeColor = Color.White;
            ChangePassword.Location = new Point(0, 0);
            ChangePassword.Margin = new Padding(0);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(321, 100);
            ChangePassword.TabIndex = 0;
            ChangePassword.Text = "Change Master Password";
            ChangePassword.UseVisualStyleBackColor = false;
            ChangePassword.Click += ChangePassword_Click;
            // 
            // DeleteAccount
            // 
            DeleteAccount.BackColor = Color.FromArgb(192, 57, 43);
            DeleteAccount.Dock = DockStyle.Fill;
            DeleteAccount.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            DeleteAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            DeleteAccount.FlatStyle = FlatStyle.Flat;
            DeleteAccount.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteAccount.ForeColor = Color.White;
            DeleteAccount.Location = new Point(321, 0);
            DeleteAccount.Margin = new Padding(0);
            DeleteAccount.Name = "DeleteAccount";
            DeleteAccount.Size = new Size(322, 100);
            DeleteAccount.TabIndex = 1;
            DeleteAccount.Text = "Delete Account";
            DeleteAccount.UseVisualStyleBackColor = false;
            DeleteAccount.Click += DeleteAccount_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.FromArgb(39, 174, 96);
            Save.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            Save.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = Color.White;
            Save.Location = new Point(0, 464);
            Save.Margin = new Padding(0);
            Save.Name = "Save";
            Save.Size = new Size(643, 100);
            Save.TabIndex = 2;
            Save.Text = "Save Changes";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 1, 0);
            tableLayoutPanel4.Controls.Add(iconPictureBox2, 0, 0);
            tableLayoutPanel4.Location = new Point(3, 285);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(337, 30);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(33, 0);
            label3.Name = "label3";
            label3.Size = new Size(301, 30);
            label3.TabIndex = 0;
            label3.Text = "Your Account Email";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.Dock = DockStyle.Fill;
            iconPictureBox2.ForeColor = SystemColors.ControlText;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconPictureBox2.IconColor = SystemColors.ControlText;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 30;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Margin = new Padding(0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(30, 30);
            iconPictureBox2.TabIndex = 1;
            iconPictureBox2.TabStop = false;
            // 
            // UserSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Name = "UserSettings";
            Size = new Size(1088, 732);
            Load += UserSettings_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox UsernameInput;
        private TextBox EmailInput;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Save;
        private Button ChangePassword;
        private Button DeleteAccount;
        private TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}
