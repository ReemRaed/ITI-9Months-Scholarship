import { Component } from '@angular/core';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent {
  
  students:{name:string, age:string}[]=[{name:"reem",age:"22"},{name:"ahmed",age:"20"},{name:"omar",age:"23"},{name:"mohammed",age:"18"}];
  

}