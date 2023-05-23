using MultiThreading.MailProvider;
using MultiThreading.MailProvider.Base;
using MultiThreading.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MailManager
    {
        private readonly ConcurrentQueue<MailObject> mailObjects = new ConcurrentQueue<MailObject>();
        private readonly ConcurrentDictionary<MailProviderType, BaseProvider> MailProviders = new ConcurrentDictionary<MailProviderType, BaseProvider>();

        public void AddMails(IEnumerable<MailObject> mails)
        {
            foreach (MailObject mail in mails)
            {
                mailObjects.Enqueue(mail);
            }
        }

        public async Task SendAllMails()
        {
            LogManager.Default.Log("SendAllMails started!");
            LogManager.Default.Log($"{mailObjects.Count} mails found!");

            var smtpProvider = new SmtpProvider();

            while (mailObjects.Count > 0)
            {
                mailObjects.TryDequeue(out MailObject mail);
                await smtpProvider.Send(mail);
            }

            LogManager.Default.Log("SendAllMails finished!");
        }

        private BaseProvider GetProvider (MailProviderType mailProviderType)
        {
            return MailProviders.GetOrAdd(mailProviderType, (x) => new SmtpProvider());
        }
    }
}
