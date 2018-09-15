using System;

namespace indeed.com.models.NewTaskParameters
{
    public class Parameters
    {
        public string Name { get; set; } = "Unknown";
        public string Description { get; set; } = string.Empty;
        public ParserRequest request { get; set; }
        public Action<string> OnComplete { get; set; } = null;
        public Action<string> OnError { get; set; } = null;
        private Parameters() { }
        public Builder Create => new Builder();
    }
}
