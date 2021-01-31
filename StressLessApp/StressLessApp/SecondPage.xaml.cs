using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StressLessApp
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
