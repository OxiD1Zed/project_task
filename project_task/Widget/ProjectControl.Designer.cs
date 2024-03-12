namespace project_task.Widget
{
    partial class ProjectControl
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
            this.labelIdValue = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCreateDateTime = new System.Windows.Forms.Label();
            this.labelCreateDateTimeValue = new System.Windows.Forms.Label();
            this.labelLastModifiedDateTimeValue = new System.Windows.Forms.Label();
            this.labelLastModifiedDateTime = new System.Windows.Forms.Label();
            this.contextMenuStripActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonChangeProject = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDeleteProject = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain.SuspendLayout();
            this.contextMenuStripActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 6;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.labelIdValue, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelId, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelCreateDateTime, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelCreateDateTimeValue, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelLastModifiedDateTimeValue, 5, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelLastModifiedDateTime, 4, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(583, 86);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelIdValue
            // 
            this.labelIdValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIdValue.AutoSize = true;
            this.labelIdValue.Location = new System.Drawing.Point(62, 0);
            this.labelIdValue.Name = "labelIdValue";
            this.labelIdValue.Size = new System.Drawing.Size(72, 86);
            this.labelIdValue.TabIndex = 3;
            this.labelIdValue.Text = "Значение";
            this.labelIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelId
            // 
            this.labelId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(53, 86);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Номер:";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCreateDateTime
            // 
            this.labelCreateDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateDateTime.AutoSize = true;
            this.labelCreateDateTime.Location = new System.Drawing.Point(140, 0);
            this.labelCreateDateTime.Name = "labelCreateDateTime";
            this.labelCreateDateTime.Size = new System.Drawing.Size(105, 86);
            this.labelCreateDateTime.TabIndex = 1;
            this.labelCreateDateTime.Text = "Дата создания:";
            this.labelCreateDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCreateDateTimeValue
            // 
            this.labelCreateDateTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreateDateTimeValue.AutoSize = true;
            this.labelCreateDateTimeValue.Location = new System.Drawing.Point(251, 0);
            this.labelCreateDateTimeValue.Name = "labelCreateDateTimeValue";
            this.labelCreateDateTimeValue.Size = new System.Drawing.Size(105, 86);
            this.labelCreateDateTimeValue.TabIndex = 5;
            this.labelCreateDateTimeValue.Text = "Значение";
            this.labelCreateDateTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastModifiedDateTimeValue
            // 
            this.labelLastModifiedDateTimeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastModifiedDateTimeValue.AutoSize = true;
            this.labelLastModifiedDateTimeValue.Location = new System.Drawing.Point(473, 0);
            this.labelLastModifiedDateTimeValue.Name = "labelLastModifiedDateTimeValue";
            this.labelLastModifiedDateTimeValue.Size = new System.Drawing.Size(107, 86);
            this.labelLastModifiedDateTimeValue.TabIndex = 4;
            this.labelLastModifiedDateTimeValue.Text = "Значение";
            this.labelLastModifiedDateTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLastModifiedDateTime
            // 
            this.labelLastModifiedDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastModifiedDateTime.AutoSize = true;
            this.labelLastModifiedDateTime.Location = new System.Drawing.Point(362, 0);
            this.labelLastModifiedDateTime.Name = "labelLastModifiedDateTime";
            this.labelLastModifiedDateTime.Size = new System.Drawing.Size(105, 86);
            this.labelLastModifiedDateTime.TabIndex = 2;
            this.labelLastModifiedDateTime.Text = "Последние изменение:";
            this.labelLastModifiedDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contextMenuStripActions
            // 
            this.contextMenuStripActions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonChangeProject,
            this.buttonDeleteProject});
            this.contextMenuStripActions.Name = "contextMenuStripActions";
            this.contextMenuStripActions.Size = new System.Drawing.Size(181, 52);
            this.contextMenuStripActions.Text = "Действия";
            // 
            // buttonChangeProject
            // 
            this.buttonChangeProject.Name = "buttonChangeProject";
            this.buttonChangeProject.Size = new System.Drawing.Size(180, 24);
            this.buttonChangeProject.Text = "Редактировать";
            // 
            // buttonDeleteProject
            // 
            this.buttonDeleteProject.Name = "buttonDeleteProject";
            this.buttonDeleteProject.Size = new System.Drawing.Size(180, 24);
            this.buttonDeleteProject.Text = "Удалить";
            // 
            // ProjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStripActions;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 8, 8, 8);
            this.Name = "ProjectControl";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(615, 118);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.contextMenuStripActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelLastModifiedDateTime;
        private System.Windows.Forms.Label labelCreateDateTime;
        private System.Windows.Forms.Label labelCreateDateTimeValue;
        private System.Windows.Forms.Label labelIdValue;
        private System.Windows.Forms.Label labelLastModifiedDateTimeValue;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActions;
        private System.Windows.Forms.ToolStripMenuItem buttonChangeProject;
        private System.Windows.Forms.ToolStripMenuItem buttonDeleteProject;
    }
}
