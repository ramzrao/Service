using InfoWebAPI.Common.Attributes;
using InfoWebAPI.Common.Helpers;
using InfoWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace InfoWebAPI.Middleware
{
    public class GenericControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
    {
        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            foreach (var entityType in IncludedRequestEntities.Types)
            {
                var typeName = entityType.Name + "Controller";
                var customAttribute = entityType.GetCustomAttributes(typeof(ApiAttribute), true).FirstOrDefault() as ApiAttribute;
                if (!feature.Controllers.Any(t => t.Name == typeName))
                {
                    TypeInfo controllerType = null;
                    if (customAttribute.Type == HttpType.Get)
                        controllerType = typeof(GenericGetController<>).MakeGenericType(entityType.AsType()).GetTypeInfo();
                    else if (customAttribute.Type == HttpType.Post)
                        controllerType = typeof(GenericPostController<>).MakeGenericType(entityType.AsType()).GetTypeInfo();
                    else if (customAttribute.Type == HttpType.Delete)
                        controllerType = typeof(GenericDeleteController<>).MakeGenericType(entityType.AsType()).GetTypeInfo();
                    feature.Controllers.Add(controllerType);
                }
            }
        }
    }
}