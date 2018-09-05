using System;

namespace indeed.com.presenters
{
    public interface ITaskPanelView
    {
        void SetTaskName(string name);
        void SetTaskDescription(string description);
        void UpdateProgress(int progress);
        event EventHandler<EventArgs> Run;
        event EventHandler<EventArgs> Pause;
        event EventHandler<EventArgs> Cancel;
        event EventHandler<EventArgs> Result;
    }
}
