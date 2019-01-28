using System;
using System.Windows.Forms;
using HomeworkTracker.IO;
using HomeworkTracker.Model;
using HomeworkTracker.ViewModel;
using TaskTrackerTabControl;
using TaskTrackerTabControl.Enum;

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
            this.createDefaultCourses();
            this.addDefaultCourseTabs();
            this.TaskTrackerControl.SelectedTabDataGrid.TaskChanged += this.cellEdited;
            this.TaskTrackerControl.PriorityChanged += this.assignChangedPriority;
            this.TaskTrackerControl.TabSelectionChanged += this.changeSelectedCourse;
            this.viewModel.SelectedCourse = this.viewModel.Courses[0];
        }

        private void changeSelectedCourse(object sender, TabSelectionChangedEventArgs e)
        {
            this.viewModel.SelectedCourse = this.viewModel.Courses[e.Index];
        }

        private void createDefaultCourses()
        {
            var newCourse1 = new Course
                {Name = "CS4280", Priority = Priority.High, Tasks = new TodoTaskCollection()};
            newCourse1.Tasks.Add(new TodoTask {Description = "This works right?", IsComplete = true});
            newCourse1.Tasks.Add(new TodoTask {Description = "Do Readings on XML Serialization", IsComplete = false});
            this.viewModel.AddCourse(newCourse1);
            var newCourse2 = new Course
                {Name = "CS3202", Priority = Priority.Medium, Tasks = new TodoTaskCollection()};
            newCourse2.Tasks.Add(new TodoTask {Description = "This works correct?", IsComplete = true});
            newCourse2.Tasks.Add(new TodoTask {Description = "Do Readings on JSON Serialization", IsComplete = false});
            this.viewModel.AddCourse(newCourse2);

            var newCourse3 = new Course
                {Name = "CS3280", Priority = Priority.Low, Tasks = new TodoTaskCollection()};
            newCourse3.Tasks.Add(new TodoTask {Description = "This works well?", IsComplete = false});
            newCourse3.Tasks.Add(new TodoTask {Description = "Do readings on XML Deserialization", IsComplete = false});
            this.viewModel.AddCourse(newCourse3);
        }

        private void addDefaultCourseTabs()
        {
            for (var i = 0; i < this.viewModel.Courses.Count; i++)
            {
                this.viewModel.SelectedCourse = this.viewModel.Courses[i];
                this.TaskTrackerControl.AddTabPage(this.viewModel.SelectedCourse.Name,
                    this.viewModel.SelectedCourse.Priority);
                this.TaskTrackerControl.TaskGroupTabPages[i].TaskGridView.DataSource = this.viewModel.TasksBinding;
            }
        }

        private void assignChangedPriority(object sender, PriorityChangedEventArgs e)
        {
            this.viewModel.SelectedCourse.Priority = e.Priority;
        }

        private void cellEdited(object sender, TaskChangedEventArgs e)
        {
            var modifiedTask = new TodoTask {Description = e.Description, IsComplete = e.IsComplete};
            var modifiedTabIndex = this.TaskTrackerControl.SelectedTab.TabIndex;
            this.viewModel.TaskModified(this.viewModel.Courses[modifiedTabIndex], modifiedTask, e.Index);
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
        }

        private void markComplete_Click(object sender, EventArgs e)
        {
            this.TaskTrackerControl.SelectedTab.TaskGridView.EndEdit();
            foreach (var current in this.viewModel.TasksBinding)
            {
                current.IsComplete = true;
                this.TaskTrackerControl.SelectedTab.TaskGridView.Refresh();
            }
        }

        private void saveToXml_Click(object sender, EventArgs e)
        {
            var serializeThis = new XmlFileWriter(this.viewModel.Courses);
            serializeThis.WriteToXmlFile();
        }

        #endregion
    }
}