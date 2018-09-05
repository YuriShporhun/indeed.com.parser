namespace indeed.com.models
{
    public class ParserRequestBuilder
    {
        private ParserRequest parameters = new ParserRequest();

        public ParserRequestBuilder FindJob(string jobPosition)
        {
            parameters.JobPosition = jobPosition;
            return this;
        }

        public ParserRequestBuilder InCity(string city)
        {
            parameters.City = city;
            return this;
        }

        public ParserRequestBuilder WithSalary(int salary)
        {
            parameters.ExpectedSalary = salary;
            return this;
        }

        public ParserRequest Build()
        {
            return parameters;
        }
    }
}
