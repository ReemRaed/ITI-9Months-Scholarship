import { Component, useState } from "react"
import React from "react" 
import User2 from "./User2"

const User=()=>{
    const [x]=useState(
        [
                {id:1,name:"Reem",age:22},
                {id:2,name:"Raed",age:23},
                {id:3,name:"Ali",age:24},
                {id:4,name:"Khaled",age:25},
        ]
    );
    console.log(x)
    return (
        <div>
            {x.map((u)=><User2 key={u.id} user={u}></User2>) }
        </div>
        );
}

export default User

