using System;

namespace indeed.com.presenters.views
{
    public interface ICreateTaskView
    {
        string TaskName { get; }
        string TaskDescription { get; }
        event EventHandler<EventArgs> Create;
    }
}
