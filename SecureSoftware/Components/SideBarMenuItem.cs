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
    public partial class SideBarMenuItem : UserControl
    {
        public SideBarMenuItem()
        {
            InitializeComponent();
        }

        #region Properties 
        private string _label;
        private FontAwesome.Sharp.IconChar _icon;
        private Color _backgroundColor;
        private Color _hoverBackgroundColor;

        [Category("Custom Props")]
        public string Label
        {
            get { return _label; }
            set { _label = value; SideBarLabel.Text = value; }
        }

        [Category("Custom Props")]
        public FontAwesome.Sharp.IconChar Icon
        {
            get { return _icon; }
            set { _icon = value; SideBarIcon.IconChar = value; }
        }

        [Category("Custom Props")]

        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; this.BackColor = value; }
        }
        #endregion
    }
}
