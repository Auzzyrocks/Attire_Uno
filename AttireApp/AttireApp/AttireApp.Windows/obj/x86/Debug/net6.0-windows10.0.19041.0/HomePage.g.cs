﻿#pragma checksum "C:\Users\Smile\Source\Repos\attire_uno\AttireApp\AttireApp\AttireApp.Shared\HomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0EA740E253144252E788934611BB6C9CA40F727B1B3FC7DBC32F887CA3422930"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttireApp
{
    partial class HomePage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBox_Text(global::Microsoft.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class HomePage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IHomePage_Bindings
        {
            private global::AttireApp.HomePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj5;
            private global::Microsoft.UI.Xaml.Controls.TextBox obj6;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj7;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj9;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj5TextDisabled = false;
            private static bool isobj6TextDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj9TextDisabled = false;
            private static bool isobj10TextDisabled = false;

            private HomePage_obj1_BindingsTracking bindingsTracking;

            public HomePage_obj1_Bindings()
            {
                this.bindingsTracking = new HomePage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 50 && columnNumber == 28)
                {
                    isobj5TextDisabled = true;
                }
                else if (lineNumber == 51 && columnNumber == 77)
                {
                    isobj6TextDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 42)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 33 && columnNumber == 28)
                {
                    isobj9TextDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 28)
                {
                    isobj10TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // HomePage.xaml line 50
                        this.obj5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 6: // HomePage.xaml line 51
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBox>(target);
                        this.bindingsTracking.RegisterTwoWayListener_6(this.obj6);
                        break;
                    case 7: // HomePage.xaml line 52
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        this.bindingsTracking.RegisterTwoWayListener_7(this.obj7);
                        break;
                    case 9: // HomePage.xaml line 33
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        this.bindingsTracking.RegisterTwoWayListener_9(this.obj9);
                        break;
                    case 10: // HomePage.xaml line 35
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IHomePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AttireApp.HomePage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AttireApp.HomePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::AttireApp.Models.ViewModels.HomeViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_MyProperty(obj.MyProperty, phase);
                        this.Update_ViewModel_MyTwoWayProperty(obj.MyTwoWayProperty, phase);
                        this.Update_ViewModel_WeatherData(obj.WeatherData, phase);
                    }
                }
            }
            private void Update_ViewModel_MyProperty(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // HomePage.xaml line 50
                    if (!isobj5TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                    }
                }
            }
            private void Update_ViewModel_MyTwoWayProperty(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // HomePage.xaml line 51
                    if (!isobj6TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBox_Text(this.obj6, obj, null);
                    }
                    // HomePage.xaml line 52
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_ViewModel_WeatherData(global::AttireApp.Models.DataModels.RootWeatherData obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_WeatherData(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_WeatherData_Location(obj.Location, phase);
                    }
                }
            }
            private void Update_ViewModel_WeatherData_Location(global::AttireApp.Models.DataModels.Location obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_WeatherData_Location(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_WeatherData_Location_Name(obj.Name, phase);
                        this.Update_ViewModel_WeatherData_Location_Region(obj.Region, phase);
                    }
                }
            }
            private void Update_ViewModel_WeatherData_Location_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // HomePage.xaml line 33
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
            private void Update_ViewModel_WeatherData_Location_Region(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // HomePage.xaml line 35
                    if (!isobj10TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_6_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.MyTwoWayProperty = this.obj6.Text;
                        }
                    }
                }
            }
            private void UpdateTwoWay_7_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.MyTwoWayProperty = this.obj7.Text;
                        }
                    }
                }
            }
            private void UpdateTwoWay_9_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            if (this.dataRoot.ViewModel.WeatherData != null)
                            {
                                if (this.dataRoot.ViewModel.WeatherData.Location != null)
                                {
                                    this.dataRoot.ViewModel.WeatherData.Location.Name = this.obj9.Text;
                                }
                            }
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class HomePage_obj1_BindingsTracking
            {
                private global::System.WeakReference<HomePage_obj1_Bindings> weakRefToBindingObj; 

                public HomePage_obj1_BindingsTracking(HomePage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<HomePage_obj1_Bindings>(obj);
                }

                public HomePage_obj1_Bindings TryGetBindingObject()
                {
                    HomePage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_WeatherData(null);
                    UpdateChildListeners_ViewModel_WeatherData_Location(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::AttireApp.Models.ViewModels.HomeViewModel obj = sender as global::AttireApp.Models.ViewModels.HomeViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_MyProperty(obj.MyProperty, DATA_CHANGED);
                                bindings.Update_ViewModel_MyTwoWayProperty(obj.MyTwoWayProperty, DATA_CHANGED);
                                bindings.Update_ViewModel_WeatherData(obj.WeatherData, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "MyProperty":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_MyProperty(obj.MyProperty, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "MyTwoWayProperty":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_MyTwoWayProperty(obj.MyTwoWayProperty, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "WeatherData":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_WeatherData(obj.WeatherData, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::AttireApp.Models.ViewModels.HomeViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::AttireApp.Models.ViewModels.HomeViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_WeatherData(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::AttireApp.Models.DataModels.RootWeatherData obj = sender as global::AttireApp.Models.DataModels.RootWeatherData;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_WeatherData_Location(obj.Location, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Location":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_WeatherData_Location(obj.Location, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::AttireApp.Models.DataModels.RootWeatherData cache_ViewModel_WeatherData = null;
                public void UpdateChildListeners_ViewModel_WeatherData(global::AttireApp.Models.DataModels.RootWeatherData obj)
                {
                    if (obj != cache_ViewModel_WeatherData)
                    {
                        if (cache_ViewModel_WeatherData != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_WeatherData).PropertyChanged -= PropertyChanged_ViewModel_WeatherData;
                            cache_ViewModel_WeatherData = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_WeatherData = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_WeatherData;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_WeatherData_Location(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    HomePage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::AttireApp.Models.DataModels.Location obj = sender as global::AttireApp.Models.DataModels.Location;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_WeatherData_Location_Name(obj.Name, DATA_CHANGED);
                                bindings.Update_ViewModel_WeatherData_Location_Region(obj.Region, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Name":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_WeatherData_Location_Name(obj.Name, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Region":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_WeatherData_Location_Region(obj.Region, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::AttireApp.Models.DataModels.Location cache_ViewModel_WeatherData_Location = null;
                public void UpdateChildListeners_ViewModel_WeatherData_Location(global::AttireApp.Models.DataModels.Location obj)
                {
                    if (obj != cache_ViewModel_WeatherData_Location)
                    {
                        if (cache_ViewModel_WeatherData_Location != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_WeatherData_Location).PropertyChanged -= PropertyChanged_ViewModel_WeatherData_Location;
                            cache_ViewModel_WeatherData_Location = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_WeatherData_Location = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_WeatherData_Location;
                        }
                    }
                }
                public void RegisterTwoWayListener_6(global::Microsoft.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_6_Text();
                        }
                    };
                }
                public void RegisterTwoWayListener_7(global::Microsoft.UI.Xaml.Controls.TextBlock sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.TextBlock.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_7_Text();
                        }
                    });
                }
                public void RegisterTwoWayListener_9(global::Microsoft.UI.Xaml.Controls.TextBlock sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Microsoft.UI.Xaml.Controls.TextBlock.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_9_Text();
                        }
                    });
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // HomePage.xaml line 17
                {
                    this.ViewModel = global::WinRT.CastExtensions.As<global::AttireApp.Models.ViewModels.HomeViewModel>(target);
                }
                break;
            case 3: // HomePage.xaml line 59
                {
                    global::Microsoft.UI.Xaml.Controls.Button element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element3).Click += this.SettingsPage_Click;
                }
                break;
            case 4: // HomePage.xaml line 63
                {
                    global::Microsoft.UI.Xaml.Controls.Button element4 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element4).Click += this.ForecastPage_Click;
                }
                break;
            case 8: // HomePage.xaml line 53
                {
                    global::Microsoft.UI.Xaml.Controls.Button element8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element8).Click += this.ShowTwoWayBind_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // HomePage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    HomePage_obj1_Bindings bindings = new HomePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

