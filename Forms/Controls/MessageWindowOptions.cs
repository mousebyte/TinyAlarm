using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class MessageWindowOptions
        : UserControl, IMessageWindowConfig
    {
        public MessageWindowOptions()
            {
            InitializeComponent();
            }

        public bool IsModal {
            get => _cIsModal.Checked;
            set => _cIsModal.Checked = value;
        }

        public bool IsSticky {
            get => _cIsSticky.Checked;
            set => _cIsSticky.Checked = value;
        }

        public Size WindowSize {
            get => _cSize.Value;
            set => _cSize.Value = value;
        }

        public int Duration {
            get => (int) _cDuration.Value;
            set => _cDuration.Value = value;
        }

        public IMessageAppearanceConfig Appearance {
            get => _cAppearanceOptions;
            set => value.CopyByInterface(_cAppearanceOptions);
        }

        public IAnimationConfig Animation {
            get => _cAnimationOptions;
            set => value.CopyByInterface(_cAnimationOptions);
        }

        private void OnStickyCheckedChanged
            (object sender,
             EventArgs e)
            {
            _lblDuration.Enabled = !IsSticky;
            _cDuration.Enabled = !IsSticky;
            }
    }
}