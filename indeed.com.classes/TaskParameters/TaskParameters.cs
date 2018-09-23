using System;

namespace indeed.com.models.NewTaskParameters
{
    public class TaskParameters
    {
        public string Name { get; set; } = "Unknown";
        public string Description { get; set; } = string.Empty;
        public ParserRequest request { get; set; }
        public Action<string> OnComplete { get; set; } = null;
        public Action<string> OnError { get; set; } = null;
        private TaskParameters() { }
        public static Builder Create => new Builder();

        public class Builder
        {
            protected TaskParameters parameters = new TaskParameters();
            internal Builder() { }

            public FieldBuilder Fields => new FieldBuilder(parameters);
            public EventBuilder Events => new EventBuilder(parameters);
            public TaskParameters Get => parameters;
        }
    }
}
