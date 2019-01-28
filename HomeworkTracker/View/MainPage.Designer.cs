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
            this.summaryOutputText = new System.Windows.Forms.TextBox();
            this.summaryOutputLabel = new System.Windows.Forms.Label();
            this.TaskTrackerControl = new TaskTrackerTabControl.TabControlTaskTracker();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markCompleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAllIncompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryOutputText
            // 
            this.summaryOutputText.Location = new System.Drawing.Point(103, 404);
            this.summaryOutputText.Multiline = true;
            this.summaryOutputText.Name = "summaryOutputText";
            this.summaryOutputText.Size = new System.Drawing.Size(508, 295);
            this.summaryOutputText.TabIndex = 1;
            // 
            // summaryOutputLabel
            // 
            this.summaryOutputLabel.AutoSize = true;
            this.summaryOutputLabel.Location = new System.Drawing.Point(100, 388);
            this.summaryOutputLabel.Name = "summaryOutputLabel";
            this.summaryOutputLabel.Size = new System.Drawing.Size(122, 13);
            this.summaryOutputLabel.TabIndex = 2;
            this.summaryOutputLabel.Text = "Tasks Not Yet Complete";
            // 
            // TaskTrackerControl
            // 
            this.TaskTrackerControl.Location = new System.Drawing.Point(11, 24);
            this.TaskTrackerControl.Margin = new System.Windows.Forms.Padding(2);
            this.TaskTrackerControl.Name = "TaskTrackerControl";
            this.TaskTrackerControl.Size = new System.Drawing.Size(600, 351);
            this.TaskTrackerControl.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(627, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.loadMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveToXml_Click);
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadMenuItem.Text = "Load";
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markCompleteMenuItem,
            this.markAllIncompleteToolStripMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // markCompleteMenuItem
            // 
            this.markCompleteMenuItem.Name = "markCompleteMenuItem";
            this.markCompleteMenuItem.Size = new System.Drawing.Size(181, 22);
            this.markCompleteMenuItem.Text = "Mark All Complete";
            this.markCompleteMenuItem.Click += new System.EventHandler(this.markComplete_Click);
            // 
            // markAllIncompleteToolStripMenuItem
            // 
            this.markAllIncompleteToolStripMenuItem.Name = "markAllIncompleteToolStripMenuItem";
            this.markAllIncompleteToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.markAllIncompleteToolStripMenuItem.Text = "Mark All Incomplete";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 720);
            this.Controls.Add(this.summaryOutputLabel);
            this.Controls.Add(this.summaryOutputText);
            this.Controls.Add(this.TaskTrackerControl);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainPage";
            this.Text = "Homework Tracker by Zach LaVere";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaskTrackerTabControl.TabControlTaskTracker TaskTrackerControl;
        private System.Windows.Forms.TextBox summaryOutputText;
        private System.Windows.Forms.Label summaryOutputLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markCompleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAllIncompleteToolStripMenuItem;
    }
}

