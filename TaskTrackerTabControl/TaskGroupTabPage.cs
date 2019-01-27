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

namespace TaskTrackerTabControl
{
    public partial class TaskGroupTabPage : TabPage
    {
        public TaskDataGridView TaskGridView { get; set; }
        public Priority Priority { get; set; }
        public TaskGroupTabPage()
        {
            InitializeComponent();
            this.TaskGridView = new TaskDataGridView();
            this.Controls.Add(this.TaskGridView);
        }

        public TaskGroupTabPage(string name) : this()
        {
            this.Text = name;
        }
    }
}
