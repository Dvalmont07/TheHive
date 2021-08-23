
using System.Collections.Generic;
using TheHive.Classes;

namespace TheHive
{
    partial class Hive
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
            this.cmbxShifts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.cmbxTasks = new System.Windows.Forms.ComboBox();
            this.btnNextShift = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbxShifts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAssignJob);
            this.groupBox1.Controls.Add(this.cmbxTasks);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment of Workers Tasks ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Worker\'s task";
            // 
            // cmbxShifts
            // 
            this.cmbxShifts.FormattingEnabled = true;
            this.cmbxShifts.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbxShifts.Location = new System.Drawing.Point(249, 46);
            this.cmbxShifts.Name = "cmbxShifts";
            this.cmbxShifts.Size = new System.Drawing.Size(89, 23);
            this.cmbxShifts.TabIndex = 4;
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
            // btnAssignJob
            // 
            this.btnAssignJob.Location = new System.Drawing.Point(6, 77);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(237, 23);
            this.btnAssignJob.TabIndex = 2;
            this.btnAssignJob.Text = "Assign this job to a Worker";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // cmbxTasks
            // 
            this.cmbxTasks.FormattingEnabled = true;
            this.cmbxTasks.Location = new System.Drawing.Point(6, 46);
            this.cmbxTasks.Name = "cmbxTasks";
            this.cmbxTasks.Size = new System.Drawing.Size(237, 23);
            this.cmbxTasks.TabIndex = 0;
            // 
            // btnNextShift
            // 
            this.btnNextShift.Location = new System.Drawing.Point(362, 20);
            this.btnNextShift.Name = "btnNextShift";
            this.btnNextShift.Size = new System.Drawing.Size(96, 104);
            this.btnNextShift.TabIndex = 1;
            this.btnNextShift.Text = "Next Shift";
            this.btnNextShift.UseVisualStyleBackColor = true;
            this.btnNextShift.Click += new System.EventHandler(this.btnNextShift_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(12, 354);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 3;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(12, 130);
            this.txtReport.Name = "txtReport";
            this.txtReport.ReadOnly = true;
            this.txtReport.Size = new System.Drawing.Size(446, 218);
            this.txtReport.TabIndex = 12;
            this.txtReport.Text = "";
            // 
            // Hive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 387);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnNextShift);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hive";
            this.Text = "The Hive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextShift;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.ComboBox cmbxTasks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxShifts;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.RichTextBox txtReport;
    }
}

