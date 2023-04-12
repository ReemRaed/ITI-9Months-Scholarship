const UserModel=require("../Models/userModel");
const bcrypt=require("bcrypt"); 


let AddNewUser=async (req,res)=>{
/**
     * 1.body==>email==>Exist
     * 2.Email Exist==>"Already Exist"
     * 3.Email not exits ==>next step==>hashPassword
     * 4.add new user
 */
    let NewUser=req.body;
    let FoundUser= await UserModel.findOne({email:NewUser.email}).exec();
    if(FoundUser){ return res.status(201).json({message:"User Already Exists"})}

    let genSalt=await bcrypt.genSalt(10);
    let hasshedPassword=await bcrypt.hash(NewUser.password,genSalt);
    NewUser.password=hasshedPassword;
    let NEWUSER=new UserModel(NewUser);
        await NEWUSER.save();
    return res.status(201).json({message:"User Added Successfully",data:NEWUSER});
}


let LoginUser= async (req,res)=>{
    let NewUser=req.body;
    let FoundUser=await UserModel.findOne({email:NewUser.email}).exec();
    if(!FoundUser) return res.status(401).json({message:"InValid email or password"});

    //2.Check Password
    let Checkpass= bcrypt.compareSync(NewUser.password,FoundUser.password);
    if(Checkpass) return res.status(201).json({message:"Login Sucessfully"});
    else return res.status(401).json({message:"InValid email or password"});
}


module.exports={
    AddNewUser,
    LoginUser
}; 
