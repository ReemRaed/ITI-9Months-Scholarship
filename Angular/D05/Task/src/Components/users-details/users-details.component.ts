import { Component, OnInit } from '@angular/core';
import { UserserviceService } from 'src/Services/userservice.service';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-users-details',
  templateUrl: './users-details.component.html',
})
export class UsersDetailsComponent {

  ID:any
  user:any
  constructor(private myservice:UserserviceService,myActivated:ActivatedRoute){
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

}
