//mongoDB

const mongoose=require("mongoose");

mongoose.connect("mongodb://127.0.0.1:27017/users");

//create schema

userSchema=new mongoose.Schema
({
    name:String,
    age:Number,
    password:String,
    email:String
});

//connect Schema with Connection
module.exports= mongoose.model("users",userSchema);


