using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace PrayerApp.Views
{
    public partial class RequestPrayerPage : ContentPage
    {
        private const string DefaultUrgencyKey = "DefaultUrgency";
        private const string DefaultExpirationKey = "DefaultExpiration";

        public RequestPrayerPage()
        {
            InitializeComponent();
            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            var defaultUrgency = Preferences.Get(DefaultUrgencyKey, "Medium");
            LoadedUrgencyLabel.Text = $"Default Urgency: {defaultUrgency}";

            var defaultExpiration = Preferences.Get(DefaultExpirationKey, 7);
            LoadedExpirationLabel.Text = $"Default Expiration: {defaultExpiration} days";
        }
    }
}
