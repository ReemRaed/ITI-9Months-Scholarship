const AJV= require("ajv");
const ajv=new AJV();

const Doctorschema={
    type:"object",
    properties:{
        name:{type:"string", pattern:"^[a-zA-Z]+$"},
        age:{type:"number"},
        email:{type: "string"},
        Password:{type:"string"},
        specialist:{type:"string"}
    },
    required:["name", "age", "email","Password","specialist"],
    additionalProperties:false
}
module.exports = ajv.compile(Doctorschema);//validate(body)==> true || false ===> method()

