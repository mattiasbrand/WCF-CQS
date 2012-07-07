using Common;
using Common.DataContracts;
using Common.DataContracts.Commands;
using Common.DataContracts.Queries;

namespace Client
{
    public class ServiceFacade
    {
        public void SendCommand(Command command)
        {
            var client = new CommandQueryServiceClient();
            client.SendCommand(command);
        }

        public TResult SendQuery<TResult>(Query<TResult> query) where TResult: QueryResult
        {
            var client = new CommandQueryServiceClient();
            return (TResult)client.SendQuery(query);
        }
    }
}
