using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderRabbitMQ.Models;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace OrderRabbitMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        ILogger<OrderController> logger;

        public OrderController(ILogger<OrderController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public IActionResult InsertOrder(Order order)
        {
            try
            {
                this.SendMessageToRabbitMq(order, "orderQueue");
                this.SendMessageToRabbitMq(order, "orderInfo");
                this.SendMessageToRabbitMq(order, "orderError");


                #region Toevoegen order
                return Accepted(order);
                #endregion
            }
            catch (Exception)
            {

                logger.LogError("Er zijn een fout bij toevoegen een order.");
                return new StatusCodeResult(500);
            }

        }
        private void SendMessageToRabbitMq(Order order, string key)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            factory.UserName = "test";
            factory.Password = "test";
            var connection = factory.CreateConnection();
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: key,
                                        durable: false,
                                        autoDelete: false,
                                        exclusive: false,
                                        arguments: null);

                var message = JsonSerializer.Serialize(order);

                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(exchange: "",
                                     routingKey: key,
                                     basicProperties: null,
                                     body: body);
            }

        }
    }
}
