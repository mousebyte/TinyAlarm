using System;
using System.Drawing;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class MessageAppearanceOptions
        : UserControl, IMessageAppearanceConfig
    {
        private bool _extendedMode;

        public MessageAppearanceOptions()
            {
            InitializeComponent();
            _extendedMode = true;
            }

        public bool EnableExtendedMode {
            get => _extendedMode;
            set {
                _extendedMode = value;
                _cText.ShowFontSelect = value;
                _cTitle.ShowFontSelect = value;
                _cOpacitySlider.Enabled = value;
                _cOpacityUpDown.Enabled = value;
                _cBackgroundColor.Enabled = value;
                _lblOpacity.Enabled = value;
                _lblBackgroundColor.Enabled = value;
            }
        }

        public string MessageTitle {
            get => _cTitle.Text;
            set => _cTitle.Text = value;
        }

        public string MessageText {
            get => _cText.Text;
            set => _cText.Text = value;
        }

        public Font TitleFont {
            get => _cTitle.Font;
            set => _cTitle.Font = value;
        }

        public Font TextFont {
            get => _cText.Font;
            set => _cText.Font = value;
        }

        public Color BackgroundColor {
            get => _cBackgroundColor.Color;
            set => _cBackgroundColor.Color = value;
        }

        public double Opacity {
            get => _cOpacitySlider.Value / 100d;
            set => _cOpacitySlider.Value = (int) (value * 100);
        }

        private void OnOpacitySliderValueChanged
            (object sender,
             EventArgs e)
            {
            _cOpacityUpDown.Value = _cOpacitySlider.Value;
            }

        private void OnOpacityUpDownValueChanged
            (object sender,
             EventArgs e)
            {
            _cOpacitySlider.Value = (int) _cOpacityUpDown.Value;
            }
    }
}