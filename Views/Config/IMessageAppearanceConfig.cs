using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseNet.TinyAlarm.Views.Config
{

    [InterfaceCopyable]
    public interface IMessageAppearanceConfig
    {
        string MessageTitle { get; set; }
        string MessageText { get; set; }
        Font TitleFont { get; set; }
        Font TextFont { get; set; }
        Color BackgroundColor { get; set; }
        double Opacity { get; set; }
    }
}
