using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1.ViewModels;
using App1.Models;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskListPage : ContentPage
    {
        bool isFirstAppearing = true;
        TaskListViewModel vm;
        public TaskListPage()
        {
            InitializeComponent();
            vm = new TaskListViewModel(Navigation);
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(!isFirstAppearing)
            {
                vm.LoadData();
            }
            isFirstAppearing = false;
        }

        private void TaskList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            TaskDTO item = e.Item as TaskDTO;
            if (item == null) return;
            TaskEditPage page = new TaskEditPage(item);
            TaskList.SelectedItem = null;
            Navigation.PushAsync(page);
        }
    }
}