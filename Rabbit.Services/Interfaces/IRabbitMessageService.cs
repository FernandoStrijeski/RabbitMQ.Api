using Rabbit.Models.Entities;

namespace Rabbit.Services.Interfaces
{
    public interface IRabbitMessageService
    {
        void SendMessage(RabbitMessage mensagem);
    }
}
