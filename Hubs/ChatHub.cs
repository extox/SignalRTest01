using AngularTest01.Models;
using Microsoft.AspNetCore.SignalR;  
using System.Threading.Tasks;  
  
namespace AngularTest01.Hubs  
{  
    public class ChatHub : Hub  
    {  
        public async Task NewMessage(Message msg)  
        {  
            await Clients.All.SendAsync("MessageReceived", msg);  
        }  
    }  
}  