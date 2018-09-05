using indeed.com.presenters.views;
using System;
using System.Windows.Forms;

namespace indeed.com.parser
{
    public partial class CreateTask : Form, ICreateTaskView
    {
        public CreateTask()
        {
            InitializeComponent();
        }

        public string TaskName => taskNameTextBox.Text;
        public string TaskDescription => taskDescriptionTextBox.Text;
        public event EventHandler<EventArgs> Create;

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            Create(this, EventArgs.Empty);
            Close();
        }
    }
}
