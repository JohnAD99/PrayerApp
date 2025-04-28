using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;
using System;

namespace PrayerApp.Views
{
    public partial class SettingsPage : ContentPage
    {
        private const string DefaultUrgencyKey = "DefaultUrgency";
        private const string DefaultExpirationKey = "DefaultExpiration";

        public SettingsPage()
        {
            InitializeComponent();
            LoadPreferences();
        }

        private void LoadPreferences()
        {
            var savedUrgency = Preferences.Get(DefaultUrgencyKey, "Medium");
            UrgencyPicker.SelectedItem = savedUrgency;
            SelectedUrgencyLabel.Text = $"Currently: {savedUrgency}";

            var savedExpiration = Preferences.Get(DefaultExpirationKey, 7);
            ExpirationSlider.Value = savedExpiration;
            SelectedExpirationLabel.Text = $"Currently: {savedExpiration} days";
        }

        private void UrgencyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedUrgency = picker.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedUrgency))
            {
                Preferences.Set(DefaultUrgencyKey, selectedUrgency);
                SelectedUrgencyLabel.Text = $"Currently: {selectedUrgency}";
            }
        }

        private void ExpirationSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var slider = (Slider)sender;
            var selectedExpiration = (int)e.NewValue;

            Preferences.Set(DefaultExpirationKey, selectedExpiration);
            SelectedExpirationLabel.Text = $"Currently: {selectedExpiration} days";
        }
    }
}
