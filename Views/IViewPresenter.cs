using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MouseNet.TinyAlarm.Forms.Controls;

namespace MouseNet.TinyAlarm.Views
{
    public interface IViewPresenter<in TView>
        where TView : IView
    {
        void Present(TView view);
    }
}