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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.Location = new Point(86, 25);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(84, 15);
            AccountName.TabIndex = 0;
            AccountName.Text = "AccountName";
            // 
            // AccountEmail
            // 
            AccountEmail.AutoSize = true;
            AccountEmail.Location = new Point(89, 50);
            AccountEmail.Name = "AccountEmail";
            AccountEmail.Size = new Size(81, 15);
            AccountEmail.TabIndex = 1;
            AccountEmail.Text = "AccountEmail";
            // 
            // button1
            // 
            button1.Location = new Point(534, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(648, 46);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AccountEmail);
            Controls.Add(AccountName);
            Name = "ListItem";
            Size = new Size(764, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccountName;
        private Label AccountEmail;
        private Button button1;
        private Button button2;
    }
}
