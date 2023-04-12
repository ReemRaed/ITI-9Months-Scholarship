const AJV= require("ajv");
const ajv=new AJV();

const Patientschema={
    type:"object",
    properties:{
        name:{type:"string", pattern:"^[a-zA-Z]+$"},
        age:{type:"number"},
        email:{type: "string"},
        Password:{type:"string"}
    },
    required:["name", "age", "email","Password"],
    additionalProperties:false
}
module.exports = ajv.compile(Patientschema);//validate(body)==> true || false ===> method()

