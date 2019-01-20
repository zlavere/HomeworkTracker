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
            this.setUp();
        }

        private void setUp()
        {
            var checkBoxColumn = new DataGridViewCheckBoxColumn {
                Name = "Complete",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            var descriptionColumn = new DataGridViewTextBoxColumn {
                Name = "Description",
            };
            this.CourseDataGridView.Columns.Insert(0, checkBoxColumn);
            this.CourseDataGridView.Columns.Insert(1, descriptionColumn);
            this.CourseDataGridView.Rows.Add(new object[] {true, "test2"});
            this.CourseDataGridView.Rows.Add(new object[] {false, "test3"});
            this.CourseDataGridView.Columns[0].DisplayIndex = 0;
            this.CourseDataGridView.Columns[1].DisplayIndex = 1;
            this.Dock = DockStyle.Fill;
        }
    }
}
