using System;
using System.Collections.Generic;

using Xamarin.Essentials;

using Xamarin.Forms;

namespace StressLessApp
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();

            double hoursToStudy = (Convert.ToDouble(Preferences.Get("credit_hours", "")) * 2) / 7.0;

            MondayText.Text = "You should study at least " + hoursToStudy + " hours today.";
        }
        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
