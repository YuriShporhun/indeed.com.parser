using indeed.com.models;
using indeed.com.models.NewTaskParameters;
using System;

namespace indeed.com.presenters
{
    public class TaskPanelPresenter
    {
        private ITaskPanelView view;
        private TaskPanelModel model = new TaskPanelModel();

        public TaskPanelPresenter(ITaskPanelView view, TaskParameters parameters)
        {
            this.view = view;
            model.Name = parameters.Name;
            model.Description = parameters.Description;
            model.Request = parameters.request;
            model.OnError += parameters.OnError;
            model.OnComplete += parameters.OnComplete;
            view.SetTaskHeader = parameters.request.Description;
            view.SetTaskName = parameters.Name;
            view.SetTaskDescription = parameters.Description;
            view.Run += RunTask;
            view.Pause += PauseTask;
            view.Cancel += CancelTask;
        }

        public async void RunTask(object sender, EventArgs e) => await model.Run();
        public void CancelTask(object sender, EventArgs e) => model.Cancel();
        public void PauseTask(object sender, EventArgs e) => model.Pause();
    }
}
