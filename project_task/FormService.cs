using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_task
{
    internal class FormService
    {
        private static FormService instance = new FormService();

        private FormService() { }

        public static FormService Instance()
        {
            return instance;
        }

        public void FlowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)sender;
            foreach(Control control in flowLayoutPanel.Controls)
            {
                control.Size = new System.Drawing.Size(flowLayoutPanel.Size.Width - flowLayoutPanel.Padding.Horizontal - control.Margin.Horizontal, control.Size.Height);
            }
        }
    }
}
