using System.Collections.Generic;
using System.Runtime.Serialization;
using Common.DataContracts.Dtos;

namespace Common.DataContracts.Queries
{
    [DataContract]
    public class ListAvailablePoniesQuery : Query<ListAvailablePoniesQueryResult>
    {
    }

    [DataContract]
    public class ListAvailablePoniesQueryResult : QueryResult
    {
        public IList<PonyDto> AvailablePonies { get; set; }
    }
}
