using System;

namespace MouseNet.TinyAlarm
{
    internal class Alarm : IAlarm
    {
        public Alarm
            (string name,
             bool repeat,
             DateTime time)
            {
            Name = name;
            Repeat = repeat;
            Time = time;
            Id = Guid.NewGuid();
            }

        public string Name { get; set; }
        public string Text => Time.ToString($"hh:mm tt");
        public Guid Id { get; }
        public bool Repeat { get; set; }
        public DateTime Time { get; set; }
    }
    
}