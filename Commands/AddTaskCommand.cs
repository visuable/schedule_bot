using MediatR;
using Telegram.Bot;

namespace schedule_bot.Commands;

public record AddTaskCommand(RequestContext Context) : IRequest
{
    public class Handler(ITelegramBotClient client) : IRequestHandler<AddTaskCommand>
    {
        public async Task Handle(AddTaskCommand request, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(request.Context.Message);
            client.SendMessage(request.Context.Message.Chat.Id, Resources.EnterSubjectName, replyMarkup: );
        }
    }
}
