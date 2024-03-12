namespace project_task.Screen
{
    partial class ProjectForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCreateDateTime = new System.Windows.Forms.Label();
            this.labelLastModifiedDateTime = new System.Windows.Forms.Label();
            this.labelIdValue = new System.Windows.Forms.Label();
            this.labelCreateDateTimeValue = new System.Windows.Forms.Label();
            this.labelLastModifiedDateTimeValue = new System.Windows.Forms.Label();
            this.flowLayoutPanelTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonAddTask = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTasks = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.contextMenuStripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 12;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333332F));
            this.tableLayoutPanelMain.Controls.Add(this.labelId, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelCreateDateTime, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelLastModifiedDateTime, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelIdValue, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelCreateDateTimeValue, 2, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelLastModifiedDateTimeValue, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelTasks, 5, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelTasks, 5, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelId, 2);
            this.labelId.Location = new System.Drawing.Point(19, 99);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(122, 83);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Номер:";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCreateDateTime
            // 
            this.labelCreateDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateDateTime.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelCreateDateTime, 2);
            this.labelCreateDateTime.Location = new System.Drawing.Point(19, 182);
            this.labelCreateDateTime.Name = "labelCreateDateTime";
            this.labelCreateDateTime.Size = new System.Drawing.Size(122, 83);
            this.labelCreateDateTime.TabIndex = 1;
            this.labelCreateDateTime.Text = "Дата создания:";
            this.labelCreateDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastModifiedDateTime
            // 
            this.labelLastModifiedDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastModifiedDateTime.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelLastModifiedDateTime, 2);
            this.labelLastModifiedDateTime.Location = new System.Drawing.Point(19, 265);
            this.labelLastModifiedDateTime.Name = "labelLastModifiedDateTime";
            this.labelLastModifiedDateTime.Size = new System.Drawing.Size(122, 83);
            this.labelLastModifiedDateTime.TabIndex = 2;
            this.labelLastModifiedDateTime.Text = "Дата последнего изменения:";
            this.labelLastModifiedDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdValue
            // 
            this.labelIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdValue.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelIdValue, 3);
            this.labelIdValue.Location = new System.Drawing.Point(147, 99);
            this.labelIdValue.Name = "labelIdValue";
            this.labelIdValue.Size = new System.Drawing.Size(186, 83);
            this.labelIdValue.TabIndex = 3;
            this.labelIdValue.Text = "Новый";
            this.labelIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCreateDateTimeValue
            // 
            this.labelCreateDateTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateDateTimeValue.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelCreateDateTimeValue, 3);
            this.labelCreateDateTimeValue.Location = new System.Drawing.Point(147, 182);
            this.labelCreateDateTimeValue.Name = "labelCreateDateTimeValue";
            this.labelCreateDateTimeValue.Size = new System.Drawing.Size(186, 83);
            this.labelCreateDateTimeValue.TabIndex = 4;
            this.labelCreateDateTimeValue.Text = "Значение";
            this.labelCreateDateTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastModifiedDateTimeValue
            // 
            this.labelLastModifiedDateTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastModifiedDateTimeValue.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelLastModifiedDateTimeValue, 3);
            this.labelLastModifiedDateTimeValue.Location = new System.Drawing.Point(147, 265);
            this.labelLastModifiedDateTimeValue.Name = "labelLastModifiedDateTimeValue";
            this.labelLastModifiedDateTimeValue.Size = new System.Drawing.Size(186, 83);
            this.labelLastModifiedDateTimeValue.TabIndex = 5;
            this.labelLastModifiedDateTimeValue.Text = "Значение";
            this.labelLastModifiedDateTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelTasks
            // 
            this.flowLayoutPanelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTasks.AutoScroll = true;
            this.flowLayoutPanelTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanelMain.SetColumnSpan(this.flowLayoutPanelTasks, 7);
            this.flowLayoutPanelTasks.ContextMenuStrip = this.contextMenuStripActions;
            this.flowLayoutPanelTasks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelTasks.Location = new System.Drawing.Point(339, 102);
            this.flowLayoutPanelTasks.Name = "flowLayoutPanelTasks";
            this.flowLayoutPanelTasks.Padding = new System.Windows.Forms.Padding(16);
            this.tableLayoutPanelMain.SetRowSpan(this.flowLayoutPanelTasks, 4);
            this.flowLayoutPanelTasks.Size = new System.Drawing.Size(442, 329);
            this.flowLayoutPanelTasks.TabIndex = 6;
            this.flowLayoutPanelTasks.WrapContents = false;
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonAddTask});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.Size = new System.Drawing.Size(196, 28);
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(195, 24);
            this.buttonAddTask.Text = "Добавить задачу";
            this.buttonAddTask.Click += new System.EventHandler(this.ButtonAddTask_Click);
            // 
            // labelTasks
            // 
            this.labelTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTasks.AutoSize = true;
            this.tableLayoutPanelMain.SetColumnSpan(this.labelTasks, 7);
            this.labelTasks.Location = new System.Drawing.Point(339, 16);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(442, 83);
            this.labelTasks.TabIndex = 7;
            this.labelTasks.Text = "Задачи:";
            this.labelTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "ProjectForm";
            this.Text = "Проект";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectForm_FormClosing);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.contextMenuStripActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCreateDateTime;
        private System.Windows.Forms.Label labelLastModifiedDateTime;
        private System.Windows.Forms.Label labelIdValue;
        private System.Windows.Forms.Label labelCreateDateTimeValue;
        private System.Windows.Forms.Label labelLastModifiedDateTimeValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTasks;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActions;
        private System.Windows.Forms.ToolStripMenuItem buttonAddTask;
    }
}