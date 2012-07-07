using System;
using Common;
using Common.DataContracts.Commands;
using Common.DataContracts.Queries;

namespace Host
{
    public class CommandQueryService : ICommandQueryService
    {
        public QueryResult SendQuery(Query query)
        {
            throw new NotImplementedException();
        }

        public void SendCommand(Command command)
        {
            throw new NotImplementedException();
        }
    }
}
