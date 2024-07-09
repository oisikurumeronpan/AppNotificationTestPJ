using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Windows.AppLifecycle;
using Microsoft.Windows.AppNotifications;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;
using Windows.Foundation.Collections;

namespace AppNotifyTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            AppNotificationManager.Default.NotificationInvoked += (s, e) => { };
            AppNotificationManager.Default.Register();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ToastNotificationManagerCompat.OnActivated += toastArgs =>
            {
                ToastArguments args = ToastArguments.Parse(toastArgs.Argument);
                Debug.WriteLine(args);
            };
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            AppNotificationManager.Default.Unregister();
        }
    }

}
