using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseNet.TinyAlarm.Views.Config;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class MessageAnimationOptions
        : UserControl, IAnimationConfig
    {
        public MessageAnimationOptions()
            {
            InitializeComponent();
            _cSpeed.SelectedIndex = 1;
            }

        public AnimationStyle Style {
            get => (AnimationStyle) _cStyle.CheckedItemIndex;
            set => _cStyle.CheckedItemIndex = (int) value;
        }

        public AnimationSpeed Speed {
            get => (AnimationSpeed) _cSpeed.SelectedIndex;
            set => _cSpeed.SelectedIndex = (int) value;
        }

        public bool FadeIn { get => _cFadeIn.Checked;
            set => _cFadeIn.Checked = value;
        }
    }
}