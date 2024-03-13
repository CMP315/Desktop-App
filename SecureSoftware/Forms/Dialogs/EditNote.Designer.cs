namespace SecureSoftware.Forms.Dialogs
{
    partial class EditNote
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
            ContentInput = new RichTextBox();
            label5 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            NameInput = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            CreateButton = new Button();
            CancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            label1.Size = new Size(444, 100);
            label1.TabIndex = 0;
            label1.Text = "EDIT NOTE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContentInput
            // 
            ContentInput.BackColor = Color.FromArgb(236, 240, 241);
            ContentInput.Enabled = false;
            ContentInput.Location = new Point(16, 217);
            ContentInput.Name = "ContentInput";
            ContentInput.ScrollBars = RichTextBoxScrollBars.Vertical;
            ContentInput.Size = new Size(413, 159);
            ContentInput.TabIndex = 25;
            ContentInput.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 184);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 24;
            label5.Text = "Content";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Pen;
            iconPictureBox4.IconColor = Color.White;
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.Location = new Point(16, 184);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(231, 32);
            iconPictureBox4.TabIndex = 23;
            iconPictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(54, 111);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 22;
            label2.Text = "Name";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(16, 111);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 21;
            iconPictureBox1.TabStop = false;
            // 
            // NameInput
            // 
            NameInput.BackColor = Color.FromArgb(236, 240, 241);
            NameInput.Enabled = false;
            NameInput.Location = new Point(16, 144);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(413, 23);
            NameInput.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.DarkViolet;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CreateButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 392);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(444, 62);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // CreateButton
            // 
            CreateButton.BackColor = Color.FromArgb(39, 174, 96);
            CreateButton.Cursor = Cursors.Hand;
            CreateButton.Dock = DockStyle.Fill;
            CreateButton.FlatAppearance.BorderColor = Color.BlanchedAlmond;
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
            CreateButton.Text = "Save";
            CreateButton.UseVisualStyleBackColor = false;
            CreateButton.Click += CreateButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 57, 43);
            CancelButton.Cursor = Cursors.Hand;
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderColor = Color.BlanchedAlmond;
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
            // EditNote
            // 
            AcceptButton = CreateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            CancelButton = CancelButton;
            ClientSize = new Size(444, 454);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(ContentInput);
            Controls.Add(label5);
            Controls.Add(iconPictureBox4);
            Controls.Add(label2);
            Controls.Add(iconPictureBox1);
            Controls.Add(NameInput);
            Controls.Add(tableLayoutPanel1);
            Name = "EditNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditNote";
            Load += EditNote_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private RichTextBox ContentInput;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox NameInput;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CreateButton;
        private Button CancelButton;
    }
}