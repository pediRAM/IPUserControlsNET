using IPUserControlsNET.MAUI;

namespace PrototypingNET.MAUI
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            
            var rnd = new Random(DateTime.Now.Millisecond);
            //ipField.IpAddress = $"{rnd.Next(0, 255)}.{rnd.Next(0, 255)}.{rnd.Next(0, 255)}.{rnd.Next(0, 255)}";
        }

        private async void OnTestClicked(object sender, EventArgs e)
        {
            if (entryText.Text != null && entryText.Text.IsValidIpAddress())
            {
                ipField.IpAddress = entryText.Text;
                await DisplayAlert("Success", $"Current ip address:\n{ipField.IpAddress}", "OK");
            }
            else
            {
                await DisplayAlert("Error", $"Invalid or no ip address:\n'{entryText.Text}' !", "OK");
            }
            
        }
    }

}
