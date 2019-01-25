using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeworkTracker.Model;
using HomeworkTracker.ViewModel;

namespace HomeworkTracker
{
    public partial class MainPage : Form
    {
        private MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.viewModel = new MainPageViewModel();
            var testTask = new ToDoTask {IsComplete = true, Description = "Test ToDo"};
            var newList = new List<ToDoTask>();
            newList.Add(testTask);
            this.TaskTrackerControl.TaskGroupTabPages[0].TaskGridView.TaskDataSource = newList.ToArray();
        }
    }
}
