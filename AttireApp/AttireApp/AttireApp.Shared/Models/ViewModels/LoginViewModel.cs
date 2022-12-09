using AttireApp.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttireApp.Models.ViewModels
{
    class LoginViewModel : BindableBase
    {
        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set=> SetMyProperty(ref _password, value);
        }

        private string _username = string.Empty;
        public string Username
        {
            get => _username;
            set => SetMyProperty(ref _username, value);
        }

        private string _loginErrorMsg = String.Empty;
        public string LoginErrorMsg
        {
            get => _loginErrorMsg;
            set => SetMyProperty(ref _loginErrorMsg, value);
        }

        private bool _isFailedLogin = false;
        public bool IsFailedLogin
        {
            get => _isFailedLogin;
            set => SetMyProperty(ref _isFailedLogin, value);
        }

        public bool OnLogin()
        {
            // do your username & password validation here
            if(Login.ValidateLogin(Username, Password) == 1)
            {
                LoginErrorMsg = String.Empty;
                return true;
            } else
            {
                IsFailedLogin = true;
                LoginErrorMsg = "Incorrect username/password";
                return false;
            }
        }
    }
}
