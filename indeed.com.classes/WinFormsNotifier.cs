using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indeed.com.models
{
    class WinFormsNotifier : IUserNotifier
    {
        public void NotifyUser(string message, string caption)
        {
            MessageBox.Show(message, caption);
        }
    }
}
