using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App1.Models;
using System.ComponentModel;
using Xamarin.Forms;
using System.Diagnostics;
using App1.Helpers;

namespace App1.ViewModels
{
    public class TaskEditViewModel : TaskEditViewModelBase
    {

        public TaskEditViewModel(TaskDTO item, INavigation Navigation)
        {
            this.Navigation = Navigation;
            ClickCommand = new Command(() => { EditData(); });
            TaskName = item.TaskName;
            Date = item.Date;
            Notify = item.Notification;
            ButtonText = "Zedytuj!";
            id = item.Id;
        }
        
        public async void EditData()
        {
            TaskDTO item = new TaskDTO()
            {
                TaskName = this.TaskName,
                Date = this.Date,
                Notification = this.Notify,
                Id = id
            };
            await DatabaseHelper.UpdateSingle<TaskDTO>(item);
            await Navigation.PopAsync();
        }
    }
}
