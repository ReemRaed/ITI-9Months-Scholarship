import { Component, OnInit } from '@angular/core';
import { UserserviceService } from 'src/Services/userservice.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-users-post',
  templateUrl: './users-post.component.html',
})
export class UsersPostComponent {
  constructor(private myService:UserserviceService,private router: Router){}
  ADD(name:any,email:any,Address:any){
   let  user={name,email,Address};

   this.myService.AddUser(user).subscribe();
   this.router.navigate(['/users']);

  }
}
