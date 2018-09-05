using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using indeed.com.presenters;

namespace indeed.com.parser
{
    public partial class TaskPanel : UserControl, ITaskPanelView
    {
        public TaskPanel()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> Run;
        public event EventHandler<EventArgs> Pause;
        public event EventHandler<EventArgs> Cancel;
        public event EventHandler<EventArgs> Result;

        public void SetTaskDescription(string description)
        {
            throw new NotImplementedException();
        }

        public void SetTaskName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateProgress(int progress)
        {
            throw new NotImplementedException();
        }
    }
}
