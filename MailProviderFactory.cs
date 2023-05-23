using MultiThreading.MailProvider;
using MultiThreading.MailProvider.Base;
using MultiThreading.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class MailProviderFactory
    {
        public static BaseProvider CreateProvider(MailProviderType mailProviderType)
        {
            return mailProviderType switch
            {
                MailProviderType.Smtp => new SmtpProvider(),
                MailProviderType.GoogleMail => new GoogleMailProvider(),
                _ => throw new NotSupportedException(),
            };
        }
    }
}
