using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRDemo.Hubs
{   
    public class ChatHub : Hub
    {    
        [HubMethodName("sendMessage")]
        public void SendMessage(string name, string message)
        {
            Clients.Others.GetMessageOther(name, message);

            Clients.Caller.GetMessageCaller(message);
        }
    }
}