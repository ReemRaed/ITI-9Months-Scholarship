import { Component } from '@angular/core';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent {

  student:{name:string,age:string,ID:number,Cources:{course:string,grade:number}}={name:"Reem",age:"22",ID:180021,Cources:{course:"Angular",grade:100}}
}
