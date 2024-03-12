namespace project_task.Widget
{
    partial class TaskControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxIsCompleted = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelIdValue = new System.Windows.Forms.Label();
            this.labelNameValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonChangeTask = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDeleteTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            this.contextMenuStripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 5;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Controls.Add(this.checkBoxIsCompleted, 4, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelIdValue, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelNameValue, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelName, 2, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(691, 86);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // checkBoxIsCompleted
            // 
            this.checkBoxIsCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsCompleted.AutoSize = true;
            this.checkBoxIsCompleted.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIsCompleted.Location = new System.Drawing.Point(555, 33);
            this.checkBoxIsCompleted.Name = "checkBoxIsCompleted";
            this.checkBoxIsCompleted.Size = new System.Drawing.Size(133, 20);
            this.checkBoxIsCompleted.TabIndex = 7;
            this.checkBoxIsCompleted.Text = "Выполнен";
            this.checkBoxIsCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxIsCompleted.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(132, 86);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "Номер:";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdValue
            // 
            this.labelIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdValue.AutoSize = true;
            this.labelIdValue.Location = new System.Drawing.Point(141, 0);
            this.labelIdValue.Name = "labelIdValue";
            this.labelIdValue.Size = new System.Drawing.Size(132, 86);
            this.labelIdValue.TabIndex = 2;
            this.labelIdValue.Text = "Значение";
            this.labelIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNameValue
            // 
            this.labelNameValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameValue.AutoSize = true;
            this.labelNameValue.Location = new System.Drawing.Point(417, 0);
            this.labelNameValue.Name = "labelNameValue";
            this.labelNameValue.Size = new System.Drawing.Size(132, 86);
            this.labelNameValue.TabIndex = 6;
            this.labelNameValue.Text = "Значение";
            this.labelNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(279, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 86);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Название:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonChangeTask,
            this.buttonDeleteTask});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.Size = new System.Drawing.Size(181, 52);
            this.contextMenuStripActions.Text = "Действия";
            // 
            // buttonChangeTask
            // 
            this.buttonChangeTask.Name = "buttonChangeTask";
            this.buttonChangeTask.Size = new System.Drawing.Size(180, 24);
            this.buttonChangeTask.Text = "Редактировать";
            // 
            // buttonDeleteTask
            // 
            this.buttonDeleteTask.Name = "buttonDeleteTask";
            this.buttonDeleteTask.Size = new System.Drawing.Size(180, 24);
            this.buttonDeleteTask.Text = "Удалить";
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStripActions;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 8, 8);
            this.Name = "TaskControl";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(723, 118);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.contextMenuStripActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelNameValue;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelIdValue;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxIsCompleted;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActions;
        private System.Windows.Forms.ToolStripMenuItem buttonChangeTask;
        private System.Windows.Forms.ToolStripMenuItem buttonDeleteTask;
    }
}
