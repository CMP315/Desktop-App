namespace SecureSoftware.Forms
{
    partial class VerifyPassword
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
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            ContextMenuButtonsTable = new TableLayoutPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            MinimizeButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            CurrentPasswordInput = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label5 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            NewPasswordInput = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ConfirmButton = new Button();
            CancelButton = new Button();
            tableLayoutPanel3.SuspendLayout();
            ContextMenuButtonsTable.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
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
            label4.Size = new Size(50, 100);
            label4.TabIndex = 5;
            label4.Text = "PASSMAN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ContextMenuButtonsTable
            // 
            ContextMenuButtonsTable.ColumnCount = 3;
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ContextMenuButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ContextMenuButtonsTable.Controls.Add(iconButton1, 2, 0);
            ContextMenuButtonsTable.Controls.Add(MinimizeButton, 0, 0);
            ContextMenuButtonsTable.Location = new Point(50, 0);
            ContextMenuButtonsTable.Margin = new Padding(0);
            ContextMenuButtonsTable.Name = "ContextMenuButtonsTable";
            ContextMenuButtonsTable.RowCount = 1;
            ContextMenuButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ContextMenuButtonsTable.Size = new Size(150, 46);
            ContextMenuButtonsTable.TabIndex = 4;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(192, 57, 43);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Fill;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(103, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(44, 40);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.BackColor = Color.FromArgb(243, 156, 18);
            MinimizeButton.Dock = DockStyle.Fill;
            MinimizeButton.FlatAppearance.BorderSize = 0;
            MinimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(243, 156, 18);
            MinimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 196, 15);
            MinimizeButton.FlatStyle = FlatStyle.Flat;
            MinimizeButton.ForeColor = SystemColors.ControlText;
            MinimizeButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            MinimizeButton.IconColor = Color.Black;
            MinimizeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MinimizeButton.Location = new Point(3, 3);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(44, 40);
            MinimizeButton.TabIndex = 5;
            MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 53);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(100, 48, 122);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(510, 53);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(100, 48, 122);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(510, 53);
            label1.TabIndex = 5;
            label1.Text = "PASSMAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(155, 89, 182);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel4);
            flowLayoutPanel1.Controls.Add(CurrentPasswordInput);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel5);
            flowLayoutPanel1.Controls.Add(NewPasswordInput);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 53);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(20, 10, 0, 0);
            flowLayoutPanel1.Size = new Size(510, 216);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.919571F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.08043F));
            tableLayoutPanel4.Controls.Add(label2, 1, 0);
            tableLayoutPanel4.Controls.Add(iconPictureBox1, 0, 0);
            tableLayoutPanel4.Location = new Point(23, 13);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(373, 35);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 0);
            label2.Name = "label2";
            label2.Size = new Size(330, 35);
            label2.TabIndex = 0;
            label2.Text = "Enter your current Master Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox1.Dock = DockStyle.Fill;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 35;
            iconPictureBox1.Location = new Point(0, 0);
            iconPictureBox1.Margin = new Padding(0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(37, 35);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // CurrentPasswordInput
            // 
            CurrentPasswordInput.Location = new Point(23, 54);
            CurrentPasswordInput.Margin = new Padding(3, 3, 3, 10);
            CurrentPasswordInput.Name = "CurrentPasswordInput";
            CurrentPasswordInput.Size = new Size(464, 23);
            CurrentPasswordInput.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.919571F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.08043F));
            tableLayoutPanel5.Controls.Add(label5, 1, 0);
            tableLayoutPanel5.Controls.Add(iconPictureBox2, 0, 0);
            tableLayoutPanel5.Location = new Point(23, 90);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(373, 35);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 0);
            label5.Name = "label5";
            label5.Size = new Size(330, 35);
            label5.TabIndex = 0;
            label5.Text = "Enter your new Master Password";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(155, 89, 182);
            iconPictureBox2.Dock = DockStyle.Fill;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 35;
            iconPictureBox2.Location = new Point(0, 0);
            iconPictureBox2.Margin = new Padding(0);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(37, 35);
            iconPictureBox2.TabIndex = 1;
            iconPictureBox2.TabStop = false;
            // 
            // NewPasswordInput
            // 
            NewPasswordInput.Location = new Point(23, 131);
            NewPasswordInput.Name = "NewPasswordInput";
            NewPasswordInput.Size = new Size(464, 23);
            NewPasswordInput.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ConfirmButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 218);
            tableLayoutPanel2.Margin = new Padding(1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(510, 51);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.FromArgb(39, 174, 96);
            ConfirmButton.Dock = DockStyle.Fill;
            ConfirmButton.FlatAppearance.BorderSize = 0;
            ConfirmButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            ConfirmButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            ConfirmButton.FlatStyle = FlatStyle.Flat;
            ConfirmButton.ForeColor = Color.White;
            ConfirmButton.Location = new Point(0, 0);
            ConfirmButton.Margin = new Padding(0);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(255, 51);
            ConfirmButton.TabIndex = 0;
            ConfirmButton.Text = "CONFIRM CHANGE";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(192, 57, 43);
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(255, 0);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(255, 51);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "CANCEL CHANGE";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // VerifyPassword
            // 
            AcceptButton = ConfirmButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = CancelButton;
            ClientSize = new Size(510, 269);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "VerifyPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerifyPassword";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ContextMenuButtonsTable.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private TableLayoutPanel ContextMenuButtonsTable;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton MinimizeButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox CurrentPasswordInput;
        private TextBox NewPasswordInput;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ConfirmButton;
        private Button CancelButton;
        private TableLayoutPanel tableLayoutPanel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}