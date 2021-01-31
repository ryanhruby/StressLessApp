using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace StressLessApp
{
    public partial class InterestsPage : ContentPage
    {
        public InterestsPage()
        {
            /*Console.WriteLine(Preferences.Get("credit_hours", 26.0));
            Console.WriteLine(Preferences.Get("num_of_classes", 11.0));
            Console.WriteLine(Preferences.Get("hasJob", false));
            Console.WriteLine(Preferences.Get("eats_breakfast", true));
            Console.WriteLine(Preferences.Get("eats_lunch", true));
            Console.WriteLine(Preferences.Get("eats_dinner", true));
            Console.WriteLine(Preferences.Get("ideal_num_of_sleep_hours", 0.0));*/
            InitializeComponent();
        }

        public List<string> interests = new List<String>();
        private string _interest = string.Empty;
        private double _numOfInterests = 0;

        void Stepper_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            double _interests = e.NewValue;
            numOfInterests.Text = string.Format("{0}", _interests);
            _numOfInterests = _interests;
        }

        private void InterestsEntry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            string interest = e.NewTextValue;
            _interest = interest;
        }

        void AddInterest_Clicked(System.Object sender, System.EventArgs e)
        {
            if (interests.Count <= _numOfInterests)
            {
                interests.Add(_interest);
                _interest = string.Empty;
                interestsEntry.Placeholder = "Type an interest here";
            }
        }
    }
}