using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TaskTrackerTabControl
{
    public partial class TaskDataGridView : DataGridView
    {
        private const int CheckBoxColumnOrdinal = 0;
        private const int DescriptionColumnOrdinal = 1;

        private DataGridViewCheckBoxColumn CheckBoxColumn { get; set; }
        private DataGridViewTextBoxColumn DescriptionColumn { get; set; }

        public event EventHandler<TaskChangedEventArgs> TaskChanged; 


        public TaskDataGridView()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setUp()
        {
            this.CheckBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = @"Complete",
                Name = "IsComplete",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                DataPropertyName = "IsComplete",
                ValueType = typeof(bool),
            };
            this.DescriptionColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = @"Description",
                Name = "Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "Description",
                ValueType = typeof(string),
            };

            this.Columns.Insert(CheckBoxColumnOrdinal, this.CheckBoxColumn);
            this.Columns.Insert(DescriptionColumnOrdinal, this.DescriptionColumn);
            this.Dock = DockStyle.Fill;
            this.EditMode = DataGridViewEditMode.EditOnEnter;
            this.AllowUserToAddRows = true;
            this.AllowUserToDeleteRows = true;
            this.ReadOnly = false;
        }

        private void onTaskChanged(bool isComplete, string description, int index)
        {
            var taskData = new TaskChangedEventArgs {
                Description = description,
                IsComplete = isComplete,
                Index = index

            };
            this.TaskChanged?.Invoke(this, taskData);
        }

        private void taskChanged_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var description = string.Empty;
            try
            {
                description = this.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            }
            catch (NullReferenceException)
            {
                description = @"(provide description here)";
            }

            bool isComplete; //DataGridCell may return a null value, isComplete must not be null bool instantiated in try/catch block.
            try
            {
                isComplete = (bool) this.Rows[e.RowIndex].Cells["IsComplete"].Value;
            }
            catch (NullReferenceException)
            {
                isComplete = false;
            }

            this.onTaskChanged(isComplete, description, e.RowIndex);
        }
    }


    public class TaskChangedEventArgs :EventArgs
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public int Index { get; set; }

    }
}
