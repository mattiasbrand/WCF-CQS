using Common.DataContracts.Queries;

namespace Host.Handlers.QueryHandlers
{
    public abstract class QueryHandlerBase<T, TResult> : IHandleQuery where T:Query<TResult> where TResult:QueryResult
    {
        public QueryResult Handle(Query query)
        {
            var typedRequest = (T)query;
            return Handle(typedRequest);
        }

        public abstract TResult Handle(T query);
    }
}