using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace WEB_API.DAL
{
    public class OrderModel
    {

        // Validation !Валидация вынесена на фронтэнд, поэтому я не ставил сюда
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNumber { get; set; }
    }
}
