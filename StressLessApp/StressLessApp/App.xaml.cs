using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace StressLessApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Preferences.Clear();

            OnStart();
        }

        protected override void OnStart()
        {
            var has_completed_tutorial = Preferences.Get("has_completed_tutorial", false);

            if (!has_completed_tutorial)
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new HomePage();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
