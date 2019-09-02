using Newtonsoft.Json;
using SimpleLoggingInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleLoggingService.Handlers
{
    public class IntakeHandling
    {
        public bool LogMessages(string message)
        {
            var formattedMessage = FormatMessage(message);
            return RouteMessage(formattedMessage);
        }

        public bool LogMessages(byte[] message)
        {
            var formattedMessage = FormatMessage(message);
            return RouteMessage(formattedMessage);
        }

        public object FormatMessage(string message)
        {
            var decodedMessage = Convert.FromBase64String(message);
            return FormatMessage(decodedMessage);
        }

        public object FormatMessage(byte[] message)
        {
            return JsonConvert.DeserializeObject(Encoding.UTF8.GetString(message));
        }

        private bool RouteMessage(object message)
        {
            if (message is IRelationalDatabaseEntity)
            { }
            if (message is IMessageQueueEntity)
            { }
            if (message is IApplicationEntity)
            { }
            if (message is ITransactions)
            { }

            return false;

        }
    }
}
