import React, { Component } from "react";

class User2 extends Component
{
  render()
  {
      const {id,name,age}=this.props.user;
    return(
        <div style={{backgroundColor:"pink",margin:"10px auto ",width:"50%",textAlign:"center",}}>
            <p style={{color:"white",fontSize:"20px",}}>ID:{id}</p>
            <p style={{color:"white",fontSize:"20px",}}>Name:{name}</p>
            <p style={{color:"white",fontSize:"20px",}}>Age:{age}</p>
        </div>
    )
  }
}

export default User2