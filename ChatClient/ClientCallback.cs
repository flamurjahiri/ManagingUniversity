using ChatInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ChatClient
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ClientCallback : IClient
    {
        public void GetMessage(string message, string userName)
        {
            ((MainWindow)Application.Current.MainWindow).takeMessages(message, userName);
            

        }

        public void getUpdate(int value, string username)
        {
            switch (value)
            {
                case 0:
                    {
                        ((MainWindow)Application.Current.MainWindow).AddUserToList(username);
                        break;
                    }
                case 1:
                    {
                        ((MainWindow)Application.Current.MainWindow).removeUserFromList(username);
                        break;
                    }
            }
        }
    }
}
