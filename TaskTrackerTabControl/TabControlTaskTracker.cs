using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
            get
            {
                var checkedPriorityButton = this.PriorityButtonGroup.First(selected => selected.Checked) ?? this.LowPriorityButton;
                var selectedPriority = this.checkIfNoneSelected(checkedPriorityButton);
                return selectedPriority;
            }
        }

        public IEnumerable<RadioButton> PriorityButtonGroup { get; private set; }

        #endregion

        #region Constructors

        public TabControlTaskTracker()
        {
            InitializeComponent();
            
            this.setUp();
        }

        #endregion

        #region Methods

        private Priority checkIfNoneSelected(RadioButton checkedPriorityButton)
        {
            if (checkedPriorityButton.Tag == null)
            {
                this.LowPriorityButton.Checked = true;
                checkedPriorityButton = this.LowPriorityButton;
            }

            var selectedPriority = (Priority) checkedPriorityButton.Tag;
            return selectedPriority;
        }

        public event EventHandler<PriorityChangedEventArgs> PriorityChanged;

        private void setUp()
        {
            this.AddTabPage("Test");
            this.setRadioButtonTags();
            this.PriorityButtonGroup = this.PriorityGroupBox.Controls.OfType<RadioButton>();
            this.taskTrackerTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
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
            Debug.WriteLine("priority changed");
            this.refreshTabControl();
            this.PriorityChanged?.Invoke(this, priorityData);

        }



        private void onTabSelectionChanged(object sender, EventArgs e)
        {
            this.SelectedTab.Priority = this.SelectedPriority;
            
        }

        private void onTabDraw_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.changeTabColorOnPriority(e);
        }

        private void changeTabColorOnPriority(DrawItemEventArgs args)
        {
            var backColor = SystemColors.Control;
            var foreColor = SystemBrushes.ControlText;
            if (this.SelectedPriority == Priority.Medium)
            {
                backColor = Color.Gold;
            }
            else if (this.SelectedPriority == Priority.High)
            {
                backColor = Color.DarkRed;
                foreColor = SystemBrushes.HighlightText;
            }
            Rectangle paddedBounds = args.Bounds;
            paddedBounds.Inflate(-2, -2);
            args.Graphics.FillRectangle(new SolidBrush(backColor), args.Bounds);
            args.Graphics.DrawString(this.taskTrackerTabControl.TabPages[args.Index].Text, this.Font, foreColor, paddedBounds);
            this.taskTrackerTabControl.SelectedTab.Invalidate();
            this.taskTrackerTabControl.SelectedTab.Update();
        }

        private void setDefaultPriority_Load(object sender, EventArgs e)
        {
            this.LowPriorityButton.Checked = true;
        }

        private void refreshTabControl()
        {
            this.taskTrackerTabControl.Invalidate();
            this.taskTrackerTabControl.Update();
        }

        #endregion
    }

    public class PriorityChangedEventArgs
    {
        #region Properties

        public Priority Priority { get; set; }

        #endregion
    }
}