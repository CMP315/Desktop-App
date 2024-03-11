namespace SecureSoftware
{
    partial class PasswordGenerator
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
            label4 = new Label();
            label1 = new Label();
            MinLengthBox = new TextBox();
            label2 = new Label();
            MaxLengthBox = new TextBox();
            label3 = new Label();
            PassOutBox = new TextBox();
            label5 = new Label();
            GenerateButton = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(100, 48, 122);
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(1036, 49);
            label4.TabIndex = 4;
            label4.Text = "PASSMAN";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 75);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 5;
            label1.Text = "Passman Secure Password Generator";
            // 
            // MinLengthBox
            // 
            MinLengthBox.Location = new Point(59, 253);
            MinLengthBox.Name = "MinLengthBox";
            MinLengthBox.Size = new Size(154, 23);
            MinLengthBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.Location = new Point(488, 429);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 14;
            // 
            // MaxLengthBox
            // 
            MaxLengthBox.Location = new Point(59, 318);
            MaxLengthBox.Name = "MaxLengthBox";
            MaxLengthBox.Size = new Size(154, 23);
            MaxLengthBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 300);
            label3.Name = "label3";
            label3.Size = new Size(156, 15);
            label3.TabIndex = 10;
            label3.Text = "Maximum Character Length";
            // 
            // PassOutBox
            // 
            PassOutBox.Location = new Point(593, 273);
            PassOutBox.Name = "PassOutBox";
            PassOutBox.ReadOnly = true;
            PassOutBox.Size = new Size(254, 23);
            PassOutBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(647, 248);
            label5.Name = "label5";
            label5.Size = new Size(149, 15);
            label5.TabIndex = 12;
            label5.Text = "Your New Secure Password";
            // 
            // GenerateButton
            // 
            GenerateButton.Location = new Point(410, 253);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(95, 43);
            GenerateButton.TabIndex = 13;
            GenerateButton.Text = "Generate Password";
            GenerateButton.UseVisualStyleBackColor = true;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 235);
            label6.Name = "label6";
            label6.Size = new Size(154, 15);
            label6.TabIndex = 15;
            label6.Text = "Minimum Character Length";
            // 
            // PasswordGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 623);
            Controls.Add(label6);
            Controls.Add(GenerateButton);
            Controls.Add(label5);
            Controls.Add(PassOutBox);
            Controls.Add(label3);
            Controls.Add(MaxLengthBox);
            Controls.Add(label2);
            Controls.Add(MinLengthBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "PasswordGenerator";
            Text = "PasswordGenerator";
            Load += PasswordGenerator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label1;
        private TextBox MinLengthBox;
        private Label label2;
        private TextBox MaxLengthBox;
        private Label label3;
        private TextBox PassOutBox;
        private Label label5;
        private Button GenerateButton;
        private Label label6;
    }
}