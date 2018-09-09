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
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string PostingTime { get; set; }
        public int ApproxSalary { get; set; }
    }
}
