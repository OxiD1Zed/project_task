using project_task.DateBase;
using project_task.Entity;
using System.Windows.Forms;

namespace project_task.Screen
{
    public partial class TaskForm : Form
    {
        private readonly Task task;
        private readonly DB db;

        public TaskForm(Task task)
        {
            InitializeComponent();
            this.db = DB.Instance();
            this.task = task;
            Init();
        }

        public TaskForm(long idProject)
        {
            InitializeComponent();
            this.db = DB.Instance();
            this.task = new Task(idProject);
            Task.Insert(this.task);
            this.task.Id = db.InsertTask(task);
            Init();
        }

        private void Init()
        {
            labelIdValue.Text = task.Id.ToString();
            textBoxName.Text = task.Name;
            textBoxDescription.Text = task.Description;
        }

        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            task.Name = textBoxName.Text.Trim();
            task.Description = textBoxDescription.Text.Trim();
            db.UpdateTask(task);
        }
    }
}
