using e_commerce_project.Models;
using System.Collections.Generic;

namespace e_commerce_project.Repos
{
    public interface IOrderRepo
    {
        List<Order> GetOrdersById(string userId);
    }
}