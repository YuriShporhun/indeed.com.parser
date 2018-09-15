using System;

namespace indeed.com.models.NewTaskParameters
{
    public class EventBuilder
    {
        Parameters parameters;
        public EventBuilder(Parameters parameters) => this.parameters = parameters;
        public EventBuilder Complete(Action<string> action)
        {
            parameters.OnComplete = action;
            return this;
        }
    }
}
