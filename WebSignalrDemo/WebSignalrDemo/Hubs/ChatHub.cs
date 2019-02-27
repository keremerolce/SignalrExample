using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace WebSignalrDemo.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string name,string message)
        {
            Clients.Others.GetMessageOther(name, message);

            Clients.Caller.GetMessageCaller(message);
        }
        public void Hello()
        {
            Clients.All.hello();
        }

        public override Task OnConnected()
        {
            string id = Context.ConnectionId;
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
    }
}