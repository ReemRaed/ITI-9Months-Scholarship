const express = require("express");
const app = express();
const path = require("path");
const bodyParser = require('body-parser');

app.use(bodyParser.urlencoded({extended:true}));
app.use(bodyParser.json());
const PORT = process.env.PORT||7010;


//Authentication
const UserRoutes=require("./routes/userroutes");
app.use("/api/users",UserRoutes);


const patientRoutes=require("./routes/patientroutes");
app.use("/api/patient",patientRoutes);



const DoctorRoutes=require("./routes/Doctorroutes");
app.use("/api/doctor",DoctorRoutes);



app.listen(PORT, ()=>{console.log("http://localhost:"+PORT)});
