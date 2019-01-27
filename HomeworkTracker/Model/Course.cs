using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTrackerTabControl.Enum;

namespace HomeworkTracker.Model
{
    public class Course
    {
        public IList<TodoTask> Tasks { get; set; }
        public string Name { get; set; }
        public Priority Priority { get; set; }

        public Course()
        {
            this.Priority = Priority.Low;
            this.Tasks = new List<TodoTask>();
        }
    }
}
