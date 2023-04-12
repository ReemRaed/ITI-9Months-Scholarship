import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserserviceService {


  constructor(private myClient:HttpClient) {}
  private readonly URL = "http://localhost:3000/users";//API

  getAllUsers()
  {
   return this.myClient.get(this.URL);
  }

  getUserBYID(id:any)
  {
    return this.myClient.get(this.URL+'/'+id);  }

  AddUser(user:any)
  {
    return this.myClient.post(this.URL, user);
  }

  UpdateUser(user:any,id:any)
  {
    return this.myClient.put(this.URL+'/'+id,user);
  }
}
