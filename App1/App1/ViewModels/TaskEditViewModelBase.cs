using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class TaskEditViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation;
        public int id;
        string _taskName;
        DateTime _date;
        bool _notify;

        public string ButtonText { get; set; }
        public ICommand ClickCommand { get; set; }

        public string TaskName
        {
            get
            {
                return _taskName;
            }
            set
            {
                if (_taskName != value)
                {
                    _taskName = value;
                    OnPropertyChanged("TaskName");
                }
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged("Date");
                }
            }
        }
        public bool Notify
        {
            get
            {
                return _notify;
            }
            set
            {
                if (_notify != value)
                {
                    _notify = value;
                    OnPropertyChanged("Notify");
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
