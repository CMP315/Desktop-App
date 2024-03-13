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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterAccountUserComponent));
            MainHorizontalTable = new TableLayoutPanel();
            TextVerticalTable = new TableLayoutPanel();
            GlobalEmail = new Label();
            GlobalUsername = new Label();
            pictureBox1 = new PictureBox();
            MainHorizontalTable.SuspendLayout();
            TextVerticalTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainHorizontalTable
            // 
            MainHorizontalTable.ColumnCount = 2;
            MainHorizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 77F));
            MainHorizontalTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainHorizontalTable.Controls.Add(TextVerticalTable, 1, 0);
            MainHorizontalTable.Controls.Add(pictureBox1, 0, 0);
            MainHorizontalTable.Dock = DockStyle.Fill;
            MainHorizontalTable.Location = new Point(0, 0);
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
            TextVerticalTable.Location = new Point(80, 3);
            TextVerticalTable.Name = "TextVerticalTable";
            TextVerticalTable.RowCount = 2;
            TextVerticalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TextVerticalTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TextVerticalTable.Size = new Size(644, 69);
            TextVerticalTable.TabIndex = 0;
            // 
            // GlobalEmail
            // 
            GlobalEmail.AutoSize = true;
            GlobalEmail.Dock = DockStyle.Fill;
            GlobalEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalEmail.ForeColor = SystemColors.Control;
            GlobalEmail.Location = new Point(3, 34);
            GlobalEmail.Name = "GlobalEmail";
            GlobalEmail.Size = new Size(638, 35);
            GlobalEmail.TabIndex = 9;
            GlobalEmail.Text = "example@test.com";
            // 
            // GlobalUsername
            // 
            GlobalUsername.AutoSize = true;
            GlobalUsername.Dock = DockStyle.Fill;
            GlobalUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GlobalUsername.ForeColor = SystemColors.Control;
            GlobalUsername.Location = new Point(3, 0);
            GlobalUsername.Name = "GlobalUsername";
            GlobalUsername.Size = new Size(638, 34);
            GlobalUsername.TabIndex = 8;
            GlobalUsername.Text = "Test User";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainHorizontalTable;
        private TableLayoutPanel TextVerticalTable;
        private Label GlobalEmail;
        private Label GlobalUsername;
        private PictureBox pictureBox1;
    }
}
