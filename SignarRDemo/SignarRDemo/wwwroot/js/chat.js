"use strict"

//create aa connection to SignalR hub
var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build(); 

// disable the send until connection is established weth server
document.getElementById("sendButton").disabled = true;

//Handle receive message and create a li elements
connection.on("ReceiveMessage", function (user,message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;")
        .replace(/>/g, "&gt;");

    var encodingMsg = user + " says" + msg;

    var li = document.createElement("li");
    li.textContent = encodingMsg;
    document.getElementById("messageList").appendChild(li);
});

//start connection
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return (console.error(err.toString))
    });


//handle sending message
document.getElementById("sendButton").addEventListener("click", function () {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
    });
    event.preventDefault();

});


