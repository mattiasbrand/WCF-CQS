using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Common.DataContracts.Queries
{
    [DataContract]
    [KnownType("GetKnownTypes")]
    public abstract class QueryResult
    {
        public static IEnumerable<Type> GetKnownTypes()
        {
            return KnownTypesProvider.GetKnownTypesFor<QueryResult>();
        }
    }
}