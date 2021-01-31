using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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
            
        }
    }
}
