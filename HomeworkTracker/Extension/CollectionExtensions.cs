using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HomeworkTracker.Model;

namespace HomeworkTracker.Extension
{
    public static class CollectionExtensions
    {
        public static TodoTaskCollection ToTodoTaskCollection(this IEnumerable<TodoTask> collection)
        {
            var todoTaskCollection = new TodoTaskCollection {
               Tasks = collection.ToList()
            };
            return todoTaskCollection;
        }
    }
}
