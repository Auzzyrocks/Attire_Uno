using AttireApp.Database.DBUser;
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

        private bool _isValidUsername = true;
        public bool IsValidUsername
        {
            get=> _isValidUsername;
            set=> SetMyProperty(ref _isValidUsername, value);
        }

        // validate info on submit
        public bool ValidateAccountInfo()
        {
            IsError = false;
            _isValidUsername = true;

            // if no username is specified
            if(Username.IsNullOrEmpty())
            {
                ErrorMsgText = "Please Enter a Username";
                IsError = true;
                return false;
            }

            // if password is empty
            if (Password.IsNullOrEmpty())
            {
                ErrorMsgText = "Please Enter a Password";
                IsError = true;
                return false;
            }

            // if passwords don't match
            if (Password != PasswordConfirm)
            {
                ErrorMsgText = "Passwords Need to Match";
                IsError = true;
                return false;
            }

            // if location not selected
            if (LocationSelected.IsNullOrEmpty())
            {
                ErrorMsgText = "Please Select a Location";
                IsError = true;
                return false;
            }

            // if warmth pref not selected
            if (WarmthPreferenceSelected < 0)
            {
                ErrorMsgText = "Please Select a Warmth Preference";
                IsError = true;
                return false;
            }

            if(TempUnitSelected < 0)
            {
                ErrorMsgText = "Please Select a Temperature Unit Preference";
                IsError = true;
                return false;
            }


            return true;
        }

        public User CreateUser()
        {
            // User(string username, string password, string email, string firstname, string lastname, string location, int tempunit, int warmthpref)
            User newUser = new User(Username, Password, Username + "@mail.com", "First Name", "Last Name",
                LocationSelected, TempUnitSelected, WarmthPreferenceSelected);

            if (newUser.HashEmail == null) // constructor still creates a user, but all internal values are null
            {
                IsError = true;
                ErrorMsgText = $"Username '{Username}' is Already Taken, Please Try Something Else.";
                return null; // user was not created 
            }
            return newUser;
        }

        private bool _isError = false;
        public bool IsError
        {
            get => _isError;
            set => SetMyProperty(ref _isError, value);
        }

        private string _errorMsgText = string.Empty;
        public string ErrorMsgText
        {
            get => _errorMsgText;
            set => SetMyProperty(ref _errorMsgText, value);
        }
    }
}
