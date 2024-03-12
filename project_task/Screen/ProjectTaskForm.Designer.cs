namespace project_task.Screen
{
    partial class ProjectTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAddProject = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStripAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripAction
            // 
            this.contextMenuStripAction.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAddProject});
            this.contextMenuStripAction.Name = "contextMenuStripAction";
            this.contextMenuStripAction.Size = new System.Drawing.Size(198, 28);
            this.contextMenuStripAction.Text = "Действия";
            // 
            // buttonAddProject
            // 
            this.buttonAddProject.Name = "buttonAddProject";
            this.buttonAddProject.Size = new System.Drawing.Size(197, 24);
            this.buttonAddProject.Text = "Добавить проект";
            this.buttonAddProject.Click += new System.EventHandler(this.ButtonAddProject_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.AutoScroll = true;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Padding = new System.Windows.Forms.Padding(16);
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.flowLayoutPanelMain.TabIndex = 2;
            this.flowLayoutPanelMain.WrapContents = false;
            // 
            // ProjectTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripAction;
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Name = "ProjectTaskForm";
            this.Text = "Проекты";
            this.contextMenuStripAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAction;
        private System.Windows.Forms.ToolStripMenuItem buttonAddProject;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
    }
}