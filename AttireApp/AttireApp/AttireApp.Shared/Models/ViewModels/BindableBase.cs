/*
 * Author: Brandon Cosh
 * Date: November 22, 2022
 * 
 * Description:
 *      An abstract class that implements the INotifyPropertyChanged interface to alert the client whenever properties change to update UI.
 *      Whenever we need to add binding to a specific page (eg. Forecast Page) we should create a new class [name]ViewModel.cs and inherit 
 *      from this class. This allows the UI to update when properties are changed on the back end, without it changes won't show.
 *      
 *      SEE ForecastViewModel.cs for an example
 */
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AttireApp.Models.ViewModels
{
    /// <summary>
    /// This is the base class to be inherited by any ViewModel that needs to be able to update dynamically
    /// <para>Implements the <see cref="INotifyPropertyChanged"/> class to notify client when properties are changed</para>
    /// <para>For us, any page that needs to bind properties will likely need this class to function properly</para>
    /// </summary>
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Checks whether a propety value is changed. If value is changed, raises the <see cref="RaisePropertyChanged(string)"/> event and returns true
        /// <para>Whenever changing a property value, you should be using <see cref="SetMyProperty{T}(ref T, T, string)"/></para>
        /// <example><code>
        /// private type _myProperty;
        /// public type MyProperty {
        ///     get => return _myProperty;
        ///     set => SetMyProperty(ref _myProperty, value)
        /// }
        /// </code></example>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="backingVariable"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected virtual bool SetMyProperty<T>(ref T backingVariable, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingVariable, value)) return false; // if the values haven't changed ignore

            backingVariable = value; // otherwise change the private field backing variable..
            RaisePropertyChanged(propertyName); // ..and raise the Property Changed event to notify UI to update
            return true;
        }

        // Raised the Property Changed Event
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
