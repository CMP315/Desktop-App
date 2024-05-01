using System.ComponentModel;

namespace SecureSoftware.Components
{
    public partial class ProgressPanel : UserControl
    {
        private int Value;
        public ProgressPanel()
        {
            InitializeComponent();
        }

        #region Properties 
        private string? _label = "Loading Accounts...";
        
        [Category("Custom Props")]
        public string? LabelProp
        {
            get { return _label; }
            set { _label = value; Label.Text = value; }
        }
        
        #endregion


        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Value = Value + 10;
            if (this.Value > 100)
            {
                Timer.Dispose();
                return;
            }
            ProgressBar.Value = Value;
        }
    }
}
