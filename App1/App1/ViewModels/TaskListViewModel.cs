using System.Threading.Tasks;
using App1.Helpers;
using App1.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using App1.Pages;

namespace App1.ViewModels
{
    public class TaskListViewModel
    {
        public ICommand AddCommand { get; set;  }
        public ObservableCollection<TaskDTO> Tasks { get; set; }

        public TaskListViewModel(INavigation Navigation)
        {
            AddCommand = new Command(() => { Navigation.PushAsync(new TaskEditPage(null)); });
            var x = Task.Run(() => DatabaseHelper.GetTable<TaskDTO>());
            var y = x.Result;
            Tasks = new ObservableCollection<TaskDTO>(y);
        }

        public void LoadData()
        {
            var x = Task.Run(() => DatabaseHelper.GetTable<TaskDTO>());
            var y = x.Result;
            Tasks.Clear();
            foreach(var item in y)
            {
                Tasks.Add(item);
            }
        }
    }
}
