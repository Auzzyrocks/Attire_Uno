using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Uno.Extensions;
using Windows.UI.Text.Core;

namespace AttireApp.Models.ViewModels
{
    class CreateAccountViewModel : AccountPreferencesViewModel
    {
        private string _username = string.Empty;
        public string Username
        {
            get => _username;
            set => SetMyProperty(ref _username, value);
        }

        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set => SetMyProperty(ref _password, value);
        }

        private string _passwordConfirm;
        public string PasswordConfirm
        {
            get => _passwordConfirm;
            set => SetMyProperty(ref _passwordConfirm, value);
        }

        private bool isValid = true;
        // validate info on submit
        public bool ValidateAccountInfo()
        {
            isValid = true;

            // if no username is specified
            if(Username.IsNullOrEmpty()) isValid = false;

            // if password is empty
            if (Password.IsNullOrEmpty()) isValid = false;

            // if passwords don't match
            if (Password != PasswordConfirm) isValid = false;

            // if location not selected
            if (LocationSelected.IsNullOrEmpty()) isValid = false;

            // if warmth pref not selected
            if (WarmthPreferenceSelected < 0) isValid = false;
            

            return isValid;
        }
    }
}
