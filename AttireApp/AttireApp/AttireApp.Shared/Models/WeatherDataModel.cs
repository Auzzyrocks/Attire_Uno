/*
 * Author: Brandon Cosh
 * Date: November 18, 2022
 */

using AttireApp.API;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;


namespace AttireApp.Models
{
    public class WeatherDataModel : ObservableObject, INotifyPropertyChanged
    {
        private Location location;
        [JsonPropertyName("location")]
        public Location Location
        {
            get => location; set => SetProperty(ref location, value);
        }

        private Current current;
        [JsonPropertyName("current")]
        public Current Current
        {
            get => current; set => SetProperty(ref current, value);
        }

        private Forecast forecast;
        [JsonPropertyName("forecast")]
        public Forecast Forecast
        {
            get => forecast; //set => SetProperty(ref forecast, value);
            set
            {
                forecast= value;
                OnPropertyChanged("Forecast");
            }
        }

        private Alerts alerts;
        [JsonPropertyName("alerts")]
        public Alerts Alerts
        {
            get => alerts; set => SetProperty(ref alerts, value);
        }

        public event PropertyChangedEventHandler PropertyChangedEV;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChangedEV?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
