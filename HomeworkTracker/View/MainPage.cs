using System.Windows.Forms;
using HomeworkTracker.Model;
using HomeworkTracker.ViewModel;
using TaskTrackerTabControl;

namespace HomeworkTracker.View
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
            this.InitializeComponent();
            this.setUp();
        }

        #endregion

        #region Methods

        private void setUp()
        {
            this.viewModel = new MainPageViewModel();
            this.TaskTrackerControl.SelectedTabDataGrid.DataSource = this.viewModel.TasksBinding;
            this.TaskTrackerControl.SelectedTabDataGrid.TaskChanged += this.cellEdited;
            this.TaskTrackerControl.PriorityChanged += this.assignChangedPriority;
        }

        private void assignChangedPriority(object sender, PriorityChangedEventArgs e)
        {
            this.viewModel.SelectedCourse.Priority = e.Priority;
        }

        private void cellEdited(object sender, TaskChangedEventArgs e)
        {
            var modifiedTask = new TodoTask {Description = e.Description, IsComplete = e.IsComplete};
            this.viewModel.AddNewTask(modifiedTask, e.Index);
        }

        private void MainPage_Load(object sender, System.EventArgs e)
        {
            
        }

        #endregion

    }
}