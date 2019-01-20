using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskTrackerTabControl
{
    public partial class CourseControl : UserControl
    {
        public CourseControl()
        {
            InitializeComponent();
            this.CourseDataGridView.ColumnCount = 2;
            this.CourseDataGridView.Columns[0].Name = "isComplete";
            this.CourseDataGridView.Columns[1].Name = "taskDescription";
            this.CourseDataGridView.Rows.Add(new string[] {"test", "test2"});
            this.CourseDataGridView.Columns[0].DisplayIndex = 0;
            this.CourseDataGridView.Columns[1].DisplayIndex = 1;
            this.Dock = DockStyle.Fill;

        }
    }
}
