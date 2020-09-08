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
        //public async Task SendMessage(string message, string room, bool join)
        //{
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

        //public Task JoinRoom(string roomName)
        //{
        //    return Groups.AddToGroupAsync(Context.ConnectionId, roomName);
        //}

        //public Task LeaveRoom(string roomName)
        //{
        //    return Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);
        //}
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", Context.User.Identity.Name ?? "anonymous", message);
        }

        //public async Task AddToGroup(string roomName)
        //{
        //    await Groups.AddToGroupAsync(Context.ConnectionId, roomName);

        //    await Clients.Group(roomName).SendAsync("Send", $"{Context.ConnectionId} has joined the group {roomName}.");
        //}

        //public async Task RemoveFromGroup(string roomName)
        //{
        //    await Groups.RemoveFromGroupAsync(Context.ConnectionId, roomName);

        //    await Clients.Group(roomName).SendAsync("Send", $"{Context.ConnectionId} has left the group {roomName}.");
        //}

        //public async Task SendTyping(object sender)
        //{
        //    // Broadcast the typing notification to all clients except the sender
        //    await Clients.Others.SendAsync("typing", sender);
        //}
    }
}
