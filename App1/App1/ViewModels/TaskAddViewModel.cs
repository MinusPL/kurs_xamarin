using App1.Helpers;
using App1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
    class TaskAddViewModel : TaskEditViewModelBase
    {
        public TaskAddViewModel(INavigation Navigation)
        {
            this.Navigation = Navigation;
            TaskName = "Nowe Zadanie";
            Date = DateTime.Now;
            Notify = true;
            ButtonText = "Dodaj!";
            ClickCommand = new Command(() => { AddTask(); });
        }

        public async void AddTask()
        {
            TaskDTO item = new TaskDTO
            {
                TaskName = this.TaskName,
                Date = this.Date,
                Notification = this.Notify
            };
            await DatabaseHelper.InsertSingle<TaskDTO>(item);
            await Navigation.PopAsync();
        }
    }
}
