using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace StressLessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuestionsPage : ContentPage
    {
        public QuestionsPage()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
          
        }

        private async void NextPageButton_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("credit_hours", CreditHourSlider.Value);
            Preferences.Set("num_of_classes", ClassesSlider.Value);
            Preferences.Set("hasJob", YesButton.IsChecked);

            await Navigation.PushAsync(new FoodPage());
        }
    }
}