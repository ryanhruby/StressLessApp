using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace StressLessApp
{
    public partial class FoodPage : ContentPage
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        private async void NextPageButton_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("eats_breakfast", yesBreakfastButton.IsChecked);
            Preferences.Set("eats_lunch", yesLunchButton.IsChecked);
            Preferences.Set("eats_dinner", yesDinnerButton.IsChecked);

            await Navigation.PushAsync(new SleepPage());
        }
    }
}