using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VetChat.Hub
{
    public class Chat : Microsoft.AspNetCore.SignalR.Hub
    {
        //public async Task SendMessage(string message)
        //{
        //    await Clients.All.SendAsync("OnMessageReceived", Context.User.Identity.Name ?? "anonymous", message);
        //}

        private static readonly Dictionary<string, string> Chatters = new Dictionary<string, string>();

        public async Task SendMessage(string name, string message)
        {
            Task updateChatters = Task.CompletedTask;
            if (!Chatters.ContainsKey(Context.ConnectionId))
            {
                Chatters.Add(Context.ConnectionId, name);
                updateChatters = Clients.All.SendAsync("OnManageChatters", name, 1);
            }

            Task broadcast = Task.CompletedTask;
            if (message.StartsWith("/w"))
            {
                var target = message.Split(' ')[1];
                broadcast = Clients.Client(Chatters.FirstOrDefault(c => c.Value == target).Key).SendAsync("OnPrivateMessage", name, message.Substring(3 + target.Length));
            }
            else
            {
                broadcast = Clients.All.SendAsync("OnMessageReceived", name, message);
            }

            Task.WaitAll(updateChatters, broadcast);
        }

        public override async Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();

            await Clients.Client(Context.ConnectionId)
                .SendAsync("OnConnected", Chatters.Select(k => k.Value).ToArray());
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var name = Chatters.FirstOrDefault(k => k.Key == Context.ConnectionId);
            if (!name.Equals(default(KeyValuePair<string, string>)))
            {
                Chatters.Remove(Context.ConnectionId);
                await Clients.All.SendAsync("OnManageChatters", name.Value, 0);
            }

            await base.OnDisconnectedAsync(exception);
        }
    }
}