using System;
using System.Windows.Forms;
using MouseNet.TinyAlarm.Forms.Controls;
using MouseNet.TinyAlarm.Views.Config;

namespace MouseNet.TinyAlarm.Forms
{
    public partial class NewAlarmForm : Form, IAlertConfig
    {
        private const string TimerCustomFormat = "HH:mm:ss";
        private const string AlarmCustomFormat = "hh:mm tt";

        public NewAlarmForm()
            {
            InitializeComponent();
            }

        public bool IsAlarm {
            get => _cType[1];
            set => _cType[1] = value;
        }

        public bool Repeat {
            get => _cRepeat.Checked;
            set => _cRepeat.Checked = value;
        }

        public TimeSpan Interval {
            get => _cTimeInterval.Value.TimeOfDay;
            set => _cTimeInterval.Value = DateTime.Today + value;
        }

        public DateTime Time {
            get => _cTimeInterval.Value;
            set => _cTimeInterval.Value = value;
        }

        public ISoundConfig Sound {
            get => _cSoundOptions;
            set => value.CopyByInterface(_cSoundOptions);
        }

        public bool ShowMessage {
            get => _cShowMessage.Checked;
            set => _cShowMessage.Checked = value;
        }

        public AlertMessageType MessageType {
            get => (AlertMessageType) _cMessageType.CheckedItemIndex;
            set => _cMessageType[(int) value] = true;
        }

        private void OnConfigureMessageClicked
            (object sender,
             EventArgs args)
            {
            ConfigureMessageClicked?.Invoke(sender, args);
            }

        private void OnShowMessageCheckedChanged
            (object sender,
             EventArgs e)
            {
            _cMessageType.Enabled = _cShowMessage.Checked;
            _cConfigureBtn.Enabled = _cShowMessage.Checked;
            }

        private void OnTimeChanged
            (object sender,
             EventArgs e)
            {
            if (IsAlarm
             && _cTimeInterval.Value.TimeOfDay
              > DateTime.Now.TimeOfDay)
                _cTimeInterval.Value =
                    DateTime.Today.AddDays(1)
                  + _cTimeInterval.Value.TimeOfDay;
            }

        private void OnTypeChanged
            (object sender,
             EventArgs e)
            {
            if (_cType.CheckedItemIndex == 1)
                {
                _cTimeInterval.CustomFormat = AlarmCustomFormat;
                _lblTimeInterval.Text = @"Time:";
                } else
                {
                _cTimeInterval.CustomFormat = TimerCustomFormat;
                _lblTimeInterval.Text = @"Interval:";
                }
            }

        public event EventHandler ConfigureMessageClicked;
    }
}