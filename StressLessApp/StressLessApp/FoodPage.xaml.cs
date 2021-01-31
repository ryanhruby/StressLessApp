using System;
using System.Collections.Generic;

using Xamarin.Forms;

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
            await Navigation.PushAsync(new SleepPage());
        }
    }
}