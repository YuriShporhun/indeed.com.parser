using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indeed.com.models
{
    /// <summary>
    /// Represents a basic job information. 
    /// </summary>
    public class JobInfo
    {
        /// <summary>
        /// ID of a job info 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Company's name which posted a job
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Description of a job
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Tittle of a job
        /// </summary>
        /// <remarks>
        /// It's usually a job name and some basic job info
        /// </remarks>
        public string Title { get; set; }

        /// <summary>
        /// City where a job is located
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Posting time of a job
        /// </summary>
        /// <remarks>
        /// It's usually in format like 'N-time ago'
        /// </remarks>
        public string PostingTime { get; set; }

        /// <summary>
        /// Salary if a job
        /// </summary>
        /// <remarks>
        /// It basically is the ExpectedSalary field from ParserRequest
        /// </remarks>
        public int ApproxSalary { get; set; }
    }
}
