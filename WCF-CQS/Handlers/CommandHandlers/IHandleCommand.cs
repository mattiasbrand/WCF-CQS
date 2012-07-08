using Common.DataContracts.Commands;

namespace Host.Handlers.CommandHandlers
{
    public interface IHandleCommand
    {
        void Handle(Command command);
    }
}