using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatInterface
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IChatServices" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IClient))]
    public interface IChatServices
    {
        [OperationContract]
         int Login(string UserName);

        [OperationContract]
        void logout();

        [OperationContract]
         void SendMessageToAll(string message, string UserName);
        [OperationContract]
        List<string> GetCurrentUsers();
    }
}
