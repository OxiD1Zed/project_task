using project_task.DateBase;
using project_task.Entity;
using project_task.Widget;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace project_task.Screen
{
    public partial class ProjectForm : Form
    {
        private readonly FormService formService;
        private readonly DB db;
        private readonly Project project;

        public ProjectForm(Project project)
        {
            InitializeComponent();
            formService = FormService.Instance();
            db = DB.Instance();
            this.flowLayoutPanelTasks.SizeChanged += formService.FlowLayoutPanel_SizeChanged;
            if(project == null)
            {
                this.project = new Project();
                Project.Insert(this.project);
                long id = db.InsertProject(this.project);
                this.project.Id = id;
            }
            else
            {
                this.project = project;
            }

            labelIdValue.Text = this.project.Id.ToString();
            labelCreateDateTimeValue.Text = this.project.CreateDateTime.ToLocalTime().ToString();
            labelLastModifiedDateTimeValue.Text = this.project.LastModifiedDateTime.ToLocalTime().ToString();
            LoadTasks();
        }

        private void LoadTasks()
        {
            flowLayoutPanelTasks.Controls.Clear();
            foreach(Task task in Task.SelectAllFromIdProject(project.Id))
            {
                TaskControl control = new TaskControl()
                {
                    Task = task
                };
                control.Size = new Size(flowLayoutPanelTasks.Size.Width - flowLayoutPanelTasks.Padding.Horizontal - control.Margin.Horizontal, control.Size.Height);
                control.SetIsCompletedClick((sender, e) =>
                {
                    task.IsCompleted = !task.IsCompleted;
                    db.UpdateTask(task);
                });
                control.SetButtonChangeClick((sender, e) =>
                {
                    TaskForm taskForm = new TaskForm(task);
                    taskForm.ShowDialog();
                    LoadTasks();
                });
                control.SetButtonDeleteClick((sender, e) =>
                {
                    db.DeleteTask(task.Id);
                    Task.Delete(task);
                    LoadTasks();
                });
                flowLayoutPanelTasks.Controls.Add(control);
            }
        }

        private void ButtonAddTask_Click(object sender, EventArgs e)
        {
            TaskForm taskForm = new TaskForm(project.Id);
            taskForm.ShowDialog();
            LoadTasks();
        }

        private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            project.LastModifiedDateTime = DateTime.Now;
            db.UpdateProject(project);
        }
    }
}
