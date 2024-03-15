namespace SecureSoftware.Components
{
    partial class MasterAccountUserComponent
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
            MainHorizontalTable = new TableLayoutPanel();
            TextVerticalTable = new TableLayoutPanel();
            GlobalEmail = new Label();
            GlobalUsername = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            MainHorizontalTable.SuspendLayout();
            TextVerticalTable.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // MainHorizontalTable
            // 
            MainHorizontalTable.ColumnCount = 2;
            MainHorizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 83F));
            MainHorizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainHorizontalTable.Controls.Add(TextVerticalTable, 1, 0);
            MainHorizontalTable.Controls.Add(tableLayoutPanel1, 0, 0);
            MainHorizontalTable.Dock = DockStyle.Fill;
            MainHorizontalTable.Location = new Point(0, 0);
            MainHorizontalTable.Margin = new Padding(0);
            MainHorizontalTable.Name = "MainHorizontalTable";
            MainHorizontalTable.RowCount = 1;
            MainHorizontalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainHorizontalTable.Size = new Size(727, 75);
            MainHorizontalTable.TabIndex = 0;
            // 
            // TextVerticalTable
            // 
            TextVerticalTable.ColumnCount = 1;
            TextVerticalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TextVerticalTable.Controls.Add(GlobalEmail, 0, 1);
            TextVerticalTable.Controls.Add(GlobalUsername, 0, 0);
            TextVerticalTable.Dock = DockStyle.Fill;
            TextVerticalTable.Location = new Point(86, 3);
            TextVerticalTable.Name = "TextVerticalTable";
            TextVerticalTable.RowCount = 2;
            TextVerticalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TextVerticalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TextVerticalTable.Size = new Size(638, 69);
            TextVerticalTable.TabIndex = 0;
            // 
            // GlobalEmail
            // 
            GlobalEmail.AutoSize = true;
            GlobalEmail.Dock = DockStyle.Fill;
            GlobalEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalEmail.ForeColor = SystemColors.Control;
            GlobalEmail.Location = new Point(0, 34);
            GlobalEmail.Margin = new Padding(0);
            GlobalEmail.Name = "GlobalEmail";
            GlobalEmail.Size = new Size(638, 35);
            GlobalEmail.TabIndex = 9;
            GlobalEmail.Text = "example@test.com";
            GlobalEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GlobalUsername
            // 
            GlobalUsername.AutoSize = true;
            GlobalUsername.Dock = DockStyle.Fill;
            GlobalUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalUsername.ForeColor = SystemColors.Control;
            GlobalUsername.Location = new Point(0, 0);
            GlobalUsername.Margin = new Padding(0);
            GlobalUsername.Name = "GlobalUsername";
            GlobalUsername.Size = new Size(638, 34);
            GlobalUsername.TabIndex = 8;
            GlobalUsername.Text = "Test User";
            GlobalUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(77, 69);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(77, 34);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(0, 34);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(77, 35);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // MasterAccountUserComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(MainHorizontalTable);
            Name = "MasterAccountUserComponent";
            Size = new Size(727, 75);
            MainHorizontalTable.ResumeLayout(false);
            TextVerticalTable.ResumeLayout(false);
            TextVerticalTable.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainHorizontalTable;
        private TableLayoutPanel TextVerticalTable;
        private Label GlobalEmail;
        private Label GlobalUsername;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
    }
}
