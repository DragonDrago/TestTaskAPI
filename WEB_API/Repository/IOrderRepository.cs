using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEB_API.DAL;

namespace WEB_API.Repository
{
    //Кстати,
    //мы можем создать общий базовый класс (Generic Base Class) для этого,
    //если это действительно большой проект с несколькими моделями.
    public interface IOrderRepository
    {
        //Task<OrderModel> FindByIdAsync(int id);
        Task<OrderModel> AddOrderAsync(OrderModel orderModel);

    }
}
