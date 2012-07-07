using System.ServiceModel;
using Common.DataContracts.Commands;
using Common.DataContracts.Queries;

namespace Common
{
    [ServiceContract]
    public interface ICommandQueryService
    {
        [OperationContract]
        QueryResult SendQuery(Query query);

        [OperationContract]
        void SendCommand(Command command);
    }
}
