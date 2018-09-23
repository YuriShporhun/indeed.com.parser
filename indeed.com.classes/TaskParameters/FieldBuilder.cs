namespace indeed.com.models.NewTaskParameters
{
    public class FieldBuilder: TaskParameters.Builder
    {
        public FieldBuilder(TaskParameters parameters) => this.parameters = parameters;
        public FieldBuilder Name(string name)
        {
            parameters.Name = name;
            return this;
        }

        public FieldBuilder Description(string description)
        {
            parameters.Description = description;
            return this;
        }

        public FieldBuilder Request(ParserRequest request)
        {
            parameters.request = request;
            return this;
        }
    }
}
