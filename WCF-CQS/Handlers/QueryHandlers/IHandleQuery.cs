using Common.DataContracts.Queries;

namespace Host.Handlers.QueryHandlers
{
    public interface IHandleQuery
    {
        QueryResult Handle(Query query);
    }
}