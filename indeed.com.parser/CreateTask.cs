using indeed.com.models;
using indeed.com.presenters.views;
using System;
using System.Windows.Forms;

namespace indeed.com.parser
{
    public partial class CreateTask : Form, ICreateTaskView
    {
        public CreateTask() => InitializeComponent();
        
        public string TaskName => taskNameTextBox.Text;
        public string TaskDescription => taskDescriptionTextBox.Text;

        public ParserRequest Request =>
            new ParserRequestBuilder()
                .FindJob(jobTextBox.Text)
                .InCity(cityTextBox.Text)
                .WithSalary(Convert.ToInt32(salaryTextBox.Text))
                .Build();

        public event EventHandler<EventArgs> Create;

        private void createTaskButton_Click(object sender, EventArgs e)
        {
            Create(this, EventArgs.Empty);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) => Close();
    }
}
