using System;
using Timeline.Views;
using Timeline.Views.Templates;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Timeline
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CustomNavigationView(new TimelineView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
