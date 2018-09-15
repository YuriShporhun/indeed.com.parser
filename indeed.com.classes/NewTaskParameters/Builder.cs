namespace indeed.com.models.NewTaskParameters
{
    public class Builder
    {
        private Parameters parameters;
        internal Builder() { }

        public FieldBuilder Fields => new FieldBuilder(parameters);
        public EventBuilder Events => new EventBuilder(parameters);
    }
}
