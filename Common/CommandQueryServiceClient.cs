using System.ServiceModel;
using Common.DataContracts;
using Common.DataContracts.Commands;
using Common.DataContracts.Queries;

namespace Common
{
    public class CommandQueryServiceClient : ClientBase<ICommandQueryService>, ICommandQueryService
    {
        public QueryResult SendQuery(Query query)
        {
            return Channel.SendQuery(query);
        }

        public void SendCommand(Command command)
        {
            Channel.SendCommand(command);
        }
    }
}