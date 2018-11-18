using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseNet.TinyAlarm.Views.Config
{

    public enum AlertMessageType
    {
        Dialog,
        Balloon,
        Notification
    }
    public interface IAlertConfig
    {
        ISoundConfig Sound { get; set; }
        bool ShowMessage { get; set; }
        AlertMessageType MessageType { get; set; }
    }

}
