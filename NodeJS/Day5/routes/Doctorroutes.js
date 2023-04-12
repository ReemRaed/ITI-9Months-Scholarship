
const express=require("express");
const router=new express.Router();
const DoctorController= require("../controllers/DoctorController");

router.post("/AddDoctor",DoctorController.AddDoctor)
router.get("/GetDoctors",DoctorController.GetDoctors)
router.put("/UpadetDoctor/:id",DoctorController.UpadetDoctor)
router.get("/getOne/:id",DoctorController.FindDoctor)
router.delete("/DeleteDoctor/:id",DoctorController.DeleteDoctor);




module.exports=router;

