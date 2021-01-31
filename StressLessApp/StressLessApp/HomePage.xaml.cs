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
    public partial class HomePage : ContentPage
    {
        System.Timers.Timer timer = new System.Timers.Timer(1000);
        TimeSpan time = new TimeSpan();
        int i = 0;

        public HomePage()
        {
            InitializeComponent();
            timer.Elapsed += Start_Timer;
        }

        private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }

        private void Start_Timer(Object sender, System.EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();

            Device.BeginInvokeOnMainThread(() =>
            { Timer.Text = time.Add(new TimeSpan(0, 0, i)).ToString(); i++; });

        }

       
        private void Pause_Timer(Object sender, System.EventArgs e)
        {
            timer.Stop();
        }

        private void End_Timer(Object sender, System.EventArgs e)
        {
            timer.Enabled = false;
            Timer.Text = "00:00:00";
            time = TimeSpan.Zero;
            
        }
        
        
    }
}