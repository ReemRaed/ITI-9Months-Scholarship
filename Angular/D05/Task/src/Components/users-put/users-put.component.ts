import { Component, OnInit } from '@angular/core';
import { UserserviceService } from 'src/Services/userservice.service';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-users-put',
  templateUrl: './users-put.component.html',
})
export class UsersPutComponent {

  ID:any
  user:any
  constructor(private myservice:UserserviceService,myActivated:ActivatedRoute,private router: Router){
    this.ID=myActivated.snapshot.params["id"];
 }
 ngOnInit(): void {
  this.myservice.getUserBYID(this.ID).subscribe(
    {
      next:(data)=>{
        this.user = data;
      },
      error:(err)=>{console.log(err)}
    }
  );
}
Update(name:any,email:any,Address:any)
{
   let user={name,email,Address};
    this.myservice.UpdateUser(user,this.ID).subscribe();
    this.router.navigate(['/users']);
}

}
