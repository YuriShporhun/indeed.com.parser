using indeed.com.models;
using indeed.com.presenters;
using indeed.com.presenters.views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace indeed.com.parser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ICollection<TaskPanelPresenter> presenters = new Collection<TaskPanelPresenter>();

        private void createToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new CreateTask();
            CreateTaskPresenter createTaskPresenter = new CreateTaskPresenter(form as ICreateTaskView);
            form.ShowDialog();

            UserControl taskPanel = new TaskPanel();

            //TODO add NewTaskParameters bulder or whatever
            /*presenters.Add(new TaskPanelPresenter(taskPanel as ITaskPanelView, new NewTaskParameters
                createTaskPresenter.Name, 
                createTaskPresenter.Description,
                createTaskPresenter.Request,
                (m) => MessageBox.Show(m),
                (m) => MessageBox.Show(m)));*/

            tasksLayoutPanel.Controls.Add(taskPanel);

            logTabs.TabPages.Add(new TabPage("Task"));
        }
    }
}
