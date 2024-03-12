using project_task.Entity;
using System;
using System.Windows.Forms;

namespace project_task.Widget
{
    public partial class TaskControl : UserControl
    {
        private Task task;

        public Task Task 
        {
            get 
            {
                return task;
            }
            set
            {
                if(value != null)
                {
                    task = value;
                    labelIdValue.Text = task.Id.ToString();
                    labelNameValue.Text = task.Name ?? "";
                    checkBoxIsCompleted.Checked = task.IsCompleted;
                }
            }
        }

        public TaskControl()
        {
            InitializeComponent();
        }

        public void SetIsCompletedClick(EventHandler eventHandler)
        {
            checkBoxIsCompleted.CheckedChanged += eventHandler;
        }

        public void SetButtonChangeClick(EventHandler eventHandler)
        {
            buttonChangeTask.Click += eventHandler;
        }

        public void SetButtonDeleteClick(EventHandler eventHandler)
        {
            buttonDeleteTask.Click += eventHandler;
        }
    }
}
