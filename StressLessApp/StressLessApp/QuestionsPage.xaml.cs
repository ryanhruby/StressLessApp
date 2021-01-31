using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            await Navigation.PushAsync(new FoodPage());
        }
    }
}