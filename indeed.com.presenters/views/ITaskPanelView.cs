using System;

namespace indeed.com.presenters
{
    public interface ITaskPanelView
    {
        string SetTaskName { set; }
        string SetTaskDescription { set; }

        void UpdateProgress(int progress);
        event EventHandler<EventArgs> Run;
        event EventHandler<EventArgs> Pause;
        event EventHandler<EventArgs> Cancel;
        event EventHandler<EventArgs> Result;
    }
}
