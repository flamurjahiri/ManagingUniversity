﻿using ChatInterface;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    public class ConnectedClient
    {
        public IClient connection;
        public string UserName
        {
            get; set;
        }

    }
}
