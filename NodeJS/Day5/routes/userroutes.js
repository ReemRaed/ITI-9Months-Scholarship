const express=require("express");
const router=new express.Router();
const UserController= require("../controllers/usercontroller");




//Register
router.post("/reg",UserController.AddNewUser)
 
//Login 
router.post("/login",UserController.LoginUser)


//Patient



module.exports=router;



