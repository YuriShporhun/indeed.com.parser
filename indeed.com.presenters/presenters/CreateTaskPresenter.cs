using indeed.com.models;
using indeed.com.presenters.views;
using System;

namespace indeed.com.presenters
{
    public class CreateTaskPresenter
    {
        NewTaskDescription model = new NewTaskDescription();
        ICreateTaskView view;

        public CreateTaskPresenter(ICreateTaskView view)
        {
            this.view = view;
            view.Create += CreateTask;
        }

        private void CreateTask(object sender, EventArgs e)
        {
            model.Name = view.TaskName;
            model.Description = view.TaskDescription;
        }

        public string Name => model.Name;
        public string Description => model.Description;
    }
}
