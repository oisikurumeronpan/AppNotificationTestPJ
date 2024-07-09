using Microsoft.Toolkit.Uwp.Notifications;
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
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picture")
                .AddText("Check this out, The Enchantments in Washington!")
                .Show();
        }
    }
}