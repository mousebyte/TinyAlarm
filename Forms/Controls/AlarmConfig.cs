using System;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class AlarmConfig : UserControl
    {
        public AlarmConfig()
            {
            InitializeComponent();
            }

        private void OnTimeChanged
            (object sender,
             EventArgs e)
            {
            if (_cTime.Value.TimeOfDay > DateTime.Now.TimeOfDay)
                _cTime.Value = DateTime.Today.AddDays(1)
                             + _cTime.Value.TimeOfDay;
            }

        public DateTime Time {
            get => _cTime.Value;
            set => _cTime.Value = value;
        }
    }
}