using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InfoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> HandleRequest<T>(T request)
        {
            var type = request.GetType();
            var responseType = type.GetInterfaces() // [IRequest<MyResponse>]
                .Single(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IRequest<>)) // IRequest<MyResponse>
                .GetGenericArguments() // [MyResponse]
                .Single(); // MyResponse

            var method = _mediator.GetType().GetMethod("Send");
            var generic = method.MakeGenericMethod(responseType);

            var task = (Task)generic.Invoke(_mediator, new object[] { request, Type.Missing });
            await task.ConfigureAwait(false);
            var resultProperty = task.GetType().GetProperty("Result");
            var response = resultProperty.GetValue(task);
            return Ok(response);
        }
    }
}