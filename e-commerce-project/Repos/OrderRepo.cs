using System.Collections.Generic;
using e_commerce_project.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_project.Repos
{
    public class OrderRepo : IOrderRepo
    {
        context db;
        public OrderRepo(context db)
        {
            this.db = db;
        }


        public List<Order> GetOrdersById(string userId)
        {
            return db.Orders.Where(o => o.user_id == userId && o.submitted == true).ToList();

        }



    }
}
