namespace SecureSoftware
{
    partial class ListItem
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
            AccountName = new Label();
            AccountEmail = new Label();
            ViewPass = new Button();
            EditPass = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AccountName.Location = new Point(113, 31);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(150, 26);
            AccountName.TabIndex = 0;
            AccountName.Text = "AccountName";
            AccountName.Click += AccountName_Click;
            // 
            // AccountEmail
            // 
            AccountEmail.AutoSize = true;
            AccountEmail.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AccountEmail.Location = new Point(109, 61);
            AccountEmail.Name = "AccountEmail";
            AccountEmail.Size = new Size(154, 30);
            AccountEmail.TabIndex = 1;
            AccountEmail.Text = "AccountEmail";
            // 
            // ViewPass
            // 
            ViewPass.Location = new Point(508, 46);
            ViewPass.Name = "ViewPass";
            ViewPass.Size = new Size(101, 67);
            ViewPass.TabIndex = 2;
            ViewPass.Text = "View Password";
            ViewPass.UseVisualStyleBackColor = true;
            ViewPass.Click += ViewPass_Click;
            // 
            // EditPass
            // 
            EditPass.Location = new Point(615, 46);
            EditPass.Name = "EditPass";
            EditPass.Size = new Size(103, 67);
            EditPass.TabIndex = 3;
            EditPass.Text = "Edit Password";
            EditPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(7, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 82);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            Controls.Add(pictureBox1);
            Controls.Add(EditPass);
            Controls.Add(ViewPass);
            Controls.Add(AccountEmail);
            Controls.Add(AccountName);
            Name = "ListItem";
            Size = new Size(764, 150);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccountName;
        private Label AccountEmail;
        private Button ViewPass;
        private Button EditPass;
        private PictureBox pictureBox1;
    }
}
