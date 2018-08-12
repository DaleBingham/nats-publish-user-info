using System;
using NATS.Client;
using System.Text;
using Newtonsoft.Json;
using nats_publish_user_info.Models;

namespace nats_publish_user_info
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new connection factory to create a connection.
            ConnectionFactory cf = new ConnectionFactory();

            // Creates a live connection to the default NATS Server running locally
            IConnection c = cf.CreateConnection();
            //  T:NATS.Client.NATSNoServersException:
            //   T:NATS.Client.NATSConnectionException:
            
            int i = 0;
            User u;
            while (true) {// Publish requests to the given subject:
                u = new User();
                u.Id = i;
                u.FirstName = "User" + i.ToString();
                u.LastName = "Bingham";
                u.Email = u.FirstName + "@gmail.com";
                u.Created = DateTime.Now;
                c.Publish("bingham.user.create", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(u)));
                i++;
                System.Threading.Thread.Sleep(new TimeSpan(0, 0, 5));
            }
        }
    }
}
