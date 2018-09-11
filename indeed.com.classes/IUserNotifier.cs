using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indeed.com.models
{
    public interface IUserNotifier
    {
        void NotifyUser(string message, string caption);
    }
}
