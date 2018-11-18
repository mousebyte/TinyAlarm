using System;

namespace MouseNet.TinyAlarm
{
    public interface ITimer : ICommonAlarm
    {
        DateTimeOffset Duration { get; set; }
    }
}