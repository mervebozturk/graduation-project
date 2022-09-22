using PycApi.Dto;

namespace PycApi.Service
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);

    }
}
