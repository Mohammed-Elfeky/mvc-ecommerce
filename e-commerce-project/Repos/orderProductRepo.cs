using System.Collections.Generic;
using e_commerce_project.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace e_commerce_project.Repos
{
    public class orderProductRepo : IorderProductRepo
    {
        context db;
        public orderProductRepo(context db)
        {
            this.db = db;
        }

        public List<OrderProduct> getOrderProducts(int id)
        {
            return db.OrdersProducts.Include(op => op.Product).Where(op => op.OrderId == id).ToList();
        }
    }
}
