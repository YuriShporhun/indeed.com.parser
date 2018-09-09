using System;
using System.Text.RegularExpressions;

namespace indeed.com.models
{
    /// <summary>
    /// Provides a bunch of parameters the parser needs, to be able to query different kind of jobs, salaries, cities, etc.
    /// </summary>
    /// <remarks>
    /// Can form a get request link to indeed.com.
    /// </remarks>
    public class ParserRequest
    {
        private string jobPosition = string.Empty;
        private int expectedSalary = 0;
        private string city = string.Empty;

        private static readonly string onlyLettersRegExp = @"^[a-zA-Z]+$";

        /// <summary>
        /// A job position to parse
        /// </summary>
        /// <remarks>
        /// Can contain only letters.
        /// Cannot be an empty string.
        /// </remarks>
        /// <example>
        /// Job position examples which can be used: 
        /// programer
        /// engineer
        /// worker
        /// Job position examples which will be rejected:
        /// programmer-worker (a dash symbol rejected)
        /// programmer engineer (a space symbol rejected)
        /// </example>
        public string JobPosition
        {
            get => jobPosition;
            internal set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(JobPosition)} cannot be an empty string or null");
                }
                if(!Regex.IsMatch(value, onlyLettersRegExp))
                {
                    throw new ArgumentException($"{nameof(JobPosition)} has to contain only letters");
                }
                jobPosition = value;
            }
        }

        /// <summary>
        /// Expected salary for a job position to parse.
        /// </summary>
        /// <remarks>
        /// When expected salary is formed into an output string the dollar sign will be added automatically.
        /// If 0 - it will be an empty string.
        /// Positive numbers only.
        /// </remarks>
        public int ExpectedSalary
        {
            get => expectedSalary;
            internal set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"{nameof(ExpectedSalary)} has to be a poistive number");
                }
                expectedSalary = value;
            }
        }

        /// <summary>
        /// City where a job is located
        /// </summary>
        /// <remarks>
        /// Can contain only letters.
        /// If city is an empty string it will be ignored.
        /// </remarks>
        public string City
        {
            get => city;
            internal set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(City)} cannot be an empty string or null");
                }
                city = value;
            }
        }

        public override string ToString()
        {
            return $"q-{JobPosition}-${ExpectedSalary}-l-{City}-jobs.html";
        }

        internal ParserRequest() { }
    }
}
