using System;

namespace indeed.com.models.NewTaskParameters
{
    public class EventBuilder: TaskParametersBuilder
    {
        public EventBuilder(TaskParameters parameters) => this.parameters = parameters;
        public EventBuilder Complete(Action<string> action)
        {
            parameters.OnComplete = action;
            return this;
        }

        public EventBuilder Error(Action<string> action)
        {
            parameters.OnError = action;
            return this;
        }
    }
}
