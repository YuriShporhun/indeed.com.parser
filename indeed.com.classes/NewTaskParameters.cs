using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indeed.com.models
{
    public class NewTaskParameters
    {
        public string Name { get; set; } = "Unknown";
        public string Description { get; set; } = string.Empty;
        public ParserRequest request { get; set; }
        public Action<string> OnComplete { get; set; } = null;
        public Action<string> OnError { get; set; } = null;
    }
}
