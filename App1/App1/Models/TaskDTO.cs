using System;

namespace App1.Models
{
    public class TaskDTO : baseDTO
    {
        public string TaskName { get; set; }
        public DateTime Date { get; set; }
        public bool Notification { get; set; }
    }
}
