namespace SecureSoftware.Forms
{
    partial class ViewPassword
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
            CancelButton = new Button();
            CopyUsernameButton = new Button();
            CopyPasswordButton = new Button();
            CopySiteNameButton = new Button();
            CopyNotesButton = new Button();
            CopyCreatedAtButton = new Button();
            label6 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            CreatedAtInput = new TextBox();
            CopyLastEditedAtButton = new Button();
            label7 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            LastEditedAtInput = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
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
            tableLayoutPanel1.Size = new Size(452, 100);
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
            label1.Size = new Size(452, 100);
            label1.TabIndex = 0;
            label1.Text = "VIEW PASSWORD";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.FromArgb(236, 240, 241);
            NameInput.Enabled = false;
            NameInput.Location = new Point(16, 145);
            NameInput.Name = "NameInput";
            NameInput.ReadOnly = true;
            NameInput.Size = new Size(348, 23);
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
            PasswordInput.Enabled = false;
            PasswordInput.Location = new Point(16, 218);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.ReadOnly = true;
            PasswordInput.Size = new Size(348, 23);
            PasswordInput.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(54, 261);
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
            iconPictureBox3.Location = new Point(16, 261);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(32, 32);
            iconPictureBox3.TabIndex = 8;
            iconPictureBox3.TabStop = false;
            // 
            // SiteNameInput
            // 
            SiteNameInput.BackColor = Color.FromArgb(236, 240, 241);
            SiteNameInput.Enabled = false;
            SiteNameInput.Location = new Point(16, 294);
            SiteNameInput.Name = "SiteNameInput";
            SiteNameInput.ReadOnly = true;
            SiteNameInput.Size = new Size(348, 23);
            SiteNameInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 331);
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
            iconPictureBox4.Location = new Point(16, 331);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(231, 32);
            iconPictureBox4.TabIndex = 11;
            iconPictureBox4.TabStop = false;
            // 
            // NotesInput
            // 
            NotesInput.BackColor = Color.FromArgb(236, 240, 241);
            NotesInput.Enabled = false;
            NotesInput.Location = new Point(16, 364);
            NotesInput.Name = "NotesInput";
            NotesInput.ReadOnly = true;
            NotesInput.ScrollBars = RichTextBoxScrollBars.Vertical;
            NotesInput.Size = new Size(348, 112);
            NotesInput.TabIndex = 13;
            NotesInput.Text = "";
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
            CancelButton.Location = new Point(0, 643);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(452, 62);
            CancelButton.TabIndex = 5;
            CancelButton.Text = "Close";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CopyUsernameButton
            // 
            CopyUsernameButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyUsernameButton.Cursor = Cursors.Hand;
            CopyUsernameButton.Enabled = false;
            CopyUsernameButton.FlatAppearance.BorderColor = Color.Black;
            CopyUsernameButton.FlatAppearance.BorderSize = 0;
            CopyUsernameButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyUsernameButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyUsernameButton.FlatStyle = FlatStyle.Flat;
            CopyUsernameButton.ForeColor = Color.White;
            CopyUsernameButton.Location = new Point(363, 145);
            CopyUsernameButton.Margin = new Padding(0);
            CopyUsernameButton.Name = "CopyUsernameButton";
            CopyUsernameButton.Size = new Size(78, 23);
            CopyUsernameButton.TabIndex = 1;
            CopyUsernameButton.Text = "Copy";
            CopyUsernameButton.UseVisualStyleBackColor = false;
            CopyUsernameButton.Click += CopyUsernameButton_Click;
            // 
            // CopyPasswordButton
            // 
            CopyPasswordButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyPasswordButton.Cursor = Cursors.Hand;
            CopyPasswordButton.Enabled = false;
            CopyPasswordButton.FlatAppearance.BorderColor = Color.Black;
            CopyPasswordButton.FlatAppearance.BorderSize = 0;
            CopyPasswordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyPasswordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyPasswordButton.FlatStyle = FlatStyle.Flat;
            CopyPasswordButton.ForeColor = Color.White;
            CopyPasswordButton.Location = new Point(363, 218);
            CopyPasswordButton.Margin = new Padding(0);
            CopyPasswordButton.Name = "CopyPasswordButton";
            CopyPasswordButton.Size = new Size(78, 23);
            CopyPasswordButton.TabIndex = 2;
            CopyPasswordButton.Text = "Copy";
            CopyPasswordButton.UseVisualStyleBackColor = false;
            CopyPasswordButton.Click += CopyPasswordButton_Click;
            // 
            // CopySiteNameButton
            // 
            CopySiteNameButton.BackColor = Color.FromArgb(41, 128, 185);
            CopySiteNameButton.Cursor = Cursors.Hand;
            CopySiteNameButton.Enabled = false;
            CopySiteNameButton.FlatAppearance.BorderColor = Color.Black;
            CopySiteNameButton.FlatAppearance.BorderSize = 0;
            CopySiteNameButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopySiteNameButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopySiteNameButton.FlatStyle = FlatStyle.Flat;
            CopySiteNameButton.ForeColor = Color.White;
            CopySiteNameButton.Location = new Point(363, 294);
            CopySiteNameButton.Margin = new Padding(0);
            CopySiteNameButton.Name = "CopySiteNameButton";
            CopySiteNameButton.Size = new Size(78, 23);
            CopySiteNameButton.TabIndex = 3;
            CopySiteNameButton.Text = "Copy";
            CopySiteNameButton.UseVisualStyleBackColor = false;
            CopySiteNameButton.Click += CopySiteNameButton_Click;
            // 
            // CopyNotesButton
            // 
            CopyNotesButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyNotesButton.Cursor = Cursors.Hand;
            CopyNotesButton.Enabled = false;
            CopyNotesButton.FlatAppearance.BorderColor = Color.Black;
            CopyNotesButton.FlatAppearance.BorderSize = 0;
            CopyNotesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyNotesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyNotesButton.FlatStyle = FlatStyle.Flat;
            CopyNotesButton.ForeColor = Color.White;
            CopyNotesButton.Location = new Point(363, 363);
            CopyNotesButton.Margin = new Padding(0);
            CopyNotesButton.Name = "CopyNotesButton";
            CopyNotesButton.Size = new Size(78, 113);
            CopyNotesButton.TabIndex = 4;
            CopyNotesButton.Text = "Copy";
            CopyNotesButton.UseVisualStyleBackColor = false;
            CopyNotesButton.Click += CopyNotesButton_Click;
            // 
            // CopyCreatedAtButton
            // 
            CopyCreatedAtButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyCreatedAtButton.Cursor = Cursors.Hand;
            CopyCreatedAtButton.Enabled = false;
            CopyCreatedAtButton.FlatAppearance.BorderColor = Color.Black;
            CopyCreatedAtButton.FlatAppearance.BorderSize = 0;
            CopyCreatedAtButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyCreatedAtButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyCreatedAtButton.FlatStyle = FlatStyle.Flat;
            CopyCreatedAtButton.ForeColor = Color.White;
            CopyCreatedAtButton.Location = new Point(363, 523);
            CopyCreatedAtButton.Margin = new Padding(0);
            CopyCreatedAtButton.Name = "CopyCreatedAtButton";
            CopyCreatedAtButton.Size = new Size(78, 23);
            CopyCreatedAtButton.TabIndex = 14;
            CopyCreatedAtButton.Text = "Copy";
            CopyCreatedAtButton.UseVisualStyleBackColor = false;
            CopyCreatedAtButton.Click += CopyCreatedAtButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(54, 490);
            label6.Name = "label6";
            label6.Size = new Size(112, 30);
            label6.TabIndex = 17;
            label6.Text = "Created At";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            iconPictureBox5.IconColor = Color.White;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.Location = new Point(16, 490);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(32, 32);
            iconPictureBox5.TabIndex = 16;
            iconPictureBox5.TabStop = false;
            // 
            // CreatedAtInput
            // 
            CreatedAtInput.BackColor = Color.FromArgb(236, 240, 241);
            CreatedAtInput.Enabled = false;
            CreatedAtInput.Location = new Point(16, 523);
            CreatedAtInput.Name = "CreatedAtInput";
            CreatedAtInput.ReadOnly = true;
            CreatedAtInput.Size = new Size(348, 23);
            CreatedAtInput.TabIndex = 15;
            // 
            // CopyLastEditedAtButton
            // 
            CopyLastEditedAtButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyLastEditedAtButton.Cursor = Cursors.Hand;
            CopyLastEditedAtButton.Enabled = false;
            CopyLastEditedAtButton.FlatAppearance.BorderColor = Color.Black;
            CopyLastEditedAtButton.FlatAppearance.BorderSize = 0;
            CopyLastEditedAtButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyLastEditedAtButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyLastEditedAtButton.FlatStyle = FlatStyle.Flat;
            CopyLastEditedAtButton.ForeColor = Color.White;
            CopyLastEditedAtButton.Location = new Point(363, 594);
            CopyLastEditedAtButton.Margin = new Padding(0);
            CopyLastEditedAtButton.Name = "CopyLastEditedAtButton";
            CopyLastEditedAtButton.Size = new Size(78, 23);
            CopyLastEditedAtButton.TabIndex = 18;
            CopyLastEditedAtButton.Text = "Copy";
            CopyLastEditedAtButton.UseVisualStyleBackColor = false;
            CopyLastEditedAtButton.Click += CopyLastEditedAtButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(54, 561);
            label7.Name = "label7";
            label7.Size = new Size(141, 30);
            label7.TabIndex = 21;
            label7.Text = "Last Edited At";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = Color.White;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.Location = new Point(16, 561);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(32, 32);
            iconPictureBox6.TabIndex = 20;
            iconPictureBox6.TabStop = false;
            // 
            // LastEditedAtInput
            // 
            LastEditedAtInput.BackColor = Color.FromArgb(236, 240, 241);
            LastEditedAtInput.Enabled = false;
            LastEditedAtInput.Location = new Point(16, 594);
            LastEditedAtInput.Name = "LastEditedAtInput";
            LastEditedAtInput.ReadOnly = true;
            LastEditedAtInput.Size = new Size(348, 23);
            LastEditedAtInput.TabIndex = 19;
            // 
            // ViewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            CancelButton = CancelButton;
            ClientSize = new Size(452, 705);
            Controls.Add(CopyLastEditedAtButton);
            Controls.Add(label7);
            Controls.Add(iconPictureBox6);
            Controls.Add(LastEditedAtInput);
            Controls.Add(CopyCreatedAtButton);
            Controls.Add(label6);
            Controls.Add(iconPictureBox5);
            Controls.Add(CreatedAtInput);
            Controls.Add(CancelButton);
            Controls.Add(CopyNotesButton);
            Controls.Add(CopySiteNameButton);
            Controls.Add(CopyPasswordButton);
            Controls.Add(CopyUsernameButton);
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
            Name = "ViewPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Password";
            Load += ViewPassword_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
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
        private new Button CancelButton;
        private Button CopyUsernameButton;
        private Button CopyPasswordButton;
        private Button CopySiteNameButton;
        private Button CopyNotesButton;
        private Button CopyCreatedAtButton;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private TextBox CreatedAtInput;
        private Button CopyLastEditedAtButton;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private TextBox LastEditedAtInput;
    }
}