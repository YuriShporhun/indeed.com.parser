using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indeed.com.presenters
{
    class TaskPanelPresenter
    {
        private ITaskPanelView view;

        public TaskPanelPresenter(ITaskPanelView view)
        {
            this.view = view;
        }
    }
}
