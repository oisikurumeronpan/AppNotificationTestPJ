using Microsoft.Windows.AppNotifications.Builder;
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
            var notification = new AppNotificationBuilder()
                .AddText("Hello!!")
                .BuildNotification();
            var doc = new Windows.Data.Xml.Dom.XmlDocument();
            doc.LoadXml(notification.Payload);
            var toast = new ToastNotification(doc);
            notifier.Show(toast);

            toast.Activated += (_, __) =>
            {
                Dispatcher.BeginInvoke(() =>
                {
                    new SuccessWindow().Show();
                });
            };
        }
    }
}