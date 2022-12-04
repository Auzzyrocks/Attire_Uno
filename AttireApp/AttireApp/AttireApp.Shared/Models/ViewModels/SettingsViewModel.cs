using AttireApp.Database.DBUser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace AttireApp.Models.ViewModels
{
    class SettingsViewModel : AccountPreferencesViewModel
    {
        public event EventHandler<SettingsViewModel> SettingsChanged;
        private bool _isSavedChanges = false;
        public bool IsSavedChanges
        {
            get => _isSavedChanges;
            set => SetMyProperty(ref _isSavedChanges, value);
        }

        public string SavedChangesMsg = "Changes have been saved!";

        public void SaveChanges()
        {
            User.CurrentUser.SetTempUnit(TempUnitSelected);
            User.CurrentUser.SetLocation(LocationSelected);
            User.CurrentUser.SetWarmthPref(WarmthPreferenceSelected);

            OnSavedChanges();
        }

        private async void OnSavedChanges()
        {
            IsSavedChanges = true;
            await Task.Delay(6000);
            IsSavedChanges = false;
        }
    }
}
