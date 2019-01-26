﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeworkTracker.Model;
using TaskTrackerTabControl.Enum;

namespace HomeworkTracker.ViewModel
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private IList<Course> courses;
        private Course selectedCourse;
        private BindingList<TodoTask> tasksBinding;

        public IList<Course> Courses
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
            }
            
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

        public MainPageViewModel()
        {
            this.TasksBinding = new BindingList<TodoTask>();
            this.Courses = new List<Course>();
            this.SelectedCourse = new Course {Name = "CS1101", Priority = Priority.High, Tasks = new List<TodoTask>()};
            this.AddNewTask(new TodoTask{Description = "This works right?", IsComplete = true}, 0);
        }

        public void AddNewTask(TodoTask task, int index)
        {
            if (index == this.TasksBinding.Count)
            {
                this.TasksBinding.Add(task);
                this.SelectedCourse.Tasks.Add(task);
            }
            else
            {
                if (!task.Description.Equals(this.TasksBinding[index].Description))
                {
                    this.TasksBinding[index].Description = task.Description;
                }

                if (!task.IsComplete != this.TasksBinding[index].IsComplete)
                {
                    this.TasksBinding[index].IsComplete = task.IsComplete;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}