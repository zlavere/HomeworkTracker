using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTracker.Model
{
    public class CourseCollection: IList<Course>
    {
        public IList<Course> Courses { get; set; }

        public CourseCollection()
        {
            this.Courses = new List<Course>();
        }

        public IEnumerator<Course> GetEnumerator()
        {
            return this.Courses.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) this.Courses).GetEnumerator();
        }

        public void Add(Course item)
        {
            this.Courses.Add(item);
        }

        public void Clear()
        {
            this.Courses.Clear();
        }

        public bool Contains(Course item)
        {
            return this.Courses.Contains(item);
        }

        public void CopyTo(Course[] array, int arrayIndex)
        {
            this.Courses.CopyTo(array, arrayIndex);
        }

        public bool Remove(Course item)
        {
            return this.Courses.Remove(item);
        }

        public int Count => this.Courses.Count;

        public bool IsReadOnly => this.Courses.IsReadOnly;

        public int IndexOf(Course item)
        {
            return this.Courses.IndexOf(item);
        }

        public void Insert(int index, Course item)
        {
            this.Courses.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.Courses.RemoveAt(index);
        }

        public Course this[int index]
        {
            get => this.Courses[index];
            set => this.Courses[index] = value;
        }
    }
}
