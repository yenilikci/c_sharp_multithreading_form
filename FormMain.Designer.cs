namespace MultiThreading
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TaskId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnListMailTasks = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.btnRunTask = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogs
            // 
            this.lbLogs.BackColor = System.Drawing.SystemColors.Info;
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 15;
            this.lbLogs.Location = new System.Drawing.Point(0, 266);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(800, 184);
            this.lbLogs.TabIndex = 0;
            this.lbLogs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.isRunningDataGridViewCheckBoxColumn,
            this.isStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.nextRunningDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mailTaskBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(800, 159);
            this.dataGridView2.TabIndex = 1;
            // 
            // TaskId
            // 
            this.TaskId.DataPropertyName = "TaskId";
            this.TaskId.HeaderText = "TaskId";
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            // 
            // isRunningDataGridViewCheckBoxColumn
            // 
            this.isRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            this.isRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            this.isRunningDataGridViewCheckBoxColumn.Name = "isRunningDataGridViewCheckBoxColumn";
            this.isRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isStartedDataGridViewCheckBoxColumn
            // 
            this.isStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.isStartedDataGridViewCheckBoxColumn.Name = "isStartedDataGridViewCheckBoxColumn";
            this.isStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            this.secondDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nextRunningDataGridViewTextBoxColumn
            // 
            this.nextRunningDataGridViewTextBoxColumn.DataPropertyName = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.HeaderText = "NextRunning";
            this.nextRunningDataGridViewTextBoxColumn.Name = "nextRunningDataGridViewTextBoxColumn";
            this.nextRunningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailTaskBindingSource
            // 
            this.mailTaskBindingSource.AllowNew = false;
            this.mailTaskBindingSource.DataSource = typeof(MultiThreading.MailTask);
            this.mailTaskBindingSource.CurrentChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentChanged);
            this.mailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentItemChanged);
            // 
            // btnListMailTasks
            // 
            this.btnListMailTasks.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnListMailTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMailTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListMailTasks.FlatAppearance.BorderSize = 2;
            this.btnListMailTasks.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListMailTasks.Location = new System.Drawing.Point(0, 0);
            this.btnListMailTasks.Name = "btnListMailTasks";
            this.btnListMailTasks.Size = new System.Drawing.Size(800, 56);
            this.btnListMailTasks.TabIndex = 2;
            this.btnListMailTasks.Text = "List Mail Tasks";
            this.btnListMailTasks.UseVisualStyleBackColor = false;
            this.btnListMailTasks.Click += new System.EventHandler(this.btnListMailTasks_Click);
            // 
            // btnStartTask
            // 
            this.btnStartTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStartTask.Enabled = false;
            this.btnStartTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartTask.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartTask.Location = new System.Drawing.Point(12, 59);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(128, 42);
            this.btnStartTask.TabIndex = 3;
            this.btnStartTask.Text = "START";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStopTask.Enabled = false;
            this.btnStopTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopTask.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStopTask.Location = new System.Drawing.Point(146, 59);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(128, 42);
            this.btnStopTask.TabIndex = 4;
            this.btnStopTask.Text = "STOP";
            this.btnStopTask.UseVisualStyleBackColor = false;
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // btnRunTask
            // 
            this.btnRunTask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRunTask.Enabled = false;
            this.btnRunTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunTask.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRunTask.Location = new System.Drawing.Point(660, 59);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(128, 42);
            this.btnRunTask.TabIndex = 5;
            this.btnRunTask.Text = "RUN";
            this.btnRunTask.UseVisualStyleBackColor = false;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRunTask);
            this.Controls.Add(this.btnStopTask);
            this.Controls.Add(this.btnStartTask);
            this.Controls.Add(this.btnListMailTasks);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "MultiThreading Form";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ListBox lbLogs;
        private DataGridView dataGridView2;
        private Button btnListMailTasks;
        private BindingSource mailTaskBindingSource;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewCheckBoxColumn isRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
        private Button btnStartTask;
        private Button btnStopTask;
        private Button btnRunTask;
    }
}