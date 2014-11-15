using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.WindowsAzure.Mobile.Service;

namespace babel.Controllers
{
    public class ChatHub : Hub
    {

        public ApiServices Services { get; set; }
        public string Send(string name, string message)
        {
            return message;
        }
    }
}