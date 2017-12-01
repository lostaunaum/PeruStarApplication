using Microsoft.Extensions.Logging;
using PeruStarApplication.Services.Interfaces;

namespace PeruStarApplication.Services
{
    public class MailService : IMailService
    {
        private readonly ILogger<IMailService> _logger;

        public MailService(ILogger<IMailService> logger)
        {
            _logger = logger;
        }

        public void SendMail(string to, string from, string subject, string body)
        {

        }
    }
}
