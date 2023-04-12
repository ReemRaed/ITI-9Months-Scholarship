//mongoDB
const mongoose=require("mongoose");
mongoose.connect("mongodb://127.0.0.1:27017/users");

let DoctorSchema= new mongoose.Schema({
    name:String,
    age:Number,
    email:String,
    Password:String,
    specialist:String
});

module.exports=mongoose.model("Doctor",DoctorSchema);

