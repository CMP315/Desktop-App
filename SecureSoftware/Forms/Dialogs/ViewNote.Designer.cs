namespace SecureSoftware.Forms.Dialogs
{
    partial class ViewNote
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
            CopyContentButton = new Button();
            CopyUsernameButton = new Button();
            ContentInput = new RichTextBox();
            label5 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            NameInput = new TextBox();
            CancelButton = new Button();
            CopyLastEditedAtButton = new Button();
            label7 = new Label();
            iconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            LastEditedAtInput = new TextBox();
            CopyCreatedAtButton = new Button();
            label6 = new Label();
            iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            CreatedAtInput = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).BeginInit();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(452, 100);
            tableLayoutPanel1.TabIndex = 1;
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
            label1.Text = "VIEW NOTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CopyContentButton
            // 
            CopyContentButton.BackColor = Color.FromArgb(41, 128, 185);
            CopyContentButton.Cursor = Cursors.Hand;
            CopyContentButton.Enabled = false;
            CopyContentButton.FlatAppearance.BorderColor = Color.Black;
            CopyContentButton.FlatAppearance.BorderSize = 0;
            CopyContentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 128, 185);
            CopyContentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            CopyContentButton.FlatStyle = FlatStyle.Flat;
            CopyContentButton.ForeColor = Color.White;
            CopyContentButton.Location = new Point(361, 207);
            CopyContentButton.Margin = new Padding(0);
            CopyContentButton.Name = "CopyContentButton";
            CopyContentButton.Size = new Size(78, 295);
            CopyContentButton.TabIndex = 18;
            CopyContentButton.Text = "Copy";
            CopyContentButton.UseVisualStyleBackColor = false;
            CopyContentButton.Click += CopyContentButton_Click;
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
            CopyUsernameButton.Location = new Point(361, 143);
            CopyUsernameButton.Margin = new Padding(0);
            CopyUsernameButton.Name = "CopyUsernameButton";
            CopyUsernameButton.Size = new Size(78, 23);
            CopyUsernameButton.TabIndex = 14;
            CopyUsernameButton.Text = "Copy";
            CopyUsernameButton.UseVisualStyleBackColor = false;
            CopyUsernameButton.Click += CopyUsernameButton_Click;
            // 
            // ContentInput
            // 
            ContentInput.BackColor = Color.FromArgb(236, 240, 241);
            ContentInput.Enabled = false;
            ContentInput.Location = new Point(14, 208);
            ContentInput.Name = "ContentInput";
            ContentInput.ReadOnly = true;
            ContentInput.ScrollBars = RichTextBoxScrollBars.Vertical;
            ContentInput.Size = new Size(348, 294);
            ContentInput.TabIndex = 21;
            ContentInput.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(52, 175);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 20;
            label5.Text = "Content";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.Location = new Point(14, 175);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(231, 32);
            iconPictureBox4.TabIndex = 19;
            iconPictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(52, 110);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 17;
            label2.Text = "Name";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(14, 110);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 16;
            iconPictureBox1.TabStop = false;
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.FromArgb(236, 240, 241);
            NameInput.Enabled = false;
            NameInput.Location = new Point(14, 143);
            NameInput.Name = "NameInput";
            NameInput.ReadOnly = true;
            NameInput.Size = new Size(348, 23);
            NameInput.TabIndex = 15;
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
            CancelButton.Location = new Point(0, 654);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(452, 62);
            CancelButton.TabIndex = 22;
            CancelButton.Text = "Close";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
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
            CopyLastEditedAtButton.Location = new Point(361, 618);
            CopyLastEditedAtButton.Margin = new Padding(0);
            CopyLastEditedAtButton.Name = "CopyLastEditedAtButton";
            CopyLastEditedAtButton.Size = new Size(78, 23);
            CopyLastEditedAtButton.TabIndex = 27;
            CopyLastEditedAtButton.Text = "Copy";
            CopyLastEditedAtButton.UseVisualStyleBackColor = false;
            CopyLastEditedAtButton.Click += CopyLastEditedAtButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(52, 585);
            label7.Name = "label7";
            label7.Size = new Size(141, 30);
            label7.TabIndex = 30;
            label7.Text = "Last Edited At";
            // 
            // iconPictureBox6
            // 
            iconPictureBox6.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconPictureBox6.IconColor = Color.White;
            iconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox6.Location = new Point(14, 585);
            iconPictureBox6.Name = "iconPictureBox6";
            iconPictureBox6.Size = new Size(32, 32);
            iconPictureBox6.TabIndex = 29;
            iconPictureBox6.TabStop = false;
            // 
            // LastEditedAtInput
            // 
            LastEditedAtInput.BackColor = Color.FromArgb(236, 240, 241);
            LastEditedAtInput.Enabled = false;
            LastEditedAtInput.Location = new Point(14, 618);
            LastEditedAtInput.Name = "LastEditedAtInput";
            LastEditedAtInput.ReadOnly = true;
            LastEditedAtInput.Size = new Size(348, 23);
            LastEditedAtInput.TabIndex = 28;
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
            CopyCreatedAtButton.Location = new Point(361, 547);
            CopyCreatedAtButton.Margin = new Padding(0);
            CopyCreatedAtButton.Name = "CopyCreatedAtButton";
            CopyCreatedAtButton.Size = new Size(78, 23);
            CopyCreatedAtButton.TabIndex = 23;
            CopyCreatedAtButton.Text = "Copy";
            CopyCreatedAtButton.UseVisualStyleBackColor = false;
            CopyCreatedAtButton.Click += CopyCreatedAtButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(52, 514);
            label6.Name = "label6";
            label6.Size = new Size(112, 30);
            label6.TabIndex = 26;
            label6.Text = "Created At";
            // 
            // iconPictureBox5
            // 
            iconPictureBox5.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            iconPictureBox5.IconColor = Color.White;
            iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox5.Location = new Point(14, 514);
            iconPictureBox5.Name = "iconPictureBox5";
            iconPictureBox5.Size = new Size(32, 32);
            iconPictureBox5.TabIndex = 25;
            iconPictureBox5.TabStop = false;
            // 
            // CreatedAtInput
            // 
            CreatedAtInput.BackColor = Color.FromArgb(236, 240, 241);
            CreatedAtInput.Enabled = false;
            CreatedAtInput.Location = new Point(14, 547);
            CreatedAtInput.Name = "CreatedAtInput";
            CreatedAtInput.ReadOnly = true;
            CreatedAtInput.Size = new Size(348, 23);
            CreatedAtInput.TabIndex = 24;
            // 
            // ViewNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            CancelButton = CancelButton;
            ClientSize = new Size(452, 716);
            Controls.Add(CopyLastEditedAtButton);
            Controls.Add(label7);
            Controls.Add(iconPictureBox6);
            Controls.Add(LastEditedAtInput);
            Controls.Add(CopyCreatedAtButton);
            Controls.Add(label6);
            Controls.Add(iconPictureBox5);
            Controls.Add(CreatedAtInput);
            Controls.Add(CancelButton);
            Controls.Add(CopyContentButton);
            Controls.Add(CopyUsernameButton);
            Controls.Add(ContentInput);
            Controls.Add(label5);
            Controls.Add(iconPictureBox4);
            Controls.Add(label2);
            Controls.Add(iconPictureBox1);
            Controls.Add(NameInput);
            Controls.Add(tableLayoutPanel1);
            Name = "ViewNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewNote";
            Load += ViewNote_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button CopyContentButton;
        private Button CopyUsernameButton;
        private RichTextBox ContentInput;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox NameInput;
        private Button CancelButton;
        private Button CopyLastEditedAtButton;
        private Label label7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox6;
        private TextBox LastEditedAtInput;
        private Button CopyCreatedAtButton;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private TextBox CreatedAtInput;
    }
}