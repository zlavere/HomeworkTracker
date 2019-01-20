using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskTrackerTabControl.Enum;

// ReSharper disable ArrangeThisQualifier

namespace TaskTrackerTabControl
{
    public partial class TabControlTaskTracker: UserControl
    {
        public TabControlTaskTracker()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.addTabPage("Test");
            this.setRadioButtonTags();
        }

        private void setRadioButtonTags()
        {
            this.HighPriorityButton.Tag = Priority.High;
            this.MediumPriorityButton.Tag = Priority.Medium;
            this.LowPriorityButton.Tag = Priority.Low;
        }

        private void addTabPage(string tabLabel)
        {
            var courseTabPage = new CourseTabPage(tabLabel);
            this.TaskTrackerTabControl.TabPages.Add(courseTabPage);
            var courseControl = new CourseControl();
            courseTabPage.Controls.Add(courseControl);
        }
    }
}
