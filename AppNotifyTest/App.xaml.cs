using Microsoft.Windows.AppNotifications;
using System.Configuration;
using System.Data;
using System.Windows;

namespace AppNotifyTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppNotificationManager.Default.NotificationInvoked += (_, __) => { };
            AppNotificationManager.Default.Register();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            AppNotificationManager.Default.Unregister();
        }
    }

}
