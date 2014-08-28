using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace MyChat
{
    public class Chat:Hub
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        public void SendToAll(string name,string message)
        {
            
            
            Clients.All.SendToAllMessage(js.Serialize(new { Name = name, Message = message}));
        }

        public void SendToGroup(string name,string message,string groupName)
        {
            Clients.Group(groupName).SendToGroupMessage(name, message);
        }

        /// <summary>
        /// 当有一个新连接的时候执行
        /// </summary>
        /// <returns></returns>
        public override System.Threading.Tasks.Task OnConnected()
        {
            //Clients.Others.SendToAllMessage(Context.ConnectionId,"连接了"+"---"+Context.ConnectionId);
           
            return base.OnConnected();
        }
        
    }
}