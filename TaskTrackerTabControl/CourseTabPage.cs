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
    public partial class CourseTabPage : TabPage
    {
        public string CourseName { get; set; }
        public Priority Priority { get; set; }

        public CourseTabPage()
        {
            InitializeComponent();
        }

        public CourseTabPage(string name) : this()
        {
            this.Text = name;
            this.CourseName = name;
        }
    }
}
