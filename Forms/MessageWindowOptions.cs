using System;
using System.Drawing;
using System.Windows.Forms;
using MouseNet.TinyAlarm.Forms.Controls;

namespace MouseNet.TinyAlarm.Forms
{
    public partial class MessageWindowOptions
        : Form, IMessageWindowConfig
    {
        public MessageWindowOptions
            (AlertMessageType type)
            {
            InitializeComponent();
            //TODO: see if I can move conditional logic elsewhere
            switch (type)
                {
                case AlertMessageType.Balloon:
                    _cSize.Enabled = false;
                    _cIsSticky.Enabled = false;
                    _cIsModal.Enabled = false;
                    _cDuration.Enabled = false;
                    _lblDuration.Enabled = false;
                    _cAppearanceOptions.EnableExtendedMode = false;
                    _cAnimationOptions.Enabled = false;
                    break;
                case AlertMessageType.Dialog:
                    _lblDuration.Enabled = false;
                    _cDuration.Enabled = false;
                    _cIsSticky.Enabled = false;
                    _cAnimationOptions.Enabled = false;
                    break;
                case AlertMessageType.Notification:
                    _cIsModal.Enabled = false;
                    break;
                }
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