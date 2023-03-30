const express = require('express');
const app = express();
const http = require('http');
const server = http.createServer(app);
const PORT=process.env.PORT||3000;

const { Server } = require("socket.io");
const io = new Server(server);

app.get('/', (req, res) => {
  res.sendFile(__dirname + '/chat.html');
});


io.on('connection', (socket) => {
    io.emit('chat message','a user connected........');
    socket.on('chat message', (message) => {
       io.emit('chat message',message)
    });
  });



server.listen(PORT,()=>{console.log("http://www.localhost:"+PORT)});









// const server=http.createServer(app);
