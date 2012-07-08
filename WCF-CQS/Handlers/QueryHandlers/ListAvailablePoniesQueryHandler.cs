using System;
using System.Collections.Generic;
using Common.DataContracts.Dtos;
using Common.DataContracts.Queries;

namespace Host.Handlers.QueryHandlers
{
    public class ListAvailablePoniesQueryHandler : QueryHandlerBase<ListAvailablePoniesQuery, ListAvailablePoniesQueryResult>
    {
        public override ListAvailablePoniesQueryResult Handle(ListAvailablePoniesQuery query)
        {
            var result = new ListAvailablePoniesQueryResult();
            result.AvailablePonies = new List<PonyDto>
            {
                new PonyDto { Id = Guid.NewGuid(), Name="Pinky Pie"},
                new PonyDto { Id = Guid.NewGuid(), Name="Starlight"},
                new PonyDto { Id = Guid.NewGuid(), Name="Sweetheart"},
                new PonyDto { Id = Guid.NewGuid(), Name="Patch"}
            };

            return result;
        }
    }
}
