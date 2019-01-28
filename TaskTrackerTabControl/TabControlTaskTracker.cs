using System;
using System.Collections.Generic;
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

        private Priority selectedPriority;
        public IList<TaskGroupTabPage> TaskGroupTabPages =>
            this.taskTrackerTabControl.TabPages.ToTaskGroupTabPagesList();

        public TaskGroupTabPage SelectedTab => (TaskGroupTabPage) this.taskTrackerTabControl.SelectedTab;
        public TaskDataGridView SelectedTabDataGrid => this.SelectedTab.TaskGridView;

        public Priority SelectedPriority
        {
            get
            {
                var checkedPriorityButton = this.PriorityButtonGroup.First(selected => selected.Checked) ??
                                            this.LowPriorityButton;
                this.selectedPriority = this.checkIfNoneSelected(checkedPriorityButton);
                return this.selectedPriority;
            }
            set => this.selectedPriority = value;
        }

        private void checkSelectedPriorityRadioButton(Priority priority)
        {
            this.PriorityButtonGroup.First(button => (Priority) button.Tag == priority).Checked = true;
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
        public event EventHandler<TabSelectionChangedEventArgs> TabSelectionChanged; 
        private void setUp()
        {
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

        public void AddTabPage(string tabLabel, Priority priority)
        {
            var courseTabPage = new TaskGroupTabPage(tabLabel) {Priority = priority};
            this.taskTrackerTabControl.TabPages.Add(courseTabPage);
            this.TaskGroupTabPages.Add(courseTabPage);
            this.refreshTabControl();
        }

        private void onRadioButtonCheckedChange(object sender, EventArgs e)
        {
            //TODO change current tab background
            var priorityData = new PriorityChangedEventArgs {
                Priority = this.SelectedPriority
            };
            this.SelectedTab.Priority = this.SelectedPriority;
            this.refreshTabControl();
            this.PriorityChanged?.Invoke(this, priorityData);
        }

        
        private void onTabSelectionChanged(object sender, EventArgs e)
        {
            this.SelectedPriority = this.SelectedTab.Priority;
            this.checkSelectedPriorityRadioButton(this.SelectedTab.Priority);
            this.refreshTabControl();
            var selectionChangedArgs = new TabSelectionChangedEventArgs
                {Index = this.taskTrackerTabControl.SelectedIndex, TaskDataGridView = this.SelectedTab.TaskGridView};
            this.TabSelectionChanged?.Invoke(this, selectionChangedArgs);
        }

        private void onTabDraw_DrawItem(object sender, DrawItemEventArgs e)
        {
            this.changeTabColorOnPriority(e);
        }

        private void changeTabColorOnPriority(DrawItemEventArgs args)
        {
                var backColor = SystemColors.Control;
                var foreColor = SystemBrushes.ControlText;
                if (this.TaskGroupTabPages[args.Index].Priority == Priority.Medium)
                {
                    backColor = Color.Gold;
                }
                else if (this.TaskGroupTabPages[args.Index].Priority == Priority.High)
                {
                    backColor = Color.DarkRed;
                    foreColor = SystemBrushes.HighlightText;
                }
                args.Graphics.FillRectangle(new SolidBrush(backColor), args.Bounds);
                var paddedBounds = args.Bounds;
                args.Graphics.DrawString(this.taskTrackerTabControl.TabPages[args.Index].Text, this.Font, foreColor, paddedBounds);
        }

        private void setDefaultPriority_Load(object sender, EventArgs e)
        {
        }

        private void refreshTabControl()
        {
            this.taskTrackerTabControl.Invalidate();
            this.taskTrackerTabControl.Update();
        }

        #endregion

    }

    public class PriorityChangedEventArgs:EventArgs
    {
        #region Properties

        public Priority Priority { get; set; }

        #endregion
    }

    public class TabSelectionChangedEventArgs:EventArgs
    {
        public int Index { get; set; }
        public TaskDataGridView TaskDataGridView { get; set; }
    }
}