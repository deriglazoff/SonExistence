using MassTransit;
using SonExistence.Dto;
using SonExistence.Interfaces;
using System.Threading.Tasks;

namespace SonExistence.Consumers
{
    public class MessageConsumer : IConsumer<DocumentDto>
    {
        private readonly IRepository _observable;

        public MessageConsumer(IRepository observable)
        {
            _observable = observable;
        }

        public Task Consume(ConsumeContext<DocumentDto> context)
        {
            _observable.Save(context.Message);
            return Task.CompletedTask;
        }
    }
}