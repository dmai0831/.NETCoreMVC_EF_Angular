namespace DutchTreat.Services
{
    //The reason for interface it, we may need different implementation in different cases
    public interface IMailService
    {
        void SendMessage(string to, string subject, string body);
    }
}