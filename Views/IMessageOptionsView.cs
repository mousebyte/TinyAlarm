using System;
using MouseNet.TinyAlarm.Views;

namespace MouseNet.TinyAlarm.Views {
    public interface IMessageOptionsView : IView
    {
        event EventHandler ConfigureClicked;
    }
}