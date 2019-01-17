namespace TaskTrackerTabControl
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskTrackerTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Course = new System.Windows.Forms.DataGridView();
            this.AddCourseButton = new System.Windows.Forms.Button();
            this.TaskTrackerTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Course)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskTrackerTabControl
            // 
            this.TaskTrackerTabControl.Controls.Add(this.tabPage1);
            this.TaskTrackerTabControl.Location = new System.Drawing.Point(3, 32);
            this.TaskTrackerTabControl.Name = "TaskTrackerTabControl";
            this.TaskTrackerTabControl.SelectedIndex = 0;
            this.TaskTrackerTabControl.Size = new System.Drawing.Size(794, 415);
            this.TaskTrackerTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Course);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Course
            // 
            this.Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Course.Location = new System.Drawing.Point(0, 0);
            this.Course.Name = "Course";
            this.Course.RowTemplate.Height = 24;
            this.Course.Size = new System.Drawing.Size(786, 386);
            this.Course.TabIndex = 0;
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.Location = new System.Drawing.Point(695, 3);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.Size = new System.Drawing.Size(92, 23);
            this.AddCourseButton.TabIndex = 1;
            this.AddCourseButton.Text = "Add Course";
            this.AddCourseButton.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.TaskTrackerTabControl);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.TaskTrackerTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TaskTrackerTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Course;
        private System.Windows.Forms.Button AddCourseButton;
    }
}
