using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AttireApp.Models.ViewModels
{
    class HomeViewModel : WeatherViewModelBase // note we inherit from WeatherViewModelBase which does similar as below but for data concerning Weather from API
    {
        // To work correctly, any variable that we want to be bindable will need a private variable; _myPropery
        // followed by a Public property; MyProperty
        // The property MUST implement a getter and setter to the private variable
        // Its important to note that the setter must use the SetMyProperty function to set the variable..
        // .. this is so an event can be raised notifying the UI it needs to update the property
        private string _myProperty;
        public string MyProperty
        {
            get => _myProperty; // notice it 'gets' the private variable
            set => SetMyProperty(ref _myProperty, value); // and 'sets' the private variable... do not set it to set itself.. will cause a loop
        }

        // Here is an example of a two way binding property
        // Its implemented the same as OneWay except in the XAML page when you bind it set the mode to TwoWay
        private string _myTwoWayProperty = string.Empty;
        public string MyTwoWayProperty
        {
            get => _myTwoWayProperty;
            set => SetMyProperty(ref _myTwoWayProperty, value);
        }

        // for normal vars that don't need to be bindable we can ignore the setters and getters and use as regular vars
        private int millisecondDelay = 4000;


        // Constructor
        public HomeViewModel()
        {
            MyProperty = $"This string was made on Initialization (wait {millisecondDelay / 1000} seconds)"; // I intialized the proprty to this string, it should appear as soon as the page loads
            DoSomeFunction(millisecondDelay); // this function will wait some amount of seconds than change the string
        }

        private async void DoSomeFunction(int milliDelay)
        {
            await Task.Delay(milliDelay); // note delay is in milliseconds
            MyProperty = "Changed value of the string, UI automatically updated"; // changed the property value, UI should automatically update
        }

        // To see why all the weather data can be bound on the home screen look at the WeatherViewModelBase class
    }
}
