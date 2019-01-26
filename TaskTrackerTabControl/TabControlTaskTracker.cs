using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTrackerTabControl.Enum;
using TaskTrackerTabControl.Extension;

// ReSharper disable ArrangeThisQualifier

namespace TaskTrackerTabControl
{
    public partial class TabControlTaskTracker: UserControl
    {
        public event EventHandler<TaskChangedEventArgs> TaskChanged;
        private const int taskCompleteColumnIndex = 0;
        private const int taskDescriptionColumnIndex = 1;
        public IList<TaskGroupTabPage> TaskGroupTabPages => this.taskTrackerTabControl.TabPages.ToTaskGroupTabPagesList();
        public TaskGroupTabPage SelectedTab => (TaskGroupTabPage) this.taskTrackerTabControl.SelectedTab;
        public TaskDataGridView SelectedTabDataGrid => this.SelectedTab.TaskGridView;

        public string testPublicProperty { get; set; }

        public Priority SelectedPriority
        {
            get
            {
                return (Priority) this.PriorityButtonGroup.First(selected => selected.Checked).Tag;
            } 
        }
        public IEnumerable<RadioButton> PriorityButtonGroup { get; private set; }

        
        public TabControlTaskTracker()
        {
            InitializeComponent();
            this.setUp();
            this.PriorityButtonGroup = this.PriorityGroupBox.Controls.OfType<RadioButton>();
        }

        private void setUp()
        {
            this.AddTabPage("Test");
            this.setRadioButtonTags();
        }

        private void setRadioButtonTags()
        {
            this.HighPriorityButton.Tag = Priority.High;
            this.MediumPriorityButton.Tag = Priority.Medium;
            this.LowPriorityButton.Tag = Priority.Low;
        }

        public void AddTabPage(string tabLabel)
        {
            var courseTabPage = new TaskGroupTabPage(tabLabel);
            this.taskTrackerTabControl.TabPages.Add(courseTabPage);
            this.TaskGroupTabPages.Add(courseTabPage);
        }

     
    }

   
}
