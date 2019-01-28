using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using HomeworkTracker.Extension;
using TaskTrackerTabControl.Enum;

namespace HomeworkTracker.Model
{
    public class Course
    {
        [XmlIgnore]
        public TodoTaskCollection Tasks { get; set; }
        
        [XmlElement("Tasks")]
        public TodoTaskCollection IncompleteTasks
        {
            get
            {
                var incompleteTasks = this.Tasks.Where(task => !task.IsComplete).ToTodoTaskCollection();
                return incompleteTasks;
            } 
        }

        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public Priority Priority { get; set; }

        public Course()
        {
            this.Priority = Priority.Low;
            this.Tasks = new TodoTaskCollection();
        }
    }
}
