﻿namespace TaskTrackerTabControl
{
    partial class TabControlTaskTracker
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
            this.taskTrackerTabControl = new System.Windows.Forms.TabControl();
            this.PriorityGroupBox = new System.Windows.Forms.GroupBox();
            this.LowPriorityButton = new System.Windows.Forms.RadioButton();
            this.MediumPriorityButton = new System.Windows.Forms.RadioButton();
            this.HighPriorityButton = new System.Windows.Forms.RadioButton();
            this.PriorityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskTrackerTabControl
            // 
            this.taskTrackerTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.taskTrackerTabControl.Location = new System.Drawing.Point(87, 3);
            this.taskTrackerTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.taskTrackerTabControl.Name = "taskTrackerTabControl";
            this.taskTrackerTabControl.SelectedIndex = 0;
            this.taskTrackerTabControl.Size = new System.Drawing.Size(566, 353);
            this.taskTrackerTabControl.TabIndex = 0;
            this.taskTrackerTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.onTabDraw_DrawItem);
            this.taskTrackerTabControl.SelectedIndexChanged += new System.EventHandler(this.onTabSelectionChanged);
            // 
            // PriorityGroupBox
            // 
            this.PriorityGroupBox.Controls.Add(this.LowPriorityButton);
            this.PriorityGroupBox.Controls.Add(this.MediumPriorityButton);
            this.PriorityGroupBox.Controls.Add(this.HighPriorityButton);
            this.PriorityGroupBox.Location = new System.Drawing.Point(3, 3);
            this.PriorityGroupBox.Name = "PriorityGroupBox";
            this.PriorityGroupBox.Size = new System.Drawing.Size(79, 85);
            this.PriorityGroupBox.TabIndex = 1;
            this.PriorityGroupBox.TabStop = false;
            this.PriorityGroupBox.Text = "Priority";
            // 
            // LowPriorityButton
            // 
            this.LowPriorityButton.AllowDrop = true;
            this.LowPriorityButton.AutoSize = true;
            this.LowPriorityButton.Location = new System.Drawing.Point(6, 65);
            this.LowPriorityButton.Name = "LowPriorityButton";
            this.LowPriorityButton.Size = new System.Drawing.Size(45, 17);
            this.LowPriorityButton.TabIndex = 2;
            this.LowPriorityButton.Text = "Low";
            this.LowPriorityButton.UseVisualStyleBackColor = true;
            this.LowPriorityButton.CheckedChanged += new System.EventHandler(this.onRadioButtonCheckedChange);
            // 
            // MediumPriorityButton
            // 
            this.MediumPriorityButton.AutoSize = true;
            this.MediumPriorityButton.Location = new System.Drawing.Point(6, 42);
            this.MediumPriorityButton.Name = "MediumPriorityButton";
            this.MediumPriorityButton.Size = new System.Drawing.Size(62, 17);
            this.MediumPriorityButton.TabIndex = 1;
            this.MediumPriorityButton.TabStop = true;
            this.MediumPriorityButton.Text = "Medium";
            this.MediumPriorityButton.UseVisualStyleBackColor = true;
            this.MediumPriorityButton.CheckedChanged += new System.EventHandler(this.onRadioButtonCheckedChange);
            // 
            // HighPriorityButton
            // 
            this.HighPriorityButton.AutoSize = true;
            this.HighPriorityButton.Location = new System.Drawing.Point(6, 19);
            this.HighPriorityButton.Name = "HighPriorityButton";
            this.HighPriorityButton.Size = new System.Drawing.Size(47, 17);
            this.HighPriorityButton.TabIndex = 0;
            this.HighPriorityButton.TabStop = true;
            this.HighPriorityButton.Text = "High";
            this.HighPriorityButton.UseVisualStyleBackColor = true;
            this.HighPriorityButton.CheckedChanged += new System.EventHandler(this.onRadioButtonCheckedChange);
            // 
            // TabControlTaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityGroupBox);
            this.Controls.Add(this.taskTrackerTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TabControlTaskTracker";
            this.Size = new System.Drawing.Size(655, 371);
            this.Load += new System.EventHandler(this.setDefaultPriority_Load);
            this.PriorityGroupBox.ResumeLayout(false);
            this.PriorityGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl taskTrackerTabControl;
        private System.Windows.Forms.GroupBox PriorityGroupBox;
        private System.Windows.Forms.RadioButton LowPriorityButton;
        private System.Windows.Forms.RadioButton MediumPriorityButton;
        private System.Windows.Forms.RadioButton HighPriorityButton;
    }
}
