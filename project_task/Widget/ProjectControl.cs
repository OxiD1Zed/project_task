using project_task.Entity;
using System;
using System.Windows.Forms;

namespace project_task.Widget
{
    public partial class ProjectControl : UserControl
    {
        private Project project;

        public Project Project
        {
            get { return project; }
            set
            {
                if(value != null)
                {
                    project = value;
                    labelIdValue.Text = project.Id.ToString();
                    labelLastModifiedDateTimeValue.Text = project.LastModifiedDateTime.ToLocalTime().ToString();
                    labelCreateDateTimeValue.Text = project.CreateDateTime.ToLocalTime().ToString();
                }
            }
        }

        public ProjectControl()
        {
            InitializeComponent();
        }

        public void SetButtonChangeEventClick(EventHandler eventHandler)
        {
            buttonChangeProject.Click += eventHandler;
        }

        public void SetButtonDeleteEventClick(EventHandler eventHandler)
        {
            buttonDeleteProject.Click += eventHandler;
        }
    }
}
