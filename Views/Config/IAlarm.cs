using System;

namespace MouseNet.TinyAlarm
{
    public interface IAlarm : ICommonAlarm
    {
        DateTime Time { get; set; }
    }
}
