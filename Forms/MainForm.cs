using System;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
            {
            InitializeComponent();
            }

        private void OnAdd
            (object sender,
             EventArgs e)
            {
            var f = new NewAlarmForm();
            f.Show(this);
            _cAlarmList.Add(new Alarm("Test", false, DateTime.Now));
            }

        private void OnRemove
            (object sender,
             EventArgs e)
            {
            _cAlarmList.RemoveSelected();
            }

        protected override void OnClosed
            (EventArgs e)
            {
            base.OnClosed(e);
            }
    }
}