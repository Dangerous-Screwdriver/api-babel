using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.AspNet.SignalR;
using babel.Models;

namespace babel.Controllers
{
    public class ChatController : ApiController
    {
        public ApiServices Services { get; set; }

        // GET api/Chat
        public string Post([FromBody] ChatMessage message)
        {
            IHubContext hubContext = Services.GetRealtime<ChatHub>();
            hubContext.Clients.All.hello(message.From + ": " + message.Message);
            return "Hello from custom controller!";
        }

        public string Get()
        {
            return "Hello Regardt";
        }

    }
}
