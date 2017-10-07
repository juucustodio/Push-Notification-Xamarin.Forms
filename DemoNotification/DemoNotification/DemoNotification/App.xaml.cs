using Com.OneSignal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DemoNotification
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoNotification.MainPage();

            OneSignal.Current.StartInit("Insert OneSignal App ID here").EndInit();
        }

        protected override void OnStart()
        {
            OneSignal.Current.RegisterForPushNotifications();
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
