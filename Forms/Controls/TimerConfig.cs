using System;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class TimerConfig : UserControl
    {
        public TimerConfig()
            {
            InitializeComponent();
            }

        public TimeSpan Interval {
            get => _cInterval.Value.TimeOfDay;
            set => _cInterval.Value = DateTime.Today + value;
        }
    }
}