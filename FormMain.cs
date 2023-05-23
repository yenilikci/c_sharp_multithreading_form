namespace MultiThreading
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
        }

        private void AddLog(string logMessage)
        {

            if (lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }

            logMessage = $"[{DateTime.Now:dd.MM.yyy HH:mm:ss:fff}] - {logMessage}";
            lbLogs.Items.Add(logMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var mailTask = new MailTask()
            {
                Second = 60
            };

            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(mailTask);
        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            btnStartTask.Enabled = !mailTask.IsStarted;
            btnStopTask.Enabled = mailTask.IsStarted;
            btnRunTask.Enabled = mailTask.IsStarted && !mailTask.IsRunning;
        }

        private void mailTaskBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnStopTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Stop();
        }

        private void btnRunTask_Click(object sender, EventArgs e)
        {

        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Start();
        }
    }
}