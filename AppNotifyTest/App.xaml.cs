using Microsoft.Toolkit.Uwp.Notifications;
using System.Windows;

namespace AppNotifyTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ToastNotificationManagerCompat.OnActivated += toastArgs => { };
        }
    }

}
