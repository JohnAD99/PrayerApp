using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PrayerApp.Models
{
    public class PrayerRequestItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _request;
        public string Request
        {
            get => _request;
            set
            {
                if (_request != value)
                {
                    _request = value;
                    OnPropertyChanged();
                }
            }
        }

        private int _numberOfPrayers;
        public int NumberOfPrayers
        {
            get => _numberOfPrayers;
            set
            {
                if (_numberOfPrayers != value)
                {
                    _numberOfPrayers = value;
                    OnPropertyChanged();
                }
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
