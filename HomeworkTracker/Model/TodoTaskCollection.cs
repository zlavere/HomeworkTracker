using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeworkTracker.Model
{
    public class TodoTaskCollection : IList<TodoTask>
    {
        private IList<TodoTask> incompleteTasks;
        public IList<TodoTask> Tasks { get; set; }

        public TodoTaskCollection()
        {
            this.Tasks = new List<TodoTask>();
            this.incompleteTasks = new List<TodoTask>();
        }

        public IEnumerator<TodoTask> GetEnumerator()
        {
            return this.Tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this.Tasks).GetEnumerator();
        }

        public void Add(TodoTask item)
        {
            this.Tasks.Add(item);
        }

        public void Clear()
        {
            this.Tasks.Clear();
        }

        public bool Contains(TodoTask item)
        {
            return this.Tasks.Contains(item);
        }

        public void CopyTo(TodoTask[] array, int arrayIndex)
        {
            this.Tasks.CopyTo(array, arrayIndex);
        }

        public bool Remove(TodoTask item)
        {
            return this.Tasks.Remove(item);
        }

        public int Count => this.Tasks.Count;

        public bool IsReadOnly => this.Tasks.IsReadOnly;

        public int IndexOf(TodoTask item)
        {
            return this.Tasks.IndexOf(item);
        }

        public void Insert(int index, TodoTask item)
        {
            this.Tasks.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.Tasks.RemoveAt(index);
        }

        public TodoTask this[int index]
        {
            get => this.Tasks[index];
            set => this.Tasks[index] = value;
        }
    }
}
