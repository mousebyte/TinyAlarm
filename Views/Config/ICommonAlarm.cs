using System;

namespace MouseNet.TinyAlarm
{
    public interface ICommonAlarm
    {
        string Name { get; set; }
        string Text { get; }
        Guid Id { get; }
        bool Repeat { get; set; }
    }
}
