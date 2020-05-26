using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Program
    {
        public static ChatServices _server;
        static void Main(string[] args)
        {
            _server = new ChatServices();
            using(ServiceHost host = new ServiceHost(_server))
            {
                host.Open();
                Console.WriteLine("Serveri u hap");
                Console.ReadLine();
            }
        }
    }
}
