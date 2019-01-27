using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TaskTrackerTabControl.Enum;
using TaskTrackerTabControl.Extension;

// ReSharper disable ArrangeThisQualifier

namespace TaskTrackerTabControl
{
    public partial class TabControlTaskTracker : UserControl
    {
        #region Properties

        public IList<TaskGroupTabPage> TaskGroupTabPages =>
            this.taskTrackerTabControl.TabPages.ToTaskGroupTabPagesList();

        public TaskGroupTabPage SelectedTab => (TaskGroupTabPage) this.taskTrackerTabControl.SelectedTab;
        public TaskDataGridView SelectedTabDataGrid => this.SelectedTab.TaskGridView;

        public Priority SelectedPriority
        {
            get { return (Priority) this.PriorityButtonGroup.First(selected => selected.Checked).Tag; }
            private set
            {
                if (!System.Enum.IsDefined(typeof(Priority), value))
                {
                    throw new InvalidEnumArgumentException(nameof(value), (int) value, typeof(Priority));
                }

                this.SelectedPriority = value;
            }
        }

        public IEnumerable<RadioButton> PriorityButtonGroup { get; }

        #endregion

        #region Constructors

        public TabControlTaskTracker()
        {
            InitializeComponent();
            this.setUp();
            this.PriorityButtonGroup = this.PriorityGroupBox.Controls.OfType<RadioButton>();
        }

        #endregion

        #region Methods

        public event EventHandler<PriorityChangedEventArgs> PriorityChanged;

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

        private void onRadioButtonCheckedChange(object sender, EventArgs e)
        {
            //TODO change current tab background
            var priorityData = new PriorityChangedEventArgs {
                Priority = this.SelectedPriority
            };
            
            this.PriorityChanged?.Invoke(this, priorityData);
        }

        private void onTabSelectionChanged(object sender, EventArgs e)
        {
            this.SelectedPriority = this.SelectedTab.Priority;
        }

        #endregion

        //TODO Set the Tag of the page to be an ID for the course! EZPZ
    }

    public class PriorityChangedEventArgs
    {
        #region Properties

        public Priority Priority { get; set; }

        #endregion
    }
}