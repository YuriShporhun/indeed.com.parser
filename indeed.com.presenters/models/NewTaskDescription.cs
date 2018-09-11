namespace indeed.com.models
{
    public class NewTaskDescription
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public ParserRequest Request { get; internal set; }
    }
}
