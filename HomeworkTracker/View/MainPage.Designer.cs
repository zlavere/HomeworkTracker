namespace HomeworkTracker
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.tabControlTaskTracker1 = new TaskTrackerTabControl.TabControlTaskTracker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tabControlTaskTracker1
            // 
            this.tabControlTaskTracker1.Location = new System.Drawing.Point(1, 0);
            this.tabControlTaskTracker1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlTaskTracker1.Name = "tabControlTaskTracker1";
            this.tabControlTaskTracker1.Size = new System.Drawing.Size(600, 366);
            this.tabControlTaskTracker1.TabIndex = 0;
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
            this.Controls.Add(this.tabControlTaskTracker1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TaskTrackerTabControl.TabControlTaskTracker tabControlTaskTracker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

