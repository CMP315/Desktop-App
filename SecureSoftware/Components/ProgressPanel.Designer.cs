namespace SecureSoftware.Components
{
    partial class ProgressPanel
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
            components = new System.ComponentModel.Container();
            Label = new Label();
            ProgressBar = new ProgressBar();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Label.Location = new Point(0, 0);
            Label.Name = "Label";
            Label.Size = new Size(300, 35);
            Label.TabIndex = 0;
            Label.Text = "Loading Accounts...";
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(3, 38);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(564, 23);
            ProgressBar.TabIndex = 1;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 200;
            Timer.Tick += Timer_Tick;
            // 
            // ProgressPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProgressBar);
            Controls.Add(Label);
            Name = "ProgressPanel";
            Size = new Size(571, 69);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label;
        private ProgressBar ProgressBar;
        private System.Windows.Forms.Timer Timer;
    }
}
