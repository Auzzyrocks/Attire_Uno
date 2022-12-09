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
            User.CurrentUser.UpdateLocation(LocationSelected);                //updates the user's location in the database to reflect this change
            User.CurrentUser.UpdateWarmthPref(WarmthPreferenceSelected);      //updates the user's warmth pref in the database to reflect this change
            User.CurrentUser.UpdateTempUnit(TempUnitSelected);                //updates the user's temp unit in the database to reflect this change

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
