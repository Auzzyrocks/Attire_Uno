using AttireApp.Database.DBUser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AttireApp.Models.ViewModels
{
    class AccountPreferencesViewModel : BindableBase
    {
        public AccountPreferencesViewModel()
        {
            if (User.CurrentUser != null)
            {
                LocationSelected = User.CurrentUser.Location;
                WarmthPreferenceSelectedString = WarmthPreferenceOptions[User.CurrentUser.WarmthPref];
                TempUnitSelectedString = TempUnitPrefOptions[User.CurrentUser.TempUnit];
            }
        }
        // location preference
        private ObservableCollection<string> _locationOptions = new()
        {
            "Nanaimo", "Duncan", "Victoria", "Courtenay", "Vancouver", "Toronto", "London"
        };
        public ObservableCollection<String> LocationOptions
        {
            get => _locationOptions;
            set => SetMyProperty(ref _locationOptions, value);
        }

        private string _locationSelected = string.Empty;
        public string LocationSelected
        {
            get => _locationSelected;
            set => SetMyProperty(ref _locationSelected, value);
        }

        // warmth preference
        private ObservableCollection<string> _warmthPreferenceOptions = new()
        {
             "Dress Very Cool", "Dress Somewhat Cool", "Dress Moderately", "Dress Somewhat Warm", "Dress Very Warm"
        };
        public ObservableCollection<String> WarmthPreferenceOptions
        {
            get => _warmthPreferenceOptions;
            set => SetMyProperty(ref _warmthPreferenceOptions, value);
        }

        // warmth preference index : 0 = Very Warm,  4 = Very Cool,  2 = Moderate
        private int _warmthPreferenceSelected = -1; // -1 tells us this hasn't been initialized
        public int WarmthPreferenceSelected
        {
            get => _warmthPreferenceSelected;
            set => SetMyProperty(ref _warmthPreferenceSelected, value);
        }

        // warmth preference string
        private string _warmthPreferenceSelectedString = string.Empty;
        public string WarmthPreferenceSelectedString
        {
            get => _warmthPreferenceSelectedString;
            set => SetMyProperty(ref _warmthPreferenceSelectedString, value);
        }

        // Temp units preference
        private ObservableCollection<string> _tempUnitPrefOptions = new()
        {
            "Celsius", "Fahrenheit"
        };
        public ObservableCollection<string> TempUnitPrefOptions
        {
            get => _tempUnitPrefOptions;
            set => SetMyProperty(ref _tempUnitPrefOptions, value);
        }

        //temp unit pref index : 0 = Celsius, 1 = Fahrenheit
        private int _tempUnitSelected = -1;
        public int TempUnitSelected
        {
            get => _tempUnitSelected;
            set => SetMyProperty(ref _tempUnitSelected, value);
        }

        //temp unit pref string
        private string _tempUnitSelectedString = string.Empty;
        public string TempUnitSelectedString
        {
            get => _tempUnitSelectedString;
            set => SetMyProperty(ref _tempUnitSelectedString, value);
        }
    }
}
