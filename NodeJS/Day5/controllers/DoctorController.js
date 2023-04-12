const { json } = require("express");
const DoctorModel=require("../Models/DoctorModel");
const DoctorValidate = require("../utilies/DoctorSchema");

let AddDoctor= async (req,res)=>{

    let NewDoctor=req.body;    
    if(DoctorValidate(NewDoctor))
    {
        let NEWDoctor=new DoctorModel(NewDoctor);
        await NEWDoctor.save();
        return res.status(201).json({message:"User Added Successfully",data:NEWDoctor});
    }
    else
    {
        return res.status(401).json({message:"Try again , check ur DATA !"});
    }
};

let GetDoctors= async (req,res)=>{
    let alldata= await DoctorModel.find();
    // return res.send( JSON.stringify(alldata));
    return  res.status(201).json({message:"Doctors loaded Successfully",data:alldata});
}


let UpadetDoctor= async (req,res)=>{

    try {
        const id = req.params.id;
        const updatedData = req.body;
        const options = { new: true };

        const result = await DoctorModel.findByIdAndUpdate(
            id, updatedData, options
        )

        res.send(result)
    }
    catch (error) {
        res.status(400).json({ message: error.message })
    }
}
    

let FindDoctor= async (req,res)=>{

    try{
        const data = await DoctorModel.findById(req.params.id);
        res.json(data)
    }
    catch(error){
        res.status(500).json({message:"Not Found"})
    }

}
let DeleteDoctor= async (req,res)=>{

    try{
        const data = await DoctorModel.findByIdAndRemove(req.params.id);
        res.json(data)
    }
    catch(error){
        res.status(404).json({message: "Not Found"})
    }

}
module.exports={AddDoctor,GetDoctors,UpadetDoctor,FindDoctor,DeleteDoctor}
