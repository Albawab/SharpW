using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Stichting.Doneren.DbContextRead;
using Stichting.Doneren.DomeinRead.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stichting.Doneren.DbContext.Read.Handler.Handles
{
    public class DbContextReadHandle
    {
        private readonly StichtingDbContextRead stichtingDbContextRead;

        public DbContextReadHandle(StichtingDbContextRead stichtingDbContextRead)
        {
            this.stichtingDbContextRead = stichtingDbContextRead;
        }

        public void Handle()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            factory.UserName = "test";
            factory.Password = "test";
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "registerUser",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);

                    var user = System.Text.Json.JsonSerializer.Deserialize<User>(message);
                    if (user != null)
                    {
                        Console.WriteLine($" [x] Received {user.Name} User", message);
                        // Toevoegen de gebruiker aan de db.
                        stichtingDbContextRead.Users.Add(user);

                        // Opslaan de gewijzigde in de db context.
                        stichtingDbContextRead.SaveChangesAsync();
                    }
                };
                channel.BasicConsume(queue: "registerUser",
                                      autoAck: true,
                                     consumer: consumer);


            }
            Console.ReadKey();
        }
    }
}
