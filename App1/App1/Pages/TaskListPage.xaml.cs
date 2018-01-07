using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskListPage : ContentPage
    {
        public TaskListPage()
        {
            InitializeComponent();
            TaskList.ItemsSource = new string[] { "jkbhjb", "hbjhg" };
        }

        private void TaskList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new TaskEditPage());
        }
    }
}