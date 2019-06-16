using Shadowsocks.Controller;
using System.Windows;

namespace Shadowsocks.View
{
    public partial class ConfigWindow
    {
        public ConfigWindow(ShadowsocksController controller, UpdateChecker updateChecker, int focusIndex)
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ServerIpTextBox.Text = @"us01.bige0.com";
        }

        public void SetServerListSelectedIndex(int index)
        {

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
