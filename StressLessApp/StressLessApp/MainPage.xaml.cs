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

        private void PleaseAnswerButton_Clicked(object sender, EventArgs e)
        {
            PleaseAnswerLabel.IsVisible = false;
            PleaseAnswerButton.IsVisible = false;

           // Preferences.Set("has_completed_tutorial", true);
           // Console.WriteLine("Completed Tutorial: " + Preferences.Get("has_completed_tutorial", false));
        }
    }
}
