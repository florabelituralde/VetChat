using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace VetChat.Hub
{
    public class Chat : Microsoft.AspNetCore.SignalR.Hub
    {
        //public async Task SendMessageGroup(string groupName, string user, string message)
        //{
        //      // One way to do
        //    await Clients.Group(groupName).SendAsync("ReceiveMessage", user, message);
        //      // Another way
        //    if (join)
        //    {
        //        await JoinRoom(room).ConfigureAwait(false);
        //        await Clients.Group(room).SendAsync("ReceiveMessage", Context.User.Identity.Name ?? "anonymous", " joined to " + room).ConfigureAwait(true);

        //    }
        //    else
        //    {
        //        await Clients.Group(room).SendAsync("ReceiveMessage", Context.User.Identity.Name ?? "anonymous", message).ConfigureAwait(true);

        //    }
        //}

        //public Task JoinRoom(string groupName)
        //{
        //    return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        //}

        //public Task LeaveRoom(string groupName)
        //{
        //    return Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        //}
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", Context.User.Identity.Name ?? "anonymous", message);
        }

        public async Task AddToGroup(string groupName, string user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {groupName}.");
        }

        public async Task RemoveFromGroup(string groupName, string user)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);

            await Clients.Group(groupName).SendAsync("Send", $"{Context.ConnectionId} has left the group {groupName}.");
        }

        public async Task TypingGroup(string user, string groupName)
        {
            // Broadcast the typing notification to all clients except the sender
            await Clients.Group(groupName).SendAsync("typing", user);
        }
    }
}