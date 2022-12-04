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
        private int _warmthPreferenceSelected = -1;
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

        private int _tempUnit = -1;
        public int TempUnit
        {
            get => _tempUnit;
            set => SetMyProperty(ref _tempUnit, value);
        }
    }
}
