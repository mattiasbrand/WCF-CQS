using Common.DataContracts.Commands;

namespace Host.Handlers.CommandHandlers
{
    public abstract class CommandHandlerBase<T> : IHandleCommand where T:Command
    {
        public void Handle(Command command)
        {
            var typedRequest = (T)command;
            Handle(typedRequest);
        }

        public abstract void Handle(T command);
    }
}