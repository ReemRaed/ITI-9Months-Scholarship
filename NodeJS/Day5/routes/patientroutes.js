
const express=require("express");
const router=new express.Router();
const PatientController= require("../controllers/patientController");

router.post("/AddPatient",PatientController.AddPatient)
router.get("/GetPatients",PatientController.GetPatients)
router.put("/UpadetPatient/:id",PatientController.UpadetPatient)
router.get("/FindPatient/:id",PatientController.FindPatients)
router.delete("/DeletePatient/:id",PatientController.Deletepatients);




module.exports=router;

