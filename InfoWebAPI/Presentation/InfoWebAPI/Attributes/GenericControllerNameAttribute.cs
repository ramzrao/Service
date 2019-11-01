using InfoWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Linq;

namespace InfoWebAPI.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class GenericControllerNameAttribute : Attribute, IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerType = controller.ControllerType.GetGenericTypeDefinition();
            if (controllerType == typeof(GenericGetController<>) || controllerType == typeof(GenericPostController<>)
                || controllerType == typeof(GenericDeleteController<>))
            {
                var entityType = controller.ControllerType.GenericTypeArguments[0];
                var customAttribute = entityType.GetCustomAttributes(typeof(ApiAttribute), true).FirstOrDefault() as ApiAttribute;
                controller.ControllerName = customAttribute?.Name ?? entityType.Name;
                foreach (var selector in controller.Selectors)
                {
                    var route = controller.Selectors.FirstOrDefault().AttributeRouteModel.Template;
                    route = route + customAttribute.ControllerRoutePrefix + "/" + customAttribute.Name;
                    selector.AttributeRouteModel.Template = route;
                }
            }
        }
    }
}