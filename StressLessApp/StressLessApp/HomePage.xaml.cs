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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            Console.WriteLine(Preferences.Get("num_of_interests", -1));
            for (int i = 0; i < Preferences.Get("num_of_interests", -1); i++)
            {
                Console.WriteLine(Preferences.Get(String.Format($"interest_{0}", i), "No interest"));
            }


            InitializeComponent();
        }
    }
}