const patienModel=require("../Models/PatientModel");
const PatientValidate = require("../utilies/patientSchema");



let AddPatient= async (req,res)=>{

let NewPatient=req.body;
// let NEWPatient=new patienrModel(NewPatient);
//     await NEWPatient.save();
//     return res.status(201).json({message:"User Added Successfully",data:NEWPatient});


if(PatientValidate(NewPatient))
{
    let NEWPatient=new patienModel(NewPatient);
    await NEWPatient.save();
    return res.status(201).json({message:"User Added Successfully",data:NEWPatient});
}
else
{
    return res.status(401).json({message:"Try again , check ur DATA !"});
}
};
let GetPatients= async (req,res)=>{
    let alldata= await patienModel.find();
    // return res.send( JSON.stringify(alldata));
    return  res.status(201).json({message:"ptients loaded Successfully",data:alldata});
}


let UpadetPatient= async (req,res)=>{

    try {
        const id = req.params.id;
        const updatedData = req.body;
        const options = { new: true };

        const result = await patienModel.findByIdAndUpdate(
            id, updatedData, options
        )

        res.send(result)
    }
    catch (error) {
        res.status(400).json({ message: "Not Found" })
    }
}
    

let FindPatients= async (req,res)=>{

    try{
        const data = await patienModel.findById(req.params.id);
        res.json(data)
    }
    catch(error){
        res.status(500).json({message:"Not Found"})
    }

}
let Deletepatients= async (req,res)=>{

    try{
        const data = await patienModel.findByIdAndRemove(req.params.id);
        res.json(data)
    }
    catch(error){
        res.status(404).json({message: "Not Found"})
    }

}
module.exports={AddPatient,GetPatients,UpadetPatient,FindPatients,Deletepatients}