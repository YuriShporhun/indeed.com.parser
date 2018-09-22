namespace indeed.com.models.NewTaskParameters
{
    public class TaskParametersBuilder
    {
        protected TaskParameters parameters;
        internal TaskParametersBuilder() { }

        public FieldBuilder Fields => new FieldBuilder(parameters);
        public EventBuilder Events => new EventBuilder(parameters);
        public TaskParameters Get => parameters;
    }
}
