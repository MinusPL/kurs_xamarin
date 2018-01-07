using App1.Helpers;
using App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new App1.MainPage());
        }

        protected override async void OnStart()
        {
            await DatabaseHelper.Initialize();

                var x = new TaskDTO() {
                TaskName = "Sprawko z Fizyki",
                Date = DateTime.Now,
                Notification = false
            };

            await DatabaseHelper.InsertSingle<TaskDTO>(x);
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
