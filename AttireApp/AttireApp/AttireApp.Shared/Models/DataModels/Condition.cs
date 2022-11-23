using System;
using System.Collections.Generic;
using System.Text;
using AttireApp.Models.ViewModels;
using System.Text.Json.Serialization;

namespace AttireApp.Models.DataModels
{
    public class Condition : BindableBase
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        private string _icon;
        [JsonPropertyName("icon")]
        public string Icon
        {
            get => "https:" + _icon; // required for UI to accurately retrieve the image from web
            set => _icon = value;
        }

        [JsonPropertyName("code")]
        public int Code { get; set; }
    }
}
