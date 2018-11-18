using System;
using System.Windows.Forms;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class AlarmList : UserControl
    {
        public AlarmList()
            {
            InitializeComponent();
            }

        private int NameColumnWidth {
            get {
                var width = _cListView.Columns[0].Width =
                                _cListView.Width
                              - _cListView.Columns[1].Width
                              - 4;
                if (_cListView.IsVerticalScrollVisible())
                    width -= SystemInformation.VerticalScrollBarWidth;
                return width;
            }
        }

        public event Action<int> AlarmNameChanged;

        private void OnColumnWidthChanging
            (object sender,
             ColumnWidthChangingEventArgs e)
            {
            e.NewWidth = _cListView.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
            }

        private void OnResize
            (object sender,
             EventArgs e)
            {
            _cListView.Columns[0].Width = NameColumnWidth;
            }

        private void OnAfterLabelEdit
            (object sender,
             LabelEditEventArgs e)
            {
            SendAlarmNameChanged((int) _cListView.Items[e.Item].Tag);
            }

        public void Add
            (IAlarm alarm)
            {
            MakeItem(alarm, _cListView.Groups[1]);
            }

        public void Add
            (ITimer timer)
            {
            MakeItem(timer, _cListView.Groups[0]);
            }

        private void MakeItem
            (ICommonAlarm alarm, ListViewGroup group)
            {
            var item = new ListViewItem(alarm.Name)
                {
                Tag = alarm.Id,
                Group = group
                };
            item.SubItems.Add(alarm.Text);
            _cListView.Items.Add(item);
            _cListView.Columns[0].Width = NameColumnWidth;
            }

        public void Remove
            (ICommonAlarm alarm)
            {
            _cListView.Items.RemoveByKey(alarm.Name);
            _cListView.Columns[0].Width = NameColumnWidth;
            }

        public void RemoveSelected()
            {
            if (_cListView.SelectedIndices.Count == 0) return;
            _cListView.Items.RemoveAt(_cListView.SelectedIndices[0]);
            _cListView.Columns[0].Width = NameColumnWidth;
        }

        protected virtual void SendAlarmNameChanged
            (int obj)
            {
            AlarmNameChanged?.Invoke(obj);
            }
    }
}