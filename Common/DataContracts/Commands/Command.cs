using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace Common.DataContracts.Commands
{
    [DataContract]
    [KnownType("GetKnownTypes")]
    public abstract class Command
    {
        public static IEnumerable<Type> GetKnownTypes()
        {
            return KnownTypesProvider.GetKnownTypesFor<Command>();
        }
    }
}