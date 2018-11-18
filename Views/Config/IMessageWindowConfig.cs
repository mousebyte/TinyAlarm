using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseNet.TinyAlarm.Views.Config
{

    [InterfaceCopyable]
    public interface IMessageWindowConfig
    {
        bool IsModal { get; set; }
        bool IsSticky { get; set; }
        Size WindowSize { get; set; }
        int Duration { get; set; }
        IMessageAppearanceConfig Appearance { get; set; }
        IAnimationConfig Animation { get; set; }
    }
}
