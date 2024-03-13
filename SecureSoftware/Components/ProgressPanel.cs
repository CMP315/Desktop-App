using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureSoftware.Components
{
    public partial class ProgressPanel : UserControl
    {
        private int Value = 0;
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
