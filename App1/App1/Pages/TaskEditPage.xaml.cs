using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Models;
using App1.ViewModels;
using System.Diagnostics;

namespace App1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskEditPage : ContentPage
    {
        public TaskEditPage(TaskDTO item)
        {
            try
            {
                InitializeComponent();
                if (item != null)
                {
                    BindingContext = new TaskEditViewModel(item, Navigation);
                }
                else
                {
                    BindingContext = new TaskAddViewModel(Navigation);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw e;
            }
        }
    }
}