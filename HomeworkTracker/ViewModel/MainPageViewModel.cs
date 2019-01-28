using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using HomeworkTracker.Model;
using TaskTrackerTabControl.Enum;

namespace HomeworkTracker.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        #region Data members

        private CourseCollection courses;
        private Course selectedCourse;
        private BindingList<TodoTask> tasksBinding;

        #endregion

        #region Properties

        public CourseCollection Courses
        {
            get => this.courses;
            set
            {
                this.courses = value;
                this.OnPropertyChanged();
            }
        }

        public BindingList<TodoTask> TasksBinding
        {
            get => this.tasksBinding;
            set
            {
                
                this.tasksBinding = value;
                this.tasksBinding.AllowNew = true;
                this.tasksBinding.AllowEdit = true;
                this.tasksBinding.AllowRemove = true;
                this.tasksBinding.RaiseListChangedEvents = true;
                this.OnPropertyChanged();
            }
        }

        public Course SelectedCourse
        {
            get => this.selectedCourse;
            set
            {
                this.selectedCourse = value;
                this.TasksBinding = new BindingList<TodoTask>(this.SelectedCourse.Tasks);
                this.OnPropertyChanged();
            }
        }

        #endregion

        #region Constructors

        public MainPageViewModel()
        {
            this.Courses = new CourseCollection();
            this.SelectedCourse = new Course();
        }

        public void AddCourse(Course course)
        {
           this.Courses.Add(course);
        }

        #endregion

        #region Methods

        public event PropertyChangedEventHandler PropertyChanged;

        public void TaskModified(Course course, TodoTask task, int index)
        {
            Debug.WriteLine(
                $"Index = {index} and Count = {this.TasksBinding.Count} / {this.SelectedCourse.Tasks.Count}");

            if (index == this.SelectedCourse.Tasks.Count)
            {
                course.Tasks.Add(task);
            }
            else
            {
                if (!task.Description.Equals(this.TasksBinding[index].Description))
                {
                   
                    course.Tasks[index].Description = task.Description;
                }

                if (!task.IsComplete != this.TasksBinding[index].IsComplete)
                {
                   
                    course.Tasks[index].IsComplete = task.IsComplete;
                }
            }
        }



        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}