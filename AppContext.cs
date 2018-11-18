using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseNet.TinyAlarm.Forms.Controls;
using MouseNet.TinyAlarm.Views.Config;

namespace MouseNet.TinyAlarm.Forms
{
    internal class AppContext
        : System.Windows.Forms.ApplicationContext
    {
        private readonly NotifyIcon _icon = new NotifyIcon();

        public AppContext()
            {
            _icon.Icon = Resources.tray;
            _icon.Visible = true;
            _icon.ContextMenu.MenuItems.Add("Exit",
                                            (sender,
                                             args) =>
                                                Application.Exit());
            }

        private void OnIconDoubleClick
            (object sender,
             EventArgs e)
            {
            var form = new NewAlarmForm();
            
            }

        private void ShowBalloon
            (IMessageWindowConfig config)
            {
            _icon.ShowBalloonTip(0,
                                 config.Appearance.MessageTitle,
                                 config.Appearance.MessageText,
                                 ToolTipIcon.Warning);
            }

        ~AppContext()
            {
            _icon.Dispose();
            }
    }
}