using AttireApp.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttireApp.Models.ViewModels
{
    class LoginViewModel : WeatherViewModelBase
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

        public bool OnLogin()
        {
            // do your username & password validation here
            //Console.WriteLine(Username);
            //Console.WriteLine(Password);
            if(Login.ValidateLogin(Username, Password) == 1)
            {
                return true;
            }

            return false;
        }
    }
}
