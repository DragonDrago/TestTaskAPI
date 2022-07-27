using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using System;
using WEB_API.DAL;
using WEB_API.Repository;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository repositoryDbContext;

        public OrderController(IOrderRepository repositoryDbContext)
        {
            this.repositoryDbContext = repositoryDbContext;
        }


        // POST: OrderController/Create
       
        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] OrderModel orderEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await repositoryDbContext.AddOrderAsync(orderEntity);
            return Ok(entity);
        }

      
    }
}
