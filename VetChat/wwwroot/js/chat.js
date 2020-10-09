"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/Chat").build();

//Disable send button until connection is established
document.getElementById("sendBtn").disabled = true;

//funtion CleanMessage(message) {
//      return var msg = message.replace(/&/g, "&").replace(/</g, "<").replace(/>/g, ">");
//}

//function AddMessage(message) {
//     var li = document.createElement("li");
//     li.textContent = encodedMsg;
//     document.getElementById("ulmessages").appendChild(li);
//     ClearTyping();
// }

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&").replace(/</g, "<").replace(/>/g, ">");
    var encodedMsg = user + " says " + msg; // Would be AddMessage(user + "says " + CleanMessage(message));
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("ulmessages").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendBtn").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendBtn").addEventListener("click", function (event) {
    var message = document.getElementById("txtmessage").value;
    connection.invoke("SendMessage", message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

document.getElementById("joinButton").addEventListener("click", function (event) {
    var room = document.getElementById("room").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", message, room, true).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});