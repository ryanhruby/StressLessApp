using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StressLessApp
{
    public partial class SleepPage : ContentPage
    {
        public SleepPage()
        {
            InitializeComponent();
        }

        void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double hours = e.NewValue;
            hoursOfSleep.Text = string.Format("{0} hours", hours);
        }

        private async void NextPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}