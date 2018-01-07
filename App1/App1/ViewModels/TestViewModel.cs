using App1.Helpers;
using App1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModels
{
    public class TestViewModel
    {
        public string TaskName {get; set;}
        public DateTime Date { get; set;}

        public TestViewModel()
        {
            var x = Task.Run(()=>DatabaseHelper.GetTable<TaskDTO>());
            var y = x.Result;
            TaskName = y[0].TaskName;
            Date = y[0].Date;
        }
    }
}
