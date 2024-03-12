using project_task.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;
using project_task.DateBase;
using project_task.Widget;

namespace project_task.Screen
{
    public partial class ProjectTaskForm : Form
    {
        private readonly FormService formService;
        private readonly DB db;
        public ProjectTaskForm()
        {
            InitializeComponent();
            formService = FormService.Instance();
            db = DB.Instance();

            this.flowLayoutPanelMain.SizeChanged += formService.FlowLayoutPanel_SizeChanged;
            db.CreateTableProject();
            db.CreateTableTask();
            Project.InsertRange(db.SelectProjects().ToArray());
            foreach (var project in db.SelectProjects())
            {
                Task.InsertRange(db.SelectTasksByIdProject(project.Id).ToArray());
            }
            LoadProjects();
        }

        private void LoadProjects()
        {
            flowLayoutPanelMain.Controls.Clear();
            foreach(Project project in Project.SelectAll())
            {
                ProjectControl control = new ProjectControl()
                {
                    Project = project
                };
                control.Size = new Size(flowLayoutPanelMain.Size.Width - flowLayoutPanelMain.Padding.Horizontal - control.Margin.Horizontal, control.Size.Height);
                control.SetButtonChangeEventClick((sender, e) => 
                {
                    ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
                    ContextMenuStrip contextMenuStrip = toolStripMenuItem.Owner as ContextMenuStrip;
                    ProjectControl localControl = contextMenuStrip.SourceControl as ProjectControl;
                    ProjectForm projectForm = new ProjectForm(localControl.Project);
                    projectForm.ShowDialog();
                    LoadProjects();
                });
                control.SetButtonDeleteEventClick((sender, e) => 
                {
                    db.DeleteProject(project.Id);
                    Project.Delete(project);
                    foreach(Task task in Task.SelectAllFromIdProject(project.Id))
                    {
                        Task.Delete(task);
                    }
                    LoadProjects();
                    
                });
                flowLayoutPanelMain.Controls.Add(control);
            }
        }

        private void ButtonAddProject_Click(object sender, EventArgs e)
        {
            ProjectForm projectForm = new ProjectForm(null);
            projectForm.ShowDialog();
            LoadProjects();
        }
    }
}
