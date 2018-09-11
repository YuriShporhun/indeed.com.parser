namespace indeed.com.parser
{
    partial class TaskPanel
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.taskNametextBox = new System.Windows.Forms.TextBox();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.runTaskButton = new System.Windows.Forms.Button();
            this.pauseTaskButton = new System.Windows.Forms.Button();
            this.cancelTaskButton = new System.Windows.Forms.Button();
            this.taskResultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 118);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Progress";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(3, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(79, 13);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "<Task header>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // taskNametextBox
            // 
            this.taskNametextBox.Location = new System.Drawing.Point(84, 20);
            this.taskNametextBox.Name = "taskNametextBox";
            this.taskNametextBox.Size = new System.Drawing.Size(211, 20);
            this.taskNametextBox.TabIndex = 5;
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(84, 48);
            this.taskDescriptionTextBox.Multiline = true;
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(211, 51);
            this.taskDescriptionTextBox.TabIndex = 6;
            // 
            // runTaskButton
            // 
            this.runTaskButton.Location = new System.Drawing.Point(17, 147);
            this.runTaskButton.Name = "runTaskButton";
            this.runTaskButton.Size = new System.Drawing.Size(72, 23);
            this.runTaskButton.TabIndex = 7;
            this.runTaskButton.Text = "Run";
            this.runTaskButton.UseVisualStyleBackColor = true;
            this.runTaskButton.Click += new System.EventHandler(this.runTaskButton_Click);
            // 
            // pauseTaskButton
            // 
            this.pauseTaskButton.Location = new System.Drawing.Point(95, 147);
            this.pauseTaskButton.Name = "pauseTaskButton";
            this.pauseTaskButton.Size = new System.Drawing.Size(64, 23);
            this.pauseTaskButton.TabIndex = 8;
            this.pauseTaskButton.Text = "Pause";
            this.pauseTaskButton.UseVisualStyleBackColor = true;
            this.pauseTaskButton.Click += new System.EventHandler(this.pauseTaskButton_Click);
            // 
            // cancelTaskButton
            // 
            this.cancelTaskButton.Location = new System.Drawing.Point(165, 147);
            this.cancelTaskButton.Name = "cancelTaskButton";
            this.cancelTaskButton.Size = new System.Drawing.Size(63, 23);
            this.cancelTaskButton.TabIndex = 9;
            this.cancelTaskButton.Text = "Cancel";
            this.cancelTaskButton.UseVisualStyleBackColor = true;
            this.cancelTaskButton.Click += new System.EventHandler(this.cancelTaskButton_Click);
            // 
            // taskResultButton
            // 
            this.taskResultButton.Location = new System.Drawing.Point(234, 147);
            this.taskResultButton.Name = "taskResultButton";
            this.taskResultButton.Size = new System.Drawing.Size(61, 23);
            this.taskResultButton.TabIndex = 10;
            this.taskResultButton.Text = "Result";
            this.taskResultButton.UseVisualStyleBackColor = true;
            this.taskResultButton.Click += new System.EventHandler(this.taskResultButton_Click);
            // 
            // TaskPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.taskResultButton);
            this.Controls.Add(this.cancelTaskButton);
            this.Controls.Add(this.pauseTaskButton);
            this.Controls.Add(this.runTaskButton);
            this.Controls.Add(this.taskDescriptionTextBox);
            this.Controls.Add(this.taskNametextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Name = "TaskPanel";
            this.Size = new System.Drawing.Size(317, 195);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox taskNametextBox;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Button runTaskButton;
        private System.Windows.Forms.Button pauseTaskButton;
        private System.Windows.Forms.Button cancelTaskButton;
        private System.Windows.Forms.Button taskResultButton;
    }
}
