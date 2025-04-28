using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PrayerApp.Models;
using System;

namespace PrayerApp.ViewModels
{
    public class PrayerRequestsViewModel
    {
        public ObservableCollection<PrayerRequestItem> PrayerRequests { get; set; }

        public ICommand AddPrayerRequestCommand { get; }

        public PrayerRequestsViewModel()
        {
            PrayerRequests = new ObservableCollection<PrayerRequestItem>();

            AddPrayerRequestCommand = new RelayCommand(AddPrayerRequest);
        }

        private void AddPrayerRequest()
        {
            var newItem = new PrayerRequestItem
            {
                Message = $"New Prayer Request {PrayerRequests.Count + 1}: Please pray for...",
                PrayerCount = 0
            };

            PrayerRequests.Add(newItem);
        }
    }
}
