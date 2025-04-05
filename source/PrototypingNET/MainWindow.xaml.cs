using IPUserControlsNET;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Windows;
using System.Windows.Media;

namespace PrototypingNET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [SupportedOSPlatform("windows7.0")]
    [SupportedOSPlatform("windows8.0")]
    [SupportedOSPlatform("windows8.1")]
    [SupportedOSPlatform("windows10.0")]
    [SupportedOSPlatform("windows11.0")]
    public partial class MainWindow : INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IpStatus.ConnectionStatus != ConnectionStatus.Connected)
                Connect();
            else
                Disconnect();
        }

        private void Disconnect()
        {
            // "try disconnect"

            // Disconnected!!! Change status
            IpStatus.ConnectionStatus = ConnectionStatus.Disconnected;

            IpPort.IsEnabled = true;
            IpField.IsEnabled = true;
            ConnectionButton.Content = "Connect";
        }

        private void Connect()
        {
            // "try connect"

            // Connected!!! Change status
            IpStatus.ConnectionStatus = ConnectionStatus.Connected;

            IpPort.IsEnabled = false;
            IpField.IsEnabled = false;
            ConnectionButton.Content = "Disconnect";
        }

        #region Property Notifications

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion Property Notifications

        private void OnTest4x255_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.IpAddress = "255.255.255.255";
        }

        private void OnTestColors_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.Foreground = Brushes.Red;
            this.IpField.Background = Brushes.Yellow;
            this.IpField.BorderBrush = Brushes.Green;
            this.IpField.BorderThickness = new Thickness(IpPort.PortNumber);
        }

        private void OnTestMargin_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.Margin = new Thickness(IpPort.PortNumber);
        }

        private void OnTestFontSize_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.FontSize = IpPort.PortNumber;
        }

        private void OnTestPadding_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.Padding = new Thickness(IpPort.PortNumber);
        }

        private void OnChangeWidthOfBorderClicked(object sender, RoutedEventArgs e)
        {
            this.border.Width = IpPort.PortNumber;
            
        }

        private void OnTestWidth_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.Width = IpPort.PortNumber;
        }

        private void OnTestHeight_Clicked(object sender, RoutedEventArgs e)
        {
            this.IpField.Height = IpPort.PortNumber;
        }
    }
}