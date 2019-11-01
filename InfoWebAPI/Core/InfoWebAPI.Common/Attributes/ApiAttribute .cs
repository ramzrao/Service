using System;

namespace InfoWebAPI.Common.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ApiAttribute : Attribute
    {
        public string ControllerRoutePrefix { get; set; }
        public string Name { get; private set; }
        public HttpType Type { get; private set; }

        public ApiAttribute(string routePrefix, string name, HttpType type)
        {
            this.ControllerRoutePrefix = routePrefix;
            this.Name = name;
            this.Type = type;
        }
    }

    public enum HttpType
    {
        Get,
        Post,
        Delete
    }
}