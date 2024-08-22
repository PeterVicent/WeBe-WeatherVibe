using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeBe___WeatherVibe.Classes
{
    internal class Notification
    {
        private WeBe WeBe { get; set; }

        public Notification(WeBe weBe)
            => WeBe = weBe;

        internal void ShowSuccessfulNotification(string title, string message)
        {
            WeBe.Notify.ShowBalloonTip(1000, title, message, ToolTipIcon.Info);
        }
    }
}
