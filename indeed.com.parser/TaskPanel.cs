using System;
using System.Windows.Forms;
using indeed.com.presenters;

namespace indeed.com.parser
{
    public partial class TaskPanel : UserControl, ITaskPanelView
    {
        public TaskPanel()
        {
            InitializeComponent();
        }

        public string SetTaskName { set => taskNametextBox.Text = value; }
        public string SetTaskDescription { set => taskDescriptionTextBox.Text = value; }
        public string SetTaskHeader { set => this.headerLabel.Text = value; }

        public event EventHandler<EventArgs> Run;
        public event EventHandler<EventArgs> Pause;
        public event EventHandler<EventArgs> Cancel;
        public event EventHandler<EventArgs> Result;

        public void UpdateProgress(int progress)
        {
            throw new NotImplementedException();
        }

        private void runTaskButton_Click(object sender, EventArgs e) =>
            Run?.Invoke(sender, EventArgs.Empty);

        private void pauseTaskButton_Click(object sender, EventArgs e) =>
            Pause?.Invoke(sender, EventArgs.Empty);

        private void cancelTaskButton_Click(object sender, EventArgs e) =>
            Cancel?.Invoke(sender, EventArgs.Empty);

        private void taskResultButton_Click(object sender, EventArgs e) =>
            Result?.Invoke(sender, EventArgs.Empty);
    }
}
