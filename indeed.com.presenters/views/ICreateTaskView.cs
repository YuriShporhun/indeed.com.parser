using indeed.com.models;
using System;

namespace indeed.com.presenters.views
{
    public interface ICreateTaskView
    {
        string TaskName { get; }
        string TaskDescription { get; }
        ParserRequest Request { get; }
        event EventHandler<EventArgs> Create;
    }
}
