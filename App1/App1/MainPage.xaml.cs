using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Pages;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TaskListPage());
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TestPage());
        }
    }
}
