using System;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms
{
    public partial class NewAlarmForm : Form
    {
        public NewAlarmForm()
            {
            InitializeComponent();
            }

        private void OnTypeChanged
            (object sender,
             EventArgs e)
            {
            var isAlarm = _cType.CheckedItemIndex == 1;

            _cTimerConfig.Enabled = !isAlarm;
            _cTimerConfig.Visible = !isAlarm;
            _cAlarmConfig.Enabled = isAlarm;
            _cAlarmConfig.Visible = isAlarm;
            }

        public bool IsAlarm => _cType[1];

        public bool Repeat => _cRepeatCheckbox.Checked;

        public TimeSpan Interval {
            get => _cTimerConfig.Interval;
            set => _cTimerConfig.Interval = value;
        }

        public DateTime Time {
            get => _cAlarmConfig.Time;
            set => _cAlarmConfig.Time = value;
        }
    }
}