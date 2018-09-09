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
        public string CompanyName { get; }
        public string Description { get; }
        public string Title { get; }
        public string City { get; }
        public string PostingTime { get; }
        public int? ApproxSalary { get; }
    }
}
