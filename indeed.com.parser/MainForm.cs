using indeed.com.models;
using indeed.com.models.NewTaskParameters;
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

            TaskParameters taskParameters = TaskParameters.Create
                .Events
                    .Error((m) => MessageBox.Show(m))
                    .Complete((m) => MessageBox.Show(m))
                .Fields
                    .Name(createTaskPresenter.Name)
                    .Description(createTaskPresenter.Description)
                    .Request(createTaskPresenter.Request)
                .Get;



            presenters.Add(new TaskPanelPresenter(taskPanel as ITaskPanelView, taskParameters));
            tasksLayoutPanel.Controls.Add(taskPanel);

            logTabs.TabPages.Add(new TabPage("Task"));
        }
    }
}
