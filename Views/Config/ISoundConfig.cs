using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseNet.TinyAlarm
{
    [InterfaceCopyable]
    public interface ISoundConfig
    {
        bool PlaySound { get; set; }
        string SoundFileName { get; set; }
        float Volume { get; set; }
        bool Loop { get; set; }
    }
}