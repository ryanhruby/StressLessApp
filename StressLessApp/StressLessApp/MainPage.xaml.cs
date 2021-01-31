using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace StressLessApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void WelcomeButton_Clicked(object sender, EventArgs e)
        {
            WelcomeLabel.IsVisible = false;
            WelcomeButton.IsVisible = false;

            PleaseAnswerLabel.IsVisible = true;
            PleaseAnswerButton.IsVisible = true;
        }

        private async void PleaseAnswerButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionsPage());
        }
    }
}
