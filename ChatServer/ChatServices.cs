using ChatInterface;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServer
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]

    public class ChatServices : IChatServices
    {
        public ConcurrentDictionary<string, ConnectedClient> _connectedClients = new ConcurrentDictionary<string, ConnectedClient>();

        public int Login(string UserName)
        {
            foreach(var client in _connectedClients){
                if (client.Key.ToLower() == UserName.ToLower())
                {
                    return 1;
                }
            }

            var euc = OperationContext.Current.GetCallbackChannel<IClient>();
            ConnectedClient newClient = new ConnectedClient();
            newClient.connection = euc;
            newClient.UserName = UserName;

            _connectedClients.TryAdd(UserName, newClient);
            updateHelper(0, UserName);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Client login: {0} at {1}", newClient.UserName, System.DateTime.Now);
            Console.ResetColor();

            return 0;
        }

        public void logout()
        {
            ConnectedClient client = getMyClient();
            if(client != null)
            {
                ConnectedClient removedClient;
                _connectedClients.TryRemove(client.UserName, out removedClient);

                updateHelper(1, removedClient.UserName);
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Client logooff: {0} at {1}", removedClient.UserName, System.DateTime.Now);
                Console.ResetColor();

            }
        }
        public ConnectedClient getMyClient()
        {
            var euc = OperationContext.Current.GetCallbackChannel<IClient>();
            foreach (var client in _connectedClients)
            {
                if(client.Value.connection == euc)
                {
                    return client.Value;
                }
            }
            return null;
        }

        private void updateHelper(int value, string username)
        {
            foreach (var client in _connectedClients)
            { 
                if(client.Value.UserName.ToLower() != username.ToLower())
                client.Value.connection.getUpdate(value, username); 
            }
        }

        public void SendMessageToAll(string message, string UserName)
        {
            foreach(var client in _connectedClients)
            {
                if(client.Key.ToLower() != UserName.ToLower())
                {
                    client.Value.connection.GetMessage(message, UserName);
                }
            }
        }

        public List<string> GetCurrentUsers()
        {
            List<string> listOfUsers = new List<string>();
            foreach(var client in _connectedClients)
            {
                listOfUsers.Add(client.Value.UserName);
            }
            return listOfUsers;
        }
    }
}
