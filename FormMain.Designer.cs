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
            this.ProviderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextRunningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnListMailTasks = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLogs
            // 
            this.lbLogs.BackColor = System.Drawing.Color.White;
            this.lbLogs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbLogs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 15;
            this.lbLogs.Location = new System.Drawing.Point(0, 330);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(780, 394);
            this.lbLogs.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskId,
            this.ProviderType,
            this.isRunningDataGridViewCheckBoxColumn,
            this.isStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.nextRunningDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mailTaskBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(780, 213);
            this.dataGridView2.TabIndex = 2;
            // 
            // TaskId
            // 
            this.TaskId.DataPropertyName = "TaskId";
            this.TaskId.HeaderText = "TaskId";
            this.TaskId.Name = "TaskId";
            this.TaskId.ReadOnly = true;
            // 
            // ProviderType
            // 
            this.ProviderType.DataPropertyName = "ProviderType";
            this.ProviderType.HeaderText = "ProviderType";
            this.ProviderType.Name = "ProviderType";
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
            this.mailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentItemChanged);
            // 
            // btnListMailTasks
            // 
            this.btnListMailTasks.BackColor = System.Drawing.Color.SeaShell;
            this.btnListMailTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMailTasks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListMailTasks.FlatAppearance.BorderSize = 2;
            this.btnListMailTasks.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListMailTasks.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnListMailTasks.Location = new System.Drawing.Point(0, 0);
            this.btnListMailTasks.Name = "btnListMailTasks";
            this.btnListMailTasks.Size = new System.Drawing.Size(780, 47);
            this.btnListMailTasks.TabIndex = 2;
            this.btnListMailTasks.Text = "List Mail Tasks";
            this.btnListMailTasks.UseVisualStyleBackColor = false;
            this.btnListMailTasks.Click += new System.EventHandler(this.btnListMailTasks_Click);
            // 
            // btnStartTask
            // 
            this.btnStartTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartTask.BackColor = System.Drawing.Color.LightGreen;
            this.btnStartTask.Enabled = false;
            this.btnStartTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStartTask.ForeColor = System.Drawing.Color.White;
            this.btnStartTask.Location = new System.Drawing.Point(6, 25);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(90, 35);
            this.btnStartTask.TabIndex = 3;
            this.btnStartTask.Text = "START";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopTask.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStopTask.Enabled = false;
            this.btnStopTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStopTask.ForeColor = System.Drawing.Color.White;
            this.btnStopTask.Location = new System.Drawing.Point(101, 25);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(90, 35);
            this.btnStopTask.TabIndex = 4;
            this.btnStopTask.Text = "STOP";
            this.btnStopTask.UseVisualStyleBackColor = false;
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // btnRunTask
            // 
            this.btnRunTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunTask.BackColor = System.Drawing.Color.LightBlue;
            this.btnRunTask.Enabled = false;
            this.btnRunTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunTask.ForeColor = System.Drawing.Color.White;
            this.btnRunTask.Location = new System.Drawing.Point(654, 25);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(120, 35);
            this.btnRunTask.TabIndex = 5;
            this.btnRunTask.Text = "RUN";
            this.btnRunTask.UseVisualStyleBackColor = false;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRunTask);
            this.groupBox1.Controls.Add(this.btnStopTask);
            this.groupBox1.Controls.Add(this.btnStartTask);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 64);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operations";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(780, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListMailTasks);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "MultiThreading Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbLogs;
        private DataGridView dataGridView2;
        private Button btnListMailTasks;
        private BindingSource mailTaskBindingSource;
        private Button btnStartTask;
        private Button btnStopTask;
        private Button btnRunTask;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn TaskId;
        private DataGridViewTextBoxColumn ProviderType;
        private DataGridViewCheckBoxColumn isRunningDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isStartedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nextRunningDataGridViewTextBoxColumn;
    }
}