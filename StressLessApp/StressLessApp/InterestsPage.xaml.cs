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
            stepper.IsEnabled = false;
            string interest = e.NewTextValue;
            _interest = interest;
        }

        void AddInterest_Clicked(System.Object sender, System.EventArgs e)
        {
            
            if (interests.Count == _numOfInterests - 1)
            {
                DisplayAlert("Success", "You have added an interest", "Done");
                interests.Add(_interest);
                _interest = string.Empty;
                interestsEntry.Text = string.Empty;
                interestsEntry.Placeholder = "All done!";
                interestsEntry.IsReadOnly = true;
            }
            else if (interests.Count < _numOfInterests)
            {
                DisplayAlert("Success", "You have added an interest", "Done");
                interests.Add(_interest);
                _interest = string.Empty;
                interestsEntry.Text = string.Empty;
                interestsEntry.Placeholder = "Type an interest here";
            }
        }

        private async void NextPageButton_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("num_of_interests", interests.Count);
            for (int i = 0; i < interests.Count; i++)
            {
                Preferences.Set(String.Format($"interest_{0}", i), interests[i]);
            }

            await Navigation.PushAsync(new HomePage());
        }


    }
}
