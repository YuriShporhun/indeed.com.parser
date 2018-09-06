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

        public string SetTaskName { set => taskNametextBox.Text = value; }
        public string SetTaskDescription { set => taskDescriptionTextBox.Text = value; }

        public event EventHandler<EventArgs> Run;
        public event EventHandler<EventArgs> Pause;
        public event EventHandler<EventArgs> Cancel;
        public event EventHandler<EventArgs> Result;

        public void UpdateProgress(int progress)
        {
            throw new NotImplementedException();
        }

        private void TaskPanel_Load(object sender, EventArgs e)
        {
       
        }
    }
}
