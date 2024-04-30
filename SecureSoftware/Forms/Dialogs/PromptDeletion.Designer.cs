namespace SecureSoftware.Forms.Dialogs
{
    partial class PromptDeletion
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
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            ContinueButton = new Button();
            CancelButton = new Button();
            EditableLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(EditableLabel, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Size = new Size(800, 252);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(100, 48, 122);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(800, 50);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(100, 48, 122);
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(800, 50);
            label2.TabIndex = 5;
            label2.Text = "PASSMAN";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ContinueButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 152);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(800, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = Color.FromArgb(192, 57, 43);
            ContinueButton.Dock = DockStyle.Fill;
            ContinueButton.FlatAppearance.BorderSize = 0;
            ContinueButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            ContinueButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(231, 76, 60);
            ContinueButton.FlatStyle = FlatStyle.Flat;
            ContinueButton.ForeColor = Color.White;
            ContinueButton.Location = new Point(0, 0);
            ContinueButton.Margin = new Padding(0);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(400, 100);
            ContinueButton.TabIndex = 0;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.FromArgb(39, 174, 96);
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(39, 174, 96);
            CancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 204, 113);
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(400, 0);
            CancelButton.Margin = new Padding(0);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(400, 100);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Go back";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditableLabel
            // 
            EditableLabel.AutoSize = true;
            EditableLabel.Dock = DockStyle.Fill;
            EditableLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditableLabel.ForeColor = Color.White;
            EditableLabel.Location = new Point(3, 56);
            EditableLabel.MaximumSize = new Size(10000, 10000);
            EditableLabel.Name = "EditableLabel";
            EditableLabel.Size = new Size(794, 96);
            EditableLabel.TabIndex = 2;
            EditableLabel.Text = "This will be changed.";
            EditableLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PromptDeletion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 89, 182);
            ClientSize = new Size(800, 252);
            Controls.Add(tableLayoutPanel1);
            Name = "PromptDeletion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PromptDeletion";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button ContinueButton;
        private Button CancelButton;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label2;
        private Label EditableLabel;
    }
}