using System;
using System.Windows.Forms;
using MouseNet.TinyAlarm.Views;

namespace MouseNet.TinyAlarm.Forms.Controls
{
    public partial class MessageOptions
        : UserControl, IMessageConfig, IMessageOptionsView
    {
        public MessageOptions()
            {
            InitializeComponent();
            }

        public bool ShowMessage {
            get => _cShowMessage.Checked;
            set => _cShowMessage.Checked = value;
        }

        public AlertMessageType MessageType {
            get => (AlertMessageType) _cMessageType.CheckedItemIndex;
            set => _cMessageType[(int) value] = true;
        }

        //TODO: Implement user control for IMessageWindowConfig
        public IMessageWindowConfig Window { get; set; }

        public event EventHandler ConfigureClicked;

        private void OnConfigureClicked
            (object sender,
             EventArgs args)
            {
            ConfigureClicked?.Invoke(sender, args);
            }
    }
}