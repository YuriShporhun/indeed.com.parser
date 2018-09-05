using indeed.com.models;

namespace indeed.com.presenters
{
    public class TaskPanelPresenter: IRefreshable
    {
        private ITaskPanelView view;
        private TaskModel model;

        public TaskPanelPresenter(ITaskPanelView view)
        {
            this.view = view;
            model = new TaskModel();
        }

        public void Refresh()
        {
            throw new System.NotImplementedException();
        }

        public void RunTask() => model.Run();

        public void CancellTask() => model.Cancell();
    }
}
