using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Common.DataContracts.Queries
{
    [DataContract]
    [KnownType("GetKnownTypes")]
    public abstract class Query
    {
        public static IEnumerable<Type> GetKnownTypes()
        {
            return KnownTypesProvider.GetKnownTypesFor<Query>();
        }
    }

    [DataContract]
    public abstract class Query<T> : Query where T : QueryResult
    {
        
    }
}