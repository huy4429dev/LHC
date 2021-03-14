using System.Threading.Tasks;

namespace DVN.Mail
{
    public interface ISendMailService
    {
        Task SendMail(MailContent mailContent);
    }
}