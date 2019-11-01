using InfoWebAPI.Common.Attributes;
using InfoWebAPI.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Linq;

namespace InfoWebAPI.Attributes
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class GenericActionNameAttribute : Attribute, IActionModelConvention
    {
        public void Apply(ActionModel action)
        {
            var controller = action.Controller;
            var controllerType = controller.ControllerType.GetGenericTypeDefinition();
            if (controllerType == typeof(GenericGetController<>) || controllerType == typeof(GenericPostController<>)
                || controllerType == typeof(GenericDeleteController<>))
            {
                var entityType = controller.ControllerType.GenericTypeArguments[0];
                var customAttribute = entityType.GetCustomAttributes(typeof(ApiAttribute), true).FirstOrDefault() as ApiAttribute;
                var actionType = customAttribute.Type;
                action.ApiExplorer.GroupName = customAttribute.ControllerRoutePrefix;
                action.ActionName = actionType.ToString();
            }
        }
    }
}