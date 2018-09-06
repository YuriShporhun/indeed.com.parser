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

            presenters.Add(new TaskPanelPresenter(taskPanel as ITaskPanelView, 
                createTaskPresenter.Name, 
                createTaskPresenter.Description));

            tasksLayoutPanel.Controls.Add(taskPanel);

            logTabs.TabPages.Add(new TabPage("Task"));
        }
    }
}
