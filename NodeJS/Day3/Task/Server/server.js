const express=require("express");
const app=express();
const path = require("path");
let  PORT= process.env.PORT || 7008;
const bodyParser = require("body-parser");

const fs=require("fs");
let Welcome=fs.readFileSync("../Client/Welcome.html").toString();

app.use(bodyParser.json())
app.use(bodyParser.urlencoded({extended:true}))

app.get("/",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))
});
app.get("/main.html",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))
})
app.get("/Client/main.html",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/main.html"))
})
app.get("/style.css",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/style.css"))
})
app.get('/client/style.css',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/style.css"))
})
app.get("/style2.css",(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/style2.css"))
})
app.get('/client/style2.css',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/style2.css"))
})

app.get('/Welcome.html',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Welcome.html"))
})
app.get('/Client/Welcome.html',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Welcome.html"))
})

app.post("/",(req,res)=>{
    var obj=req.body;
    // console.log(obj.Fname);
    // console.log(obj.Lname);
    // console.log(obj.Address);
    // console.log(obj.Mobile);
    // console.log(obj.email);
    res.write(Welcome.replace("{Name}",obj.Fname+" " +obj.Lname)
    .replace("{Address}",obj.Address).replace("{Phone}",obj.Mobile).replace("{Email}",obj.email));
});
app.get('/favicon.ico',(req,res)=>{
            res.sendFile(path.join(__dirname,"../Client/Icons/favicon.ico"))
})
app.get('/Client/Icons/favicon.ico',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Icons/favicon.ico"))
})
app.get('/Client/favicon.ico',(req,res)=>{
    res.sendFile(path.join(__dirname,"../Client/Icons/favicon.ico"))
})

app.listen(PORT,()=>{console.log("http://www.localhost:"+PORT)});

