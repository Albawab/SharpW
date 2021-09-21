using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LatestVersion.Data
{
    public class OrdersService
    {
        public List<Order> orders = new List<Order>();

        public async Task<List<Order>> GetOrders()
        {
            return await Task.Run(() =>
             orders = Enumerable.Range(1, 75).Select(x => new Order()
             {
                 OrderID = 1000 + x,
                 CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
                 Freight = 2.1 * x,
             }).ToList()
            );
            
        }
    }
}
