using System.Linq;
using Common;
using Common.DataContracts.Commands;
using Common.DataContracts.Queries;
using Host.Handlers.CommandHandlers;
using Host.Handlers.QueryHandlers;

namespace Host
{
    public class CommandQueryService : ICommandQueryService
    {
        public QueryResult SendQuery(Query query)
        {
            var queryHandlerType = typeof(QueryHandlerBase<,>);
            var queryType = query.GetType();
            var queryResultType = queryType.BaseType.GetGenericArguments().First();
            var handler = (IHandleQuery)IoC.Container.GetInstance(queryHandlerType.MakeGenericType(queryType, queryResultType));
            return handler.Handle(query);
        }

        public void SendCommand(Command command)
        {
            var commandHandlerType = typeof(CommandHandlerBase<>);

            var handler = (IHandleCommand)IoC.Container.GetInstance(commandHandlerType.MakeGenericType(command.GetType()));
            handler.Handle(command);
        }
    }
}
