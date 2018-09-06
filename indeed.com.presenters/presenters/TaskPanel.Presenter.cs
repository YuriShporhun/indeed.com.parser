using indeed.com.models;

namespace indeed.com.presenters
{
    public class TaskPanelPresenter
    {
        private ITaskPanelView view;
        private TaskModel model = new TaskModel();

        public TaskPanelPresenter(ITaskPanelView view, string name, string description)
        {
            this.view = view;
            model.Name = name;
            model.Description = description;
            view.SetTaskName = name;
            view.SetTaskDescription = description;
        }

        public void RunTask() => model.Run();
        public void CancellTask() => model.Cancell();
    }
}
