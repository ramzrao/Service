using InfoWebAPI.Attributes;
using InfoWebAPI.Common.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InfoWebAPI.Controllers
{
    [Authorize]
    [Route("api/InfoService/")]
    [GenericControllerName]
    public class GenericPostController<T> : BaseController
    {
        public GenericPostController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [GenericActionName]
        public async Task<IActionResult> Post([FromBody]T request) => await HandleRequest<T>(request);
    }
}