import { Component, OnInit } from '@angular/core';
import { UserserviceService } from 'src/Services/userservice.service';
@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styles: [
  ]
})
export class UsersComponent implements OnInit {
  constructor(private myService:UserserviceService){}
  users:any;
  ngOnInit(): void {
    this.myService.getAllUsers().subscribe(
      {
        next:(data)=>{
          this.users = data;
        },
        error:(err)=>{console.log(err)}
      }
    );
  }

}
