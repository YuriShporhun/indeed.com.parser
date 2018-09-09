using indeed.com.models;
using NUnit.Framework;

namespace indeed.com.tests
{
    [TestFixture]
    public class ParserRequestBulderTests
    {
        private ParserRequestBuilder builder;

        [SetUp]
        public void SetUp()
        {
            builder = new ParserRequestBuilder();
        }

        [Test]
        public void IsRequestBuildedProperly_CorrectParams_ShouldPass()
        {
            string request = builder
                .FindJob("engineer")
                .InCity("Charlottesville")
                .WithSalary(80000)
                .Build()
                .ToString();

            Assert.AreEqual(request, "q-engineer-$80000-l-Charlottesville-jobs.html");
        }
    }
}
