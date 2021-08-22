
namespace TheHive
{
    partial class theHive
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.assignJob = new System.Windows.Forms.Button();
            this.shift = new System.Windows.Forms.ComboBox();
            this.tasks = new System.Windows.Forms.ComboBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.shift);
            this.groupBox1.Controls.Add(this.tasks);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment of Workers Tasks ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Worker\'s task";
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 77);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(237, 23);
            this.assignJob.TabIndex = 2;
            this.assignJob.Text = "Assign this job to a Worker";
            this.assignJob.UseVisualStyleBackColor = true;
            // 
            // shift
            // 
            this.shift.FormattingEnabled = true;
            this.shift.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.shift.Location = new System.Drawing.Point(249, 46);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(119, 23);
            this.shift.TabIndex = 1;
            // 
            // tasks
            // 
            this.tasks.FormattingEnabled = true;
            this.tasks.Items.AddRange(new object[] {
            "Collect honey",
            "Produce honey",
            "Take care of the eggs",
            "Teach baby bees",
            "Maintain hive",
            "Patrol"});
            this.tasks.Location = new System.Drawing.Point(6, 46);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(237, 23);
            this.tasks.TabIndex = 0;
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(407, 24);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(96, 88);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Next Shift";
            this.nextShift.UseVisualStyleBackColor = true;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 141);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(491, 210);
            this.report.TabIndex = 2;
            // 
            // theHive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 360);
            this.Controls.Add(this.report);
            this.Controls.Add(this.nextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "theHive";
            this.Text = "The Hive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.ComboBox shift;
        private System.Windows.Forms.ComboBox tasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox report;
    }
}

