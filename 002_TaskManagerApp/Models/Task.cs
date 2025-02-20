using System;

namespace TaskManagerApp.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Title} - Due: {DueDate.ToShortDateString()}";
        }
    }
}
