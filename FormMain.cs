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

            if(lbLogs.InvokeRequired)
            {
                lbLogs.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }

            logMessage = $"[{DateTime.Now:dd.MM.yyy HH:mm:ss:fff}] - {logMessage}";
            lbLogs.Items.Add(logMessage);
            lbLogs.SelectedIndex = lbLogs.Items.Count - 1;
        }
    }
}