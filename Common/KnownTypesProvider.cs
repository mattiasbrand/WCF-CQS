using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public static class KnownTypesProvider
    {
        public static IEnumerable<Type> GetKnownTypesFor<T>()
        {
            return typeof (T).Assembly.GetExportedTypes()
                .Where(x => typeof (T).IsAssignableFrom(x) && x.IsGenericTypeDefinition == false);
        }
    }
}