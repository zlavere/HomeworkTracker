using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HomeworkTracker.Model;
using HomeworkTracker.ViewModel;
using TaskTrackerTabControl;

namespace HomeworkTracker
{
    public partial class MainPage : Form
    {
        #region Data members

        private MainPageViewModel viewModel;

        #endregion

        #region Constructors

        public MainPage()
        {
            // ReSharper disable once ArrangeThisQualifier
            InitializeComponent();
            this.setUp();
        }

        #endregion

        #region Methods

        private void setUp()
        {
            this.viewModel = new MainPageViewModel();
            this.TaskTrackerControl.SelectedTabDataGrid.DataSource = this.viewModel.TasksBinding;
            this.TaskTrackerControl.SelectedTabDataGrid.TaskChanged += this.cellEdited;
        }

        private void cellEdited(object sender, TaskChangedEventArgs e)
        {
            var modifiedTask = new TodoTask {Description = e.Description, IsComplete = e.IsComplete};
            this.viewModel.AddNewTask(modifiedTask, e.Index);
        }

        #endregion

//        private void modifyTask(object sender, TaskChangedEventArgs e)
//        {
//            var modifiedTask = this.viewModel.SelectedCourse.Tasks[e.RowIndex];
//            modifiedTask.Description = e.TaskDescription;
//            modifiedTask.IsComplete = e.IsTaskComplete;
//            Debug.WriteLine(this.viewModel.SelectedCourse.Tasks[e.RowIndex].Description);
//        }
    }
}