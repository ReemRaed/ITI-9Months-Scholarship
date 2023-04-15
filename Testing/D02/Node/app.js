const express = require("express")
const app = express();

app.get('/',(req,res)=>{
    res.status(200).send("One endpoint")
});


app.get('/users',(req,res)=>{
    res.status(200).send("One endpoint")
});




var server = app.listen(3000);
module.exports = server