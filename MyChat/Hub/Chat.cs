using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyChat
{
    public class Chat:Hub
    {
        public void SendToAll(string name,string message)
        {
            Clients.All.SendToAllMessage(name, message);
        }

        public void SendToGroup(string name,string message,string groupName)
        {
            Clients.Group(groupName).SendToGroupMessage(name, message);
        }
    }
}