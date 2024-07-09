using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Windows.AppNotifications.Builder;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using Windows.ApplicationModel.Background;
using Windows.UI.Notifications;

namespace AppNotifyTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ToastNotifier notifier = ToastNotificationManager.CreateToastNotifier();

        public MainWindow()
        {
            InitializeComponent();
            notifybtn.Click += Notifybtn_Click;
        }

        private void Notifybtn_Click(object sender, RoutedEventArgs e)
        {
            var content = new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picture")
                .AddText("Check this out, The Enchantments in Washington!")
                .AddButton(new ToastButton("accept", "accept"))
                .SetToastScenario(ToastScenario.IncomingCall)
                .GetToastContent()
                .GetXml();

            var notification = new ToastNotification(content);

            notifier.Show(notification);

            notification.Activated += Notification_Activated;
            
        }

        private void Notification_Activated(ToastNotification sender, object args)
        {
            Dispatcher.BeginInvoke(() =>
            {
                new SuccessWindow().Show();
            });

        }
    }
}