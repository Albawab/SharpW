var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

var message = document.getElementById("message");
var bt = document.getElementById("bt");

connection.on("ReceiveMessage", function a(second) {
    var li = document.createElement("li");
    var textnode = document.createTextNode(second);
    li.appendChild(textnode);
    message.appendChild(li);

});

connection.start();


bt.addEventListener("click", Send);
function Send() {

    connection.invoke("SendMessage");
}