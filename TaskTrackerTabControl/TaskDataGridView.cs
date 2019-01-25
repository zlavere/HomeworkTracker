using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace TaskTrackerTabControl
{
    public partial class TaskDataGridView : DataGridView
    {
        private const int CheckBoxColumnOrdinal = 0;
        private const int DescriptionColumnOrdinal = 1;
        private IEnumerable<object> taskDataSource;
        public DataGridViewCheckBoxColumn CheckBoxColumn => (DataGridViewCheckBoxColumn)this.Columns[CheckBoxColumnOrdinal];
        public DataGridViewTextBoxColumn DescriptionColumn => (DataGridViewTextBoxColumn)this.Columns[DescriptionColumnOrdinal];

        public IEnumerable<object> TaskDataSource
        {
            get => this.taskDataSource;
            set
            {
                this.taskDataSource = value;
                this.setDataSource();
            }
        }

        public TaskDataGridView()
        {
            InitializeComponent();
            this.setUp();
        }

        private void setDataSource()
        {
            var dataSourceBindingList = new BindingList<object>(this.taskDataSource.ToList());
            dataSourceBindingList.AllowNew = true;
            dataSourceBindingList.AllowEdit = true;
            this.DataSource = dataSourceBindingList;
        }

        private void setUp()
        {
            
            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = @"Complete",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader,
                DataPropertyName = "IsComplete"
            };
            var descriptionColumn = new DataGridViewTextBoxColumn
            {
                HeaderText = @"Description",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DataPropertyName = "Description"
            };

            this.Columns.Insert(CheckBoxColumnOrdinal, checkBoxColumn);
            this.Columns.Insert(DescriptionColumnOrdinal, descriptionColumn);
            this.Columns[CheckBoxColumnOrdinal].DisplayIndex = CheckBoxColumnOrdinal;
            this.Columns[DescriptionColumnOrdinal].DisplayIndex = DescriptionColumnOrdinal;
            this.Dock = DockStyle.Fill;
            
        }

    }
}
