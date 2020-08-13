using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace BlazorApp1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        public static List<Orders> order = new List<Orders>();
        // GET: api/Default
        [HttpGet]
        public async Task<object> Get(int code)
        {
            if (order.Count == 0)
            {
                BindDataSource();
            }

            int empId;
            if (code < 6)
                empId = 1;
            else
                empId = 10000;


            var data = order.Where(w=>w.EmployeeID==empId).AsQueryable();
            var count = data.Count();
            var queryString = Request.Query;
            string grid = queryString["ej2grid"];
            string sort = queryString["$orderby"];   //sorting      
            string filter = queryString["$filter"];
            string auto = queryString["$inlineCount"];
            code = Convert.ToInt32(queryString["code"]);
            if (sort != null) //Sorting 
            {
                var sortfield = sort.Split(',');
                for (var i = sortfield.Length; i > 0; i--)
                {
                    var sortColumn = sortfield[i - 1].Split(" ");
                    var sorttype = sortColumn[0];
                    if (sortColumn.Length == 2)
                    {
                        switch (sorttype)
                        {
                            case "OrderID":
                                data = data.OrderByDescending(x => x.OrderID);
                                break;
                            case "CustomerID":
                                data = data.OrderByDescending(x => x.CustomerID);
                                break;
                            case "Freight":
                                data = data.OrderByDescending(x => x.Freight);
                                break;
                            case "EmployeeID":
                                data = data.OrderByDescending(x => x.EmployeeID);
                                break;
                            case "OrderDate":
                                data = data.OrderByDescending(x => x.OrderDate);
                                break;

                        }
                    }
                    else
                    {
                        switch (sorttype)
                        {
                            case "OrderID":
                                data = data.OrderBy(x => x.OrderID);
                                break;
                            case "CustomerID":
                                data = data.OrderBy(x => x.CustomerID);
                                break;
                            case "Freight":
                                data = data.OrderBy(x => x.Freight);
                                break;
                            case "EmployeeID":
                                data = data.OrderBy(x => x.EmployeeID);
                                break;
                            case "OrderDate":
                                data = data.OrderBy(x => x.OrderDate);
                                break;
                        }
                    }
                }
            }
            if (queryString.Keys.Contains("$inlinecount"))
            {
                StringValues Skip;
                StringValues Take;
                int skip = (queryString.TryGetValue("$skip", out Skip)) ? Convert.ToInt32(Skip[0]) : 0;
                int top = (queryString.TryGetValue("$top", out Take)) ? Convert.ToInt32(Take[0]) : data.Count();

                return new { Items = data.Skip(skip).Take(code), Count = count };

            }
            else
            {
                return data;
            }
        }
        private void BindDataSource()
        {
            int code = 10000;
            for (int i = 1; i < 25; i++)
            {
                order.Add(new Orders(code + 1, "ALFKI", i + 0, 2.3 * i, new DateTime(1991, 05, 15), "Berlin"));
                order.Add(new Orders(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04), "Madrid"));
                order.Add(new Orders(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30), "Cholchester"));
                order.Add(new Orders(code + 4, "BLONP", i + 3, 5.3 * i, new DateTime(1930, 10, 22), "Marseille"));
                order.Add(new Orders(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18), "Tsawassen"));
                code += 5;
            }
        }
        //// POST: api/Default
        [HttpPost]
        public object Post([FromBody]Orders value)
        {
            order.Insert(0, value);
            return value;
        }

        //// PUT: api/Default/5
        [HttpPut]
        public object Put([FromBody]Orders value)
        {
            var re = Request;
            var headers = re.Headers;
            var data = order.Where(or => or.OrderID == value.OrderID).FirstOrDefault();
            if (data != null)
            {
                data.OrderID = value.OrderID;
                data.CustomerID = value.CustomerID;
                data.Freight = value.Freight;
            }
            return value;
        }
        //// DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete([FromBody]int id)
        {
            order.Remove(order.Where(or => or.OrderID == id).FirstOrDefault());
            //return value;
        }
    }
}