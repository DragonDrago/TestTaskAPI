using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEB_API.DAL;
using Microsoft.EntityFrameworkCore;

namespace WEB_API.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext applicationDbContext;

        public OrderRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<int> AddOrderAsync(OrderModel orderModel)
        {
            var entity = new OrderModel()
            {
                Name = orderModel.Name,
                CompanyNumber = orderModel.CompanyNumber,
                CompanyName = orderModel.CompanyName
            };
            applicationDbContext.OrderModels.Add(entity);
            await applicationDbContext.SaveChangesAsync();
            return entity.Id;
        }

        public async Task<OrderModel> FindByIdAsync(int id)
        {
            var record = await applicationDbContext.OrderModels.Where(x => x.Id == id).Select(x => new OrderModel()
            {
                Id = x.Id,
                Name = x.Name,
                CompanyName = x.CompanyName,
                CompanyNumber = x.CompanyNumber
            }).FirstOrDefaultAsync();
            return record;
        }
    }
}
