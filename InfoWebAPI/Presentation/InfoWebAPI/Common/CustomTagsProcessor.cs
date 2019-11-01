using InfoWebAPI.Common.Attributes;
using InfoWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc.Controllers;
using NSwag.Generation.AspNetCore;
using NSwag.Generation.Processors;
using NSwag.Generation.Processors.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfoWebAPI.Common
{
    public class CustomTagsProcessor : OperationTagsProcessor
    {
        /// <summary>Adds the controller name as operation tag.</summary>
        /// <param name="context">The context.</param>
        protected override void AddControllerNameTag(OperationProcessorContext context)
        {
            var aspNetCoreContext = (AspNetCoreOperationProcessorContext)context;
            if (aspNetCoreContext.ControllerType.IsGenericType)
            {
                var controllerType = aspNetCoreContext.ControllerType.GetGenericTypeDefinition();

                if (controllerType == typeof(GenericGetController<>) || controllerType == typeof(GenericPostController<>)
                    || controllerType == typeof(GenericDeleteController<>))
                {
                    var entityType = aspNetCoreContext.ControllerType.GenericTypeArguments[0];
                    var customAttribute = entityType.GetCustomAttributes(typeof(ApiAttribute), true).FirstOrDefault() as ApiAttribute;
                    var groupPrefix = customAttribute.ControllerRoutePrefix;
                    aspNetCoreContext.OperationDescription.Operation.Tags.Add(groupPrefix);
                    return;
                }
            }

            base.AddControllerNameTag(context);
        }
    }
}
