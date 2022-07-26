using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEB_API.DAL;

namespace WEB_API.Repository
{
    public interface IOrderRepository
    {
        Task<OrderModel> FindByIdAsync(int id);
        Task<int> AddOrderAsync(OrderModel orderModel);

    }
}
