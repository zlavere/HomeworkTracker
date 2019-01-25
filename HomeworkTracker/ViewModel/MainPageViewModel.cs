using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HomeworkTracker.Model;

namespace HomeworkTracker.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private IList<Course> courses;
        private Course selectedCourse;

        public IList<Course> Courses
        {
            get => this.courses;
            set { this.courses = value; this.OnPropertyChanged(); }
        }

        public Course SelectedCourse
        {
            get => this.selectedCourse;
            set
            {
                this.selectedCourse = value;
                this.OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
