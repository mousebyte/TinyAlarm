using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseNet.TinyAlarm.Views.Config
{

    public enum AnimationStyle
    {
        SlideUp,
        SlideLeft
    }

    public enum AnimationSpeed
    {
        Slow,
        Fast,
        VeryFast
    }
    [InterfaceCopyable]
    public interface IAnimationConfig
    {
        AnimationStyle Style { get; set; }
        AnimationSpeed Speed { get; set; }
        bool FadeIn { get; set; }
    }
}
