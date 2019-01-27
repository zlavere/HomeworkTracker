namespace HomeworkTracker.View
{
    partial class MainPage
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskTrackerControl = new TaskTrackerTabControl.TabControlTaskTracker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TaskTrackerControl
            // 
            this.TaskTrackerControl.Location = new System.Drawing.Point(1, 0);
            this.TaskTrackerControl.Margin = new System.Windows.Forms.Padding(2);
            this.TaskTrackerControl.Name = "TaskTrackerControl";
            this.TaskTrackerControl.Size = new System.Drawing.Size(600, 366);
            this.TaskTrackerControl.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 381);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 306);
            this.textBox1.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 720);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TaskTrackerControl);
            this.Name = "MainPage";
            this.Text = "Homework Tracker by Zach LaVere";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaskTrackerTabControl.TabControlTaskTracker TaskTrackerControl;
        private System.Windows.Forms.TextBox textBox1;
    }
}

