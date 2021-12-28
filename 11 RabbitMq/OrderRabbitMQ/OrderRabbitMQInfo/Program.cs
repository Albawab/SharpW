// See https://aka.ms/new-console-template for more information

using OrderRabbitMQInfo.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

var factory = new ConnectionFactory() { HostName = "localhost" };
factory.UserName = "test";
factory.Password = "test";
using (var connection = factory.CreateConnection())
using (var channel = connection.CreateModel())
{
    channel.ExchangeDeclare(exchange:"direct_logs",type: ExchangeType.Direct);
    var queueName = channel.QueueDeclare().QueueName;
    channel.QueueBind(queue:queueName,
                            exchange: "direct_logs",
                            routingKey: "orderInfo");
    
    channel.QueueBind(queue:queueName,
                            exchange: "direct_logs",
                            routingKey: "orderError");
    
    channel.QueueBind(queue:queueName,
                            exchange: "direct_logs",
                            routingKey: "orderQueue");
/*    channel.QueueDeclare(queue: queueName,
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);
    channel.QueueDeclare(queue: queueName,
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);
    channel.QueueDeclare(queue: queueName,        
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);*/

    var consumer = new EventingBasicConsumer(channel);
    consumer.Received += (model, ea) =>
    {
        var body = ea.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);

        var order = System.Text.Json.JsonSerializer.Deserialize<Order>(message);
        if (order != null)
        {
            Console.WriteLine($" [x] Received {order.ItemName} Info", message);
        }        
    };
    channel.BasicConsume(queue: queueName,
                         autoAck: true,
                         consumer: consumer);

    Console.WriteLine(" Press [enter] to exit.");
    Console.ReadLine();
}
