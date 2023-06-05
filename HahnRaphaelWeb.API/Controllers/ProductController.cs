using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Entities;
using HahnRaphaelWeb.Domain.Handlers;
using HahnRaphaelWeb.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HahnRaphaelWeb.API.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Product> GetAll(
            [FromServices] IProductRepository repository
            )
        {
            return repository.GetAll();
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateProductCommand command,
            [FromServices] ProductHandler handler
            )
        {
            return (GenericCommandResult) handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
            [FromBody] UpdateProductCommand command,
            [FromServices] ProductHandler handler
        )
        {

            return (GenericCommandResult) handler.Handle(command);
        }

        [Route("")]
        [HttpDelete]
        public GenericCommandResult Remove(
            [FromBody] RemoveProductCommand command,
            [FromServices] ProductHandler handler
        )
        {
            return ( GenericCommandResult) handler.Handle(command);
        }
    }
}
