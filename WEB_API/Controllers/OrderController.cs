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

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetOrderById([FromBody]int id)
        //{
        //    var book = await repositoryDbContext.FindByIdAsync(id);
        //    if(book == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(book);
        //}

        // POST: OrderController/Create
       
        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] OrderModel orderEntity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await repositoryDbContext.AddOrderAsync(orderEntity);
            //return CreatedAtAction(nameof(GetOrderById), new {id=id,controller="order"},id);
            return Ok(entity);
        }

      
    }
}
