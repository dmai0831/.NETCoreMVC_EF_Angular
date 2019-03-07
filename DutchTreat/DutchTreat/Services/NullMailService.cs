using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Services
{
    public class NullMailService : IMailService
    {
        //By default of the project, logging is setup for console and debug window
        private readonly ILogger<NullMailService> _logger;
        public NullMailService(ILogger<NullMailService> Logger)
        {
            _logger = Logger;
        }

        public void SendMessage(string to, string subject, string body)
        {
            //Log the message
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");

        }
    }
}
