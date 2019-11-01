using InfoWebAPI.Common.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InfoWebAPI.Common.Helpers
{
    public static class IncludedRequestEntities
    {
        public static IReadOnlyList<TypeInfo> Types;

        static IncludedRequestEntities()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName.Contains("InfoWebAPI"));
            var typeList = new List<TypeInfo>();
            foreach (var assembly in assemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.GetCustomAttributes(typeof(ApiAttribute), true).Length > 0)
                    {
                        typeList.Add(type.GetTypeInfo());
                    }
                }
            }
            //var assembly = typeof(IncludedRequestEntities).GetTypeInfo().Assembly;

            Types = typeList;
        }
    }
}