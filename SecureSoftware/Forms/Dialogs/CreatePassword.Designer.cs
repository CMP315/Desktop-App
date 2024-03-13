namespace SecureSoftware.Forms
{
    partial class CreatePassword
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            NameInput = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label3 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            PasswordInput = new TextBox();
            label4 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            SiteNameInput = new TextBox();
            label5 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            NotesInput = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            CreateButton = new Button();
            CancelButton = new Button();
            GeneratePassword = new Button();
            QuickGenPassword = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkViolet;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(444, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 48, 122);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Gill Sans MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(444, 100);
            label1.TabIndex = 0;
            label1.Text = "CREATE PASSWORD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.FromArgb(236, 240, 241);
            NameInput.Location = new Point(16, 145);
            NameInput.Name = "NameInput";
            NameInput.PlaceholderText = "Enter the account Username or E-Mail";
            NameInput.Size = new Size(413, 23);
            NameInput.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(16, 112);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 112);
            label2.Name = "label2";
            label2.Size = new Size(176, 30);
            label2.TabIndex = 3;
            label2.Text = "Username / Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(54, 185);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.Location = new Point(16, 185);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(32, 32);
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = Color.FromArgb(236, 240, 241);
            PasswordInput.Location = new Point(16, 218);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.PlaceholderText = "Enter the Password";
            PasswordInput.Size = new Size(413, 23);
            PasswordInput.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 285);
            label4.Name = "label4";
            label4.Size = new Size(109, 30);
            label4.TabIndex = 9;
            label4.Text = "Site Name";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Globe;
            iconPictureBox3.IconColor = Color.White;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.Location = new Point(16, 285);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(32, 32);
            iconPictureBox3.TabIndex = 8;
            iconPictureBox3.TabStop = false;
            // 
            // SiteNameInput
            // 
            SiteNameInput.BackColor = Color.FromArgb(236, 240, 241);
            SiteNameInput.Location = new Point(16, 318);
            SiteNameInput.Name = "SiteNameInput";
            SiteNameInput.PlaceholderText = "Enter the Site Name";
            SiteNameInput.Size = new Size(413, 23);
            SiteNameInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 355);
            label5.Name = "label5";
            label5.Size = new Size(68, 30);
            label5.TabIndex = 12;
            label5.Text = "Notes";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.Location = new Point(16, 355);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(231, 32);
            iconPictureBox4.TabIndex = 11;
            iconPictureBox4.TabStop = false;
            // 
            // NotesInput
            // 
            NotesInput.BackColor = Color.FromArgb(236, 240, 241);
            NotesInput.Location = new Point(16, 388);
            NotesInput.Name = "NotesInput";
            NotesInput.ScrollBars = RichTextBoxScrollBars.Vertical;
            NotesInput.Size = new Size(413, 112);
            NotesInput.TabIndex = 13;
            NotesInput.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CreateButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 515);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(444, 62);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(39, 174, 96);
            CreateButton.Cursor = Cursors.Hand;
            CreateButton.Dock = DockStyle.Fill;
            CreateButton.FlatAppearance.BorderColor = Color.Black;
            CreateButton.FlatAppearance.BorderSize = 0;
            CreateButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            CreateButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            CreateButton.FlatStyle = FlatStyle.Flat;
            CreateButton.ForeColor = Color.White;
            CreateButton.Location = new Point(0, 0);
            CreateButton.Margin = new Padding(0);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(222, 62);
            CreateButton.TabIndex = 0;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 57, 43);
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderColor = Color.Black;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(222, 0);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(222, 62);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // GeneratePassword
            // 
            GeneratePassword.BackColor = Color.FromArgb(41, 128, 185);
            GeneratePassword.FlatAppearance.BorderSize = 0;
            GeneratePassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            GeneratePassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            GeneratePassword.FlatStyle = FlatStyle.Flat;
            GeneratePassword.ForeColor = Color.White;
            GeneratePassword.Location = new Point(175, 247);
            GeneratePassword.Name = "GeneratePassword";
            GeneratePassword.Size = new Size(168, 23);
            GeneratePassword.TabIndex = 16;
            GeneratePassword.Text = "Securely Generate Password";
            GeneratePassword.UseVisualStyleBackColor = false;
            GeneratePassword.Click += GeneratePassword_Click;
            // 
            // QuickGenPassword
            // 
            QuickGenPassword.BackColor = Color.FromArgb(22, 160, 133);
            QuickGenPassword.FlatAppearance.BorderSize = 0;
            QuickGenPassword.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 160, 133);
            QuickGenPassword.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 188, 156);
            QuickGenPassword.FlatStyle = FlatStyle.Flat;
            QuickGenPassword.ForeColor = Color.White;
            QuickGenPassword.Location = new Point(16, 247);
            QuickGenPassword.Name = "QuickGenPassword";
            QuickGenPassword.Size = new Size(153, 23);
            QuickGenPassword.TabIndex = 17;
            QuickGenPassword.Text = "Quick Generate Password";
            QuickGenPassword.UseVisualStyleBackColor = false;
            QuickGenPassword.Click += QuickGenPassword_Click;
            // 
            // CreatePassword
            // 
            AcceptButton = CreateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            CancelButton = CancelButton;
            ClientSize = new Size(444, 577);
            Controls.Add(QuickGenPassword);
            Controls.Add(GeneratePassword);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(NotesInput);
            Controls.Add(label5);
            Controls.Add(iconPictureBox4);
            Controls.Add(label4);
            Controls.Add(iconPictureBox3);
            Controls.Add(SiteNameInput);
            Controls.Add(label3);
            Controls.Add(iconPictureBox2);
            Controls.Add(PasswordInput);
            Controls.Add(label2);
            Controls.Add(iconPictureBox1);
            Controls.Add(NameInput);
            Controls.Add(tableLayoutPanel1);
            Name = "CreatePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePassword";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox NameInput;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox PasswordInput;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private TextBox SiteNameInput;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private RichTextBox NotesInput;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CreateButton;
        private new Button CancelButton;
        private Button GeneratePassword;
        private Button QuickGenPassword;
    }
}